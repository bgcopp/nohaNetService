using System;
using System.Globalization;
using System.IO;

namespace BGCOP.CAVTOP.COMMON
{
	public class LogCls
	{
		private string _eventoLog;

		private string _fpath;

		public string Evento
		{
			get
			{
				return this._eventoLog;
			}
			set
			{
				this._eventoLog = value;
			}
		}

		public string FilePath
		{
			get
			{
				return this._fpath;
			}
			set
			{
				this._fpath = value;
			}
		}

		public LogCls()
		{
		}

		public void AddEvent()
		{
			int num = this._fpath.IndexOf(".", StringComparison.Ordinal);
			string str = this._fpath;
			string str1 = DateTime.Now.Day.ToString("0#");
			string str2 = DateTime.Now.Month.ToString("0#");
			int year = DateTime.Now.Year;
			string str3 = str.Insert(num, string.Concat(str1, str2, year.ToString(CultureInfo.InvariantCulture)));
			try
			{
				StreamWriter streamWriter = new StreamWriter(str3, true);
				string[] shortDateString = new string[] { "[", null, null, null, null, null };
				shortDateString[1] = DateTime.Now.ToShortDateString();
				shortDateString[2] = " ";
				shortDateString[3] = DateTime.Now.ToShortTimeString();
				shortDateString[4] = "] ";
				shortDateString[5] = this._eventoLog;
				streamWriter.WriteLine(string.Concat(shortDateString));
				streamWriter.Close();
			}
			catch (Exception exception)
			{
			}
		}
	}
}