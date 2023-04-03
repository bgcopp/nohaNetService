using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Empresas
	{
		public Empresas()
		{
		}

		public TEmpresa Consultar(string nombre)
		{
			TEmpresa tEmpresa = (
				from d in (new masterDBACEntities()).TEmpresa
				where d.RazonSocial == nombre
				select d).FirstOrDefault<TEmpresa>();
			return tEmpresa;
		}

		public bool CrearEmpresa(TEmpresa nueva, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TEmpresa nullable = nueva;
			nullable.usuarioUltimaGestion = new int?(usuarioUg);
			masterDBACEntity.AddToTEmpresa(nullable);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public bool EliminarEmpresa(int idEmp)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TEmpresa tEmpresa = masterDBACEntity.TEmpresa.FirstOrDefault<TEmpresa>((TEmpresa c) => c.idEmpresa == idEmp);
			masterDBACEntity.TEmpresa.DeleteObject(tEmpresa);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TEmpresa> ListarTodas()
		{
			List<TEmpresa> list;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				IOrderedQueryable<TEmpresa> tEmpresa = 
					from d in masterDBACEntity.TEmpresa
					orderby d.RazonSocial
					select d;
				list = tEmpresa.ToList<TEmpresa>();
			}
			return list;
		}

		public bool ModificarEmpresa(int idEmp, TEmpresa nueva, int usuarioUg)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TEmpresa razonSocial = masterDBACEntity.TEmpresa.FirstOrDefault<TEmpresa>((TEmpresa c) => c.idEmpresa == idEmp);
			if (razonSocial != null)
			{
				razonSocial.nit = nueva.nit;
				razonSocial.RazonSocial = nueva.RazonSocial;
				razonSocial.telefonos = nueva.telefonos;
				razonSocial.telContactoInterno = nueva.telContactoInterno;
				razonSocial.EmpleadoContacto = nueva.EmpleadoContacto;
				razonSocial.ObservacioneEmpresa = nueva.ObservacioneEmpresa;
				razonSocial.CargoContacto = nueva.CargoContacto;
				razonSocial.fechaUltimaGestion = new DateTime?(DateTime.Now);
				razonSocial.usuarioUltimaGestion = new int?(usuarioUg);
				masterDBACEntity.SaveChanges();
			}
			return true;
		}
	}
}