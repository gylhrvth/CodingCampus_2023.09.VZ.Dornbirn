using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week04
{
    internal class RecursionExample
    {

        public static void Start()
        {
            //Try
            Console.WriteLine(Summe(11));
            //AUFGABE 1
            Console.WriteLine(RekursiveSumme(10));
            //AUFGABE 2
            Console.WriteLine(RekursiveFakt(10));
            //AUFGABE 3
            Console.WriteLine(FibonacciWithPrefix(6, ""));
        }

        public static int Summe(int size)
        {
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                result += i;
            }
            return result;

        }

        public static int RekursiveSumme(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            int result = 0;
            result = x + RekursiveSumme(x - 1);
            return result;
        }

        public static long RekursiveFakt(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            long result = x * RekursiveFakt(x - 1);
            return result;
        }

        public static int Fibonacci(int x)
        {
            if ( x <= 2)
            {
                return 1;
            }
            int result = Fibonacci(x - 1) + Fibonacci(x - 2);
            return result;

        }



        public static int FibonacciWithPrefix(int x, string prefix)
        {
            Console.WriteLine("{0}FibonacciWithPrefix({1})", prefix, x);
            if (x <= 2)
            {
                return 1;
            }
            int result = FibonacciWithPrefix(x - 1, prefix + "|  ") + FibonacciWithPrefix(x - 2, prefix + "|  ");
            
            Console.WriteLine("{0}FibonacciWithPrefix({1}) = {2}", prefix, x, result);
            return result;

        }
    }
}
