using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Krankenhaus
{
    internal class KrankenhausExample
    {
        public static void Start()
        {
            Krankenhaus krankenhaus = new Krankenhaus("...", 0000);

            krankenhaus.Name = "Krankenhaus Schwarzwald";
            krankenhaus.Year = 1992;

            Ambulanz ambulanz = new Ambulanz(DateTime.Now);

            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString("t"));

            ambulanz.Time = DateTime.Now;

            if (d.ToString("t") != Convert.ToString(7) || d.ToString("t") != Convert.ToString(8) || d.ToString("t") != Convert.ToString(9) || d.ToString("t") != Convert.ToString(10) || d.ToString("t") != Convert.ToString(10) || d.ToString("t") != Convert.ToString(11) || d.ToString("t") != Convert.ToString(12) || d.ToString("t") != Convert.ToString(13) || d.ToString("t") != Convert.ToString(14) || d.ToString("t") != Convert.ToString(15) || d.ToString("t") != Convert.ToString(16) || d.ToString("t") != Convert.ToString(17) || d.ToString("t") != Convert.ToString(18) || d.ToString("t") != Convert.ToString(19) || d.ToString("t") != Convert.ToString(20) || d.ToString("t") != Convert.ToString(21))
            {

            }




        }
    }
}
