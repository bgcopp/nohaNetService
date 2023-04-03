using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Horarios
	{
		public Horarios()
		{
		}

		public void Agregar(string nombre, bool esmaestro, DateTime fechaInicio, DateTime fechaFin, bool permanente, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			THorario tHorario = new THorario()
			{
				NombreHorario = nombre,
				esMaestro = esmaestro,
				fechaInicio = new DateTime?(fechaInicio),
				fechaFin = new DateTime?(fechaFin),
				esPermanente = new bool?(permanente),
				fechaUltimaGestion = new DateTime?(DateTime.Now),
				usuarioUltimaGestion = new int?(usuarioUg)
			};
			masterDBACEntity.AddToTHorario(tHorario);
			masterDBACEntity.SaveChanges();
		}

		public void Eliminar(int idT)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			THorario tHorario = masterDBACEntity.THorario.FirstOrDefault<THorario>((THorario c) => c.idHorario == idT);
			if (tHorario != null)
			{
				masterDBACEntity.THorario.DeleteObject(tHorario);
				masterDBACEntity.SaveChanges();
			}
		}

		public List<THorario> ListarTodas()
		{
			IOrderedQueryable<THorario> tHorario = 
				from d in (new masterDBACEntities()).THorario
				orderby d.NombreHorario
				select d;
			return tHorario.ToList<THorario>();
		}

		public void Modificar(int idT, string nombre, bool esmaestro, DateTime fechaInicio, DateTime fechaFin, bool permanente, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			THorario nullable = masterDBACEntity.THorario.FirstOrDefault<THorario>((THorario c) => c.idHorario == idT);
			if (nullable != null)
			{
				nullable.NombreHorario = nombre;
				nullable.esMaestro = esmaestro;
				nullable.fechaInicio = new DateTime?(fechaInicio);
				nullable.fechaFin = new DateTime?(fechaFin);
				nullable.esPermanente = new bool?(permanente);
				nullable.fechaUltimaGestion = new DateTime?(DateTime.Now);
			}
			masterDBACEntity.SaveChanges();
		}
	}
}