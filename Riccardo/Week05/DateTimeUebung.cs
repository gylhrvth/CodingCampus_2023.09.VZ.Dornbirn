using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ressources;

namespace Riccardo.Week05
{
    internal class DateTimeUebung
    {
        public static void Start()
        {
            TimeWhenAndWhere();   
        }

        public static void TimeWhenAndWhere()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");


            Console.WriteLine(t.ToString("yyyy.MM.dd"));

            Console.WriteLine(t.ToString("t"));

            Console.WriteLine(t.ToString("yyyy.MM.dd t"));
        }

    }
}
