using System;

namespace Fabian.Week01
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSum(20, 50);
            PrintFactorial(1, 20);
        }

        public static void PrintSum(int minNum, int maxNum)
        {
            for(int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($" {i} + {i} = {i + i}");
            }
        }

        public static void PrintFactorial(int minNum, int maxNum)
        {
            for (long i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($"");
            }

        }
    }
}
