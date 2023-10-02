using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week01
{
    internal class Schleifen
    {
        public static void Start()
        {

            /*
            // For Schleife

            for (int i = 0; i <= 10; i++)

                Console.WriteLine(i);


            // while Schleife

            int t = 0;

            while (t <= 10)
            {
                Console.WriteLine(t);
                t = t + 1;
            }


            // Aufgabe 2

            for (int z = 0; z < 10; z++)
                Console.WriteLine(z);

            */
            // Aufgabe 3

            for (int o = 0; o <= 10; o++)
            {
                if (o % 2 == 0)
                {
                    Console.WriteLine($"Diese Zahl ist gerade!{o}");
                }
                else
                {
                    Console.WriteLine($"Dies ist eine ungerade Zahl!{o}");
                }

              // Aufgabe Rewind
              /*
                for (int q = 10; q >= -10; q--)
                {
                    Console.WriteLine($"Q = {q}");
                }
              */


            }

        }

        }
    }