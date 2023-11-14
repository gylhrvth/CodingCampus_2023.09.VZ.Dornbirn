using System;
using System.Globalization;
namespace Mohammed.Selftest
{
	public class Calendar
	{
		public static void Start()
		{
			Date();
			Console.WriteLine();

			string[] cultureInfo = {"de-DE", "kw-KW"};
			DayOfWeek(cultureInfo);
		}

		public static void Date()
		{
			DateTime t = DateTime.Now;
			Console.WriteLine(t.ToString("ddd") + " " + t.ToString("d"));

		}

		public static void DayOfWeek(string[] cultureInfo)
		{
			CultureInfo[] cultures = new CultureInfo[cultureInfo.Length];
			DateTime t = DateTime.Now;

			for(int i =0; i < cultureInfo.Length; i++)
			{
				cultures[i] = new CultureInfo(cultureInfo[i]);
				Console.WriteLine(t.ToString("dddd", cultures[i]));
			}
		}
	}
}

