using System;
using System.Runtime.InteropServices;

namespace Simon.Week01
{
    public class Schleifen
    {
        public static void Start()
        {
            Console.WriteLine("for-schleife");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i.ToString());
            }

            Console.WriteLine("\nwhile-schleife");

            int a = 0;
            while (a <= 10)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine("\ncount ex 10");

            for (int b = 0; b < 10; b++)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine("\nzählen mit trick");

            for (int c = 0; c <= 10; c++)
            {
                if (c % 2 == 0)
                {
                    Console.Write(c + " ");
                }
            }

            Console.WriteLine("\nrewind");

            for (int d = 10; d >= -10; d--)
            {
                Console.Write(d + " ");
            }



        }
    }
}


