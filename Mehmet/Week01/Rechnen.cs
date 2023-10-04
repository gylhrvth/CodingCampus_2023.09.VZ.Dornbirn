using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Mehmet.Week01
{
    public class Rechnen
    {

        public static void Start()
        {
            Console.WriteLine("Printing characters horizontally:");
            PrintChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintSquare:");
            PrintSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintRect");
            PrintRect("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleBottomLeft");
            PrintTriangleBottomLeft("x", 4);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleTopLeft");
            PrintTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleTopRight");
            PrintTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleBottomRight");
            PrintTriangleBottomRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintEmptySquare");
            PrintEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintEmptySquare2");
            PrintEmptySquare2("a", 3);
            Console.WriteLine();

            Console.WriteLine("PrintSlash");
            PrintSlash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("PrintSlash2");
            PrintSlash2("y", 4, false);
            Console.WriteLine();

            Console.WriteLine("PrintSlash2.1");
            PrintSlash2("y", 4, true);
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
            for (int s = 0; s < count; s++)
            {
                PrintChars(symbol, count);
                Console.WriteLine();
            }
        }

        public static void PrintRect(String symbol, int count1, int count2)
        {
            for (int i = 0; i < count2; i++)
            {
                for (int j = 0; j < count1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void PrintTriangleBottomLeft(String symbol, int row)
        {
            for (int r = 0; r < row; r++)
            {
                for (int a = 0; a < r; a++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }
        }

        public static void PrintTriangleTopLeft(string symbol, int row)
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = row; y > x; y--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleTopRight(string symbol, int row)
        {
            for (int x = 0; x < row; x++)
            {

                for (int z = 0; z < x; z++)
                {
                    Console.Write(" ");
                }

                for (int y = row; y > x; y--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleBottomRight(string symbol, int row)
        {
            for (int x = 0; x < row; x++)
            {
                {
                    for (int y = row - 1; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                    for (int z = -1; z < x; z++)
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintEmptySquare(string symbol, int row)
        {
            PrintChars(symbol, row);
            for (int x = 0; x < row - 2; x++)
            {
                Console.WriteLine();
                for (int y = row - 2; y < row; y++)
                {
                    Console.Write(symbol);
                    for (int z = 0; z < row - 2; z++)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
            PrintChars(symbol, row);
        }


        public static void PrintEmptySquare2(string symbol, int row)

        {
            PrintChars(symbol, row);
            for (int x = 0; x < row - 2; x++)
            {
                Console.WriteLine();
                for (int y = row - 2; y < row; y++)
                {
                    Console.Write(symbol);
                    for (int z = 0; z < row - 2; z++)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
            PrintChars(symbol, row);
        }

        public static void PrintSlash(string symbol, int row, bool backslash)
        {
            if (backslash)
            {
                for (int x = 0; x < row; x++)
                {
                    for (int z = 0; z < x; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
        public static void PrintSlash2(string symbol, int row, bool slash)
        {
            if (slash)
            {
                Console.WriteLine("Richtig");
            }
            else
            {
                for (int x = 0; x < row; x++)
                {
                    for (int z = x + 1; z < row; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
    }
}





