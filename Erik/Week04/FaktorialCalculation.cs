using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week04
{
    public class FaktorialCalculation
    {

        public static void Start()
        {
            Console.WriteLine(SumOfNumbers);
            Console.WriteLine(FaktorialSum);
            Console.WriteLine(Fibonacci);


        }

        public static int SumOfNumbers(int n)
        {
            int num = 0;
            int sum = num + (num + 1);
            return sum;
        }


        public static int recursionSum(int context)
        {
            {
                if (context == 0) return 0;
                return context + SumOfNumbers(context - 1);
            }  
        }

        public static int FaktorialSum(int context)
        {
            {
                if (context == 1) return 1;
                return context * SumOfNumbers(context - 1);
            }
        }

        public static int Fibonacci(int x)
        {
            if (x == 1 || x == 2) return 1;
            x = Fibonacci(x - 1) + Fibonacci(x - 2); return x;
        }
    }
}
