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
            //PrintTriangleBottomLeft("*", 10);
            //PrintTriangleTopRight("*", 5);
            //PrintSquare("*", 10);
            //PrintEmptySquare("*", 10);
            //PrintPyramid("*", 6);
            PrintMeinRhombus("x", 10);
            //PrintTest("x", 7);


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
        public static void PrintPyramid(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size * 2 - 1; col++)
                {
                    if (col == size - 1 - row || col == size - 1 + row || row == size - 1)
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
        public static void PrintMeinRhombus(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col - 3 || row == col + 3 || row + col == size + 2 || row + col == 3)
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

        public static void PrintTest(String symbol, int size)
        {
           for(int row = 0;row < size; row++)
            {
                for(int col = 0;col < size * 2 - 1 ; col++)
                {
                    if(row + size - 1 == col )
                    {
                        Console.Write(symbol);
                    }else if (row + col == size - 1)
                    {
                        Console.Write(symbol);
                    }else if (row == size - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    

                }
                Console.WriteLine();
            }

        }












    }
}


