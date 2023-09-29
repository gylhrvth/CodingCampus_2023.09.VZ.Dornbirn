using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class MethodenUndSchleifen
    {
        public static void Main()
        {
            PrintTriangleBottomRight("x", 5);
        }

        public static void PrintChars(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSquare(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                PrintChars(symbol, width);
                Console.WriteLine();
            }
        }

        public static void PrintRect(string symbol, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintChars(symbol, width);
                Console.WriteLine();
            }
        }

        public static void PrintTriangleBottomLeft(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(symbol);
                    }
                }

                Console.WriteLine();
            }

        }

        public static void PrintTriangleTopLeft(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(symbol);
                    }
                }

                Console.WriteLine();

            }
        }

        public static void PrintTriangleTopRight(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(symbol);
                    } else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

        }

        public static void PrintTriangleBottomRight(string symbol, int width)
        {

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j <= i)
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
