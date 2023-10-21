using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week04
{
    internal class RekursiveAlgorithm
    {
        public static void Start()
        {
            Console.WriteLine("Summerekursiv");
            int sum = SummeRekursiv(5);
            Console.WriteLine("Die Rekursive Summe ist: " + sum);
            Console.WriteLine("=====================================");

            Console.WriteLine("Faktorialrekursiv");
            long x = FaktorialRekursiv(20);
            Console.WriteLine("Faktorialrekursiv ist: " + x);
            Console.WriteLine("=====================================");

            Console.WriteLine("Fibonaccirechnung ist:");
            Console.WriteLine( FibonacciRechnung(10));
           
            Console.WriteLine("========================================");
        }


        public static int SummeRekursiv(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x + SummeRekursiv(x - 1);

        }




        public static long FaktorialRekursiv(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * FaktorialRekursiv(x - 1);

        }




        public static int FibonacciRechnung(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            return FibonacciRechnung(x - 1) + FibonacciRechnung(x -2) ;

        }  

    }
}
