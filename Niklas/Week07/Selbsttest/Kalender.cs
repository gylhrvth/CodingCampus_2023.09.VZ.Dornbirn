using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Kalender
    {
        public static void Start()
        {
            TimeDate();
            Console.WriteLine();
            Culture();
        }
        public static void TimeDate()
        {
            DateTime t = DateTime.Now;
            Console.Write(t.ToString("ddd "));
            Console.WriteLine(t.ToString("d"));
        }
        public static void Culture()
        {
            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };
            for (int i = 0; i < cultureInfo.Length; i++)
            {
                CultureInfo cultureInfo1 = new CultureInfo(cultureInfo[i]);
                DateTime dateTime = DateTime.Now;
                Console.WriteLine(dateTime.ToString("dddd", cultureInfo1));
            }
           
        }
    }
}
