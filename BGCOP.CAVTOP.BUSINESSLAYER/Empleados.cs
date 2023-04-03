using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Empleados : IDisposable
	{
		public Empleados()
		{
		}

		public void cambiarHorario(string identi, int idhora)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TEmpleado tEmpleado = (
					from a in masterDBACEntity.TEmpleado
					where a.identificacion == identi
					select a).FirstOrDefault<TEmpleado>();
				if (tEmpleado != null)
				{
					TTarjeta nullable = (
						from b in masterDBACEntity.TTarjeta
						where (int?)b.idTarjeta == tEmpleado.idTarjeta
						select b).FirstOrDefault<TTarjeta>();
					if (nullable != null)
					{
						nullable.idHorario = new int?(idhora);
						masterDBACEntity.SaveChanges();
					}
				}
			}
		}

		public TEmpleado consultarXtarjeta(string tarId)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TTarjeta tTarjetum = (
				from a in masterDBACEntity.TTarjeta
				where a.numtarjeta == tarId
				select a).FirstOrDefault<TTarjeta>();
			TEmpleado tEmpleado = (
				from b in masterDBACEntity.TEmpleado
				where b.idTarjeta == (int?)tTarjetum.idTarjeta
				select b).FirstOrDefault<TEmpleado>();
			return tEmpleado;
		}

		public bool CrearEmpleado(string nombre, string telefonoExt, string RazonSocial, string nombreDivi, string tipoIdenti, string cargoE, string identificacion, string fechaC, string codigoB, int usuarioUg)
		{
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				TEmpleado tEmpleado = new TEmpleado();
				TiposIdentificacion tiposIdentificacion = new TiposIdentificacion();
				try
				{
					TTipoIdentificacion tTipoIdentificacion = tiposIdentificacion.consulta(tipoIdenti);
					tEmpleado.idTipoIdentificacion = new int?(tTipoIdentificacion.idTipoIdentificacion);
				}
				catch (Exception exception)
				{
				}
				Cargos cargo = new Cargos();
				DivisionesEmpresa divisionesEmpresa = new DivisionesEmpresa();
				try
				{
					tEmpleado.idDivisionEmpresa = divisionesEmpresa.consulta(nombreDivi).IdDivisionEmpresa;
				}
				catch (Exception exception1)
				{
				}
				try
				{
					TCargo tCargo = cargo.Buscar(cargoE);
					tEmpleado.idCargo = new int?(tCargo.idCargo);
				}
				catch (Exception exception2)
				{
				}
				Empresas empresa = new Empresas();
				try
				{
					tEmpleado.idEmpresa = empresa.Consultar(RazonSocial).idEmpresa;
				}
				catch (Exception exception3)
				{
				}
				tEmpleado.fechaUltimaGestion = new DateTime?(Convert.ToDateTime(fechaC));
				tEmpleado.usuarioUltimaGestion = new int?(usuarioUg);
				tEmpleado.idTipoEstado = 1;
				tEmpleado.identificacion = identificacion;
				tEmpleado.nombre = nombre;
				masterDBACEntity.AddToTEmpleado(tEmpleado);
				masterDBACEntity.SaveChanges();
			}
			catch (Exception exception4)
			{
				throw;
			}
			return true;
		}

		public void Dispose()
		{
		}

		public List<viEmpleado> listarEmpleados()
		{
			IQueryable<viEmpleado> masterDBACEntity = 
				from ls in (new masterDBACEntities()).viEmpleado
				select ls;
			return masterDBACEntity.ToList<viEmpleado>();
		}

		public List<TEmpleado> ListarTodos()
		{
			List<TEmpleado> list;
			try
			{
				IOrderedQueryable<TEmpleado> tEmpleado = 
					from tp in (new masterDBACEntities()).TEmpleado
					orderby tp.nombre
					select tp;
				list = tEmpleado.ToList<TEmpleado>();
			}
			catch (Exception exception)
			{
				throw;
			}
			return list;
		}

		public List<TEmpleado> ListarTodos(int idempresa)
		{
			List<TEmpleado> list;
			try
			{
				IOrderedQueryable<TEmpleado> tEmpleado = 
					from tp in (new masterDBACEntities()).TEmpleado
					where tp.idEmpresa == idempresa
					orderby tp.nombre
					select tp;
				list = tEmpleado.ToList<TEmpleado>();
			}
			catch (Exception exception)
			{
				throw;
			}
			return list;
		}
	}
}