using System.Diagnostics;

namespace Fabian.Week04
{
    public class Recursive
    {
        public static void Start()
        {
            Console.WriteLine("Sum:");
            PrintSumFirst(10);
            Console.WriteLine("\nFactorial:");
            PrintFactorial(10);
            Console.WriteLine("\nFibonacci:");
            PrintFibonacci(10);
        }

        public static int SumFirst(int num)
        {
            if(num == 0) return 0;           
            return num + SumFirst(num - 1);
        }
        public static void PrintSumFirst(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0, 2} = {1}", i, SumFirst(i));
            }
        }

        public static int Factorial(int num)
        {
            if (num == 1) return 1;
            return num * Factorial(num - 1);
        }      
        public static void PrintFactorial(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0, 2}! = {1, 10}", i, Factorial(i));
            }
        }

        public static int Fibonacci(int num)
        {
            if (num <= 2) return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        public static void PrintFibonacci(int num)
        {
            for (int i = 1; i <= num;i++)
            {
                Console.WriteLine("{0, 2} = {1}", i, Fibonacci(i));
            }
        }
    }
}
