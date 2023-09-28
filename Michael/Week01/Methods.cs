using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    public class Methods
    {

        static void printChars(char character, int length, bool newLine = false)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            if (newLine){
                Console.WriteLine("");
            }
        }



        static void printSquare(char character, int length)
        {
            for (int i = 0; i < length; i++)
            {
                printChars(character, length, true);
            }
        }



        static void printRect(char character, int width, int length)
        {
            for (int i = 0; i < length; i++)
            {
                printChars(character, width, true);
            }
        }



        static void printTriangleBottomLeft(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                printChars(character, i + 1, true);
            }
        }



        static void printTriangleTopLeft(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                printChars(character, i, true);
            }
        }



        static void printTriangleTopRight(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                printChars(' ', width - i, false);
                printChars(character, i, true);
            }
        }



        static void printTriangleBottomRight(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                printChars(' ', width-i-1, false);
                printChars(character, i+1, true);
            }
        }



        static void printEmptySquare(char character, int width)
        {
            for (int i=0; i < width; i++)
            {
                if (i == 0 || i == width - 1)
                {
                    printChars(character, width, true);
                }
                else
                {
                    printChars(character, 1, false);
                    printChars(' ', width - 2, false);
                    printChars(character, 1, true);
                }
            }
        }



        static void printSlash(char character, int length, bool backslash = true)
        {
            if (backslash)
            {
                for (int i = 0; i < length; i++)
                {
                    printChars(' ', i, false);
                    printChars(character, 1, true);
                }
            }
            else
            {
                for (int i = length; i > 0; i--)
                {
                    printChars(' ', i, false);
                    printChars(character, 1, true);
                }
            }
        }



        static void printTriangle(char character, int length, bool solidLine = true, bool top = true)
        {
            for (int i = 0; i < length; i++)
            {
                if (i == 0) {
                    if (top)
                    {
                        printChars(' ', length - 1, false);
                        printChars(character, 1, false);
                        printChars(' ', length - 1, true);
                    }

                } else if (i == length-1 && solidLine) {
                    printChars(character, 2*length-1, true);
                } else { 
                    printChars(' ', (2*length-2*i-1)/2, false);
                    printChars(character, 1, false);
                    printChars(' ', 2*i-1, false);
                    printChars(character, 1, false);
                    printChars(' ', (2 * length - 2*i-1) / 2, true); 
                    }

            }
        }



        static void printInvertedTriangle(char character, int length, bool solidLine= true, bool top= true)
        {
            for (int i = length-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (top)
                    {
                        printChars(' ', length - 1, false);
                        printChars(character, 1, false);
                        printChars(' ', length - 1, true);
                    }

                }
                else if (i == length - 1 && solidLine)
                {
                    printChars(character, 2 * length - 1, true);
                }
                else
                {
                    printChars(' ', (2 * length - 2 * i - 1) / 2, false);
                    printChars(character, 1, false);
                    printChars(' ', 2 * i - 1, false);
                    printChars(character, 1, false);
                    printChars(' ', (2 * length - 2 * i - 1) / 2, true);
                }

            }
        }



        static void printRhombus(char character, int length)
        {
            printTriangle(character, (length + 1) / 2, false, true);
            printInvertedTriangle(character, (length - 1) / 2, false, true);
        }

        static void printX(char character, int length) 
        {
            printInvertedTriangle(character, (length + 1) / 2, false, true);
            printTriangle(character, (length + 1) / 2, false, false);
        }



        static void printChristmasTree(int height)
        {
            if (height < 5)
            {
                Console.WriteLine("a tree that small should not be cut down");
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    printChars(' ', height - 1 - i, false);
                    printChars('x', 2 * i - 1, false);
                    printChars(' ', 0, true);
                }

                for (int i = 0; i < 2 * (height - 1) - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        printChars('O', 1, false);
                    }
                    else
                    {
                        printChars(' ', 1, false);
                    }
                }
                Console.WriteLine("");

                for (int i = 0; i < 2; i++)
                {
                    printChars(' ', (2 * (height - 1) - 6) / 2, false);
                    printChars('+', 5, true);
                }
            }
        }



        static void printCirclePythagoras(int radius)
        {
            int left = 0;
            decimal body = 0;

            for (int i = radius; i >= -radius; i--)
            {
                body = (decimal)Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(i, 2));
                left = radius - (int)Math.Floor(body);

                printChars(' ', left, false);
                printChars('X', 2 * (int)Math.Floor(body), false);
                printChars(' ', 0, true);

            }
        }


        static void printCircleSinCos(int radius)
        {
            for (int y = radius; y >= -radius; y--)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    if ( Math.Round( Math.Pow(x,2) + Math.Pow(y,2)) == Math.Pow(radius,2))
                    {
                        printChars('X', 1, false);
                    }
                    else
                    {
                        printChars(' ', 1, false);
                    }
                }
                printChars(' ', 0, true);
            }
        }



        public static void Method()
        {
            printCirclePythagoras(10);

        }
    }
}

            