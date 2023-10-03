using System;
using System.Xml.Linq;

namespace Eren.Week01
{
    public class MethodsLoops


    //*Erstelle eine Methode die eine bestimmte Anzahl parameterisierbarer Zeichen einer Zeile ausgibt.*//
    {
        public static void Start()
        {

            PrintChars("x", 10);
            Console.WriteLine();



            Console.WriteLine("Aufgabe: Print Square");
            Printsquare("x", 4);
            Console.WriteLine();


            Console.WriteLine("Aufgabe: Print Rectangle");
            PrintRect("x", 10, 3);
            Console.WriteLine();


            Console.WriteLine("Aufgabe: Print Trinangle (1)");
            printTriangleBottomLeft("x", 4);

            Console.WriteLine("");
            Console.WriteLine("Aufgabe: Print Trinangle (2)");


            printTriangleTopLeft2("x", 5);

            Console.WriteLine("");
            Console.WriteLine("Aufgabe: Print Trinangle (3)");

            PrintTriangleTopRight("x", 5);

            Console.WriteLine("");
            Console.WriteLine("Aufgabe: Print Trinangle (4)\n");

            PrintTriangleBottomRight("x", 5);

            Console.WriteLine("");
            Console.WriteLine("Aufgabe: Print Empty Square");

            PrintEmptySquare("x", 10);
            Console.WriteLine("");

            Console.WriteLine("Aufgabe: Print Empty Square2");

            PrintEmptySquare2("A", 3);
            Console.WriteLine();


            Console.WriteLine("Aufgabe: Print Square2");
            Printsquare2("A", 10);
            Console.WriteLine();

            Console.WriteLine("Aufgabe: Print Square2");
            PrintRect2("A", 10, 3);
            Console.WriteLine();
        }

        public static void PrintChars(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);

            }
        }

        //*Erstelle eine Methode welche ein Quader mit variabler Größe und mit angegebenem Zeichen ausgibt.*//

        public static void Printsquare(string symbol, int v2)
        {

            for (int h = 0; h < v2; h++)
            {

                for (int x = 0; x < v2; x++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        //* Erstelle eine Methode welche ein Viereck mit variabler Größe und mit angegebenem Zeichen ausgibt.*//

        public static void PrintRect(string symbol, int v3, int v4)
        {

            for (int y = 0; y < v4; y++)
            {

                for (int j = 0; j < v3; j++)
                {
                    Console.Write(symbol);
                }


                Console.WriteLine(symbol);


            }

        }

        //*Erstelle eine Methode welche ein Dreieck mit variabler Größe und mit angegebenem Zeichen ausgibt.

        public static void printTriangleBottomLeft(string symbol, int g)
        {
            for (int m1 = 1; m1 <= g; m1++)
            {
                PrintChars(symbol, m1);
                Console.WriteLine("");

            }


        }

        //*Erstelle eine Methode welche ein Dreieck mit variabler Größe und mit angegebenem Zeichen ausgibt.



        //public static void printTriangleTopLeft(string symbol, int height)
        //{
        //    for (int row = height; row > 0; row--)
        //    {
        //        PrintChars(symbol, row);
        //        Console.WriteLine();
        //    }
        //}



        public static void printTriangleTopLeft2(string symbol, int height)
        {
            for (int row = 0; row < height; row++)
            {
                int symbolCount = height - row;

                PrintChars(symbol, symbolCount);

                Console.WriteLine();


            }


        }

        //*Erstelle eine Methode welche ein Dreieck mit variabler Größe und mit angegebenem Zeichen ausgibt.



        public static void PrintTriangleTopRight(string symbol, int height)
        {
            for (int row = 0; row < height; row++)

            {

                int symbolCount = height - row;//* rechnet jedes loop, 1.mal 5 - 0 = 0 also 5 x usw
                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                PrintChars(symbol, symbolCount);
                Console.WriteLine();

            }


        }

        //*Erstelle eine Methode welche ein Dreieck mit variabler Größe und mit angegebenem Zeichen ausgibt.



        public static void PrintTriangleBottomRight(string symbol, int height)
        {
            for (int row = 0; row < height; row++)

            {
                //* int space;
                int symbolCount = height - row;
                PrintChars(" ", symbolCount);
                for (int space = 0; space <= row; space++)
                {
                    Console.Write(symbol);
                }


                Console.WriteLine();

            }


        }

        //*Erstelle eine Methode welche ein Quader mit variabler Größe und mit angegebenem Zeichen ausgibt.

        public static void PrintEmptySquare(string symbol, int height)


        {
            for (int straight = 0; straight < height; straight++)
            {
                Console.Write(symbol);

            }

            Console.WriteLine();

            //*Diagonal


            for (int diagonal = 0; diagonal < height - 2; diagonal++)
            {
                Console.Write(symbol);
                for (int space = 0; space < height - 2; space++)
                {

                    Console.Write(" ");

                }
                Console.WriteLine(symbol);

            }


            //* Diagonal

            if (height >= 2)
            {
                for (int straight = 0; straight < height; straight++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }




        }

        public static void PrintEmptySquare2(string symbol, int height)
        {
            for (int straight = 0; straight < height; straight++)
            {
                Console.Write(symbol);

            }

            Console.WriteLine();

            //*Diagonal


            for (int diagonal = 0; diagonal < height - 2; diagonal++)
            {
                Console.Write(symbol);
                for (int space = 0; space < height - 2; space++)
                {

                    Console.Write(" ");

                }
                Console.WriteLine(symbol);

            }


            //* Diagonal

            if (height >= 2)
            {
                for (int straight = 0; straight < height; straight++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }

        }


        public static void PrintSlash(string symbol, int height)
        {


        }





        //* If else -----------------------------------------------

        public static void Printsquare2(string symbol, int size)
        {

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col >= row)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write("A");
                    }
                }
                Console.WriteLine();
            }



        }


        public static void PrintRect2(string symbol, int width, int length)
        {

            for (int row = 0; row < length; row++)
            {

                for (int col = 0; col < width; col++)
                {
                    if( col >= row)
                    {
                        Console.Write(symbol);
                    }

                    else
                    {
                        Console.WriteLine();
                    }
                           

                }


            }






        }


    }



}























