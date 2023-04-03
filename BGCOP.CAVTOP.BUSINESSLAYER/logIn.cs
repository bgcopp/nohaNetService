using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class logIn
	{
		public logIn()
		{
		}

		public usrDB CompruebaLogin(string usuario, string contra)
		{
			usrDB _usrDB = new usrDB()
			{
				idUsr = -1
			};
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			byte[] md5Hash = this.GetMd5Hash(contra);
			var variable = (
				from usu in masterDBACEntity.TUsuario
				join ts in masterDBACEntity.TTipoUsuario on usu.idTipoUsuario equals (int?)ts.idTipoUsuario
				where (usu.login == usuario) && usu.password.Equals(md5Hash)
				select new { idusr = usu.idUsuario, permi = ts.permisos }).FirstOrDefault();
			if (variable != null)
			{
				_usrDB.idUsr = variable.idusr;
				_usrDB.permiUsr = variable.permi;
			}
			return _usrDB;
		}

		private byte[] GetMd5Hash(string input)
		{
			MD5 mD5 = MD5.Create();
			return mD5.ComputeHash(Encoding.Default.GetBytes(input));
		}
	}
}