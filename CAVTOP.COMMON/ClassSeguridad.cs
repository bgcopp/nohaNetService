using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace BGCOP.CAVTOP.COMMON
{
	public class ClassSeguridad
	{
		public int Valor
		{
			get;
			set;
		}

		public ClassSeguridad()
		{
		}

		public byte[] GetMd5Hash(string input)
		{
			MD5 mD5 = MD5.Create();
			return mD5.ComputeHash(Encoding.Default.GetBytes(input));
		}
	}
}