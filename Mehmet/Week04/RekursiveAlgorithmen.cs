using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week04
{
    internal class RekursiveAlgorithmen
    {
        public static void Start()
        {
            /*
            for (int i = 1; i <= 20; ++i)
            {
                Console.WriteLine("RekursiveSumme({0,2}) = {1,3}", i , RekursiveSumme(i));
            }
            */
            RekursiveSumme(5, "");

            Console.WriteLine();

            RekursiveFaktorial(19);

            Console.WriteLine();

            Fibonacci(10);
        }


        public static int RekursiveSumme(int x, string prefix)
        {
            Console.WriteLine("{0}RekursiveSumme({1})", prefix, x);           
            if (x == 0)
            {
                return 0;
            }
            int result = x + RekursiveSumme(x-1, prefix + "|   ");
            Console.WriteLine("{0}{1}", prefix, result);
            return result;
        }


        public static long RekursiveFaktorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            long result = x * RekursiveFaktorial(x - 1);
            Console.WriteLine(result);
            return result;
        }

        
        public static int Fibonacci(int x)
        {
            if (x == 1 || x == 2) 
            {
                return 1;
            }
            int fibonacci = Fibonacci(x-1) + Fibonacci(x-2);
            Console.Write("," + fibonacci);
            return fibonacci;
        }



    }
}
