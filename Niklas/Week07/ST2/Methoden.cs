using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.ST2
{
    internal class Methoden
    {
        public static void Start()
        {
            string symbol = "X";
            int amount = 3;
            Aufgabe1(symbol, amount);
            Console.WriteLine();
            Aufgabe2(symbol, amount);
            Console.WriteLine();
            Aufgabe3(symbol, amount);
            Console.WriteLine();
            Aufgabe4(symbol, amount, true);
        }

        public static void Aufgabe1(string symbol, int amount)
        {
            for (; amount > 0; amount--)
            {
                Console.Write(symbol);
            }
        }

        public static void Aufgabe2(string symbol, int amount)
        {
            for (; amount > 0; amount--)
            {
                Console.WriteLine(symbol);
                Console.WriteLine();
            }
        }
        public static void Aufgabe3(string symbol, int amount)
        {
            int amount2 = amount;
            for (; amount > 0; amount--)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            for (; amount2 > 0; amount2--)
            {
                Console.WriteLine(symbol);
                Console.WriteLine();
            }
        }
        public static void Aufgabe4(string symbol, int amount, bool tf)
        {
            int save = amount;
            int a = 0;
            if (tf == true)
            {
                for (int i = 0; i < save;)
                {
                    for (int j = 0; j < save;)
                    {
                        Console.Write(".");
                        j++;
                    }
                    Console.WriteLine(symbol);
                    i++;
                }
                for (; amount > 0; amount--)
                {
                    
                }
            }
        }
    }
}
