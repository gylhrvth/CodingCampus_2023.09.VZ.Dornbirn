using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week04
{
    public class RekursivExpms
    {
        public static void Start()
        {

            // Teste die rekursive Summe
            int summeResult = Summe(10);
            Console.WriteLine("Summe(5) = " + summeResult);

            // Teste die rekursive Faktorial
            int faktorialResult = Fakt(5);
            Console.WriteLine("Fakt(5) = " + faktorialResult);

            // Teste die Fibonacci-Funktion
            int fibonacciResult = Fibonacci(6);
            Console.WriteLine("Fibonacci(6) = " + fibonacciResult);

        }

        public static int Summe(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                return x + Summe(x - 1);
            }
        }


        public static int Fakt(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Fakt(x - 1);
            }
        }

        public static int Fibonacci(int x)
        {
            if (x == 1 || x == 2)
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
