using System;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class MessageDTO
	{
		public string Error
		{
			get;
			set;
		}

		public string ErrorInterno
		{
			get;
			set;
		}

		public string Mensaje
		{
			get;
			set;
		}

		public bool Resultado
		{
			get;
			set;
		}

		public MessageDTO()
		{
		}
	}
}