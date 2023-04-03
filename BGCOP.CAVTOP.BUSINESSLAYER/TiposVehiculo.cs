using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class TiposVehiculo
	{
		public TiposVehiculo()
		{
		}

		public bool AgregarTipoVehiculo(string nombreTipoVehiculo, DateTime fechaUlt, int UsuarioAct)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TipoVehiculo tipoVehiculo = new TipoVehiculo()
			{
				NombreTipoVehiculo = nombreTipoVehiculo,
				fechaUltimaGestion = new DateTime?(fechaUlt),
				usuarioUltimaGestion = new int?(UsuarioAct)
			};
			masterDBACEntity.AddToTipoVehiculo(tipoVehiculo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public TipoVehiculo consulta(string tipo)
		{
			TipoVehiculo tipoVehiculo = (
				from d in (new masterDBACEntities()).TipoVehiculo
				where d.NombreTipoVehiculo == tipo
				select d).First<TipoVehiculo>();
			return tipoVehiculo;
		}

		public bool EliminarTipoVehiculo(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TipoVehiculo tipoVehiculo = masterDBACEntity.TipoVehiculo.FirstOrDefault<TipoVehiculo>((TipoVehiculo c) => (int)c.idTipoVehiculo == id);
			masterDBACEntity.TipoVehiculo.DeleteObject(tipoVehiculo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TipoVehiculo> ListarTodos()
		{
			IQueryable<TipoVehiculo> tipoVehiculo = 
				from d in (new masterDBACEntities()).TipoVehiculo
				select d;
			return tipoVehiculo.ToList<TipoVehiculo>();
		}

		public bool ModificarTipoVehiculo(int id, TipoVehiculo nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TipoVehiculo nombreTipoVehiculo = masterDBACEntity.TipoVehiculo.FirstOrDefault<TipoVehiculo>((TipoVehiculo c) => (int)c.idTipoVehiculo == id);
			if (nombreTipoVehiculo != null)
			{
				nombreTipoVehiculo.NombreTipoVehiculo = nuevo.NombreTipoVehiculo;
				nombreTipoVehiculo.fechaUltimaGestion = nuevo.fechaUltimaGestion;
				nombreTipoVehiculo.usuarioUltimaGestion = nuevo.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}