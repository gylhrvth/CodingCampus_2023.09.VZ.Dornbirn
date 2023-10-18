using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week04
{
    internal class RekusivExample
    {
        public static void StartRekusivExample() 
        {
            Console.WriteLine(SumRekusiv(5));
            Console.WriteLine(RekursiveFaktorial(5));
            Console.WriteLine(Fibonacci(5));
        }

        public static int Add(int value)
        {
            int result = 0;

            for (int i = 0; i < value; i++)
            {
                result += i;
            }

            return result;
        }

        public static int SumRekusiv(int x)
        {

            if(x == 0) {  return 0; }

            return x + SumRekusiv(x - 1);

        }

        public static int RekursiveFaktorial(int x)
        {
            if(x == 1) { return 1;}

            return x * RekursiveFaktorial(x - 1);
        }

        public static int Fibonacci(int x) 
        {
            if(x == 1 || x == 2) { return 1;}

            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }
}
