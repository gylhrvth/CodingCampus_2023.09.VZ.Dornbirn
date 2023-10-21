
using System.Security.Cryptography.X509Certificates;

namespace Cemal.Week04
{
    internal class RecursiveExamples
    {
        public static void Start()
        {
            Console.WriteLine(RecursiveSumme(5));
            Console.WriteLine(RecursiveFaktorial(5));
            Console.WriteLine(RecursiveFibonacci(5));


        }

        public static int RecursiveSumme(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x + RecursiveSumme(x - 1);
        }

        public static Int64 RecursiveFaktorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * RecursiveFaktorial(x - 1);
        }

        public static int RecursiveFibonacci(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            return RecursiveFibonacci(x - 1) + RecursiveFibonacci(x - 2);
        }
    }
}
