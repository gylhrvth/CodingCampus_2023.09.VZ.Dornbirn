using System;
namespace Timo.Week01
{
    public class Zählen
    {
        public static void Start()
        {
            int i = 0;
            Console.WriteLine("\n While");
            while (i <= 10)
            {
                Console.WriteLine("i: " + i);
                i++;
            }
            Console.WriteLine("\n For");
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("x: " + x);
            }
            Console.WriteLine("\n ModuloÜberprüfung");
            int a = 0;
            while (a <= 10)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + ": Gerade Zahl");
                }
                else if (a % 2 == 1)
                {
                    Console.WriteLine(a + ": Ungerade Zahl");
                }
                a++;
            }
            Console.WriteLine("\n Gerade Zahlen:");
            for (int b = 0;  b <= 10; b++) 
            {
                if ((b % 2) == 0) 
                {
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("\n Rewind");
            for (int c = 10; c>=-10; c--)
            {
                Console.WriteLine(c);
            }
        }
    }
}