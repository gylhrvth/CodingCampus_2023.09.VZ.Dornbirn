using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Methods
    {
        public static void Start()
        {
            //PrintLineStipple("X", 10);
            //PrintRowStipple("X", 3);
            //PrintStipple("X", 3);
            PrintSlash("X", 5, true);
            PrintSlash("Y", 5, false);
        }

        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }
        }

        public static void PrintRowStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + " ");
                Console.WriteLine();
            }
        }

        public static void PrintStipple(string symbol, int amount)
        {
            PrintLineStipple(symbol, amount);
            Console.WriteLine();
            PrintRowStipple(symbol, amount);
        }

        public static void PrintSlash(string symbol, int amount, bool trueFalse)
        {
            if (trueFalse == true)
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
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount - i; j++)
                    {

                        if (amount - 1 - i == j)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
