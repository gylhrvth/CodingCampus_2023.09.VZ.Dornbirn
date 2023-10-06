using System;
using System.Collections.Concurrent;
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
                Console.Write(character + "");
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


        public static void printTriangle(char character, int length, int offset = 0, bool solidLine = true, bool top = true)
        {
            for (int i = 0; i < length; i++)
            {
                printChars(' ', offset);

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


        public static void printInvertedTriangle(char character, int length, int offset = 0, bool solidLine = true, bool top = true)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                printChars(' ', offset);

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
            if (length % 2 == 0)
            {
                Console.WriteLine("only works with odd numbers. length got extended by 1\n");
                length += 1;
            }

            printTriangle(character, (length + 1) / 2, 0, false, true);
            printInvertedTriangle(character, (length - 1) / 2, 1, false, true);
        }


        public static void printRhombusLoop(char character, int length)
        {
            if (length % 2 == 0)
            {
                Console.WriteLine("only works with odd numbers. length got extended by 1\n");
                length += 1;
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
            if (length % 2 == 0)
            {
                Console.WriteLine("only works with odd numbers. length got extended by 1\n");
                length += 1;
            }

            printInvertedTriangle(character, (length + 1) / 2, 0, false, true);
            printTriangle(character, (length + 1) / 2, 0, false, false);
        }


        public static void printXBool(char character, int length)
        {
            if (length % 2 == 0)
            {
                Console.WriteLine("only works with odd numbers. length got extended by 1\n");
                length += 1;
            }

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    if (Math.Abs(x-length/2) == Math.Abs(y-length/2))
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
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
                    double distanceFromCenter = Math.Pow(x / 2, 2) + Math.Pow(y, 2);
                    double innerEdge = Math.Pow(radius - width, 2);
                    double outerEdge = Math.Pow(radius, 2);

                    if (innerEdge < distanceFromCenter && distanceFromCenter < outerEdge)
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
            int range = 50;
            int yCoord = 0;
            int xCoord = 0;

            for (int y = 0; y < range; y++)
            {
                yCoord = y - range / 2;

                for (int x = 0; x < 50; x++)
                {

                    xCoord = x - range / 2;

                    if (Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2) == 900)
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


        public static void drawCube(char characterOut, char characterIn, int length)
        {
            for (int y = 0; y < length + length/2 - 1; y++)
            {
                if (y == 0 || y == length - 1)
                {
                    printChars(characterOut, length);

                    
                    if (y == length - 1)
                    {
                        printChars(' ', length / 2 - 2);
                        printChars(characterOut, 1);
                    }
                    
                    Console.WriteLine();
                }
                else if (y < length / 2 - 1)
                {
                    printChars(characterOut, 1);
                    printChars(' ', y - 1);
                    printChars(characterIn, 1);
                    printChars(' ', length - y - 2);
                    printChars(characterOut, 1);
                    printChars(' ', y - 1);
                    printChars(characterOut, 1, true);
                }
                else if (y == length/2 - 1)
                {
                    printChars(characterOut, 1);
                    printChars(' ', y - 1);
                    printChars(characterIn, length / 2 + length%2);
                    printChars(characterOut, 1);
                    printChars(characterIn, y - 1);
                    printChars(characterOut, 1, true);

                }
                else if (y < length - 1)
                {
                    printChars(characterOut, 1);
                    printChars(' ', length / 2 - 2);
                    printChars(characterIn, 1);
                    printChars(' ', length / 2 - 1 + length%2);
                    printChars(characterOut, 1);
                    printChars(' ', length / 2 - 2);
                    printChars(characterOut, 1, true);
                }
                else if (y < length + length/2 - 2)
                {
                    printChars(' ', y - length + 1);
                    printChars(characterOut, 1);
                    printChars(' ', length + length / 2 - y - 3);
                    printChars(characterIn, 1);
                    printChars(' ', length/2 + y - length + length%2);
                    printChars(characterOut, 1);
                    printChars(' ', -y + length + length/2 - 3);
                    printChars(characterOut, 1, true);
                }
                else
                {
                    printChars(' ', y - length + 1);
                    printChars(characterOut, length);
                }
            }
        }


        public static void drawCubeConditionTip(char characterOut, char characterIn, int length)
        {
            for (int y = 0; y < length + length / 2 - 1; y++)
            {
                for (int x = 0; x < length + length / 2 - 1; x++)
                {   
                    
                    //solid lines                                                           *** conditions for: ***
                    if (                                                                
                        (x == 0 && y <= length - 1) ||                                  //solid straight top line
                        (y == 0 && x <= length - 1) ||                                  //solid straight bottom/middle line
                        (x == length - 1 && y <= length - 1) ||                         //solid straight right/middle line
                        (y == length - 1 && x <= length - 1) ||                         //solid straight left line
                        (y == x - (length - 1)) ||                                      //solid diagonal top right line
                        (x == y - (length - 1)) ||                                      //solid diagonal bottom left line
                        (x == y && y > length - 1) ||                                   //solid diagonal bottom right line
                        (x == length + length / 2 - 2 && y > length / 2 - 1) ||         //solid straight right line
                        (y == length + length / 2 - 2 && x > length / 2 - 1)            //solid straight bottom line
                       )
                    {
                        Console.Write(characterOut + " ");
                    }

                    //dotted lines
                    else if (
                        (x == y && y < length / 2 - 1) ||                               //dotted diagonal top right line
                        (x == length / 2 - 1 && y > length / 2 - 2) ||                  //dotted straight left line
                        (y == length / 2 - 1 && x > length / 2 - 2)                     //doted straight top line
                            )
                    {
                        Console.Write(characterIn + " ");
                    }

                    //whitespace
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void drawCubeCondition(int length)
        {
            //array initialization
            char[,] toDraw = new char[3 * length + 2, 3 * length + 2];


            //test condition for print
            for (int x = - length; x<=length; x++)
            {
                for (int y = -length; y <= length; y++)
                {
                    for (int z = -length; z <= length; z++)
                    {
                        if(Math.Max(Math.Max(x,y),z) == length)
                        {
                            toDraw[x + ((z + length) / 2) + length, y + ((z + length) / 2) + length] = 'X';
                        }
                        else
                        {
                            toDraw[x + ((z + length) / 2) + length, y + ((z + length) / 2) + length] = ' ';
                        }
                    }
                }
            }

            //print the whole thing
            for (int j = 0; j <= 3 * length + 1; j++)
            {
                for (int i = 0; i <= 3 * length + 1; i++)
                {
                    Console.Write(toDraw[i, j]);
                }
                Console.WriteLine();
            }
        }


        public static void drawPyramid(char characterOut, char characterIn, int diagonal)
        {
            for (int y = 0; y <= diagonal - diagonal / 4; y++)
            {
                for (int x = 0; x <= diagonal; x++)
                {

                    //solid lines                                                           *** conditions for: ***
                    if (
                        (x == diagonal / 2) ||                                              //solid vertical middle line
                        (diagonal / 2 - x == y && y < diagonal) ||                          //solid top left line
                        (x - diagonal / 2 == y && y < diagonal) ||                          //solid top right line
                        (y - diagonal / 2 == (x + 1) / 2) ||                                //solid bottom left line
                        (3 * diagonal / 4 - y == (x - diagonal / 2) / 2)                    //solid bottom right line
                       )
                    {
                        Console.Write(characterOut + " ");
                    }

                    //dotted lines
                    else if (
                        (diagonal / 2 - y == (x + 1) / 2 && x < diagonal / 2) ||            //doted left line
                        (y - diagonal / 4 == ((x - diagonal / 2)) / 2 && x > diagonal / 2)  //doted right line
                            )
                    {
                        Console.Write(characterIn + " ");
                    }

                    //whitespace
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void Method()
        {
            drawPyramid('x', '.', 40);
        }
    }
}

