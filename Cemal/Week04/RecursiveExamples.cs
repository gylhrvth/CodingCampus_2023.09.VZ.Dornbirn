
using System.Security.Cryptography.X509Certificates;

namespace Cemal.Week04
{
    internal class RecursiveExamples
    {
        public static void Start()
        {
            Console.WriteLine(RecursiveSumme(5));

        }

        public static int RecursiveSumme(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + RecursiveSumme(n - 1);
        }
    }
}
