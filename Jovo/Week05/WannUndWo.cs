using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week05
{
    internal class WannUndWo
    {
        public static void Start()
        {
            Console.WriteLine("Date:");
            Date();
            Console.WriteLine("=============");

            Console.WriteLine("Time:");
            Time();
            Console.WriteLine("============");

            Console.WriteLine("DateAndTime:");
            DateAndTime();
            Console.WriteLine("=============");

        }


        public static void Date()
        {
            DateTime t = DateTime.Now;
            
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("yyyy.MM.dd"));
        }


        public static void Time()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");
            Console.WriteLine(t.ToString("t"));

        }


        public static void DateAndTime()
        {

            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");
            Console.WriteLine(t.ToString("F"));

        }
    }
}
