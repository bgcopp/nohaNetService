using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class TiposUsuarios
	{
		public TiposUsuarios()
		{
		}

		public bool ActualizarTipoUsuario(int tipoBusq, string nuevoNombre, string nuevosPermisos, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTipoUsuario nullable = masterDBACEntity.TTipoUsuario.FirstOrDefault<TTipoUsuario>((TTipoUsuario c) => c.idTipoUsuario == tipoBusq);
			nullable.NombreTipoUsuario = nuevoNombre;
			nullable.permisos = nuevosPermisos;
			nullable.fechaUltimaGestion = new DateTime?(DateTime.Now);
			nullable.usuarioUltimaGestion = new int?(usuarioUg);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public bool CrearTipoUsuario(string nombreTipo, string mPermisos, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTipoUsuario tTipoUsuario = new TTipoUsuario()
			{
				NombreTipoUsuario = nombreTipo,
				fechaUltimaGestion = new DateTime?(DateTime.Now),
				usuarioUltimaGestion = new int?(usuarioUg),
				permisos = mPermisos
			};
			masterDBACEntity.AddToTTipoUsuario(tTipoUsuario);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public bool EliminarTipoUsuario(int tipoBusq)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTipoUsuario tTipoUsuario = masterDBACEntity.TTipoUsuario.FirstOrDefault<TTipoUsuario>((TTipoUsuario c) => c.idTipoUsuario == tipoBusq);
			masterDBACEntity.TTipoUsuario.DeleteObject(tTipoUsuario);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TTipoUsuario> ListarTodosLosTipos()
		{
			List<TTipoUsuario> list;
			try
			{
				IOrderedQueryable<TTipoUsuario> tTipoUsuario = 
					from tp in (new masterDBACEntities()).TTipoUsuario
					orderby tp.NombreTipoUsuario
					select tp;
				list = tTipoUsuario.ToList<TTipoUsuario>();
			}
			catch (Exception exception)
			{
				throw;
			}
			return list;
		}
	}
}