using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Inners
	{
		public Inners()
		{
		}

		public List<Tinner> listarTodos()
		{
			IOrderedQueryable<Tinner> tinner = 
				from a in (new masterDBACEntities()).Tinner
				orderby a.CodeInner
				select a;
			return tinner.ToList<Tinner>();
		}
	}
}