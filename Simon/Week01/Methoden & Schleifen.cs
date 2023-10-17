using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week01
{
    public class Methoden___Schleifen
    {
        public static void Start()
        {
            Console.WriteLine("\nPrint Characters");
            PrintChars('x', 10);

            Console.WriteLine("\nPrint Square");
            Printsquare('x', 10);

            Console.WriteLine("\nPrint Rectangle");
            PrintRect('x', 10, 3);

            Console.WriteLine("\nPrint Triangle1");
            PrintTriangleBottomLeft('x', 5);

            Console.WriteLine("\nPrint Triangle2");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\nPrint Triangle 3");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\nPrint Triangle 4");
            PrintTriangleBottomRight('x', 5);

            Console.WriteLine("\nPrint Empty Square");
            PrintEmptySquare('x', 10);

            Console.WriteLine("\nPrint Empty Square");
            PrintEmptySquare('A', 3);

            Console.WriteLine("\nPrint Slash");
            PrintSlash('x', 3, true);

            Console.WriteLine("\nPrint Triangle");
            PrintTriangle('x', 3);

            Console.WriteLine("\nPrint Triangle v2");
            PrintTriangle('x', 5);

            Console.WriteLine("\nPrint Triangle v3");
            PrintTriangle('x', 1);

            Console.WriteLine("\nPrint Rhombus");
            PrintRhombus('x', 7);

            Console.WriteLine("\nPrintX");
            PrintX('x', 5);

            Console.WriteLine("\nPrint Christmastree");
            PrintChristmasTree(20, '*');
            PrintChristmasTree(2, '*');

            Console.WriteLine("\nPrint circle Pythagoras");
            PrintCirclePythagoras(10);



        }


        //Aufgabe Print Characters
        public static void PrintChars(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                Console.Write(symbol);
            }
        }
        //Aufgabe Print Square
        public static void Printsquare(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }
        }
        //Aufgabe Print Rectangle
        public static void PrintRect(char symbol, int zahl, int zahl1)
        {
            for (int i = 0; i < zahl1; i++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }

        }

        //Aufgabe Print Triangle (1)

        public static void PrintTriangleBottomLeft(char symbol, int zahl)
        {
            int i = 0;
            while (i < zahl)
            {
                int x = 0;
                while ((x - 1) < i)
                {
                    Console.Write(symbol);
                    x++;
                }
                Console.Write("\n");
                i++;
            }

        }

        //Aufgabe Print Trianble (2)

        public static void PrintTriangleTopLeft(char symbol, int zahl)
        {
            int i = 0;
            while (i < zahl)
            {
                int x = zahl;
                while (x > i)
                {
                    Console.Write(symbol);
                    x--;
                }
                Console.Write("\n");
                i++;
            }

        }

        //Aufgabe Print Triangle (3)

        public static void PrintTriangleTopRight(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                int spaces = i;
                int characters = zahl - i;
                PrintChars(' ', spaces);
                PrintChars(symbol, characters);
                Console.WriteLine();
            }
        }

        //Aufgabe Print Triangle (4)

        public static void PrintTriangleBottomRight(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                int spaces = zahl - i - 1;
                int characters = i + 1;
                PrintChars(' ', spaces);
                PrintChars(symbol, characters);
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

        //Aufgabe Print Rhombus

        public static void PrintRhombus(char symbol, int number)
        {

            int a = 1;
            for (int i = 0; i < (number - 1) / 2; i++)
            {
                int row = i;
                int space = number / 2;

                if (row == 0)
                {
                    PrintChars(' ', space);
                    Console.Write(symbol);
                    PrintChars(' ', space);
                    Console.WriteLine();
                }

                else
                {
                    int space1 = number / 2 - i;
                    int space2 = a;
                    PrintChars(' ', space1);
                    Console.Write(symbol);
                    PrintChars(' ', space2);
                    Console.Write(symbol);
                    Console.WriteLine();
                    a = a + 2;
                }
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
            int a = 1;
            for (int i = 0; i < (number - 1) / 2; i++)
            {

                int space1 = number / 2 - i - 1;
                int space2 = a;
                PrintChars(' ', space1);
                Console.Write(symbol);
                PrintChars(' ', space2);
                Console.Write(symbol);
                Console.WriteLine();
                a = a + 2;
            }
        }
        //benötigt für Christmastree
        public static void PrintCharsString(String symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                Console.Write(symbol);
            }
        }

        //Aufgabe Print Christmastree

        public static void PrintChristmasTree(int number, char symbol)
        {
            //if (number % 3 == 0)
            //{


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
                else if (row == 0)
                {
                    PrintChars(' ', space);
                    Console.Write(symbol);
                    PrintChars(' ', space);
                    Console.WriteLine();
                }
                else
                {
                    int space1 = number - i - 1;
                    int space2 = a;
                    PrintChars(' ', space1);
                    Console.Write(symbol);
                    PrintChars(symbol, space2);
                    Console.Write(symbol);
                    Console.WriteLine();
                    a = a + 2;
                }
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                int space = (number * 2) / 3;
                PrintChars(' ', space);
                PrintChars('+', (number * 2) / 3 - 1);
                Console.WriteLine();
            }
            //}
            /*else
            {
                Console.WriteLine("Bitte gib nur eine Nummer ein die teil der 3er Reihe ist.");
            }*/
        }
        // Bonusaufgabe: Print circle Pythagoras

        public static void PrintCirclePythagoras(int number)
        {

        }
    }

}