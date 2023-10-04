using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week02
{
    internal class BooleanExamples
    {
        public static void start()
        {
            Console.WriteLine("PrintTriangle");
            PrintTriangle("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintRhombus");
            PrintRhombus("x", 7);
            Console.WriteLine();

            Console.WriteLine("PrintX");
            PrintX("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintChristmasTree");
            PrintChristmasTree(9);
            Console.WriteLine();



        }

        public static void PrintTriangle(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                int numberOfSymbols = 2 * i + 1;
                int numberOfSpaces = row - i - 1;
                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < numberOfSymbols; k++)
                {
                    if (k == 0 || k == numberOfSymbols - 1 || i == row - 1)
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

        public static void PrintRhombus(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col - size / 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (row - col == size / 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (size / 2 - col == row)
                    {
                        Console.Write(symbol);
                    }
                    else if (row + 1 + col == size + size / 2)
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

        public static void PrintX(string symbol, int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (y == x)
                    {
                        Console.Write(symbol);
                    }
                    else if (size - y == x + 1)
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


        public static void PrintChristmasTree(int size)
        {
            for (int x = 0; x < size; x++)
            {
                {
                    for (int y = size - 1; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                    for (int z = -1; z < x; z++)
                    {
                        Console.Write("*");
                    }
                    for (int z = 0; z < x; z++)
                    {
                        Console.Write("*");
                    }
                    for (int y = size; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();          
            }
            for ( int y = 0; y < size; ++y)
            {
                Console.Write("O");
                Console.Write(" ");
            }
            Console.WriteLine();
            for ( int y = 0;y < size /4; ++y)
            {
                for (int x1= 0; x1 < size -3 ; ++x1)
                {
                    Console.Write(" ");
                }
                for (int x2 = 0; x2 < size - 4; ++x2)
                {
                    Console.Write("+");
                }
                for (int x3 = 0; x3 < size - 3; ++x3)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }








    }
}



