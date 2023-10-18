using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week04
{
    internal class Faktorial
    {
        public static void Start()
        {
            Console.WriteLine(RecursiveSumme(10));
            Console.WriteLine(RekursiveFaktorial(19));
            Console.WriteLine(Fibonacci(10));
        }

        public static int RecursiveSumme(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x + RecursiveSumme(x - 1);
        }



        public static long RekursiveFaktorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
           
            return x * RekursiveFaktorial(x - 1);
            
        }



        public static int Fibonacci(int x)
        {
            if (x == 1 || x == 2) // n <=2 wäre auch möglich
            {
                return 1;
            }
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }
}



