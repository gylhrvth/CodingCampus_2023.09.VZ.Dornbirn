using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dimitri.Week05
{
    internal class Date
    {
        public static void Main()
        {
            FormatTime();
        }

        public static void FormatTime()
        {
            DateTime t = DateTime.Now;
            CultureInfo austria = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("t", austria));
        }
    }
}
