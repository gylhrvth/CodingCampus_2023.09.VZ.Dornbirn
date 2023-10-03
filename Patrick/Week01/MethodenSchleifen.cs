using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week01
{
    internal class MethodenSchleifen
    {

        //public static void start()
        //{
        //    console.writeline("print horizontal characters:");
        //    printchars("x", 10);
        //    console.writeline();

        //    console.writeline("print square:");
        //    printsquare("x", 10);
        //    console.writeline();
        //    console.writeline();
        //    sandbox("x", 5);
        //}

        //public static void printchars(string symbol, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        console.write(symbol);
        //    }
        //}


        //public static void printsquare(string symbol, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        for (int k = 0; k < count; k++)
        //        {
        //            console.write(symbol);
        //        }
        //        console.writeline();
        //    }

        //}


        //public static void start()
        //{
        //    printrect("x", 3, 10);
        //}

        //public static void printrect(string symbol, int count, int count1)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        for (int j = 0; j < count1; j++)
        //        {
        //            console.write(symbol);

        //        }

        //        console.writeline();


        //    }


        //    public static void start()
        //    {
        //        printtrianglebottomleft("x", 4);
        //    }

        //    public static void printtrianglebottomleft(string symbol, int count)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            int symbolcount = i + 1;

        //            for (int j = 0; j < symbolcount; j++)
        //            {
        //                console.write(symbol);

        //            }
        //            console.writeline("");
        //        }
        //    }

        //    public static void start()
        //    {
        //        printtriangletopleft("x", 5);
        //    }

        //    public static void printtriangletopleft(string symbol, int count)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {

        //            for (int j = count; j > i; j--)
        //            {
        //                console.write(symbol);
        //            }
        //            console.writeline("");
        //        }

        //    }



        //    public static void start()
        //    {
        //        printtriangletopright("x", 5);
        //        printchars("x", 10);

        //    }

        //    public static void printtriangletopright(string symbol, int count)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            for (int j = 0; j < count; j++)
        //            {
        //                if (i <= j)
        //                {
        //                    console.write(symbol);
        //                }
        //                else
        //                {
        //                    console.write(".");
        //                }
        //            }
        //            console.writeline();

        //        }

        //        console.writeline("------");

        //        printchars(symbol, count);
        //        console.writeline();

        //        for (int i = 1; i < count; i++)
        //        {
        //            printchars(".", i);
        //            printchars(symbol, count - i);
        //            console.writeline();
        //        }

        // }


        //public static void Start()
        //{
        //    //printTriangleBottomRight("x", 5);
        //}
        //public static void printTriangleBottomRight(string symbol, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        for (int j = 0; j < count; j++)
        //        {
        //            if (i + j >= count - 1)
        //            {
        //                Console.Write(symbol);
        //            }
        //            else
        //            {
        //                Console.Write(" ");
        //            }
        //        }

        //        Console.WriteLine();

        //    }


        //for (int k = 0; k < count; k++)
        //{
        //    for (int l = 4; l > count; l--)
        //    {
        //        Console.Write("0");

        //    }
        //    for (int m = 0; m < count; m++)
        //    {
        //        Console.WriteLine(symbol);
        //    }
        //    Console.WriteLine();
        //}


        public static void Start()
        {
            printEmptySquare("x", 10);
            printEmptySquare2("A", 3);
            printEmptySquare3("A", 3);
            printSlash("x", 3);

        }
        public static void printEmptySquare(string symbol, int count)
        {
            //Ganze Zeile X
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();

            //Zeilen und Spalten X und 0
            for (int zeile = 0; zeile < count; zeile++)
            {
                for (int spalte = 0; spalte < count; spalte++)
                {
                    if (spalte == 0 || spalte == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //Ganze Zeile X
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine("-----");
        }



        public static void printEmptySquare2(string symbol, int count)
        {
            for (int zeile = 0; zeile < count; zeile++)
            {

                for (int spalte = 0; spalte < count; spalte++)
                {
                    if (zeile == 0 || zeile == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (spalte == 0 || spalte == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine("-----");
        }
        public static void printEmptySquare3(string symbol, int row)
        {
            for (int y = 0; y < row; y++)
            {

                Console.WriteLine();
                for (int x = 0; x < row; x++)
                {
                    if (x == 0 || x == row - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (y == 0 || y == row - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine("--------");
        }

        public static void printSlash(string symbol, int counter)
        {
            for (int x = 0; x < counter; x++)
            {
                for (int y = 0; y < counter; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (x == counter - 2 && y == counter - 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (x == counter - 1 && y == counter - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }

        }



    }
}



