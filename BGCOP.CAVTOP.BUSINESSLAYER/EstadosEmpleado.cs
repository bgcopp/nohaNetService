using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class EstadosEmpleado
	{
		public EstadosEmpleado()
		{
		}

		public bool AgregarEstado(TEstado nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTEstado(nuevo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public bool EliminarEstado(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TEstado tEstado = masterDBACEntity.TEstado.FirstOrDefault<TEstado>((TEstado c) => c.idTipoEstado == id);
			masterDBACEntity.TEstado.DeleteObject(tEstado);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TEstado> ListarTodos()
		{
			IQueryable<TEstado> tEstado = 
				from d in (new masterDBACEntities()).TEstado
				select d;
			return tEstado.ToList<TEstado>();
		}

		public bool ModificarEstado(int id, TEstado nuevo)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TEstado nombreEstado = masterDBACEntity.TEstado.FirstOrDefault<TEstado>((TEstado c) => c.idTipoEstado == id);
			if (nombreEstado != null)
			{
				nombreEstado.NombreEstado = nuevo.NombreEstado;
				nombreEstado.fechaUltimaGestion = nuevo.fechaUltimaGestion;
				nombreEstado.usuarioUltimaGestion = nuevo.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}