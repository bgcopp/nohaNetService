using System.Data;
using System.Data.SqlClient;
using BGCOP.CAVTOP.COMMON;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Vtarjetas
	{
		public LogCls log = new LogCls();

		public Vtarjetas()
		{
		}

		public int diaSemanaF(string dia)
		{
			string str = dia;
			string str1 = str;
			if (str != null)
			{
				switch (str1)
				{
					case "Sunday":
						{
							return 1;
						}
					case "Monday":
						{
							return 2;
						}
					case "Tuesday":
						{
							return 3;
						}
					case "Wednesday":
						{
							return 4;
						}
					case "Thursday":
						{
							return 5;
						}
					case "Friday":
						{
							return 6;
						}
					case "Saturday":
						{
							return 7;
						}
				}
			}
			return 0;
		}

		public void GuardaMarcacionParqueadero(string idvehiculo, string idempleado, string mregistro)
		{
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			try
			{
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TRegistroVehiculo tRegistroVehiculo = new TRegistroVehiculo()
					{
						idVehiculo = new int?(int.Parse(idvehiculo)),
						idempleado = new int?(int.Parse(idempleado)),
						fechadeRegistro = new DateTime?(DateTime.Now),
						mregistro = mregistro
					};
					masterDBACEntity.AddToTRegistroVehiculo(tRegistroVehiculo);
					masterDBACEntity.SaveChanges();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
			}
		}

		public bool GuardaMarcacionTarjeta(string idCard, string innerN)
		{
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			try
			{
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == idCard
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						bool? nullable = tTarjetum.esvisitante;
						if ((!nullable.GetValueOrDefault() ? true : !nullable.HasValue))
						{
							TEmpleado tEmpleado = (
								from b in masterDBACEntity.TEmpleado
								where b.idTarjeta == (int?)tTarjetum.idTarjeta
								select b).FirstOrDefault<TEmpleado>();
							TMarcacion tMarcacion = new TMarcacion()
							{
								fechaMarcacion = new DateTime?(DateTime.Now),
								idEmpleado = new int?(tEmpleado.idEmpleado),
								NoTarjeta = idCard,
								NoInner = innerN
							};
							masterDBACEntity.AddToTMarcacion(tMarcacion);
							masterDBACEntity.SaveChanges();
						}
						else
						{
							TVisitanteVisitaProgramada tVisitanteVisitaProgramada = (
								from a in masterDBACEntity.TVisitanteVisitaProgramada
								where a.idTarjeta == (int?)tTarjetum.idTarjeta
								orderby a.fechaLlegada descending
								select a).FirstOrDefault<TVisitanteVisitaProgramada>();
							TMarcacion tMarcacion1 = new TMarcacion()
							{
								fechaMarcacion = new DateTime?(DateTime.Now),
								idVisitante = new decimal?(tVisitanteVisitaProgramada.idVisitante),
								idVisitanteVistaP = new decimal?(tVisitanteVisitaProgramada.idTabla),
								NoTarjeta = idCard,
								NoInner = innerN
							};
							masterDBACEntity.AddToTMarcacion(tMarcacion1);
							masterDBACEntity.SaveChanges();
						}
					}
					else
					{
						return false;
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
			}
			return true;
		}

		public MessageDTO verificaParqueoEntrada(string Card, string CB)
		{
			MessageDTO messageDTO;
			string card = Card;
			MessageDTO str = new MessageDTO();
			bool flag = false;
			bool flag1 = false;
			try
			{
				long num = Convert.ToInt64(card);
				card = string.Format("{0:X}", num).ToLower();
				var card1n = string.Format("{0:X}", 78228050);
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == card
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.CodigodeBarras == CB
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo =
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado != tEmpleado.idEmpleado)
										{
											continue;
										}
										flag = true;
										break;
									}
									IQueryable<TvehiculoParqueo> tvehiculoParqueo =
										from f in masterDBACEntity.TvehiculoParqueo
										where f.idVehiculo == tVehiculo.idVehiculo
										select f;
									if (tvehiculoParqueo != null)
									{
										int num1 = Convert.ToInt32(DateTime.Now.DayOfWeek);
										foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
										{
											using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
											{
												TParqueo nullable = (
													from g in masterDBACEntity1.TParqueo
													where g.idParqueadero == tvehiculoParqueo1.idParqueadero
													select g).FirstOrDefault<TParqueo>();
												if (nullable != null)
												{
													bool? nullable1 = nullable.estaocupado;
													if ((nullable1.GetValueOrDefault() ? true : !nullable1.HasValue))
													{
														str.Mensaje = string.Concat("El parquedero ", nullable.nParqueo, " se encuentra ocupado.");
														str.Resultado = false;
														str.Error = "*";
														str.ErrorInterno = "*";
													}
													else
													{
														switch (num1)
														{
															case 0:
																{
																	bool? nullable2 = tvehiculoParqueo1.dia1;
																	if ((!nullable2.GetValueOrDefault() ? true : !nullable2.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 1:
																{
																	bool? nullable3 = tvehiculoParqueo1.dia2;
																	if ((!nullable3.GetValueOrDefault() ? true : !nullable3.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 2:
																{
																	bool? nullable4 = tvehiculoParqueo1.dia3;
																	if ((!nullable4.GetValueOrDefault() ? true : !nullable4.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 3:
																{
																	bool? nullable5 = tvehiculoParqueo1.dia4;
																	if ((!nullable5.GetValueOrDefault() ? true : !nullable5.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 4:
																{
																	bool? nullable6 = tvehiculoParqueo1.dia5;
																	if ((!nullable6.GetValueOrDefault() ? true : !nullable6.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 5:
																{
																	bool? nullable7 = tvehiculoParqueo1.dia6;
																	if ((!nullable7.GetValueOrDefault() ? true : !nullable7.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 6:
																{
																	bool? nullable8 = tvehiculoParqueo1.dia7;
																	if ((!nullable8.GetValueOrDefault() ? true : !nullable8.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
														}
														if (!(flag & flag1))
														{
															str.Mensaje = string.Concat("El parqueadero no esta programado para usted este dia de la semana!", flag.ToString(), " - ", flag1.ToString());
															str.Resultado = false;
															str.Error = "*";
															str.ErrorInterno = "*";
														}
														else
														{
															nullable.estaocupado = new bool?(true);
															nullable.ocupadopor = tVehiculo.Placa;
															masterDBACEntity1.SaveChanges();
															string str1 = tVehiculo.idVehiculo.ToString(CultureInfo.InvariantCulture);
															int num2 = tEmpleado.idEmpleado;
															this.GuardaMarcacionParqueadero(str1, num2.ToString(CultureInfo.InvariantCulture), "Entrada Vehicular");
															(new TareasInner()).AgregarTarea(1, "OpenS", CB);
															str.Mensaje = "Acceso concedido al parqueadero!";
															str.Resultado = true;
															str.Error = "*";
															str.ErrorInterno = "*";
															messageDTO = str;
															return messageDTO;
														}
													}
												}
												else
												{
													str.Mensaje = "No existe un parqueo para este vehiculo!";
													str.Resultado = false;
													str.Error = "*";
													str.ErrorInterno = "*";
												}
											}
										}
									}
									else
									{
										str.Mensaje = "No existe un parqueadero asignado!";
										str.Resultado = false;
										str.Error = "*";
										str.ErrorInterno = "*";
										messageDTO = str;
										return messageDTO;
									}
								}
								else
								{
									str.Mensaje = "No existe un vehiculo asignado!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe un empleado asociado a esta tarjeta!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						return messageDTO;
					}
				}
				return str;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = exception.ToString();
				//str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoEntrada(string CB)
		{
			MessageDTO messageDTO;
			MessageDTO messageDTO1 = new MessageDTO();
			try
			{
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TVehiculo tVehiculo = (
						from c in masterDBACEntity.TVehiculo
						where c.CodigodeBarras == CB
						select c).FirstOrDefault<TVehiculo>();
					if (tVehiculo != null)
					{
						IQueryable<TvehiculoParqueo> tvehiculoParqueo =
							from f in masterDBACEntity.TvehiculoParqueo
							where f.idVehiculo == tVehiculo.idVehiculo
							select f;
						if (tvehiculoParqueo != null)
						{
							using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
							{
								foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
								{
									TParqueo nullable = (
										from g in masterDBACEntity1.TParqueo
										where g.idParqueadero == tvehiculoParqueo1.idParqueadero
										select g).FirstOrDefault<TParqueo>();
									if (nullable != null)
									{
										bool? nullable1 = nullable.estaocupado;
										if ((nullable1.GetValueOrDefault() ? true : !nullable1.HasValue))
										{
											messageDTO1.Mensaje = string.Concat("El parqueadero [", nullable.nParqueo, "] se encuentra ocupado.");
											messageDTO1.Resultado = false;
											messageDTO1.Error = "*";
											messageDTO1.ErrorInterno = "*";
										}
										else
										{
											nullable.estaocupado = new bool?(true);
											nullable.ocupadopor = tVehiculo.Placa;
											masterDBACEntity1.SaveChanges();
											int num = tVehiculo.idVehiculo;
											this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Entrada Vehicular");
											(new TareasInner()).AgregarTarea(1, "OpenS", CB);
											messageDTO1.Mensaje = "Acceso concedido al parqueadero!";
											messageDTO1.Resultado = true;
											messageDTO1.Error = "*";
											messageDTO1.ErrorInterno = "*";
											messageDTO = messageDTO1;
											return messageDTO;
										}
									}
									else
									{
										messageDTO1.Mensaje = "No se puede localizar el parqueadero en la tabla maestra!";
										messageDTO1.Resultado = false;
										messageDTO1.Error = "*";
										messageDTO1.ErrorInterno = "*";
									}
								}
							}
						}
						else
						{
							messageDTO1.Mensaje = "El vehiculo no tiene un parqueadero asignado!";
							messageDTO1.Resultado = false;
							messageDTO1.Error = "*";
							messageDTO1.ErrorInterno = "*";
							messageDTO = messageDTO1;
							return messageDTO;
						}
					}
					else
					{
						messageDTO1.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
						messageDTO1.Resultado = false;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
						return messageDTO;
					}
				}
				return messageDTO1;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				messageDTO1.Mensaje = string.Concat("Error: ", exception.ToString());
				messageDTO1.ErrorInterno = (exception.InnerException == null ? "" : exception.InnerException.ToString());
				messageDTO1.Resultado = false;
				messageDTO1.Error = "*";
				messageDTO1.ErrorInterno = "*";
				messageDTO = messageDTO1;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalida(string Card, string CB)
		{
			MessageDTO messageDTO;
			string card = Card;
			MessageDTO str = new MessageDTO();
			try
			{
				long num = Convert.ToInt64(card);
				card = string.Format("{0:X}", num).ToLower();
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == card
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.CodigodeBarras == CB
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo =
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado != tEmpleado.idEmpleado)
										{
											continue;
										}
										(new TareasInner()).AgregarTarea(1, "OpenS", CB);
										using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
										{
											TParqueo nullable = (
												from k1 in masterDBACEntity1.TParqueo
												where k1.ocupadopor == tVehiculo.Placa
												select k1).FirstOrDefault<TParqueo>();
											if (nullable == null)
											{
												str.Mensaje = "El vehiculo no ha ingresado!";
												str.Resultado = true;
												str.Error = "*";
												str.ErrorInterno = "*";
												messageDTO = str;
												return messageDTO;
											}
											else
											{
												nullable.ocupadopor = "";
												nullable.estaocupado = new bool?(false);
												masterDBACEntity1.SaveChanges();
												string str1 = tVehiculo.idVehiculo.ToString(CultureInfo.InvariantCulture);
												int num1 = tEmpleado.idEmpleado;
												this.GuardaMarcacionParqueadero(str1, num1.ToString(CultureInfo.InvariantCulture), "Salida Vehicular");
												str.Mensaje = "Salida Exitosa!";
												str.Resultado = true;
												str.Error = "*";
												str.ErrorInterno = "*";
												messageDTO = str;
												return messageDTO;
											}
										}
									}
								}
								else
								{
									str.Mensaje = "la asignacion del vehiculo no se encuentra en la BASE de datos!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El vehiculo no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe el en la BASE de datos!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						return messageDTO;
					}
				}
				str.Mensaje = "Acceso no permitido";
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				return str;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = string.Concat("Error :", exception.ToString());
				str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalida(string CB)
		{
			MessageDTO messageDTO;
			MessageDTO messageDTO1 = new MessageDTO();
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TVehiculo tVehiculo = (
					from c in masterDBACEntity.TVehiculo
					where c.CodigodeBarras == CB
					select c).FirstOrDefault<TVehiculo>();
				if (tVehiculo != null)
				{
					(new TareasInner()).AgregarTarea(1, "OpenS", CB);
					TParqueo nullable = (
						from k1 in masterDBACEntity.TParqueo
						where k1.ocupadopor == tVehiculo.Placa
						select k1).FirstOrDefault<TParqueo>();
					if (nullable == null)
					{
						messageDTO1.Mensaje = "El vehiculo no ha ingresado!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
					else
					{
						nullable.ocupadopor = "";
						nullable.estaocupado = new bool?(false);
						masterDBACEntity.SaveChanges();
						int num = tVehiculo.idVehiculo;
						this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Salida Vehicular");
						messageDTO1.Mensaje = "Salida Exitosa!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
				}
				else
				{
					messageDTO1.Mensaje = "El vehiculo no se encuentra en la base de datos";
					messageDTO1.Resultado = false;
					messageDTO1.Error = "*";
					messageDTO1.ErrorInterno = "*";
					messageDTO = messageDTO1;
				}
			}
			return messageDTO;
		}

		public bool VerificaTarjetaBussiness(string idCard)
		{
			int num;
			int num1;
			bool flag;
			bool flag1 = false;
			DateTime now = DateTime.Now;
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			DateTime value = new DateTime();
			DateTime dateTime = new DateTime();
			try
			{
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					now = DateTime.Now;
					string str = idCard;
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == str
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						bool? nullable = tTarjetum.activa;
						if ((nullable.GetValueOrDefault() ? true : !nullable.HasValue))
						{
							bool? nullable1 = tTarjetum.esvisitante;
							if ((!nullable1.GetValueOrDefault() ? true : !nullable1.HasValue))
							{
								TEmpleado tEmpleado = (
									from mm in masterDBACEntity.TEmpleado
									where mm.idTarjeta == (int?)tTarjetum.idTarjeta
									select mm).FirstOrDefault<TEmpleado>();
								if (tEmpleado != null)
								{
									TEstado tEstado = (
										from nn in masterDBACEntity.TEstado
										where nn.idTipoEstado == tEmpleado.idTipoEstado
										select nn).FirstOrDefault<TEstado>();
									if (tEstado == null)
									{
										flag = false;
										return flag;
									}
									else if (tEstado.NombreEstado.ToUpper() == "ACTIVO")
									{
										THorario tHorario = (
											from b in masterDBACEntity.THorario
											where (int?)b.idHorario == tTarjetum.idHorario
											select b).FirstOrDefault<THorario>();
										if (tHorario == null)
										{
											flag = false;
											return flag;
										}
										else if (!tHorario.esMaestro)
										{
											bool? nullable2 = tHorario.esPermanente;
											if ((!nullable2.GetValueOrDefault() ? true : !nullable2.HasValue))
											{
												if (tHorario.fechaInicio.HasValue)
												{
													value = tHorario.fechaInicio.Value;
												}
												if (tHorario.fechaFin.HasValue)
												{
													dateTime = tHorario.fechaFin.Value;
												}
												num = value.CompareTo(now);
												num1 = dateTime.CompareTo(now);
												if (num < 0 && num1 >= 0)
												{
													DateTime now1 = DateTime.Now;
													int num2 = this.diaSemanaF(now1.DayOfWeek.ToString());
													IQueryable<TDiasHorario> tDiasHorario =
														from c in masterDBACEntity.TDiasHorario
														where c.idHorario == tTarjetum.idHorario
														select c;
													if (tDiasHorario != null)
													{
														foreach (TDiasHorario tDiasHorario1 in tDiasHorario)
														{
															byte? nullable3 = tDiasHorario1.dia;
															if ((nullable3.GetValueOrDefault() != num2 ? true : !nullable3.HasValue))
															{
																continue;
															}
															DateTime.TryParse(tDiasHorario1.entrada, out value);
															DateTime.TryParse(tDiasHorario1.salida, out dateTime);
															value.ToString("dd/MM/yyyy HH:mm:ss");
															dateTime.ToString("dd/MM/yyyy HH:mm:ss");
															now.ToString("dd/MM/yyyy HH:mm:ss");
															num = value.CompareTo(now);
															num1 = dateTime.CompareTo(now);
															byte? nullable4 = tDiasHorario1.dia;
															if ((nullable4.GetValueOrDefault() != num2 ? true : !nullable4.HasValue) || num >= 0 || num1 < 0)
															{
																continue;
															}
															flag1 = true;
															break;
														}
													}
													else
													{
														flag = false;
														return flag;
													}
												}
											}
											else
											{
												DateTime dateTime1 = DateTime.Now;
												int num3 = this.diaSemanaF(dateTime1.DayOfWeek.ToString());
												IQueryable<TDiasHorario> tDiasHorarios =
													from c in masterDBACEntity.TDiasHorario
													where c.idHorario == tTarjetum.idHorario
													select c;
												if (tDiasHorarios != null)
												{
													foreach (TDiasHorario tDiasHorario2 in tDiasHorarios)
													{
														DateTime.TryParse(tDiasHorario2.entrada, out value);
														DateTime.TryParse(tDiasHorario2.salida, out dateTime);
														num = value.CompareTo(now);
														num1 = dateTime.CompareTo(now);
														byte? nullable5 = tDiasHorario2.dia;
														if ((nullable5.GetValueOrDefault() != num3 ? true : !nullable5.HasValue) || num >= 0 || num1 < 0)
														{
															continue;
														}
														flag1 = true;
														break;
													}
												}
												else
												{
													flag = false;
													return flag;
												}
											}
										}
										else
										{
											flag = true;
											return flag;
										}
									}
									else
									{
										flag = false;
										return flag;
									}
								}
								else
								{
									flag = false;
									return flag;
								}
							}
							else
							{
								if (tTarjetum.fechavisi1.HasValue)
								{
									value = tTarjetum.fechavisi1.Value;
								}
								if (tTarjetum.fechavisi2.HasValue)
								{
									dateTime = tTarjetum.fechavisi2.Value;
								}
								num = value.CompareTo(now);
								num1 = dateTime.CompareTo(now);
								if (num < 0 && num1 >= 0)
								{
									flag = true;
									return flag;
								}
							}
						}
						else
						{
							flag = false;
							return flag;
						}
					}
					else
					{
						flag = false;
						return flag;
					}
				}
				return flag1;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
				return flag1;
			}
			return flag;
		}


		public MessageDTO verificaParqueoEntradaPlaca(string Card, string placa)
		{
			MessageDTO messageDTO;
			string card = Card;
			MessageDTO str = new MessageDTO();
			bool flag = false;
			bool flag1 = false;
			try
			{
				long num = Convert.ToInt64(card, 16);
				card = string.Format("{0:X}", num).ToLower();
				var card1n = string.Format("{0:X}", 78228050);
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					//cambio para los 26 o 24 bits
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta.EndsWith(card) == true
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.Placa == placa
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo =
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado != tEmpleado.idEmpleado)
										{
											continue;
										}
										flag = true;
										break;
									}
									IQueryable<TvehiculoParqueo> tvehiculoParqueo =
										from f in masterDBACEntity.TvehiculoParqueo
										where f.idVehiculo == tVehiculo.idVehiculo
										select f;
									if (tvehiculoParqueo != null)
									{
										int num1 = Convert.ToInt32(DateTime.Now.DayOfWeek);
										foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
										{
											using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
											{
												TParqueo nullable = (
													from g in masterDBACEntity1.TParqueo
													where g.idParqueadero == tvehiculoParqueo1.idParqueadero
													select g).FirstOrDefault<TParqueo>();
												if (nullable != null)
												{
													bool? nullable1 = nullable.estaocupado;
													if ((nullable1.GetValueOrDefault() ? true : !nullable1.HasValue))
													{
														str.Mensaje = string.Concat("El parquedero ", nullable.nParqueo, " se encuentra ocupado.");
														str.Resultado = false;
														str.Error = "*";
														str.ErrorInterno = "*";
													}
													else
													{
														switch (num1)
														{
															case 0:
																{
																	bool? nullable2 = tvehiculoParqueo1.dia1;
																	if ((!nullable2.GetValueOrDefault() ? true : !nullable2.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 1:
																{
																	bool? nullable3 = tvehiculoParqueo1.dia2;
																	if ((!nullable3.GetValueOrDefault() ? true : !nullable3.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 2:
																{
																	bool? nullable4 = tvehiculoParqueo1.dia3;
																	if ((!nullable4.GetValueOrDefault() ? true : !nullable4.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 3:
																{
																	bool? nullable5 = tvehiculoParqueo1.dia4;
																	if ((!nullable5.GetValueOrDefault() ? true : !nullable5.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 4:
																{
																	bool? nullable6 = tvehiculoParqueo1.dia5;
																	if ((!nullable6.GetValueOrDefault() ? true : !nullable6.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 5:
																{
																	bool? nullable7 = tvehiculoParqueo1.dia6;
																	if ((!nullable7.GetValueOrDefault() ? true : !nullable7.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
															case 6:
																{
																	bool? nullable8 = tvehiculoParqueo1.dia7;
																	if ((!nullable8.GetValueOrDefault() ? true : !nullable8.HasValue))
																	{
																		break;
																	}
																	flag1 = true;
																	break;
																}
														}
														if (!(flag & flag1))
														{
															str.Mensaje = string.Concat("El parqueadero no esta programado para usted este dia de la semana!", flag.ToString(), " - ", flag1.ToString());
															str.Resultado = false;
															str.Error = "*";
															str.ErrorInterno = "*";
														}
														else
														{
															nullable.estaocupado = new bool?(true);
															nullable.ocupadopor = tVehiculo.Placa;
															masterDBACEntity1.SaveChanges();
															string str1 = tVehiculo.idVehiculo.ToString(CultureInfo.InvariantCulture);
															int num2 = tEmpleado.idEmpleado;
															this.GuardaMarcacionParqueadero(str1, num2.ToString(CultureInfo.InvariantCulture), "Entrada Vehicular");
															//(new TareasInner()).AgregarTarea(1, "OpenS", placa);
															str.Mensaje = "Acceso concedido al parqueadero!";
															str.Resultado = true;
															str.Error = "*";
															str.ErrorInterno = "*";
															messageDTO = str;
															InsertLog(card, placa, "entry", str.Mensaje, 20);
															return messageDTO;
														}
													}
												}
												else
												{
													str.Mensaje = "No existe un parqueo para este vehiculo!";
													str.Resultado = false;
													str.Error = "*";
													str.ErrorInterno = "*";
													InsertLog(card, placa, "entry", str.Mensaje, -99);
												}
											}
										}
									}
									else
									{
										str.Mensaje = "No existe un parqueadero asignado!";
										str.Resultado = false;
										str.Error = "*";
										str.ErrorInterno = "*";
										messageDTO = str;
										InsertLog(card, placa, "entry", str.Mensaje, -99);
										return messageDTO;
									}
								}
								else
								{
									str.Mensaje = "No existe un vehiculo asignado!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									InsertLog(card, placa, "entry", str.Mensaje, -99);
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								InsertLog(card, placa, "entry", str.Mensaje, -99);
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe un empleado asociado a esta tarjeta!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							InsertLog(card, placa, "entry", str.Mensaje, -99);
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						InsertLog(card, placa, "entry", str.Mensaje, -99);
						return messageDTO;
					}
				}
				InsertLog(card, placa, "entry", str.Mensaje, -99);
				return str;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = exception.ToString();
				//str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
				InsertLog(card, placa, "entry", str.Mensaje, -99);
			}
			InsertLog(card, placa, "entry", str.Mensaje, -99);
			return messageDTO;
		}


    public MessageDTO verificaParqueoEntradaPlaca(string placa)
    {
     
      MessageDTO messageDTO1 = new MessageDTO();
      try
      {
        var detalle = SqlTools.ExecSqlGetList<regOcr>("  select * from TRegistroVehiculoOcr where OcrfechadeRegistro > DATEADD(SECOND, -55, getdate()) and OcrPlate = '" + placa + "'").ToList();
        if (detalle.Any())
        {
          messageDTO1.Mensaje = string.Concat("El vehiculo [", placa, "] registro no necesario por tiempo.");
          messageDTO1.Resultado = false;
          messageDTO1.Error = "*";
          messageDTO1.ErrorInterno = "*";
          

          return messageDTO1;
        }
       
				//verificar que el vehiculo existe
				var tVehiculo = SqlTools.ExecSqlGetList<TVehiculo>("Select * from TVehiculo where Placa='" + placa + "'").ToList().FirstOrDefault();
				if (tVehiculo == null)
				{
          messageDTO1.Mensaje = "El Vehiculo no se encuentra en la BASE de datos!";
          messageDTO1.Resultado = false;
          messageDTO1.Error = "*";
          messageDTO1.ErrorInterno = "*";
          
          InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
          return messageDTO1;
        }

				//obtiene parqueo vehiculo
				var tvehiculoParqueo = SqlTools.ExecSqlGetList<TvehiculoParqueo>("select * from TvehiculoParqueo where idVehiculo=" + tVehiculo.idVehiculo).ToList();
				if (!tvehiculoParqueo.Any())
				{
          messageDTO1.Mensaje = "El vehiculo no tiene un parqueadero asignado!";
          messageDTO1.Resultado = false;
          messageDTO1.Error = "*";
          messageDTO1.ErrorInterno = "*";
          
          InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
          return messageDTO1;
        }
				foreach(var tvehiculoParqueo1 in tvehiculoParqueo)
				{
					var parqueo = SqlTools.ExecSqlGetList<TParqueo>("select * from TParqueo where idParqueadero = " + tvehiculoParqueo1.idParqueadero).ToList().FirstOrDefault();
					if(parqueo == null)
					{
            messageDTO1.Mensaje = "No se puede localizar el parqueadero en la tabla maestra!";
            messageDTO1.Resultado = false;
            messageDTO1.Error = "*";
            messageDTO1.ErrorInterno = "*";
            InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
            return messageDTO1;
          }

					if((bool)parqueo.estaocupado == true)
					{
            messageDTO1.Mensaje = string.Concat("El parqueadero [", parqueo.nParqueo, "] se encuentra ocupado.");
            messageDTO1.Resultado = true; //false
            messageDTO1.Error = "*";
            messageDTO1.ErrorInterno = "*";
            InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
            return messageDTO1;
          }
          var fecha = DateTime.Now.AddSeconds(-55);
					var target = SqlTools.ExecSqlGetList<TRegistroVehiculo>("select * from TRegistroVehiculo where idVehiculo = " + tVehiculo.idVehiculo + " and fechadeRegistro >= '" + fecha.ToString("yyyyMMdd HH:mm:ss") + "'").ToList();
          if (target.Any())
          {
            messageDTO1.Mensaje = string.Concat("*El vehiculo [", tVehiculo.Placa, "] debe esperar para procesar.");
            messageDTO1.Resultado = false;
            messageDTO1.Error = "*";
            messageDTO1.ErrorInterno = "*";
            
            InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
            return messageDTO1;
          }

          //nullable.estaocupado = new bool?(true);
          //nullable.ocupadopor = tVehiculo.Placa;
          //masterDBACEntity1.SaveChanges();
          var cad = @"update TParqueo set estaocupado = 1, ocupadopor= '" + placa + "' where idParqueadero = " + parqueo.idParqueadero;
          SqlTools.SQLExecute(cad);

          int num = tVehiculo.idVehiculo;
          this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Entrada Vehicular");
          //(new TareasInner()).AgregarTarea(1, "OpenS", CB);
          messageDTO1.Mensaje = "Acceso concedido al parqueadero!";
          messageDTO1.Resultado = true;
          messageDTO1.Error = "*";
          messageDTO1.ErrorInterno = "*";
          
          InsertLog("-", placa, "entry", messageDTO1.Mensaje, 20);
          return messageDTO1;

        }

        
        InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
        return messageDTO1;
      }
      catch (Exception exception1)
      {
        Exception exception = exception1;
        messageDTO1.Mensaje = string.Concat("Error: ", exception.ToString());
        messageDTO1.ErrorInterno = (exception.InnerException == null ? "" : exception.InnerException.ToString());
        messageDTO1.Resultado = false;
        messageDTO1.Error = "*";
        messageDTO1.ErrorInterno = "*";
        
      }
      return messageDTO1;
    }

    public MessageDTO verificaParqueoEntradaPlaca_old(string placa)
		{
			MessageDTO messageDTO;
			MessageDTO messageDTO1 = new MessageDTO();
			try
			{
				var detalle = SqlTools.ExecSqlGetList<regOcr>("  select * from TRegistroVehiculoOcr where OcrfechadeRegistro > DATEADD(SECOND, -55, getdate()) and OcrPlate = '" + placa + "'").ToList();
				if (detalle.Any())
				{
					messageDTO1.Mensaje = string.Concat("El vehiculo [", placa, "] registro no necesario por tiempo.");
					messageDTO1.Resultado = false;
					messageDTO1.Error = "*";
					messageDTO1.ErrorInterno = "*";
					messageDTO = messageDTO1;

					return messageDTO;
				}
				//if(placa==   "QQQAAAXXX")
				//{
				//          messageDTO1.Mensaje = string.Concat("El vehiculo [", placa, "] debe esperar para procesar.");
				//          messageDTO1.Resultado = false;
				//          messageDTO1.Error = "*";
				//          messageDTO1.ErrorInterno = "*";
				//          messageDTO = messageDTO1;

				//          //return messageDTO;
				//      }
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TVehiculo tVehiculo = (
						from c in masterDBACEntity.TVehiculo
						where c.Placa == placa
						select c).FirstOrDefault<TVehiculo>();
					if (tVehiculo != null)
					{
						IQueryable<TvehiculoParqueo> tvehiculoParqueo =
							from f in masterDBACEntity.TvehiculoParqueo
							where f.idVehiculo == tVehiculo.idVehiculo
							select f;
						if (tvehiculoParqueo != null)
						{
							using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
							{
								foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
								{
									TParqueo nullable = (
										from g in masterDBACEntity1.TParqueo
										where g.idParqueadero == tvehiculoParqueo1.idParqueadero
										select g).FirstOrDefault<TParqueo>();
									if (nullable != null)
									{
										bool? nullable1 = nullable.estaocupado;
										if ((nullable1.GetValueOrDefault() ? true : !nullable1.HasValue))
										{
											messageDTO1.Mensaje = string.Concat("El parqueadero [", nullable.nParqueo, "] se encuentra ocupado.");
											messageDTO1.Resultado = true; //false
											messageDTO1.Error = "*";
											messageDTO1.ErrorInterno = "*";
											//InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
										}
										else
										{
											var fecha = DateTime.Now.AddSeconds(-55);
											//busca un registro del vehiculo que tenga menos de 2 min
											var target = masterDBACEntity1.TRegistroVehiculo.FirstOrDefault(a => a.idVehiculo == tVehiculo.idVehiculo && a.fechadeRegistro >= fecha);
											if (target != null)
											{
												messageDTO1.Mensaje = string.Concat("*El vehiculo [", tVehiculo.Placa, "] debe esperar para procesar.");
												messageDTO1.Resultado = false;
												messageDTO1.Error = "*";
												messageDTO1.ErrorInterno = "*";
												messageDTO = messageDTO1;
												InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
												return messageDTO;
											}
											nullable.estaocupado = new bool?(true);
											nullable.ocupadopor = tVehiculo.Placa;
											masterDBACEntity1.SaveChanges();
											int num = tVehiculo.idVehiculo;
											this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Entrada Vehicular");
											//(new TareasInner()).AgregarTarea(1, "OpenS", CB);
											messageDTO1.Mensaje = "Acceso concedido al parqueadero!";
											messageDTO1.Resultado = true;
											messageDTO1.Error = "*";
											messageDTO1.ErrorInterno = "*";
											messageDTO = messageDTO1;
											InsertLog("-", placa, "entry", messageDTO1.Mensaje, 20);
											return messageDTO;
										}
									}
									else
									{
										messageDTO1.Mensaje = "No se puede localizar el parqueadero en la tabla maestra!";
										messageDTO1.Resultado = false;
										messageDTO1.Error = "*";
										messageDTO1.ErrorInterno = "*";
										//InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
									}
								}
							}
						}
						else
						{
							messageDTO1.Mensaje = "El vehiculo no tiene un parqueadero asignado!";
							messageDTO1.Resultado = false;
							messageDTO1.Error = "*";
							messageDTO1.ErrorInterno = "*";
							messageDTO = messageDTO1;
							InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
							return messageDTO;
						}
					}
					else
					{
						messageDTO1.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
						messageDTO1.Resultado = false;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
						InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
						return messageDTO;
					}
				}
				InsertLog("-", placa, "entry", messageDTO1.Mensaje, -99);
				return messageDTO1;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				messageDTO1.Mensaje = string.Concat("Error: ", exception.ToString());
				messageDTO1.ErrorInterno = (exception.InnerException == null ? "" : exception.InnerException.ToString());
				messageDTO1.Resultado = false;
				messageDTO1.Error = "*";
				messageDTO1.ErrorInterno = "*";
				messageDTO = messageDTO1;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalidaPlaca(string Card, string placa)
		{
			MessageDTO messageDTO;
			string card = Card;
			MessageDTO str = new MessageDTO();
			try
			{
				long num = Convert.ToInt64("" + card, 16);
				card = string.Format("{0:X}", num).ToLower();
				using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta.EndsWith(card) == true
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.Placa == placa
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo =
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado != tEmpleado.idEmpleado)
										{
											continue;
										}
										//(new TareasInner()).AgregarTarea(1, "OpenS", CB);
										using (masterDBACEntities masterDBACEntity1 = new masterDBACEntities())
										{
											TParqueo nullable = (
												from k1 in masterDBACEntity1.TParqueo
												where k1.ocupadopor == tVehiculo.Placa
												select k1).FirstOrDefault<TParqueo>();
											if (nullable == null)
											{
												str.Mensaje = "El vehiculo no ha ingresado!";
												str.Resultado = true;
												str.Error = "*";
												str.ErrorInterno = "*";
												messageDTO = str;
												InsertLog(card, placa, "exit", str.Mensaje, -99);
												return messageDTO;
											}
											else
											{
												nullable.ocupadopor = "";
												nullable.estaocupado = new bool?(false);
												masterDBACEntity1.SaveChanges();
												string str1 = tVehiculo.idVehiculo.ToString(CultureInfo.InvariantCulture);
												int num1 = tEmpleado.idEmpleado;
												this.GuardaMarcacionParqueadero(str1, num1.ToString(CultureInfo.InvariantCulture), "Salida Vehicular");
												str.Mensaje = "Salida Exitosa!";
												str.Resultado = true;
												str.Error = "*";
												str.ErrorInterno = "*";
												messageDTO = str;
												InsertLog(card, placa, "exit", str.Mensaje, 20);
												return messageDTO;
											}
										}
									}
								}
								else
								{
									str.Mensaje = "la asignacion del vehiculo no se encuentra en la BASE de datos!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									InsertLog(card, placa, "exit", str.Mensaje, -99);
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El vehiculo no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								InsertLog(card, placa, "exit", str.Mensaje, -99);
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe el en la BASE de datos!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							InsertLog(card, placa, "exit", str.Mensaje, -99);
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						InsertLog(card, placa, "exit", str.Mensaje, -99);
						return messageDTO;
					}
				}
				str.Mensaje = "Acceso no permitido";
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				InsertLog(card, placa, "exit", str.Mensaje, -99);
				return str;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = string.Concat("Error :", exception.ToString());
				str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
				InsertLog(card, placa, "exit", str.Mensaje, -99);
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalidaPlaca(string placa)
		{
			MessageDTO messageDTO;
			MessageDTO messageDTO1 = new MessageDTO();

			//if (placa == "QQQAAAXXX")
			//{
			//	messageDTO1.Mensaje = string.Concat("El vehiculo [", placa, "] debe esperar para procesar.");
			//	messageDTO1.Resultado = false;
			//	messageDTO1.Error = "*";
			//	messageDTO1.ErrorInterno = "*";
			//	messageDTO = messageDTO1;

			//	return messageDTO;
			//}
			var detalle = SqlTools.ExecSqlGetList<regOcr>("  select * from TRegistroVehiculoOcr where OcrfechadeRegistro > DATEADD(SECOND, -55, getdate()) and OcrPlate = '" + placa + "'").ToList();
			if (detalle.Any())
			{
				messageDTO1.Mensaje = string.Concat("El vehiculo [", placa, "] registro no necesario por tiempo.");
				messageDTO1.Resultado = false;
				messageDTO1.Error = "*";
				messageDTO1.ErrorInterno = "*";
				messageDTO = messageDTO1;

				return messageDTO;
			}
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TVehiculo tVehiculo = (
					from c in masterDBACEntity.TVehiculo
					where c.Placa == placa
					select c).FirstOrDefault<TVehiculo>();
				if (tVehiculo != null)
				{
					//(new TareasInner()).AgregarTarea(1, "OpenS", CB);
					TParqueo nullable = (
						from k1 in masterDBACEntity.TParqueo
						where k1.ocupadopor == tVehiculo.Placa
						select k1).FirstOrDefault<TParqueo>();
					if (nullable == null)
					{
						messageDTO1.Mensaje = "El vehiculo no ha ingresado!";
						messageDTO1.Resultado = true; //false // solo por rectificar el trafico
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
						InsertLog("-", placa, "exit", messageDTO1.Mensaje, -99);
					}
					else
					{
						//validacion de tiempo para la salida
						var fecha = DateTime.Now.AddSeconds(-55);
						var target = masterDBACEntity.TRegistroVehiculo.FirstOrDefault(a => a.idVehiculo == tVehiculo.idVehiculo && a.fechadeRegistro >= fecha);
						if (target != null)
						{
							messageDTO1.Mensaje = string.Concat("El vehiculo [", tVehiculo.Placa, "] debe esperar para procesar.");
							messageDTO1.Resultado = false;
							messageDTO1.Error = "*";
							messageDTO1.ErrorInterno = "*";
							messageDTO = messageDTO1;
							InsertLog("-", placa, "exit", messageDTO1.Mensaje, -99);
							return messageDTO;
						}
						nullable.ocupadopor = "";
						nullable.estaocupado = new bool?(false);
						masterDBACEntity.SaveChanges();
						int num = tVehiculo.idVehiculo;
						this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Salida Vehicular");
						messageDTO1.Mensaje = "Salida Exitosa!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
						InsertLog("-", placa, "exit", messageDTO1.Mensaje, 20);
					}
				}
				else
				{
					messageDTO1.Mensaje = "El vehiculo no se encuentra en la base de datos";
					messageDTO1.Resultado = false;
					messageDTO1.Error = "*";
					messageDTO1.ErrorInterno = "*";
					messageDTO = messageDTO1;
					InsertLog("-", placa, "exit", messageDTO1.Mensaje, -99);
				}
			}

			return messageDTO;
		}

		public MessageDTO verificaParqueoSalidaOPlaca(string placa)
		{
			MessageDTO messageDTO;
			MessageDTO messageDTO1 = new MessageDTO();
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TVehiculo tVehiculo = (
					from c in masterDBACEntity.TVehiculo
					where c.Placa == placa
					select c).FirstOrDefault<TVehiculo>();
				if (tVehiculo != null)
				{
					//(new TareasInner()).AgregarTarea(1, "OpenS", CB);
					TParqueo nullable = (
						from k1 in masterDBACEntity.TParqueo
						where k1.ocupadopor == tVehiculo.Placa
						select k1).FirstOrDefault<TParqueo>();
					if (nullable == null)
					{
						messageDTO1.Mensaje = "El vehiculo no ha ingresado!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
					else
					{
						nullable.ocupadopor = "";
						nullable.estaocupado = new bool?(false);
						masterDBACEntity.SaveChanges();
						int num = tVehiculo.idVehiculo;
						this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Salida Vehicular");
						messageDTO1.Mensaje = "Salida Exitosa!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
				}
				else
				{
					messageDTO1.Mensaje = "El vehiculo no se encuentra en la base de datos";
					messageDTO1.Resultado = false;
					messageDTO1.Error = "*";
					messageDTO1.ErrorInterno = "*";
					messageDTO = messageDTO1;
				}
			}
			return messageDTO;
		}

		public void InsertLog(string card, string placa, string sentido, string memo, int result)
		{
			var cad = @"INSERT INTO [dbo].[TRegistroVehiculoOcr]
                 ([OcrPlate]
                 ,[OcrCard]
                 ,[OcrWay]
                 ,[OcrfechadeRegistro]
                 ,[OcrMemoRegistro]
                 ,[OcrVerificationResult])
           VALUES
                 ('" + placa + @"',
                  '" + card + @"',
                  '" + sentido + @"',
                  GETDATE(),
                  '" + memo + @"',
                  " + result + @")";
			SqlTools.SQLExecute(cad);
		}
	}

	public class SqlTools
	{

		public static string SQLExecute(string sQuery)
		{
			var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString();

			#region old_code
			using (var sqlConnection = new SqlConnection(cadCnx))
			{
				sqlConnection.Open();
				var dbCmd = new System.Data.SqlClient.SqlCommand(sQuery, sqlConnection);
				try
				{
					dbCmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Exception customException = new Exception();
					//if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
					//{
					//    throw customException;
					//}
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			#endregion

			return "";
		}

		public static DataTable AdoSqlGetDataTable(string sQuery, string alternativeCnx = "")
		{

			{
				SqlConnection sqlConnection;
				if (string.IsNullOrEmpty(alternativeCnx))
				{
					sqlConnection =
						new SqlConnection(
							System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString());
				}
				else
				{
					sqlConnection =
						new SqlConnection(
							System.Configuration.ConfigurationManager.ConnectionStrings[alternativeCnx].ToString());
				}
				sQuery = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + sQuery;
				var DsResult = new DataSet();
				var Result = new DataTable();



				sqlConnection.Open();

				try
				{
					using (SqlDataAdapter dbAdapter = new SqlDataAdapter(sQuery, sqlConnection))
					{
						dbAdapter.Fill(DsResult, "Table");
						if (DsResult.Tables.Count > 0)
						{
							Result = DsResult.Tables[0];
						}
					}
				}
				catch (Exception ex)
				{
					//Exception customException = new Exception();
					//if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
					//{
					//    throw customException;
					//}
					//MessageBox.Show(ex.Message);
				}
				finally
				{
					DsResult.Dispose();
					sqlConnection.Close();
					//dbCxn.Close();
				}

				return Result;
			}
		}

		public static IEnumerable<T> ExecSqlGetList<T>(string query, string alternativeCnx = "") where T : new()
		{
			//var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["Terpel_TC_ProdADO"].ToString();
			//var empList = new List<T>();
			//query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + query;
			//using (var _db = new SqlConnection(cadCnx))
			//{
			//    empList = _db.Query<T>(query).ToList();
			//}

			//return empList;

			var obj = AdoSqlGetDataTable(query, alternativeCnx);
			var res = obj.ToList<T>();
			return res;


		}
	}

	public class regOcr
	{
		public string OcrPlate { get; set; }
		public string OcrCard { get; set; }
		public string OcrWay { get; set; }
		public DateTime OcrfechadeRegistro { get; set; }
	}
	public static class DataTableExtensions
	{



		private static Dictionary<Type, IList<PropertyInfo>> typeDictionary = new Dictionary<Type, IList<PropertyInfo>>();
		public static IList<PropertyInfo> GetPropertiesForType<T>()
		{
			var type = typeof(T);
			if (!typeDictionary.ContainsKey(typeof(T)))
			{
				typeDictionary.Add(type, type.GetProperties().ToList());
			}
			return typeDictionary[type];
		}

		//public static IList<T> ToList<T>(this DataTable table) where T : new()
		//{
		//  IList<PropertyInfo> properties = GetPropertiesForType<T>();
		//  IList<T> result = new List<T>();

		//  foreach (var row in table.Rows)
		//  {
		//    var item = CreateItemFromRow<T>((DataRow)row, properties);
		//    result.Add(item);
		//  }

		//  return result;
		//}

		private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
		{
			T item = new T();
			foreach (var property in properties)
			{
				property.SetValue(item, row[property.Name], null);
			}
			return item;
		}


		public static IList<T> ToList<T>(this DataTable table) where T : new()
		{

			string propName = string.Empty;
			List<T> entityList = new List<T>();

			foreach (DataRow dr in table.Rows)
			{
				// Create Instance of the Type T
				T entity = System.Activator.CreateInstance<T>();

				// Get all properties of the Type T
				System.Reflection.PropertyInfo[]
				entityProperties = typeof(T).GetProperties();

				// Loop through the properties defined in the 
				// entityList entity object and mapped the value
				foreach (System.Reflection.PropertyInfo item in
								entityProperties)
				{
					propName = string.Empty;
					if (propName.Equals(string.Empty))
						propName = item.Name;

					if (table.Columns.Contains(propName))
					{
						// Assign value to the property
						try
						{
							item.SetValue
							(
									entity,
									dr[propName].GetType().
											Name.Equals(typeof(DBNull).Name)
											? null : dr[propName],
									null
							);
						}
						catch (Exception)
						{

							throw;
						}

					}
				}


				entityList.Add(entity);
			}
			return entityList;
		}

	}
}