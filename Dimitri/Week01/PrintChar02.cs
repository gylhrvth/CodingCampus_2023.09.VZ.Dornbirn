using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class PrintChar02
    {
        public static void Main()
        {
            PrintX("x", 9);
        }

        public static void PrintTriangleBottomLeft(string symbol, int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int numrow = 1; numrow <= i; numrow++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
        public static void PrintTriangleTopLeft(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void PrintTriangleTopRight(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int numspace = row; numspace > i; numspace--)
                {
                    Console.Write(" ");
                }
                for (int numsym = 0; numsym < i; numsym++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        public static void PrintTriangleBottomRight(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int numspace = 0; numspace < i; numspace++)
                {
                    Console.Write(" ");
                }
                for (int numsym = row; numsym >= i; numsym--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void PrintEmptySquare(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                /*
                 * SCHOEN!!!
                 */
                else if (i == row - 1)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(symbol);

                    for (int k = 0; k < row - 2; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }


        }

        public static void PrintSlash(string symbol, int row, bool back)
        {
            for (int i = 0; i < row; i++)
            {
                if (back)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                    Console.WriteLine();
                }
                else
                {
                    for (int j = i; j < row - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                    Console.WriteLine();

                }


            }
        }

        public static void PrintTriangle(string symbol, int row)
        {
            for (int i = 1; i <= row; i++)
            {
                if (i == row)
                {
                    for (int j = (row * 2) - 1; j > 0; j--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                else if (i == 1)
                {
                    for (int j = (row - 1); j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);

                    for (int j = (row - 1); j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = i; j < row; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    for (int j = i - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintRhombus(string symbol, int row)
        {
            if (row % 2 == 0)
            {
                Console.WriteLine("Bitte eine ungerade Zahl angeben.");
                return;
            }

            int upperHalf = (row + 1) / 2;

            for (int i = 1; i <= upperHalf; i++)
            {
                if (i == 1)
                {
                    for (int j = (upperHalf - 1); j > 0; j--)
                    {
                        Console.Write("0");
                    }

                    Console.Write(symbol);

                    for (int j = (upperHalf - 1); j > 0; j--)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = i; j < upperHalf; j++)
                    {
                        Console.Write("0");
                    }
                    Console.Write(symbol);
                    for (int j = i - 1; j > 0; j--)
                    {
                        Console.Write("0");
                    }
                    for (int j = 1; j < i - 1; j++)
                    {
                        Console.Write("0");
                    }
                    Console.Write(symbol);
                    for (int j = i; j < upperHalf; j++)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine();

                }
            }


            int lowerHalf = row - upperHalf;

            for (int i = 1; i <= lowerHalf; i++)
            {
                if (i == lowerHalf)
                {
                    for (int j = (lowerHalf); j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);

                    for (int j = (lowerHalf); j > 0; j--)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    for (int j = lowerHalf * 2 - i - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintX(string symbol, int row)

        {
            if (row % 2 == 0)
            {
                Console.WriteLine("Bitte eine ungerade Zahl angeben.");
                return;
            }
            for (int i = 1; i <= row; i++)
            {
                if (i == (row + 1) / 2)
                {
                    for (int j = (row - 1) / 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);

                    for (int j = (row - 1) / 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                else if (i < (row + 1) / 2)
                {
                    for (int j = i - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    for (int j = row - i; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
                else if (i > (row + 1) / 2)
                {
                    for (int j = row - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    for (int j = ((row - 1 / 2) - i) + 2; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintChristmasTree(int triangleHeight)
        {
            //print crown
            int widthTree = triangleHeight * 2 - 1;

            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = i; j < triangleHeight - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = widthTree - ((triangleHeight - 1) * 2) + i; j > 0; j--)
                {
                    Console.Write("x");
                }

                for (int j = widthTree - ((triangleHeight - 1) * 2) + i - 1; j > 0; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            //print line above the stem
            for (int i = 0; i < triangleHeight - 1; i++)
            {
                Console.Write("O ");
            }
            Console.Write("O");
            Console.WriteLine();

            //print stem

            int widthStem = widthTree / 3;
            int heightStem = widthStem / 2;
            string stemSymbol = "+";

            for (int j = 0; j < heightStem; j++)
            {
                for (int i = 0; i < (widthTree - widthStem) / 2; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < widthStem; i++)
                {
                    Console.Write(stemSymbol);
                }
                Console.WriteLine();
            }

        }
    }
}

