using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class Calendar
    {
        public static void Start()
        {
            CurrentDate();
            Console.WriteLine();

            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };
            CurrentDayOfWeek(cultureInfo);
        }
        public static void CurrentDate()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t.ToString("dddd")+ " " + t.ToString("d"));
        }
        public static void CurrentDayOfWeek(string[] cultureInfo)
        {
            DateTime t = DateTime.Now;
            CultureInfo[] cultures = new CultureInfo[cultureInfo.Length];

            for (int i = 0; i < cultureInfo.Length; i++)
            {
                cultures[i] = new CultureInfo(cultureInfo[i]);
                Console.WriteLine(t.ToString("dddd", cultures[i]));

            }

        }
    }
}
