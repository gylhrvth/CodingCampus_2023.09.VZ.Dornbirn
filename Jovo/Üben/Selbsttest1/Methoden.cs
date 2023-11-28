using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbsttest1
{
    internal class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("Methoden Aufgabe 1");
            Methode1("X", 10);
            Console.WriteLine("\n=======================");

            Console.WriteLine("Methoden Aufgabe 2");
            Methode2("X", 3);
            Console.WriteLine("\n=======================");

            Console.WriteLine("Methoden Aufgabe 3");
            Methode3("X", 3);
            Console.WriteLine("\n=======================");

            Console.WriteLine("Methoden Aufgabe 4");
            Methode4("x", "y", 3, true);
            Console.WriteLine("\n=======================");
        }


        //Aufgabe 1
        public static void Methode1(string symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol + " ");
            }
        }


        //Aufgabe 2
        public static void Methode2(string symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}\n", symbol);
            }
        }


        //Aufgabe 3
        public static void Methode3(string symbol, int length)
        {
            Methode1(symbol, length);
            Console.WriteLine();
            Methode2(symbol, length);
        }


        //Aufgabe 4
        public static void Methode4(string symbol, string symbol2, int length, bool backslash)
        {
            for (int i = 0; i < length; i++)
            {
                if (backslash)
                {
                    for (int j = 0; j < i; j++)
                    {

                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
                else
                {
                    for (int k = length - 1; k > i; k--)
                    {

                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol2);
                }
            }
        }
    }
}
