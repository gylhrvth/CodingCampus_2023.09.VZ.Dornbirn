using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class Methoden
    {
        public static void Start()
        {
            //Aufgabe 1)
            Console.WriteLine("Aufgabe 1: \n");
            PrintLineStipple("X", 3);
            Console.WriteLine("==========================");

            //Aufgabe 2)
            Console.WriteLine("Aufgabe 2: \n");
            PrintRowStipple("X", 3);
            Console.WriteLine("==========================");

            //Aufgabe 3)
            Console.WriteLine("Aufgabe 3: \n");
            PrintStipple("X", 3);
            Console.WriteLine("==========================");

            //Aufgabe 4)
            Console.WriteLine("Aufgabe 4: \n");
            PrintSlash("X", 3, false);
            Console.WriteLine("==========================");
        }


        //Aufgabe 1)
        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2)
        public static void PrintRowStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol);
                if (i < amount - 1)
                {
                    Console.WriteLine();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 3)
        public static void PrintStipple(string symbol, int amount)
        {
            PrintLineStipple(symbol, amount);
            PrintRowStipple(symbol, amount);
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 4)
        public static void PrintSlash(string symbol, int amount, bool slash)
        {
            if (slash)
            {
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for(int i = 0;i < amount; i++)
                {
                    for(int j  = 0; j <= amount; j++)
                    {
                        if(amount-i == j)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
