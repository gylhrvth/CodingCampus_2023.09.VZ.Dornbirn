using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week01
{
    internal class Üben
    {
        public static void Start()
        {
            Console.WriteLine("for Schleife");

            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nwhile-Schleife");
            int a = 0;
            while (a <= 10)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("count without 10");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nCount with trick");
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nRewind");
            for (int i = 10; i >= -10; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nPrint Characters");
            PrintChars('x', 10);

            Console.WriteLine("\nPrint Square");
            PrintSquare('x', 10);

            Console.WriteLine("\nPrint Rectangle");
            PrintRect('x', 10, 3);

            Console.WriteLine("\nPrint Triangle Bottom Left");
            PrintTriangleBottomLeft('x', 5);

            Console.WriteLine("\nPrint Triangle Top Left");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\nPrint Triangle Top Right");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Right");
            PrintTriangleBottomRight('x', 5);

            Console.WriteLine("\nPrint Empty Square");
            PrintEmptySquare('x', 10);

            Console.WriteLine("\nPrint Empty Square2");
            PrintEmptySquare('A', 3);

            Console.WriteLine("\nPrint Slash");
            PrintSlash('x', 3, true);

            Console.WriteLine("\nPrint Slash");
            PrintSlash('y', 4, false);

            Console.WriteLine("\nPrint Pyramid");
            PrintPyramid('x', 3);

            Console.WriteLine("\nPrint Pyramid v2");
            PrintPyramid('x', 5);

            Console.WriteLine("\nPrint Pyramid v3");
            PrintPyramid('x', 1);

            Console.WriteLine("\nPrint Rhombus");
            PrintRhombus('x', 10);

            Console.WriteLine("\nPrintX");
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
        // Aufgabe Print Square
        public static void PrintSquare(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number);
                Console.WriteLine();
            }
        }
        // Aufgabe Print Rectangle
        public static void PrintRect(char symbol, int number, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintChars(symbol, number);
                Console.WriteLine();
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
        // Aufgabe Print Triangle Top Left
        public static void PrintTriangleTopLeft(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number - i);
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
        //Aufgabe Print Epty Square
        public static void PrintEmptySquare(char symbol, int number)
        {
            PrintChars(symbol, number);
            Console.WriteLine();
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(symbol);
                PrintChars(' ', number - 2);
                Console.Write(symbol);
                Console.WriteLine();
            }
            PrintChars(symbol, number);
            Console.WriteLine();
        }
        //Aufgabe Print Slash
        public static void PrintSlash(char symbol, int number, bool Slash)
        {
            if (Slash == true)
            {
                for (int i = 0; i < number; i++)
                {
                    PrintChars(' ', i);
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    PrintChars(' ', number - i);
                    Console.WriteLine(symbol);
                }
            }
        }
        //Aufgabe Print Pyramid
        public static void PrintPyramid(char symbol, int number)
        {
            if (number == 1)
            {
                Console.WriteLine(symbol);
            }
            else
            {
                PrintChars(' ', number - 1);
                Console.WriteLine(symbol);
                for (int i = 0; i < number - 2; i++)
                {
                    PrintChars(' ', number - i - 2);
                    Console.Write(symbol);
                    PrintChars(' ', (i * 2) + 1);
                    Console.WriteLine(symbol);
                }
                PrintChars(symbol, (number * 2) - 1);
                Console.WriteLine();
            }
        }
        //Aufgabe Print Rhombus
        public static void PrintRhombus(char symbol, int number)
        {

            PrintChars(' ', number/2);
            Console.WriteLine(symbol);
            for (int i = 0; i < (number/2)-1; i++)
            {
                PrintChars(' ', (number/2) - i - 1);
                Console.Write(symbol);
                PrintChars(' ', (i * 2) + 1);
                Console.WriteLine(symbol);
            }
            

            int b = 0;
            for (int i = 0; i < (number + 1) / 2; i++)
            {
                int row = i;
                int space = (number - 1) / 2;
                if (row == (number - 1) / 2)
                {
                    PrintChars(' ', space);
                    Console.Write(symbol);
                    PrintChars(' ', space);
                    Console.WriteLine();
                }
                else
                {
                    int space1 = i;
                    int space2 = b + number - 2;
                    PrintChars(' ', space1);
                    Console.Write(symbol);
                    PrintChars(' ', space2);
                    Console.WriteLine(symbol);
                    b = b - 2;
                }
            }
        }
        //Aufgabe Print X
        public static void PrintX(char symbol, int number)
        {
            int hnumber = number / 2;
            for (int i = 0; i < hnumber; i++)
            {
                PrintChars(' ', i);
                Console.Write(symbol);
                PrintChars(' ', hnumber + 1 - (i * 2));
                Console.WriteLine(symbol);
            }
            PrintChars(' ', number / 2);
            Console.WriteLine(symbol);
            for (int i = 0; i < hnumber; i++)
            {
                PrintChars(' ', hnumber - i - 1);
                Console.Write(symbol);
                PrintChars(' ', (i * 2) + 1);
                Console.WriteLine(symbol);
            }
        }

    }
}
