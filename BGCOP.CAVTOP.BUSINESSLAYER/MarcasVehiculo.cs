using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class MarcasVehiculo
	{
		public MarcasVehiculo()
		{
		}

		public void Agregar(string marcaNueva, DateTime fechaC, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TMarcaVehiculo tMarcaVehiculo = new TMarcaVehiculo()
			{
				NombreMarcaVehiculo = marcaNueva,
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioUg)
			};
			masterDBACEntity.AddToTMarcaVehiculo(tMarcaVehiculo);
			masterDBACEntity.SaveChanges();
		}

		public void Eliminar(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TMarcaVehiculo tMarcaVehiculo = masterDBACEntity.TMarcaVehiculo.FirstOrDefault<TMarcaVehiculo>((TMarcaVehiculo c) => (int)c.idMarcaVehiculo == id);
			masterDBACEntity.TMarcaVehiculo.DeleteObject(tMarcaVehiculo);
			masterDBACEntity.SaveChanges();
		}

		public List<TMarcaVehiculo> ListarTodos()
		{
			IQueryable<TMarcaVehiculo> tMarcaVehiculo = 
				from d in (new masterDBACEntities()).TMarcaVehiculo
				select d;
			return tMarcaVehiculo.ToList<TMarcaVehiculo>();
		}

		public void Modificar(int id, string marcaNueva, DateTime fechaC, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TMarcaVehiculo nullable = masterDBACEntity.TMarcaVehiculo.FirstOrDefault<TMarcaVehiculo>((TMarcaVehiculo c) => (int)c.idMarcaVehiculo == id);
			if (nullable != null)
			{
				nullable.NombreMarcaVehiculo = marcaNueva;
				nullable.fechaUltimaGestion = new DateTime?(fechaC);
				nullable.usuarioUltimaGestion = new int?(usuarioUg);
				masterDBACEntity.SaveChanges();
			}
		}
	}
}