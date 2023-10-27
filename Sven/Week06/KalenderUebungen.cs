using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06
{
    internal class KalenderUebungen
    {
        static public void Start()
        {

            WhereAndWhen();
            DateOfBirth();


        }

        public static void WhereAndWhen()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d", austrian));
            Console.WriteLine(t.ToString("T", austrian));
            Console.WriteLine(t.ToString("g", austrian));

            Console.WriteLine(t.ToString("yyyy.MM.dd"));
        }

        public static void DateOfBirth()
        {
            string brth = "";

            Console.WriteLine("Please tell me your date of birth: ");
            brth = Console.ReadLine();

            DateTime.Parse(brth);



        }
    }
}
