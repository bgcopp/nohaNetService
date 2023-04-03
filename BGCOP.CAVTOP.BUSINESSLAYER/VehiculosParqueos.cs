using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class VehiculosParqueos
	{
		public VehiculosParqueos()
		{
		}

		public void Agregar(int idParqueo, int idVehiculo, DateTime fechaC, int usuarioAct, int diaS = 1, string obs = "Sin Obeservaciones", bool d0 = false, bool d1 = false, bool d2 = false, bool d3 = false, bool d4 = false, bool d5 = false, bool d6 = false)
		{
			TvehiculoParqueo tvehiculoParqueo = new TvehiculoParqueo()
			{
				idParqueadero = idParqueo,
				idVehiculo = idVehiculo,
				diaSemana = (byte)diaS,
				ObservacionesVP = obs,
				dia1 = new bool?(d0),
				dia2 = new bool?(d1),
				dia3 = new bool?(d2),
				dia4 = new bool?(d3),
				dia5 = new bool?(d4),
				dia6 = new bool?(d5),
				dia7 = new bool?(d6),
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioAct)
			};
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTvehiculoParqueo(tvehiculoParqueo);
			masterDBACEntity.SaveChanges();
		}

		public TvehiculoParqueo consultarreg(int idParqueo, int idVehiculo)
		{
			TvehiculoParqueo tvehiculoParqueo = (
				from a in (new masterDBACEntities()).TvehiculoParqueo
				where a.idParqueadero == idParqueo && a.idVehiculo == idVehiculo
				select a).FirstOrDefault<TvehiculoParqueo>();
			return tvehiculoParqueo;
		}

		public void Eliminar(int idParqueo, int idVehiculo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TvehiculoParqueo tvehiculoParqueo = masterDBACEntity.TvehiculoParqueo.FirstOrDefault<TvehiculoParqueo>((TvehiculoParqueo c) => c.idVehiculo == idVehiculo && c.idParqueadero == idParqueo);
			if (tvehiculoParqueo != null)
			{
				masterDBACEntity.TvehiculoParqueo.DeleteObject(tvehiculoParqueo);
			}
		}

		public List<viParqueoVehiculo> listarTodos()
		{
			IOrderedQueryable<viParqueoVehiculo> masterDBACEntity = 
				from d in (new masterDBACEntities()).viParqueoVehiculo
				orderby d.Parqueadero
				select d;
			return masterDBACEntity.ToList<viParqueoVehiculo>();
		}

		public void modificar(int idParqueo, int idVehiculo, int dia, bool d0 = false)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TvehiculoParqueo nullable = masterDBACEntity.TvehiculoParqueo.FirstOrDefault<TvehiculoParqueo>((TvehiculoParqueo c) => c.idVehiculo == idVehiculo && c.idParqueadero == idParqueo);
			if (nullable != null)
			{
				switch (dia)
				{
					case 0:
					{
						nullable.dia1 = new bool?(d0);
						break;
					}
					case 1:
					{
						nullable.dia2 = new bool?(d0);
						break;
					}
					case 2:
					{
						nullable.dia3 = new bool?(d0);
						break;
					}
					case 3:
					{
						nullable.dia4 = new bool?(d0);
						break;
					}
					case 4:
					{
						nullable.dia5 = new bool?(d0);
						break;
					}
					case 5:
					{
						nullable.dia6 = new bool?(d0);
						break;
					}
					case 6:
					{
						nullable.dia7 = new bool?(d0);
						break;
					}
				}
				masterDBACEntity.SaveChanges();
			}
		}

		public void Modificar(int idParqueo, int idVehiculo, DateTime fechaC, int usuarioAct, int diaS = -1, string obs = "Sin Obeservaciones", bool d0 = false, bool d1 = false, bool d2 = false, bool d3 = false, bool d4 = false, bool d5 = false, bool d6 = false)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TvehiculoParqueo nullable = masterDBACEntity.TvehiculoParqueo.FirstOrDefault<TvehiculoParqueo>((TvehiculoParqueo c) => c.idVehiculo == idVehiculo && c.idParqueadero == idParqueo);
			if (nullable != null)
			{
				nullable.ObservacionesVP = obs;
				switch (diaS)
				{
					case -1:
					{
						nullable.dia1 = new bool?(d0);
						nullable.dia2 = new bool?(d1);
						nullable.dia3 = new bool?(d2);
						nullable.dia4 = new bool?(d3);
						nullable.dia5 = new bool?(d4);
						nullable.dia6 = new bool?(d5);
						nullable.dia7 = new bool?(d6);
						break;
					}
					case 0:
					{
						nullable.dia1 = new bool?(d0);
						break;
					}
					case 1:
					{
						nullable.dia2 = new bool?(d1);
						break;
					}
					case 2:
					{
						nullable.dia3 = new bool?(d2);
						break;
					}
					case 3:
					{
						nullable.dia4 = new bool?(d3);
						break;
					}
					case 4:
					{
						nullable.dia5 = new bool?(d4);
						break;
					}
					case 5:
					{
						nullable.dia6 = new bool?(d5);
						break;
					}
					case 6:
					{
						nullable.dia7 = new bool?(d6);
						break;
					}
				}
				nullable.fechaUltimaGestion = new DateTime?(fechaC);
				nullable.usuarioUltimaGestion = new int?(usuarioAct);
				masterDBACEntity.SaveChanges();
			}
		}
	}
}