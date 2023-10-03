using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week01
{
    internal class Excs
    {
        public static void Start()
        {
            // PrintTriangleBottomLeft("*", 10);
            // PrintTriangleTopRight("*", 5);
            // PrintSquare("*", 10);
            //PrintEmptySquare("*", 10);
            PrintTriangle("*", 5);

           
        }

        static void PrintTriangleBottomLeft(string symbol, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleTopRight(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                     Console.Write(" ");
                }
                for (int k = 0; k < size - i; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        static void PrintSquare(string symbol, int size)
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

        static void PrintEmptySquare(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
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
        static void PrintTriangle(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int numberOfSymbols = 2 * i + 1;
                int numberOfSpaces = size - i - 1;

                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < numberOfSymbols; k++)
                {
                    if (k == 0 || k == numberOfSymbols - 1 || i == size - 1)
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
