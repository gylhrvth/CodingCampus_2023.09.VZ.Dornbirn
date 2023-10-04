using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week02
{
    internal class Triangle_V2
    {
        public static void Start()
        {
            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPrint Characters");
            PrintChars('x', 10);

            Console.WriteLine("\nPrint Triangle Bottom Left");
            PrintTriangleBottomLeft('x', 4);

            Console.WriteLine("\nPrint Triangle Bottom Leftv2");
            PrintTriangleBottomLeftv2('x', 5);

            Console.WriteLine("\nPrint Triangle Top Left");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\nPrint Triangle Top Leftv2");
            PrintTriangleTopLeftv2('x', 5);

            Console.WriteLine("\nPrint Triangle Top Right");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\nPrint Triangle Top Rightv2");
            PrintTriangleTopRightv2('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Right");
            PrintTriangleBottomRight('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Rightv2");
            PrintTriangleBottomRightv2('x', 5);

            Console.WriteLine("\nPrint Empty Square");
            PrintEmptySquare('x', 10);

            Console.WriteLine("\nPrint Empty Squarev2");
            PrintEmptySquarev2('x', 10);

            Console.WriteLine("\nPrint Slash");
            PrintSlash('x', 4, true);

            Console.WriteLine("\nPrint Slashv2");
            PrintSlashv2('x', 5, false);

            Console.WriteLine("\nPrint Pyramid");
            PrintTriangle('x', 5);

            Console.WriteLine("\nPrint Pyramidv2");
            PrintPyramid('x', 5);

            Console.WriteLine("\nPrint Rhombusv2");
            PrintRhombus('x', 11);

            Console.WriteLine("\nPrint Xv2");
            PrintX('x', 5);
        }


        // Aufgabe Print Characters
        public static void PrintChars(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
            }
        }
        // Aufgbe Print Triangle Bottom Left
        public static void PrintTriangleBottomLeft(char symbol, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintChars(symbol, i);
                Console.WriteLine();
            }
        }
        // V2
        public static void PrintTriangleBottomLeftv2(char symbol, int number)
        {
            for (int x = 0; x < number; x++)
            {
                for (int y = 0; y < number; y++)
                {
                    if (x >= y)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }


        // Aufgabe Print Triangle Top Left
        public static void PrintTriangleTopLeft(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number - i);
                Console.WriteLine();
            }
        }
        // V2
        public static void PrintTriangleTopLeftv2(char symbol, int number)
        {
            for (int x = 0; x < number; x++)
            {
                for (int y = 0; y < number; y++)
                {
                    if (x <= (number - 1) - y)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
        //Aufgabe Print Triangle Top Right
        public static void PrintTriangleTopRight(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number - i);
                Console.WriteLine();
                PrintChars(' ', i + 1);
            }
        }
        // V2
        public static void PrintTriangleTopRightv2(char symbol, int number)
        {
            for (int x = 0; x < number; x++)
            {
                for (int y = 0; y < number; y++)
                {
                    if (x <= y)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
        //Aufgabe Print Triangle Bottom Right
        public static void PrintTriangleBottomRight(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(' ', number - i);
                PrintChars(symbol, i + 1);
                Console.WriteLine();
            }
        }
        // V2
        public static void PrintTriangleBottomRightv2(char symbol, int number)
        {
            for (int x = 0; x < number; x++)
            {
                for (int y = 0; y < number; y++)
                {
                    if (x >= (number - 1) - y)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
        //Aufgabe Print Empty Square
        public static void PrintEmptySquare(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                int row = i;


                if (row == 0 || row == number - 1)
                {
                    PrintChars(symbol, number);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(symbol);
                    PrintChars(' ', number - 2);
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
        //v2
        public static void PrintEmptySquarev2(char symbol, int number)
        {
            for (int x = 0; x < number; x++)
            {
                for (int y = 0; y < number; y++)
                {
                    if (x == 0 || x == number - 1 || y == 0 || y == number - 1)
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
        //Aufgabe Print Slash
        public static void PrintSlash(char symbol, int number, bool backslash)
        {
            for (int i = 0; i < number; i++)
            {
                if (backslash == true)
                {
                    int spaces = i;
                    PrintChars(' ', spaces);
                    PrintChars(symbol, 1);
                    Console.WriteLine();
                }
                else
                {
                    int spaces = number - i + 1;
                    PrintChars(' ', spaces - 2);
                    PrintChars(symbol, 1);
                    Console.WriteLine();
                }
            }
        }
        //v2
        public static void PrintSlashv2(char symbol, int number, bool backslash)
        {
            if (backslash == true)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (i == j)
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
            else
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (i == (number - 1) - j)
                        //i == 0 && j == (number - 1) - i || i == 1 && j == (number - 1) - i|| i == 2 && j == (number - 1) - i|| i == 3 && j == (number - 1) - i|| i == 4 && j == (number - 1) - i
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
        }
        //Aufgabe Print Triangle

        public static void PrintTriangle(char symbol, int number)
        {
            int a = 1;
            for (int i = 0; i < number; i++)
            {
                int row = i;
                int space = number - 1;
                if (row == number - 1)
                {
                    PrintChars(symbol, number * 2 - 1);
                    Console.WriteLine();
                }
                else if (row == 0 && number == 1)
                {
                    Console.WriteLine(symbol);
                }
                else if (row == 0)
                {
                    PrintChars(' ', space);
                    Console.Write(symbol);
                    Console.WriteLine();
                }

                else
                {
                    int space1 = number - i - 1;
                    int space2 = a;
                    PrintChars(' ', space1);
                    Console.Write(symbol);
                    PrintChars(' ', space2);
                    Console.Write(symbol);
                    Console.WriteLine();
                    a = a + 2;
                }
            }
        }
        //v2
        public static void PrintPyramid(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < (number * 2) - 1; j++)
                {
                    if (i == (number - 1) - j || i == number - 1 || number + i - 1 == j)
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
        //Print Rhombus v2
        public static void PrintRhombus(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == ((number - 1) / 2) - j || ((number - 1) / 2) + i == j || (number / 2) + i + 1 == j + number || i == ((number - 2) / 2) - j + number)
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
        //Print Rhombus v2 acutally
        public static void PrintRhombusv2(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == ((number - 1) / 2) - j || j == ((number - 1) / 2) + i || (number / 2) + i + 1 == j + number || i == ((number - 2) / 2) - j + number)
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

        //Print X v2
        public static void PrintX(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == (number - 1) - j || i == j)
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


    }
}
