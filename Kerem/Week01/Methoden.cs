using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week01
{
    internal class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("Print");
            printChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("Print2");
            printSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("Print3");
            printRectangle("x", 10, 3);
            Console.WriteLine();
        }

        public static void printChars(char symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }
        public static void printSquare(char symbol, int count)
        {
            for (int i = 0; i <count; i++)
            {
                for(int j = 0; j <count; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

            }
              
        }
        public static void printRectangle(char symbol, int count, string zeile )
        {
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(); 

            }
                
        }

    }
}










