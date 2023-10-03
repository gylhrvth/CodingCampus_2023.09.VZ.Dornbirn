using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dimitri.Week02
{
    internal class MethodenUndSchleifen
    {
        public static void Main()
        {
            PrintChars("x", 5);
            PrintSquare("x", 5);
            PrintRect("x", 5, 3);
            PrintTriangleBottomLeft("x", 5);
            PrintTriangleTopLeft("x", 5);
            PrintTriangleTopRight("x", 5);
            PrintTriangleBottomRight("x", 5);
            PrintEmptySquare("A", 5);
            PrintSlash("x", 7, true);
            PrintPyramid("x", 5);
            PrintRhombus("x", 7);
            PrintX("x", 13);
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
                    }
                    else
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
                    if (j + i > width - 2)
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

        public static void PrintEmptySquare(string symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == width - 1 || j == 0 || j == width - 1)
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

        public static void PrintSlash(string symbol, int width, bool back)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((j == i && back) || (j + i == width - 1 && !back))
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

        public static void PrintPyramid(string symbol, int height)
        {
            if (height % 2 == 0)
            {
                Console.WriteLine($"{height} ist gerade. Bitte eine ungerade Zahl eingeben");
            }

            int width = height * 2 - 1;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i == 0 && j == height - 1) || i == height - 1 || ((i + j == height - 1) || (j - i == height - 1)))
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

        public static void PrintRhombus(string symbol, int height)
        {
            if (height % 2 == 0)
            {
                Console.WriteLine($"{height} ist gerade. Bitte eine ungerade Zahl eingeben");
            }

            int middle = (height - 1) / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    // bottom left
                    if (i - j == middle)
                    {
                        Console.Write(symbol);
                    }
                    // top right
                    else if (j - i == middle)
                    {
                        Console.Write(symbol);
                    }
                    // top left
                    else if (j + i == middle && i < middle && i != 0)
                    {
                        Console.Write(symbol);
                    }
                    // bottom right
                    else if (j + i == middle * 3 && i > middle && i != height - 1)
                    {
                        Console.Write(symbol);
                    }
                    // spaces
                    else
                    {
                        Console.Write(" ");
                    }

                }

                Console.WriteLine();
            }

        }

        public static void PrintX(string symbol, int height)
        {
            if (height % 2 == 0)
            {
                Console.WriteLine($"{height} ist gerade. Bitte eine ungerade Zahl eingeben");
            }

            int middle = (height - 1) / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == j || j + i == height - 1)
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
