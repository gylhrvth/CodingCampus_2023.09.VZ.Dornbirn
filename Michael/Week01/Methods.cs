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

        public static void printChars(char character, int length, bool newLine = false)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(character);
            }
            if (newLine)
            {
                Console.WriteLine("");
            }
        }



        public static void printSquare(char character, int length)
        {
            for (int i = 0; i < length; i++)
            {
                printChars(character, length, true);
            }
        }



        public static void printRect(char character, int width, int length)
        {
            for (int i = 0; i < length; i++)
            {
                printChars(character, width, true);
            }
        }



        /* printRect loop */

        public static void printRectLoop(char character, int width, int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }



        public static void printTriangleBottomLeft(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                printChars(character, i + 1, true);
            }
        }



        /* printTriangleBottomLeft loop */

        public static void printTriangleBottomLeftLoop(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }




        public static void printTriangleTopLeft(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                printChars(character, i, true);
            }
        }




        /* printTriangleTopLeft loop */

        public static void printTriangleTopLeftLoop(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }



        public static void printTriangleTopRight(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                printChars(' ', width - i, false);
                printChars(character, i, true);
            }
        }


        /* printTriangleTopRight loop */

        public static void printTriangleTopRightLoop(char character, int width)
        {
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }



        public static void printTriangleBottomRight(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                printChars(' ', width - i - 1, false);
                printChars(character, i + 1, true);
            }
        }



        /* printTriangleBottomRight loop */

        public static void printTriangleBottomRightLoop(char character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width - i - 1; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(character);

                }
                Console.WriteLine();
            }
        }



        public static void printEmptySquare(char character, int width)
        {
            for (int i = 0; i < width; i++)
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



        /* printEmptySquare loop */

        public static void printEmptyRectLoop(char character, int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == length - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(character);
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.WriteLine(character);
                }
            }
        }



        public static void printSlash(char character, int length, bool backslash = true)
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



        public static void printTriangle(char character, int length, bool solidLine = true, bool top = true)
        {
            for (int i = 0; i < length; i++)
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



        public static void printInvertedTriangle(char character, int length, bool solidLine = true, bool top = true)
        {
            for (int i = length - 1; i >= 0; i--)
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



        public static void printRhombus(char character, int length)
        {
            printTriangle(character, (length + 1) / 2, false, true);
            printInvertedTriangle(character, (length - 1) / 2, false, true);
        }



        /* printRhombus loop */

        public static void printRhombusLoop(char character, int length)
        {
            if (length % 2 == 0)
            {
                Console.WriteLine("please enter an odd number. length got reduced by 1");
                length -= 1;
            }

            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == length - 1)
                {
                    for (int j = 0; j < (length - 1) / 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.WriteLine(character);
                }
                else if (i < (length + 1) / 2)
                {

                    for (int j = 0; j < (length - 1) / 2 - i; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(character);

                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.WriteLine(character);

                }

                else
                {
                    for (int j = 0; j < i - (length + 1) / 2 + 1; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(character);

                    for (int j = 0; j < length - (2 * i - (length - 3)); j++)
                    {
                        Console.Write(' ');
                    }

                    Console.WriteLine(character);

                }

            }
        }




        public static void printX(char character, int length)
        {
            printInvertedTriangle(character, (length + 1) / 2, false, true);
            printTriangle(character, (length + 1) / 2, false, false);
        }



        public static void printChristmasTree(char character, int height)
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
                    printChars(character, 2 * i - 1, false);
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
            }
            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {
                printChars(' ', (2 * (height - 1) - 6) / 2, false);
                printChars('+', 5, true);
            }
        }




        public static void printCirclePythagoras(char character, int radius)
        {
            int left = 0;
            decimal body = 0;

            for (int i = radius; i >= -radius; i--)
            {
                body = ((decimal)Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(i, 2)));
                left = radius - (int)Math.Floor(body);

                printChars(' ', left, false);
                printChars(character, 2 * (int)Math.Floor(body), false);
                printChars(' ', 0, true);

            }
        }


        public static void printCirclePythagorasBetter(char character, int radius)
        {
            for (int y = radius; y >= -radius; y--)
            {
                for (int x = Convert.ToInt32(-radius * 2); x <= Convert.ToInt32(radius * 2); x++)
                {
                    if (Math.Round(Math.Pow(x / 2, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                    {
                        printChars(character, 1, false);
                    }
                    else
                    {
                        printChars(' ', 1, false);
                    }
                }
                printChars(' ', 0, true);
            }
        }


        public static void printEmptyCirclePythagoras(char character, int radius, int width)
        {
            for (int y = radius; y >= -radius; y--)
            {
                for (int x = Convert.ToInt32(-radius * 2); x <= Convert.ToInt32(radius * 2); x++)
                {
                    if (Math.Round(Math.Pow(x / 2, 2) + Math.Pow(y, 2)) < Math.Pow(radius, 2) && Math.Round(Math.Pow(x / 2, 2) + Math.Pow(y, 2)) > Math.Pow(radius - width, 2))
                    {
                        printChars(character, 1, false);
                    }
                    else
                    {
                        printChars(' ', 1, false);
                    }
                }
                printChars(' ', 0, true);
            }
        }



        public static void drawCondition()
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) == 900)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }



        public static void Method()
        {
            printRhombusLoop('X', 20);

        }
    }
}

