using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class Kalender
    {
        public static void Start()
        {
            //Aufgabe 1)
            Console.WriteLine("Aufgabe 1: \n");
            Calendar();
            Console.WriteLine("==========================");

            //Aufgabe 2)
            Console.WriteLine("Aufgabe 2: \n");
            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };
            Datum(cultureInfo);
            Console.WriteLine("==========================");
        }

        //Aufgabe 1:
        public static void Calendar()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t.ToString("ddd") + " " + t.ToString("d"));
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2:
        public static void Datum(string[] cultureInfo)
        {
            DateTime d = DateTime.Now;

            for (int i = 0; i < cultureInfo.Length; i++)
            {
                CultureInfo info = new CultureInfo(cultureInfo[i]);
                Console.WriteLine(d.ToString("dddd", info));
            }
        }
    }
}
