using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week01
{
    internal class Testen
    {
        public static void Start()
        {
            // Square("x", 10);
            // Rectangle("*", 3, 10);
            // PrintTriangle("x", 4);
            PrintTriangle2("*", 5);


        }
        public static void Square(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }

        }


        public static void Rectangle(string symbol, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 1; col < width; col++)
                {
                    Console.Write(symbol);

                }
                Console.WriteLine();
            }

        }

        public static void PrintTriangle(string symbol, int height)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        public static void PrintChars(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintTriangle2(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }


    }
}








