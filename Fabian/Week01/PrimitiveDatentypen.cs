using System;

namespace Fabian.Week01
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSum(20, 50);
            Console.WriteLine();
            PrintFactorial(1, 20);
            Console.WriteLine();
            PrintDecimalNums(0, 100000);
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
                Console.WriteLine($"{i,-10} {i}");
            }

        }

        public static void PrintDecimalNums(double minNum, double maxNum)
        {
            for(double i = minNum;i <= maxNum; i += 0.1)
            {
                
                Console.WriteLine(Math.Round(i, 2));
            }
        }

    }
}
