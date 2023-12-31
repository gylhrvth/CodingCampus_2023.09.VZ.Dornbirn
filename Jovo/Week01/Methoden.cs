﻿
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Jovo.Week01
{
    public class Methoden
    {


        public static void Start()
{
            
            Console.WriteLine("Printing characters horizontally:");
            PrintChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing square:");
            PrintSquare("x", 5);
            Console.WriteLine();

            Console.WriteLine("Printing square2:");
            PrintSquare2("x", 5);
            Console.WriteLine();

            Console.WriteLine("Printing rectangle");
            PrintRectangle("x", 10, 3);
            Console.WriteLine();


            Console.WriteLine("Printing triangle ");
            PrintTriangle("x", 4);
            Console.WriteLine();


            Console.WriteLine("Printing triangle 2");
            PrintTriangle2("x", 5);
            Console.WriteLine();

            Console.WriteLine("Printing triangle 3");
            PrintTriangle3("x", 5);
            Console.WriteLine();


            Console.WriteLine("Printing triangle 4");
            PrintTriangle4("x", 5);
            Console.WriteLine();


            Console.WriteLine("Printing EmptySquare");
            PrintEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing EmtySquare2");
            PrintEmptySquare2("A", 3);
            Console.WriteLine();

            Console.WriteLine("Printing BackSlash");
            PrintBackslash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("Printing Slash");
            PrintSlash("y", 4, false);
            Console.WriteLine();

            Console.WriteLine("Printing Slash2");
            PrintSlash("y", 4, true);
            Console.WriteLine();

            Console.WriteLine("Printing Triangle");
            PrintTriangle5("x", 3);
            Console.WriteLine();

            Console.WriteLine("Printing TestLehrer");
            PrintTestLehrer("a", 5);
            Console.WriteLine();

            Console.WriteLine("Prinitng TestLehrer2");
            PrintTestLehrer2("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest");
            PrintMeinTest("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest2");
            PrintMeinTest2("x", 10);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest3");
            PrintMeinTest3("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest4");
            PrintMeinTest4("x", 4);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest5");
            PrintMeinTest5("x", 5);
            Console.WriteLine();

            Console.WriteLine("Printing MeinTest6");
            PrintMeinTest6("x", 5);
            Console.WriteLine();
            
            Console.WriteLine("Printing MeinRhombus");
            Methoden2.PrintMeinRhombus("x", 10);
            Console.WriteLine();
            
            
            Console.WriteLine("Printing Christmastree");
            PrintChristmastree(9);
            Console.WriteLine();

            Console.WriteLine("Printing Christmastree2");
            PrintChristmastree2(9);
            Console.WriteLine();

            Console.WriteLine("Printing the Final Pyramid");
            Methoden2.PrintTheFinalPyramid("x", 5);
            Console.WriteLine();


            Console.WriteLine("PrintChristmasTree");
            PrintChristmasTree(9, "x");
            Console.WriteLine();



           

            Console.WriteLine("\nPrint Characters");
            PrintChars2('x', 10);

            Console.WriteLine("PrintRhombus");
            PrintRhombus("x", 7);
            Console.WriteLine();
        }




        public static void PrintChars2(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                Console.Write(symbol);
            }
        }





        //Aufgabe Print Characters
        public static void PrintChars(String character, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }
        }

        //Aufgabe Print Square
        public static void PrintSquare(String symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }

        //Aufgabe Print Square
        public static void PrintSquare2(String symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    PrintChars(symbol, rows);
                    Console.WriteLine();

                }
                return;

            }
        }



        //Aufgabe Print Rectangle

        public static void PrintRectangle(string symbol, int rows, int rows2)
        {
            for (int i = 0; i < rows2; i++)
            {
                PrintChars(symbol, rows);
                Console.WriteLine();

            }

        }


        public static void PrintTriangle(string symbol, int rows)
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine(symbol);
            }

        }





        public static void PrintTriangle2(string symbol, int rows)
        {

            for (int i = 0; i < rows; i++)
            {

                for (int j = rows; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }





        }



        public static void PrintTriangle3(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write(" ");
                }


                for (int j = rows; j > i; j--)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }






        }



        public static void PrintTriangle4(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                {
                    for (int z = rows - 1; z > i; z--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = -1; j < i; j++)
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }

        }


        public static void PrintEmptySquare(string symbol, int rows)
        {



            PrintChars(symbol, rows);





            for (int i = 0; i < rows - 2; i++)
            {
                Console.WriteLine();
                for (int z = rows - 2; z < rows; z++)
                {
                    Console.Write(symbol);
                    for (int f = 0; f < rows - 2; f++)
                        Console.Write(" ");


                }

            }
            Console.WriteLine();
            PrintChars(symbol, rows);

        }


        public static void PrintEmptySquare2(string symbol, int rows)
        {
            PrintChars(symbol, rows);


            for (int i = 0; i < rows - 2; i++)
            {
                Console.WriteLine();
                for (int z = rows - 2; z < rows; z++)
                {
                    Console.Write(symbol);
                    for (int f = 0; f < rows - 2; f++)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
            PrintChars(symbol, rows);
        }









        public static void PrintBackslash(string symbol, int rows, bool Backslash)
        {

            if (Backslash)
            {
                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                    Console.WriteLine();

                }


            }





        }

        public static void PrintSlash(string symbol, int rows, bool Slash)
        {
            if (Slash)
            {
                Console.Write("Richtig!!");

            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = i + 1; j < rows; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                    Console.WriteLine();

                }








            }


        }



        public static void PrintTriangle5(string symbol, int rows)
        {


        }





        public static void PrintTestLehrer(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row + col == size - 1 || row == col)
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
        }





        //weiter 


        public static void PrintTestLehrer2(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size *2-1 ; col++)
                {
                    if (col == size - 1 - row || col == size - 1 + row || row == size - 1)
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
        }




        //







        public static void PrintMeinTest(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        Console.Write(symbol);
                    }
                }
            }

        }
        public static void PrintMeinTest2(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col || row == size - 1 || row == col-2)
                    {
                        Console.Write(symbol);
                    }

                }
                Console.WriteLine();


            }




        }



        public static void PrintMeinTest3(string symbol, int size, int col)
        {
            for (int row = 0; row < col; row++)
            {
                for (int col2 = 0; col2 < col;col2++)
                {



                    if (row == col || row <= size || row == col2)
                    {
                        Console.Write(symbol);
                    }


                }
                
            }

        }


        public static void PrintMeinTest4(string symbol, int size)
        {
            for( int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(col <= row)
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintMeinTest5(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for(int col = 0; col < size; col++)
                {
                    if(col >= row)
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();

            }
        }
        public static void PrintMeinTest6(string symbol, int size)
        {
            for(int row =0; row < size; row++)
            {
                for(int col=0; col < size; col++)
                {
                    if (col >= row)
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
        }



        public static void PrintChristmastree(int size)
        {
            for(int row = 0; row < size * 2 -1 ; row++)
            {
                for (int col = 0; col < size * 2 -1 ; col++)
                {
                    

                    if (row + size -1  == col )
                    {
                        Console.Write("a");
                    }else if (row + col == size -1  )
                    {
                        Console.Write("s");
                    }else if ( row == size/ 2)
                    {
                        Console.Write("f");
                    }
                    else
                    {
                        Console.Write(".");
                    }


                }
                Console.WriteLine();




            }
            


        }
        public static void PrintChristmastree2(int size)
        {
            for ( int row = 0; row < size * 2 -1; row++)
            {
                for (int col = 0; col < size * 2 - 1; col++)
                {
                    if (row >= size -col  )
                    {
                        Console.Write("a");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void PrintChristmasTree(int size, string symbol)
        {
            for (int x = 0; x < size; x++)
            {
                {
                    for (int y = size - 1; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                    for (int z = -1; z < x; z++)
                    {
                        Console.Write(symbol);
                    }
                    for (int z = 0; z < x; z++)
                    {
                        Console.Write(symbol);
                    }
                    for (int y = size; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int y = 0; y < size; ++y)
            {
                Console.Write("O");
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int y = 0; y < size / 4; ++y)
            {
                for (int x1 = 0; x1 < size - 3; ++x1)
                {
                    Console.Write(" ");
                }
                for (int x2 = 0; x2 < size - 4; ++x2)
                {
                    Console.Write("+");
                }
                for (int x3 = 0; x3 < size - 3; ++x3)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintRhombus(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col - size / 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (row - col == size / 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (size / 2 - col == row)
                    {
                        Console.Write(symbol);
                    }
                    else if (row + 1 + col == size + size / 2)
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

        }




    }




}














