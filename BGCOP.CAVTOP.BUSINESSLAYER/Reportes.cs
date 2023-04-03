using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Reportes
	{
		public Reportes()
		{
		}

		public List<reporteEmpleadoDTO> consultarReporteEmpleados(DateTime fecha1, DateTime fecha2, int idEmpresa, int idempleado)
		{
			List<reporteEmpleadoDTO> reporteEmpleadoDTOs;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				if (idEmpresa == -999)
				{
					if (idempleado != -999)
					{
						List<reporteEmpleadoDTO> list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
							join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idEmpleado == idempleado
							orderby a.fechaMarcacion
							select new reporteEmpleadoDTO()
							{
								Empresa = c.RazonSocial,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion,
								Identificacion = b.identificacion,
								Nombre = b.nombre
							}).ToList<reporteEmpleadoDTO>();
						reporteEmpleadoDTOs = list;
					}
					else
					{
						List<reporteEmpleadoDTO> list1 = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
							join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2)
							orderby a.fechaMarcacion
							select new reporteEmpleadoDTO()
							{
								Empresa = c.RazonSocial,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion,
								Identificacion = b.identificacion,
								Nombre = b.nombre
							}).ToList<reporteEmpleadoDTO>();
						reporteEmpleadoDTOs = list1;
					}
				}
				else if (idempleado != -999)
				{
					List<reporteEmpleadoDTO> reporteEmpleadoDTOs1 = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
						join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idEmpleado == idempleado
						orderby a.fechaMarcacion
						select new reporteEmpleadoDTO()
						{
							Empresa = c.RazonSocial,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion,
							Identificacion = b.identificacion,
							Nombre = b.nombre
						}).ToList<reporteEmpleadoDTO>();
					reporteEmpleadoDTOs = reporteEmpleadoDTOs1;
				}
				else
				{
					List<reporteEmpleadoDTO> list2 = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
						join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && c.idEmpresa == idEmpresa
						orderby a.fechaMarcacion
						select new reporteEmpleadoDTO()
						{
							Empresa = c.RazonSocial,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion,
							Identificacion = b.identificacion,
							Nombre = b.nombre
						}).ToList<reporteEmpleadoDTO>();
					reporteEmpleadoDTOs = list2;
				}
			}
			return reporteEmpleadoDTOs;
		}

		public List<reporteVehiculosDTO> consultarReporteVehiculos(DateTime fecha1, DateTime fecha2, int idVehiculo)
		{
			List<reporteVehiculosDTO> reporteVehiculosDTOs;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				if (idVehiculo != -999)
				{
					List<reporteVehiculosDTO> list = (
						from a in masterDBACEntity.TRegistroVehiculo
						join b in masterDBACEntity.TVehiculo on a.idVehiculo equals (int?)b.idVehiculo
						join c in masterDBACEntity.TEmpleado on a.idempleado equals (int?)c.idEmpleado
						where b.idVehiculo == idVehiculo && (a.fechadeRegistro >= (DateTime?)fecha1) && (a.fechadeRegistro <= (DateTime?)fecha2)
						orderby a.fechadeRegistro
						select new reporteVehiculosDTO()
						{
							Conductor = c.nombre,
							Evento = a.mregistro,
							Fecha_Marcacion = (DateTime)a.fechadeRegistro,
							Placa = b.Placa
						}).ToList<reporteVehiculosDTO>();
					reporteVehiculosDTOs = list;
				}
				else
				{
					List<reporteVehiculosDTO> list1 = (
						from a in masterDBACEntity.TRegistroVehiculo
						join b in masterDBACEntity.TVehiculo on a.idVehiculo equals (int?)b.idVehiculo
						join c in masterDBACEntity.TEmpleado on a.idempleado equals (int?)c.idEmpleado
						where (a.fechadeRegistro >= (DateTime?)fecha1) && (a.fechadeRegistro <= (DateTime?)fecha2)
						orderby a.fechadeRegistro
						select new reporteVehiculosDTO()
						{
							Conductor = c.nombre,
							Evento = a.mregistro,
							Fecha_Marcacion = (DateTime)a.fechadeRegistro,
							Placa = b.Placa
						}).ToList<reporteVehiculosDTO>();
					reporteVehiculosDTOs = list1;
				}
			}
			return reporteVehiculosDTOs;
		}

		public List<reporteVisitanteDTO> consultarReporteVisitantes(DateTime fecha1, DateTime fecha2, int idEmpresaDestino, int idVisitante)
		{
			List<reporteVisitanteDTO> reporteVisitanteDTOs;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				if (idEmpresaDestino == -999)
				{
					if (idVisitante != -999)
					{
						List<reporteVisitanteDTO> list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
							join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
							join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
							join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
							join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idVisitante == (decimal)idVisitante
							orderby a.fechaMarcacion
							select new reporteVisitanteDTO()
							{
								idvisitante = (decimal)a.idVisitante,
								Identificacion = b.identificacionVisitante,
								Nombre_Visitante = b.nombreVisitante,
								Empresa_Destino = e.RazonSocial,
								Empleado_Destino = f.nombre,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion
							}).ToList<reporteVisitanteDTO>();
						reporteVisitanteDTOs = list;
					}
					else
					{
						List<reporteVisitanteDTO> list1 = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
							join c in masterDBACEntity.TVisitanteVisitaProgramada on a.idVisitanteVistaP equals (decimal?)c.idTabla
							join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
							join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
							join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2)
							orderby a.fechaMarcacion descending
							select new reporteVisitanteDTO()
							{
								idvisitante = (decimal)a.idVisitante,
								Identificacion = b.identificacionVisitante,
								Nombre_Visitante = b.nombreVisitante,
								Empresa_Destino = e.RazonSocial,
								Empleado_Destino = f.nombre,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion
							}).ToList<reporteVisitanteDTO>();
						reporteVisitanteDTOs = list1;
					}
				}
				else if (idVisitante != -999)
				{
					List<reporteVisitanteDTO> reporteVisitanteDTOs1 = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
						join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
						join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
						join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
						join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idVisitante == (decimal)idVisitante
						orderby a.fechaMarcacion
						select new reporteVisitanteDTO()
						{
							idvisitante = (decimal)a.idVisitante,
							Identificacion = b.identificacionVisitante,
							Nombre_Visitante = b.nombreVisitante,
							Empresa_Destino = e.RazonSocial,
							Empleado_Destino = f.nombre,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion
						}).ToList<reporteVisitanteDTO>();
					reporteVisitanteDTOs = reporteVisitanteDTOs1;
				}
				else
				{
					List<reporteVisitanteDTO> list2 = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
						join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
						join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
						join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
						join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && e.idEmpresa == idEmpresaDestino
						orderby a.fechaMarcacion
						select new reporteVisitanteDTO()
						{
							idvisitante = (decimal)a.idVisitante,
							Identificacion = b.identificacionVisitante,
							Nombre_Visitante = b.nombreVisitante,
							Empresa_Destino = e.RazonSocial,
							Empleado_Destino = f.nombre,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion
						}).ToList<reporteVisitanteDTO>();
					reporteVisitanteDTOs = list2;
				}
			}
			return reporteVisitanteDTOs;
		}
	}
}