using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week04
{
    internal class Rekursiv
    {
        public static void Start()
        {
            Console.WriteLine(SumRekusriv(5));

            Console.WriteLine(FaktRekursiv(20));

            Console.WriteLine(Fibonacci(5));
        }
        static long SumRekusriv(long x)
        {

            if (x == 0)
            {
                return 0;
            }
            else
            {
                return x + SumRekusriv(x - 1);
            }
        }
        static long FaktRekursiv(long x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * FaktRekursiv(x - 1);
            }

        }
        static long Fibonacci(long x)
        {
            if (x <= 2)
            {
                return 1;
            }

            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

    }
}
