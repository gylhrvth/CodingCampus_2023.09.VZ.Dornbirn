using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week05
{
    public class Kalender
    {
        public static void Start()
        {
            Time();
            Day();
            Both();
        }

        public static void Time()
        {
             Console.WriteLine(TimeOnly.FromDateTime(DateTime.Now));
        }
        public static void Day()
        {
            Console.WriteLine(DateOnly.FromDateTime(DateTime.Now));
        }
        public static void Both()
        {
            Console.WriteLine(DateTime.Now);
        }

    }
}
