using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class FaktorialAufgabe
    {
        public static void Start()
        {
            int c = Add();
            Console.WriteLine( );
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0,2}! = {1,20}", i, Factorialcalculus(i));
            }
        }

        public static int Add()
        {
            int result = 0;
            for (int i = 20; i <= 50; i++)
            {
                result += i;
            }
            return result;
        }

        public static long Factorialcalculus(int n)
        {
            long solution = 1;
            for (int i = 1; i <= n; i++)
            {
                solution *= i;
            }
            return solution;
        }
    }
}



