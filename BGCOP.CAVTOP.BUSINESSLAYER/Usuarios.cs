using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Usuarios
	{
		public Usuarios()
		{
		}

		public bool AgregarUsuario(TUsuario nuevoUsuario, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTUsuario(nuevoUsuario);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public bool EliminarUsuario(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TUsuario tUsuario = masterDBACEntity.TUsuario.FirstOrDefault<TUsuario>((TUsuario c) => c.idUsuario == id);
			masterDBACEntity.TUsuario.DeleteObject(tUsuario);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TUsuario> ListarTodosLosUsuarios()
		{
			IQueryable<TUsuario> tUsuario = 
				from usr in (new masterDBACEntities()).TUsuario
				select usr;
			return tUsuario.ToList<TUsuario>();
		}

		public bool ModificarUsuario(int id, TUsuario nuevoUsuario, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TUsuario nullable = masterDBACEntity.TUsuario.FirstOrDefault<TUsuario>((TUsuario c) => c.idUsuario == id);
			if (nullable != null)
			{
				nullable.nombre = nuevoUsuario.nombre;
				nullable.login = nuevoUsuario.login;
				nullable.password = nuevoUsuario.password;
				nullable.activo = nuevoUsuario.activo;
				nullable.fotoUsuario = nuevoUsuario.fotoUsuario;
				nullable.fechaUltimaGestion = new DateTime?(DateTime.Now);
				nullable.idTipoUsuario = nuevoUsuario.idTipoUsuario;
				nullable.usuarioUltimaGestion = new int?(usuarioUg);
				masterDBACEntity.SaveChanges();
			}
			return true;
		}

		public TUsuario obtenerUsuario(string login)
		{
			return (new masterDBACEntities()).TUsuario.FirstOrDefault<TUsuario>((TUsuario c) => c.login == login);
		}
	}
}