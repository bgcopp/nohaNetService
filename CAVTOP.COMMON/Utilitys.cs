using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.COMMON
{
	public class Utilitys
	{
		public int IdUsuarioActual
		{
			get;
			set;
		}

		public int PermisosUsuarioActual
		{
			get;
			set;
		}

		public Utilitys()
		{
		}

		public Image Bytes2Image(byte[] bytes)
		{
			if (bytes == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream(bytes);
			Bitmap bitmap = null;
			try
			{
				bitmap = new Bitmap(memoryStream);
			}
			catch (Exception exception)
			{
				throw;
			}
			return bitmap;
		}

		public byte[] Image2Bytes(Image img)
		{
			FileStream fileStream = new FileStream(Path.GetTempFileName(), FileMode.OpenOrCreate, FileAccess.ReadWrite);
			img.Save(fileStream, ImageFormat.Png);
			fileStream.Position = (long)0;
			int num = Convert.ToInt32(fileStream.Length);
			byte[] numArray = new byte[num];
			fileStream.Read(numArray, 0, num);
			fileStream.Close();
			return numArray;
		}
	}
}