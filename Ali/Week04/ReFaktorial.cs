using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week04
{
    internal class Class1
    {
        public static void Start()
        {
            Console.Write("Aufgabe 1 Rekursive Summe:  ");
            int sum = RekSum(5);
            Console.WriteLine(sum);
            Console.WriteLine();

            Console.WriteLine("Aufgabe 2 Rekursiver Faktor:  ");
            int fakt = RekFakt(5);
            Console.Write(fakt);
            Console.WriteLine();

            Console.WriteLine("Aufgabe 3 Fibonacci: ");
            int fibo = Fibonacci(5);
            Console.WriteLine(fibo);



        }
        public static int RekSum(int x)
        {
            if (x == 0)
                {
                    return 0;
                }
                
            return x + RekSum(x - 1);   
        }
        public static int RekFakt(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * RekFakt(a - 1);
        }
        public static int Fibonacci(int y)
        {
            if (y == 1)
            {
                return 1;
            }
            if (y == 2)

            {
                return 1;
            }
           
            return Fibonacci(y - 1) + Fibonacci(y - 2);



        }
         
















    }
    
}
