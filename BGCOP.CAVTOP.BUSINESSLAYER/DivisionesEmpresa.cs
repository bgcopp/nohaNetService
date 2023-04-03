using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class DivisionesEmpresa
	{
		public DivisionesEmpresa()
		{
		}

		public bool AgregarDivision(TDivisionEmpresa nueva)
		{
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				masterDBACEntity.AddToTDivisionEmpresa(nueva);
				masterDBACEntity.SaveChanges();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Console.WriteLine("en la inmunda!°");
				throw exception;
			}
			return true;
		}

		public TDivisionEmpresa consulta(string nombre)
		{
			TDivisionEmpresa tDivisionEmpresa = (
				from d in (new masterDBACEntities()).TDivisionEmpresa
				where d.NombreDivision == nombre
				select d).First<TDivisionEmpresa>();
			return tDivisionEmpresa;
		}

		public bool EliminarDivision(int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TDivisionEmpresa tDivisionEmpresa = masterDBACEntity.TDivisionEmpresa.FirstOrDefault<TDivisionEmpresa>((TDivisionEmpresa c) => c.IdDivisionEmpresa == id);
			masterDBACEntity.TDivisionEmpresa.DeleteObject(tDivisionEmpresa);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TDivisionEmpresa> ListarTodas()
		{
			IQueryable<TDivisionEmpresa> tDivisionEmpresa = 
				from d in (new masterDBACEntities()).TDivisionEmpresa
				select d;
			return tDivisionEmpresa.ToList<TDivisionEmpresa>();
		}

		public List<TDivisionEmpresa> ListarTodas(int idEmp)
		{
			IQueryable<TDivisionEmpresa> tDivisionEmpresa = 
				from d in (new masterDBACEntities()).TDivisionEmpresa
				where d.IdEmpresa == (int?)idEmp
				select d;
			return tDivisionEmpresa.ToList<TDivisionEmpresa>();
		}

		public bool ModificarDivision(int id, TDivisionEmpresa nueva)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TDivisionEmpresa nombreDivision = masterDBACEntity.TDivisionEmpresa.FirstOrDefault<TDivisionEmpresa>((TDivisionEmpresa c) => c.IdDivisionEmpresa == id);
			if (nombreDivision != null)
			{
				nombreDivision.NombreDivision = nueva.NombreDivision;
				nombreDivision.fechaUltimaGestion = nueva.fechaUltimaGestion;
				nombreDivision.IdEmpresa = nueva.IdEmpresa;
				nombreDivision.usuarioUltimaGestion = nueva.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}