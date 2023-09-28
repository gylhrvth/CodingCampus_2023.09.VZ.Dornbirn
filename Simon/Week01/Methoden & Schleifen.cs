using System;
using System.Collections.Generic;
using System.Linq;
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
            PrintSlash('x', 3, false);

            


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

                    PrintTriangleBottomRight(symbol, number);
        }



            }


        }







    }
}
