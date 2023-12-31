﻿namespace DarioLuis.Week01
{
    public class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("\nPrintChars");
            PrintChars("x", 10);

            Console.WriteLine("\nPrint Square");
            PrintSquare("x", 10);

            Console.WriteLine("\nPrint Rect");
            PrintRect("x", 3, 10);

            Console.WriteLine("\nPrintTriangleBottomLeft");
            PrintTriangleBottomLeft("x", 4);

            Console.WriteLine("\nPrintTriangleTopLeft");
            PrintTriangleTopLeft("x", 4);

            Console.WriteLine("\nPrintTriangleTopRight");
            PrintTriangleTopRight("x", 4);

            Console.WriteLine("\nPrintEmptySquare");
            PrintEmptySquare("x", 10);

            Console.WriteLine("\nPrintEmptySquare");
            PrintEmptySquare2("A", 2);

            Console.WriteLine("\nPrintSlash");
            PrintSlash("x", 3, true);
            PrintSlash("x", 4, false);

            Console.WriteLine("\nPrintTriangle");
            PrintTriangle("x", 3);

            Console.WriteLine("\nPrintBigTRiangle");
            PrintBigTriangle("x", 5);

            Console.WriteLine("\nPrintRhombus");
            PrintRhombus("x", 4);

        }

        public static void PrintChars(string character, int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                Console.Write(character);
            }
        }
        public static void PrintSquare(string character, int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                PrintChars(character, rows);
                Console.WriteLine(character);
            }
        }
        public static void PrintRect(string character, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                PrintChars(character, columns);
                Console.WriteLine(character);
            }
        }
        public static void PrintTriangleBottomLeft(string character, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine(character);
            }

        }
        public static void PrintTriangleTopLeft(string character, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = rows - 1; j > i; j--)
                {
                    Console.Write(character);
                }
                Console.WriteLine(character);
            }
        }
        public static void PrintTriangleTopRight(string character, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < rows - i; k++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
        public static void PrintEmptySquare(string character, int size)
        {
            PrintChars(character, size);
            Console.WriteLine("");
            for (int j = 0; j < size - 2; j++)
            {
                Console.Write(character);
                PrintChars(" ", size - 2);
                Console.WriteLine(character);
            }
            PrintChars(character, size);
        }
        public static void PrintEmptySquare2(string character, int size)
        {
            PrintChars(character, size);
            Console.WriteLine("");
            for (int j = 0; j <= size - 2; j++)
            {
                Console.Write(character);
                PrintChars(" ", size - 2);
                Console.WriteLine(character);
            }
            PrintChars(character, size);
        }
        public static void PrintSlash(string character, int rows, bool backslash)
        {
            if (backslash)
            {
                for (int k = 0; k < rows - 2; k++)
                {
                    Console.WriteLine(character);
                    Console.WriteLine(" " + character);
                    Console.WriteLine("  " + character);
                }
            }
            Console.WriteLine("");
            if (backslash)
            {
                Console.WriteLine("   " + "y");
                Console.WriteLine("  " + "y");
                Console.WriteLine(" " + "y");
                Console.WriteLine("y");
            }
        }
        public static void PrintTriangle(string symbol, int zahl)
        {
            if (zahl == 1)
            {
                PrintChars(symbol, zahl);
            }
            else
            {
                PrintChars(" ", zahl - 2);
                Console.WriteLine(symbol);
                int spacedifferent = 1;
                for (int i = 1; i < zahl - 1; i++)
                {
                    int spaces = i;
                    int characters = zahl - i;
                    PrintChars(" ", characters - 2);
                    Console.Write(symbol);
                    for (int a = spacedifferent; a > 0; a--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(symbol);
                    spacedifferent = spacedifferent + 1;
                    Console.WriteLine();
                }
                PrintChars(symbol, (zahl * 2) - 2);
            }
        }
        public static void PrintBigTriangle(string symbol, int zahl)
        {
            if (zahl == 1)
            {
                PrintChars(symbol, zahl);
            }
            else
            {
                PrintChars(" ", zahl - 2);
                Console.WriteLine(symbol);
                int spacedifferent = 1;
                for (int i = 1; i < zahl - 1; i++)
                {
                    int spaces = i;
                    int characters = zahl - i;
                    PrintChars(" ", characters - 2);
                    Console.Write(symbol);
                    for (int a = spacedifferent; a > 0; a--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(symbol);
                    spacedifferent = spacedifferent + 2;
                    Console.WriteLine();
                }
                PrintChars(symbol, (zahl * 2) - 2);
            }
        }
        public static void PrintRhombus(string symbol, int zahl)
        {
            //obere Hälfte
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(symbol);
                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            //untere Hälfte
            for (int i = zahl - 2; i >= 0; i--)
            {
                for (int j = 0; j < zahl - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }
    }
}