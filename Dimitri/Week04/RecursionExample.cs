using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week04
{
    internal class RecursionExample
    {
        public static void Main()
        {
            Console.WriteLine(RecursiveSum(10));
            Console.WriteLine(RecursiveFac(10));
            Console.WriteLine(RecursiveFibunacci(7, ""));

        }

        public static int RecursiveSum(int x)
        {

            if (x == 0)
            {
                return 0;
            }
            return x + RecursiveSum(x - 1);
        }

        public static int RecursiveFac(int x)
        {

            if (x == 0)
            {
                return 1;
            }
            return x * RecursiveFac(x - 1);
        }

        public static int RecursiveFibunacci(int x, string prefix)
        {
            Console.WriteLine("{0}RecursiveFibunacci Stufe: " + x, prefix);
            if (x <= 2)
            {
                int result1 = 1;
                Console.WriteLine("{0}RecursiveFibunacci {2} is {1}", prefix, result1, x);
                return result1;
            }
            int result = RecursiveFibunacci(x - 1, prefix + "  " ) + RecursiveFibunacci(x - 2, prefix + "  ");
            Console.WriteLine("{0}RecursiveFibunacci {2} is {1}", prefix, result, x );
            return result;
        }
    }
}
