using System;
using System.ComponentModel.Design;

namespace Sven.Week04
{
    internal class RekursiveUebungen
    {
        public static void RekursiveExamples()
        {
            Console.WriteLine("Rekursive Summe:");
            RekursiveSumme(4);
            Console.WriteLine();

            Console.WriteLine("Rekursive Faktorial:");
            RekursiveFaktorial(10);
            Console.WriteLine();

            Console.WriteLine("Rekursive Fibonacci:");
            RekursiveFibonacci(15);
            Console.WriteLine();

        }

        static int RekursiveSumme(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            int sum = number + RekursiveSumme(number - 1);
            Console.WriteLine(sum);
            return sum;

        }

        static int RekursiveFaktorial(int Fakt)
        {
            if (Fakt == 1)
            {
                return 1;
            }

            int sum = Fakt * RekursiveFaktorial(Fakt - 1);
            Console.WriteLine(sum);
            return sum;

        }
        static int RekursiveFibonacci(int fib)
        {
            if (fib == 1 || fib == 2)
            {
                return 1;
            }

            return fib = RekursiveFibonacci(fib - 1) + RekursiveFibonacci (fib - 2);
            //Console.WriteLine(sum);
            //return sum;

        }


    }
}
