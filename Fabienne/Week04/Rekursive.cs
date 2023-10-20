using System;
using System.Xml;

namespace Fabienne.Week04
{
    internal class Rekursive
    {
        public static void Start() 
        {
            Console.WriteLine(RekursiveSumme(7));
            Console.WriteLine();
            Console.WriteLine(RekursiveFaktorial(7));
            Console.WriteLine();
            Console.WriteLine(Fibonacci(7));
        }
        public static int RekursiveSumme(int x)
        {          
            if (x == 0) { return 0; } 
            
            return x + RekursiveSumme(x - 1);
        }
        public static int RekursiveFaktorial(int x)
        {
            if (x == 1) { return 1; }
            
            return x * RekursiveFaktorial(x - 1);
        }
        public static int Fibonacci(int x)
        {
            if (x == 1 || x == 2) { return 1; };

            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }
}
