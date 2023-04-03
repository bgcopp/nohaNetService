using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Vehiculos
	{
		public Vehiculos()
		{
		}

		public void Agregar(string placa, int modelo, string codigoBarras, string color, DateTime fechaC, int usuarioAct)
		{
			TVehiculo tVehiculo = new TVehiculo()
			{
				Placa = placa,
				color = color,
				idModeloVehiculo = new short?((short)modelo),
				CodigodeBarras = codigoBarras,
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioAct)
			};
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				masterDBACEntity.AddToTVehiculo(tVehiculo);
				masterDBACEntity.SaveChanges();
			}
			catch (Exception exception)
			{
				throw;
			}
		}

		public void Agregar(string placa, string modelo, string codigoBarras, string color, DateTime fechaC, int usuarioAct)
		{
			TVehiculo tVehiculo = new TVehiculo()
			{
				Placa = placa,
				color = color,
				CodigodeBarras = codigoBarras,
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioAct)
			};
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				TModeloVehiculo tModeloVehiculo = (
					from a in masterDBACEntity.TModeloVehiculo
					where a.NombreModelo == modelo
					select a).FirstOrDefault<TModeloVehiculo>();
				if (tModeloVehiculo != null)
				{
					tVehiculo.idModeloVehiculo = new short?(tModeloVehiculo.idModeloVehiculo);
					masterDBACEntity.AddToTVehiculo(tVehiculo);
					masterDBACEntity.SaveChanges();
				}
				else
				{
					(new ModelosVehiculo()).CrearModeloVehiculo(modelo, DateTime.Now, 1, 1);
					TModeloVehiculo tModeloVehiculo1 = (
						from a in masterDBACEntity.TModeloVehiculo
						where a.NombreModelo == modelo
						select a).FirstOrDefault<TModeloVehiculo>();
					tVehiculo.idModeloVehiculo = new short?(tModeloVehiculo1.idModeloVehiculo);
					masterDBACEntity.AddToTVehiculo(tVehiculo);
					masterDBACEntity.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				throw;
			}
		}

		public void asignarVehiculoEmpleado(string identEmp, string placa)
		{
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				TEmpleado tEmpleado = (
					from a in masterDBACEntity.TEmpleado
					where a.identificacion == identEmp
					select a).FirstOrDefault<TEmpleado>();
				TVehiculo tVehiculo = (
					from b in masterDBACEntity.TVehiculo
					where b.Placa == placa
					select b).FirstOrDefault<TVehiculo>();
				TEmpleadoVehiculo tEmpleadoVehiculo = new TEmpleadoVehiculo()
				{
					IdEmpleado = tEmpleado.idEmpleado,
					IdVehiculo = tVehiculo.idVehiculo,
					fechaUltimaGestion = new DateTime?(DateTime.Now),
					usuarioUltimaGestion = new int?(1)
				};
				masterDBACEntity.AddToTEmpleadoVehiculo(tEmpleadoVehiculo);
				masterDBACEntity.SaveChanges();
			}
			catch (Exception exception)
			{
			}
		}

		public TVehiculo consultarVehiculo(string placa)
		{
			return (new masterDBACEntities()).TVehiculo.FirstOrDefault<TVehiculo>((TVehiculo c) => c.Placa == placa);
		}

		public void Eliminar(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TVehiculo tVehiculo = masterDBACEntity.TVehiculo.FirstOrDefault<TVehiculo>((TVehiculo c) => c.idVehiculo == id);
			masterDBACEntity.TVehiculo.DeleteObject(tVehiculo);
			masterDBACEntity.SaveChanges();
		}

		public string GenCodigodeBarras()
		{
			string str = "";
			bool flag = true;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			while (flag)
			{
				str = this.RandomString(12, false);
				if ((
					from a in masterDBACEntity.TVehiculo
					where a.CodigodeBarras == str
					select a).FirstOrDefault<TVehiculo>() != null)
				{
					continue;
				}
				flag = false;
			}
			return str;
		}

		public List<TVehiculo> ListarTodos()
		{
			IOrderedQueryable<TVehiculo> tVehiculo = 
				from d in (new masterDBACEntities()).TVehiculo
				orderby d.Placa
				select d;
			return tVehiculo.ToList<TVehiculo>();
		}

		public void Modificar(int id, string placa, int modelo, string codigoBarras, string color, DateTime fechaC, int usuarioAct)
		{
			TVehiculo tVehiculo = new TVehiculo()
			{
				Placa = placa,
				color = color,
				idModeloVehiculo = new short?((short)modelo),
				CodigodeBarras = codigoBarras,
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioAct)
			};
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TVehiculo codigodeBarras = masterDBACEntity.TVehiculo.FirstOrDefault<TVehiculo>((TVehiculo c) => c.idVehiculo == id);
			if (codigodeBarras != null)
			{
				codigodeBarras.Placa = tVehiculo.Placa;
				codigodeBarras.color = tVehiculo.color;
				codigodeBarras.idModeloVehiculo = tVehiculo.idModeloVehiculo;
				codigodeBarras.CodigodeBarras = tVehiculo.CodigodeBarras;
				codigodeBarras.fechaUltimaGestion = tVehiculo.fechaUltimaGestion;
				codigodeBarras.usuarioUltimaGestion = tVehiculo.usuarioUltimaGestion;
			}
			masterDBACEntity.SaveChanges();
		}

		public string RandomString(int size, bool lowerCase)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < size; i++)
			{
				char chr = Convert.ToChar(Convert.ToInt32(Math.Floor(9 * random.NextDouble() + 48)));
				stringBuilder.Append(chr);
			}
			if (!lowerCase)
			{
				return stringBuilder.ToString();
			}
			return stringBuilder.ToString().ToLower();
		}
	}
}