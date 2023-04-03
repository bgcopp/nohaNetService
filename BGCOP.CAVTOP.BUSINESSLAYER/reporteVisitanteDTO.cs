using System;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class reporteVisitanteDTO
	{
		public string Empleado_Destino
		{
			get;
			set;
		}

		public string Empresa_Destino
		{
			get;
			set;
		}

		public DateTime Fecha_Marcacion
		{
			get;
			set;
		}

		public string Identificacion
		{
			get;
			set;
		}

		public decimal idvisitante
		{
			get;
			set;
		}

		public string Nombre_Visitante
		{
			get;
			set;
		}

		public reporteVisitanteDTO()
		{
		}
	}
}