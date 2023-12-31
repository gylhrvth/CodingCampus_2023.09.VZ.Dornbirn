﻿namespace Kerem.Week02
{
    internal class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
            Console.WriteLine("printSlash");
            printSlash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("printSlash2");
            printSlash2("y", 4, false);
            Console.WriteLine();

            Console.WriteLine("printpyramid");
            printPyramid("x", 5);
            Console.WriteLine();

            Console.WriteLine("printX");
            printX("x", 5);
            Console.WriteLine();
        }


        public static void printSlash(string symbol, int size, bool Slash)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
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
        public static void printSlash2(string symbol, int size, bool BackSlash)
        {
            if (BackSlash == false)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = i; j < size; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
        public static void printPyramid(string symbol, int size)
        {
            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size * 2 - 1; cols++)
                {
                    if (rows == cols - size * 2)
                    {
                        Console.Write(".");
                    }
                    else if (rows + cols == 4)
                    {
                        Console.Write("x");
                    }
                    else if (rows == cols)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printX(string symbol, int size)
        {
            for (int rows = 0; rows < size; rows++)
            {

                for (int cols = 0; cols < size; cols++)
                {
                    if (rows == cols - size * 2)
                    {
                        Console.Write(".");
                    }
                    else if (rows + cols == 4)
                    {
                        Console.Write("x");
                    }
                    else if (rows == cols)
                    {
                        Console.Write("x");
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
