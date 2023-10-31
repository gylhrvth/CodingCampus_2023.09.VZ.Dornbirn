using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class Schleifen
    {
        public static void Start()
        {
            //Aufgabe 1)
            Console.WriteLine("Aufgabe 1: \n");
            CountBack();
            Console.WriteLine("==========================");

            //Aufgabe 2)
            Console.WriteLine("Aufgabe 2: \n");
            PrintMod3();
            Console.WriteLine("==========================");

            //Aufgabe 3)
            Console.WriteLine("Aufgabe 3: \n");
            While();
            Console.WriteLine("==========================");
        }

        //Aufgabe 1)
        public static void CountBack()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2)
        public static void PrintMod3()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 3)
        public static void While()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                if (i > 5)
                {
                    Console.WriteLine();
                }
                i++;
            }
        }
    }
}
