using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;

namespace Sven.Week01
{
    public class Methoden
    {


        public static void Start()
        {
            Console.WriteLine("Printing characters horizontally:");
            PrintChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing square:");
            PrintSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing rect:");
            PrintRect("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("Print triangle bot left:");
            printTriangleBottomLeft("x", 4);
            Console.WriteLine();

            Console.WriteLine("Print triangle top left:");
            printTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("Print triangle top right:");
            printTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("Print empty square:");
            printEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("Print empty square small:");
            printEmptySquaresmall("A", 3);
            Console.WriteLine();

            Console.WriteLine("Print slash:");
            printslash("y", 4, true);
            Console.WriteLine();

            Console.WriteLine("Print slash2:");
            printslash2("y", 4, true);
            Console.WriteLine();

            Console.WriteLine("Print triangle:");
            printTriangle("x", 3);
            Console.WriteLine();

            Console.WriteLine("Print triangle large:");
            printTriangleLarge("x", 5);
            Console.WriteLine();

            Console.WriteLine("Print Rhombus:");
            printRhombus("x", 7);
            Console.WriteLine();

            Console.WriteLine("Print X:");
            printRhombus("x", 5);
            Console.WriteLine();
        }

        public static void PrintChars(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSquare(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void PrintRect(String symbol, int count1, int count2)
        {
            for (int i = 1; i <= count2; i++)
            {
                for (int j = 1; j <= count1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void printTriangleBottomLeft(String symbol, int count)
        {

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void printTriangleTopLeft(String symbol, int count)
        {

            for (int i = count; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void printTriangleTopRight(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < count - i; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }

        }

        public static void printEmptySquare(String symbol, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (i == 1 || i == count || j == 1 || j == count)
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

        public static void printEmptySquaresmall(String symbol, int count)
        {
            printEmptySquare(symbol, count);
        }


        public static void printslash(String symbol, int count, bool boolean)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == j)
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



        public static void printslash2(String symbol, int count, bool boolean)
        {

            if (boolean == false)
            {
                for (int i = 0; i < count; i++)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine(symbol);

                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            else
            {

                for (int i = 0; i < count; i++)
                {

                    for (int j = 0; j < count; j++)
                    {


                        if (i + j == count - 1)
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


        public static void printTriangle(String symbol, int count)
        {
            int i, j;

            for (i = 1; i <= count; i++)
            {

                for (j = i; j < count; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= (2 * i - 1); j++)
                {

                    if (i == count || j == 1 || j == (2 * i - 1))
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
        public static void printTriangleLarge(String symbol, int count)
        {
            printTriangle(symbol, count);
        }

        public static void printRhombus(String symbol, int count)
        {

            int row, col;

            for (row = 1; row <= count ; row++)
            {

                for (col = 0; col <= count; col++)
                {
                    Console.Write(" ");

                    if (row == col)

                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void printX(String symbol, int count)
        {




        }
    }
}

