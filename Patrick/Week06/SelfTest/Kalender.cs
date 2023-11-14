using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Kalender
    {
        public static void Start()
        {
            //Aufgabe1
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("ddd ") + date.ToString("d"));
            Console.WriteLine("=========================================");

            //Aufgabe2
            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };          
            PrintLanguages(cultureInfo);
        }

        public static void PrintLanguages(string[] cultureInfo)
        {
            foreach (var culture in cultureInfo)
            {
                DateTime day = DateTime.Now;
                CultureInfo cultureInfoObj = new CultureInfo(culture);
                Console.WriteLine(day.ToString("dddd", cultureInfoObj));
            }
        }
        
    }
}
