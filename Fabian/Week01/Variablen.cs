using System;

namespace Fabian.Week01
{
    public class Variablen
    {
        public static void Start()
        {
            //Aufgabe Zählen

            //1.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"For-Loop: {i}");
            }

            int j = 0;

            //2.
            while (j <= 10)
            {
                Console.WriteLine($"While-Loop: {j}");
                j++;
            }

            //Aufgabe Zählen 2
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            //Aufgabe Zählen mit Trick
            for(int l = 0;  l <= 10; l++)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine($"Even numbers: {l}");
                }
            }

            //Aufgabe Rewind
            for(int m = 10; m >= -10; m--)
            {
                Console.WriteLine($"Backwards couting: {m}");
            }
        }
    }
}
