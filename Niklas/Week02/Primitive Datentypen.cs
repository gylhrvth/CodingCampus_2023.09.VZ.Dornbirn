using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            Console.WriteLine("\nSumme: ");
            PrintSumme(20);
            Console.WriteLine();



        }
        static void PrintSumme(int times)
        {
            times = 20;
            while (times < 50)
            {
                Console.WriteLine((times, "+" +times));
                times++;
            }

        }


    }
}
