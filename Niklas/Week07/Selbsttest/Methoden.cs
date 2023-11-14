using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Methoden
    {
        public static void Start()
        {
            string symbol;
            int amount;
            bool factor;

            Console.WriteLine("\nLines: ");
            PrintLineStipple("X", 10);
            Console.WriteLine();

            Console.WriteLine("\nRows: ");
            PrintRowStipple("X", 3);

            Console.WriteLine("\nBoth: ");
            PrintStipple("X", 3);

            Console.WriteLine("\nSlash: ");
            PrintSlash("X", 3, true);
        }
        public static void PrintLineStipple(string symbol, int amount)
        {
            for (amount = 10; amount > 0; amount--)
            {
                Console.Write(symbol);
            }
        }
        public static void PrintRowStipple(string symbol, int amount)
        {
            for (amount = 3; amount > 0; amount--)
            {
                Console.WriteLine(symbol);
                Console.WriteLine();
            }
        }
        public static void PrintStipple(string symbol, int amount)
        {
            for (amount = 3; amount > 0; amount--)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            for (amount = 3; amount > 0; amount--)
            {
                Console.WriteLine(symbol);
                Console.WriteLine();
            }
        }
        public static void PrintSlash(string symbol, int amount, bool factor)
        {
            int amount2 = amount * 2;
            if (factor == true)
            {
                for (amount = 0; amount < amount2 / 2; amount++)
                {
                    string i = new string(Convert.ToChar(" "), amount);
                    Console.Write(i);
                    Console.WriteLine(symbol);
                }
            }
            else if (factor == false)
            {
                for (; amount > 0; amount--)
                {
                    string i = new string(Convert.ToChar(" "), amount - 1);
                    Console.Write(i);
                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
