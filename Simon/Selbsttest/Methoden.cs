using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest
{
    internal class Methoden
    {
        public static void Start()
        {
            PrintStipple("X", 3);
            PrintSlash("y", 3, false);

        }

        public static void PrintLineStipple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
        public static void PrintRowStippple(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + "\n");
            }
        }

        public static void PrintStipple(string symbol, int amount)
        {
            PrintLineStipple(symbol, amount);
            PrintRowStippple(symbol, amount);
        }

        public static void PrintChar(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSlash(string symbol, int leangth, bool backslash)
        {
            if (backslash == true)
            {
                for (int i = 0; i < leangth; i++)
                {
                    PrintChar(" ", i);
                    PrintChar(symbol, 1);
                    Console.WriteLine();
                }
            }
            else if (backslash == false)
            {
                for (int i = 0; i < leangth; i++)
                {
                    PrintChar(" ", leangth-i-1);
                    PrintChar(symbol, 1);
                    Console.WriteLine();
                }
            }
        }





    }
}
