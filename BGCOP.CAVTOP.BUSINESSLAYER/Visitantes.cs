using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Visitantes
	{
		public Visitantes()
		{
		}

		public void crear(TVisitante obj)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			masterDBACEntity.AddToTVisitante(obj);
			masterDBACEntity.SaveChanges();
		}

		public List<TvisitanteReducido> ListarTodos()
		{
			List<TvisitanteReducido> list;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				list = (
					from a in masterDBACEntity.TVisitante
					join b in 
						from c in masterDBACEntity.TVisitanteVisitaProgramada
						select c on a.idVisitante equals b.idVisitante
					orderby a.nombreVisitante
					select new TvisitanteReducido()
					{
						idVisitante = (int)a.idVisitante,
						nombre = a.nombreVisitante
					}).ToList<TvisitanteReducido>();
			}
			return list;
		}
	}
}