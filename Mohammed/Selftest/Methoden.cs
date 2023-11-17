using System;
namespace Mohammed.Selftest
{
    public class Methoden
    {
        public static void Start()
        {
            PrintLineStipple("X", 10);
            PrintRowStipple("X", 3);
            PrintStipple();
            PrintSlash("X", 3, true);
            PrintSlash("Y", 3, false);
        }


        //Aufgabe 1
        public static void PrintLineStipple(string symbol, int amount)
        {
            //string symbol = "X";
            //int amount = 10;

            for (int i = 0; i < amount; i++)
            {
                if(i < amount - 1)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        //Aufgabe 2
        public static void PrintRowStipple(string symbol, int amount)
        {
            //string symbol = "X";
            //int amount = 3;

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + "\n");
            }

        }

        //Aufgabe 3
        public static void PrintStipple()
        {
            

            PrintLineStipple("X", 3);
            Console.WriteLine();
            PrintRowStipple("X", 3);

            Console.WriteLine();

        }

        //Aufgabe 4
        //Hier habe ich leider ein Problem!!
        public static void PrintSlash(string symbol, int amount, bool backslash)
        {
            if (backslash)
            {
                for(int i = 0; i < amount; i++)
                {
                    for(int j = 0; j > i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < amount - i - 1; i++)
                {
                    for (int j = 0; j > i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}

