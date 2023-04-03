using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Parqueaderos
	{
		public Parqueaderos()
		{
		}

		public void Agregar(string parqueo, DateTime fechaC, int usuarioAct, string observaciones = "Sin Observaciones")
		{
			TParqueo tParqueo = new TParqueo()
			{
				nParqueo = parqueo,
				observacionesParqueo = observaciones,
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioAct)
			};
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTParqueo(tParqueo);
			masterDBACEntity.SaveChanges();
		}

		public void Eliminar(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TParqueo tParqueo = masterDBACEntity.TParqueo.FirstOrDefault<TParqueo>((TParqueo c) => c.idParqueadero == id);
			masterDBACEntity.TParqueo.DeleteObject(tParqueo);
			masterDBACEntity.SaveChanges();
		}

		public void liberarParqueo(string placa)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TParqueo nullable = (
					from k1 in masterDBACEntity.TParqueo
					where k1.ocupadopor == placa
					select k1).FirstOrDefault<TParqueo>();
				if (nullable != null)
				{
					nullable.ocupadopor = "";
					nullable.estaocupado = new bool?(false);
					masterDBACEntity.SaveChanges();
				}
			}
		}

		public List<TParqueo> ListarTodos()
		{
			IOrderedQueryable<TParqueo> tParqueo = 
				from d in (new masterDBACEntities()).TParqueo
				orderby d.nParqueo
				select d;
			return tParqueo.ToList<TParqueo>();
		}

		public void Modificar(int id, string pNuevo, DateTime fechaC, int usuarioUg, string observaciones = "Sin Observaciones")
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TParqueo nullable = masterDBACEntity.TParqueo.FirstOrDefault<TParqueo>((TParqueo c) => c.idParqueadero == id);
			if (nullable != null)
			{
				nullable.nParqueo = pNuevo;
				nullable.observacionesParqueo = observaciones;
				nullable.fechaUltimaGestion = new DateTime?(fechaC);
				nullable.usuarioUltimaGestion = new int?(usuarioUg);
				masterDBACEntity.SaveChanges();
			}
		}
	}
}