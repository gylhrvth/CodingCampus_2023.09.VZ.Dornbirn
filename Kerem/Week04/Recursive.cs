using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week04
{
    internal class Recursive
    {
        public static void Start()
        {
            Kerem.Week02.DataTypes.PrintFactorial(20);

            for (int i = 1; i <= 20; ++i)
            {
                Console.WriteLine("fibonacci({0}) = {1}", i, RecurisveFibonacci(i));
            }
            
        }
        public static int RecursiveSumme(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            return n + RecursiveSumme(n - 1);
            
        }
        public static long RecursiveFactorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * RecursiveFactorial(x - 1);

        }
        public static int RecurisveFibonacci(int k)
        {
            if (k <= 2)
            {
                return 1;
                
            }
            return  RecurisveFibonacci(k - 1) + RecurisveFibonacci(k - 2);
        }


    }
}
