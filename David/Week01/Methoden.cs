using System;
using System.Drawing;

namespace David.Week01
{
    public class Methoden
    {



        public static void Start()

        {
            Console.WriteLine("Print Characters");
            PrintChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("\n\nPrint Square");
            PrintSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("\nPrint Rectangele");
            PrintRect("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("\nPrint Triangle (1)");
            PrintTriangleBottomLeft("x", 4);
            Console.WriteLine();

            Console.WriteLine("-------new-------");
            PrintTriangleBottomLeft2("x", 5);
            Console.WriteLine();
            Console.WriteLine("---------neu-------");

            Console.WriteLine("\nPrint Triangle (2)");
            PrintTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nPrintTriangleTopRight");
            PrintTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nPrintTriangleBottomRight5");
            PrintTriangleBottomRight5("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nprintEmptySquare3");
            PrintEmptySquare3("x", 10);
            Console.WriteLine();

            Console.WriteLine("\nPrintEmptySquare");
            PrintEmptySquare("A", 3);
            Console.WriteLine();

            Console.WriteLine("\nPrintSlash");
            PrintSlash("x", 3);
            Console.WriteLine();



        }
        // Ü1


        public static void PrintChars(String symbol, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSquare(String symbol, int count)
        {
            for (int j = 0; j < count; ++j)
            {
                for (int z = 0; z < count; z++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }

        public static void PrintRect(String symbol, int count, int row)
        {
            for (int q = 0; q < row; q++)
            {
                for (int p = 0; p < count; p++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();


            }
        }

        public static void PrintTriangleBottomLeft(String symbol, int count)
        {
            for (int row = 0; row < count; row++)
            {

                int symbolCount = row + 1;

                for (int col = 0; col < symbolCount; col++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }


        //Sandro Erklärung "X und Y Achse"

        public static void PrintTriangleBottomLeft2(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                PrintChars("x", i);
                Console.WriteLine();
            }

        }


        //Lukas Erklärung "Mathe"
        public static void PrintTriangleBottomRight5(String symbol, int count)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x >= y)
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



        public static void PrintTriangleTopLeft(String symbol, int count)
        {
            for (int row = count; row > 0; row--)
            {
                int symbolCount = row + count;

                for (int with = count; with < symbolCount; with++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }

        public static void PrintTriangleTopRight(String symbol, int count)
        {
            for (int row = 0; row < count; row++)
            {

                for (int space = 0; space < row; space++)
                {
                    Console.Write("0");
                }

                for (int space = count - row; space > 0; space--)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

            }

        }
        //public static void PrintTriangleBottomRight(String symbol, int count)
        //{
        //  for (int i = 0; i < count; i++)
        //{
        //  for (int j = count; j > i; j--)
        //{
        //     Console.Write("5");
        //}
        //
        //
        //  }
        //Console.WriteLine("7");
        //}

        public static void PrintEmptySquare3(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("a");
                    }
                    else if (j == 0)
                    {
                        Console.Write("b");
                    }
                    else if (i == count - 1)
                    {
                        Console.Write("c");
                    }
                    else if (j == count - 1)
                    {
                        Console.Write("d");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
               


            }
        }
        public static void PrintEmptySquare(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (i == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (j == count-1)
                    {
                        Console.Write(symbol);
                    }
                    else if(i == count-1)
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
        public static void PrintSlash(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j= 0; j < count; j++)
                {
                    if ( j < i)
                    {
                        Console.Write(" ");
                    }
                    else if (i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(symbol);
                    }
                    
                }
                Console.WriteLine();
            }
            
        }


    }

}
