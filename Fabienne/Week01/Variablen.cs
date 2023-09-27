using System;

namespace Fabienne.Week01
{
    public class Variablen
    {
        public static void Start()
        {
            //aufgabe: zählen

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("for is: " + i);
            }

            int j = 0;
            while (j <= 10)
            {               
                Console.WriteLine("while is: " + j);
                j++;
            }

            //aufgabe: zählen  2

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("k is: " + k);
            }

            //aufgabe: zählen mit tricks 1

            int n = 0;
            while (n <= 10)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("n ist gerade weil: " + n);
                }
                else
                {
                    Console.WriteLine("n ist nicht gerade weil: " + n);
                }
                n++;
            }

            //aufgabe: zählen mit tricks 2

            int l = 0;
            while (l <= 10)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine(l);
                }

                l++;
            }

            //aufgabe: rewind

            for (int m = 10; m >= -10; m--)
            {
                Console.WriteLine("m is: " + m);
            }

        }
    }
}
