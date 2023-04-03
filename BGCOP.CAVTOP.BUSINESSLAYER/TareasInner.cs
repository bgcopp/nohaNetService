using System;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class TareasInner
	{
		public TareasInner()
		{
		}

		public void AgregarTarea(int CodeInner, string codigoTarea, string codigoBarras)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TInnerAccion tInnerAccion = new TInnerAccion()
				{
					CodeInner = new int?(CodeInner),
					CodigoAccion = codigoTarea,
					Cumplido = new int?(0),
					fecha = new DateTime?(DateTime.Now)
				};
				masterDBACEntity.AddToTInnerAccion(tInnerAccion);
				masterDBACEntity.SaveChanges();
			}
		}

		public void CumplirTarea(TInnerAccion tmp)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TInnerAccion nullable = (
					from a in masterDBACEntity.TInnerAccion
					where a.id == tmp.id
					select a).FirstOrDefault<TInnerAccion>();
				nullable.Cumplido = new int?(1);
				masterDBACEntity.SaveChanges();
			}
		}

		public TInnerAccion ObtenerUltimaTarea(int CodeInner)
		{
			TInnerAccion tInnerAccion;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TInnerAccion tInnerAccion1 = (
					from a in masterDBACEntity.TInnerAccion
					where a.CodeInner == (int?)CodeInner && a.Cumplido == (int?)0
					orderby a.fecha descending
					select a).FirstOrDefault<TInnerAccion>();
				tInnerAccion = tInnerAccion1;
			}
			return tInnerAccion;
		}
	}
}