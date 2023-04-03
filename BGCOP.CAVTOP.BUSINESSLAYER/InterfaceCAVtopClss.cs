using System;
using System.Collections.Generic;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	internal interface InterfaceCAVtopClss
	{
		void Agregar();

		void Consultar();

		void Eliminar();

		List<object> ListarTodos();

		void Modificar();
	}
}