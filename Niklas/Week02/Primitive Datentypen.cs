using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSumme(20);
            Console.WriteLine();

            Console.WriteLine("\nFaktorial: ");
            PrintFaktorial(1);
            Console.WriteLine();

        }

        static void PrintSumme(int times)
        {
            int rows = 20;
            int times2 = 21;
            while (rows <= 50)
            {
                Console.WriteLine("Summe = " + (times + times2));
                times += times2;
                times2++;
                if (times % 2 != 0)
                {
                    Console.Write("");
                }
                else { }
                rows++;
            }
        }
        static void PrintFaktorial(int times)
        {
            int rows = 1;
            int times2 = 2;
            while (rows <= 20)
            {
                Console.WriteLine($"{times} * {times2} = ");
                times += times2;
                times2++;
                if (times2 % 2 != 0) 
                {
                    times2++;
                }
                if (times % 2 != 1)
                {
                    times++;
                }
                rows++;
            }
        }
    
    
    public static int Factor(int times, int times2)
        {
            int reulst = times * times2;

            return reulst;
        }
    }
}




