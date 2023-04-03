using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Cargos
	{
		public Cargos()
		{
		}

		public bool AgregarCargo(TCargo nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTCargo(nuevo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public TCargo Buscar(string valor)
		{
			TCargo tCargo = (
				from d in (new masterDBACEntities()).TCargo
				where d.NombreCargo == valor
				select d).First<TCargo>();
			return tCargo;
		}

		public bool EliminarCargo(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TCargo tCargo = masterDBACEntity.TCargo.FirstOrDefault<TCargo>((TCargo c) => c.idCargo == id);
			masterDBACEntity.TCargo.DeleteObject(tCargo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TCargo> ListarTodas()
		{
			IQueryable<TCargo> tCargo = 
				from d in (new masterDBACEntities()).TCargo
				select d;
			return tCargo.ToList<TCargo>();
		}

		public bool ModificarCargo(int id, TCargo nueva)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TCargo nombreCargo = masterDBACEntity.TCargo.FirstOrDefault<TCargo>((TCargo c) => c.idCargo == id);
			if (nombreCargo != null)
			{
				nombreCargo.NombreCargo = nueva.NombreCargo;
				nombreCargo.fechaUltimaGestion = nueva.fechaUltimaGestion;
				nombreCargo.usuarioUltimaGestion = nueva.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}