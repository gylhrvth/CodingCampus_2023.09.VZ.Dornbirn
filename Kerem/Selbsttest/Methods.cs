using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class Methods
    {
        public static void Start()
        {
            PrintLineStipple("x", 10);
            Console.WriteLine();
            PrintRowStipple("x", 3);
            Console.WriteLine();
            PrintStipple();
            Console.WriteLine();
            PrintSlash("x", 3,true);
            PrintSlash("y", 4, false);
        }
        public static void PrintLineStipple(string symbol, int amount)
        {
            for( int i = 0; i < amount; i++ )
            {
                Console.Write(symbol);
            }
        }
        public static void PrintRowStipple(string symbol, int amount)
        {
            for(int i = 0; i < amount;i++ )
            {
                Console.WriteLine(symbol + "\n");
            }
        }
        public static void PrintStipple()
        {
            PrintLineStipple("X", 3);
            Console.WriteLine();
            PrintRowStipple("X", 3);
        }
        public static void PrintSlash(string symbol, int amount, bool backSlash)
        {
            if(backSlash)
            {
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                for(int i = 0; i < amount; i++)
                {
                    for( int j = 0; j < amount -i -1; j++)
                    {
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }

        }
    }
}
