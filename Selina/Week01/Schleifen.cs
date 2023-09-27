using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week01
{
    internal class Schleifen
    {
        public static void Start()
        {
            // Aufgabe Zählen 

            //1.Zähle in einer Schleife von 0 bis inklusive 10 und gib die Zahlen aus.

                Console.WriteLine("\nAufgabe 1: \n");

                // for-Schleife:
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\nAufgabe 2: \n");

                // while-Schleife:
                int y = 0;
                int number = 0;

                while (y<=10)
                {
                    Console.WriteLine($"Zahl:  {y}     Zählvariable: {number} ");
                    number++;
                    y++;
                }

                Console.WriteLine("\nAufgabe 3: \n");

            //2.Zähle in einer Schleife von 0 bis exklusive 10 und gib die Zählvariable aus.
             

                // for-Schleife:
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\nAufgabe 4: \n");

           //Zähle in einer Schleife von 0 bis inklusive 10 gib nur jede gerade Zahl aus.

                for (int i = 0; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("\nAufgabe 5: \n");

            //Zähle in einer Schleife rückwärts von 10 bis inklusive -10 und gib die Zählvariable aus.

                for (int i = 10; i >= -10; i--)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
