using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week02
{
    internal class Datentypen
    {
        public static void StartDatentypen()
        {
            Console.WriteLine("Aufgabe Summe");
            int sum = Summe(20, 50);
            Console.WriteLine("Summe: " + sum);
            Console.WriteLine();

            Console.WriteLine("Aufgabe Faktorial");
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("{0, 2}! = {1, 20}", i, Faktorial(i));
            }
            
        }

        public static int Summe(int first, int second)
        {
            int result = 0;
            for (int i = first; i <= second; i++)
            {
                result += i;
            }
            return result;
        }

        public static long Faktorial(long second)
        {
            long result = 1;
            for (long i = 1; i <= second; i++)
            {
                result *= i;                
            }
            return result;
        }
    }
}
