using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week01
{
    internal class MethodenRectangle
    {
        public static void Start()
        {
            // PrintChars("g", 10);
            //PrintRlect("x", 3, 10);
            // PrintTriangleBottom("x", 4);
            // Sandbox("x", 5);
            // PrintTriangleTopLeft("y", 10);
            // PrintTriangleTopRight("x", 5); v
            //PrintTriangleBottomRight("x", 5);
            //PrintEmptySqure("x", 7);
           // PrintemptySquare("A", 5);
        }

        public static void PrintChars(string symbol, int count)
        {
            for (int k = 0; k < count; k++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintRect(String symbol, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)

                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleBottomLeft(String symbol, int height)
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




        public static void Sandbox(String symbol, int count)
        {
            for (int i = 1; i < count; i++)
            {
                PrintChars(symbol, i);
                Console.WriteLine();
            }
        }



        public static void PrintTriangleTopLeft(String symbol, int count)
        {
            for (int i = count; i > 0; i--)
            {
                PrintChars(symbol, i);
                Console.WriteLine();
            }
        }



        public static void PrintTriangleTopRight(String symbol, int count)
        {
            for (int i = count; i > 0; i--)
            {
                PrintChars(" ", count - i);


                PrintChars(symbol, i);
                Console.WriteLine();
            }

        }

        public static void PrintTriangleBottomRight(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                PrintChars(" ", count - i); // eines zuviel
                PrintChars(symbol, i); // eines zu wenig
                Console.WriteLine(symbol);
            }

        }



        public static void PrintEmptySqure(String symbol, int count)
        {
            for (int zeile = 0; zeile < count; zeile++)
            {

                for (int spalte = 0; spalte < count; spalte++)
                {
                    if (zeile == 0 || spalte == 0 || zeile == count - 1 || spalte == count - 1)
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



        public static void PrintemptySquare(string symbol, int count)
        {
            for (int zeile = 0; zeile < count; zeile++)
            {
                for (int spalte = 0; spalte < count; spalte++)
                {
                    if (zeile == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (spalte == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (zeile < count - 1)
                    {
                        Console.Write("o");
                    }
                    else if (spalte < count - 1)
                    {
                        Console.Write(symbol);
                    }

                }
                Console.WriteLine();
            }
        }
    }
}



