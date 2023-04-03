using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class TiposIdentificacion
	{
		public TiposIdentificacion()
		{
		}

		public bool AgregarTipoIdentificacion(TTipoIdentificacion nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTTipoIdentificacion(nuevo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public TTipoIdentificacion consulta(string tipo)
		{
			TTipoIdentificacion tTipoIdentificacion = (
				from d in (new masterDBACEntities()).TTipoIdentificacion
				where d.descripcionIdentificacion == tipo
				select d).First<TTipoIdentificacion>();
			return tTipoIdentificacion;
		}

		public bool EliminarTipoIdentificacion(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTipoIdentificacion tTipoIdentificacion = masterDBACEntity.TTipoIdentificacion.FirstOrDefault<TTipoIdentificacion>((TTipoIdentificacion c) => c.idTipoIdentificacion == id);
			masterDBACEntity.TTipoIdentificacion.DeleteObject(tTipoIdentificacion);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TTipoIdentificacion> ListarTodos()
		{
			IQueryable<TTipoIdentificacion> tTipoIdentificacion = 
				from d in (new masterDBACEntities()).TTipoIdentificacion
				select d;
			return tTipoIdentificacion.ToList<TTipoIdentificacion>();
		}

		public bool ModificarTipoIdentificacion(int id, TTipoIdentificacion nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTipoIdentificacion tTipoIdentificacion = masterDBACEntity.TTipoIdentificacion.FirstOrDefault<TTipoIdentificacion>((TTipoIdentificacion c) => c.idTipoIdentificacion == id);
			if (tTipoIdentificacion != null)
			{
				tTipoIdentificacion.descripcionIdentificacion = nuevo.descripcionIdentificacion;
				tTipoIdentificacion.fechaUltimaGestion = nuevo.fechaUltimaGestion;
				tTipoIdentificacion.usuarioUltimaGestion = nuevo.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}