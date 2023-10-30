using System;
using System.Globalization;

namespace Gyula.Week05
{
	public class DateExamples
	{
		public static void Start()
		{
			DateTimeSandbox();
		}

		public static void DateTimeSandbox()
		{
			DateTime t = DateTime.Now;
			CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d"));
            Console.WriteLine(t.ToString("d", austrian));
            Console.WriteLine(t.ToString("t"));
            Console.WriteLine(t.ToString("t", austrian));
            Console.WriteLine(t.ToString("F"));
            Console.WriteLine(t.ToString("F", austrian));

			Console.WriteLine(t.ToString("yyyy.MM.dd"));

        }
    }
}

