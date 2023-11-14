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
            Random random = new Random();
            int rand = random.Next(100);
            DateTime d = DateTime.Now;
            string time = d.ToString("t");
            TimeSpan open = new TimeSpan(8, 0, 0);
            TimeSpan closed = new TimeSpan(21, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;




            Krankenhaus krankenhaus = new Krankenhaus("...", 0000);

            krankenhaus.Name = "Krankenhaus Schwarzwald";
            krankenhaus.Year = 1992;
            krankenhaus.Area = "Open";

            Ambulanz ambulanz = new Ambulanz(time, 0);
            ambulanz.Time = time;
            ambulanz.Waiting = 0;


            Patient patient = new Patient("Klaus", 24, "Ambulanz");

            //check if open
            if ((now > open) && (now < closed))
            {
                krankenhaus.Area = "Open";
            }
            else if ((now < open) && (now > closed))
            {
                krankenhaus.Area = "Closed";
            }
            if (krankenhaus.Area == "Open" && patient.Health == "Ambulance")
            {
                ambulanz.Waiting += 1;
            }

            //random generator for health status
            if (rand < 30)
            {
                patient.Health = "Station";
            }
            else if (rand > 30 && krankenhaus.Area == "Open" && patient.Health != "Station")
            {
                patient.Health = "Ambulanz";
            }
            else if (rand > 30 && krankenhaus.Area == "Closed")
            {
                patient.Health = "Home";
            }









        }
    }
}
