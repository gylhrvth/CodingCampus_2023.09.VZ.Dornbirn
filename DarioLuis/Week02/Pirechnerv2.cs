using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week02
{
    class Pirechnerv2
    {
        public static void Sart()
        {
            Console.WriteLine(CalculatePi());
        }
        public static double CalculatePi()
        {
            double pi = 3;

            for (double i = 2; i < 100000; i += 2)
            {
                
                pi += 4 / (i * (i + 1) * (i + 2));
                Console.WriteLine($"pi= {pi}");
                pi *= -1;
                
            }
            return pi;
        }
    }
}
