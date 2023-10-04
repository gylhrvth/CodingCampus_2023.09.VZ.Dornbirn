using System;

namespace Kerem.Week01
{
    internal class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("PrintCharacter");
            printChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintCharacter");
            printWhile("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintSquare");
            printSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintRectangle");
            printRectangle("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle");
            printTriangleBottomLeft("x", 4);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle2");
            printTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle3");
            printTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintTrinangle4");
            printTriangleBottomRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintEmptySquare");
            printEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintEmptySquare2");
            printEmptySquare2("A", 10);
            Console.WriteLine();

            Console.WriteLine("PrintEmptySquare3");
            printEmptySquare3("A", 3);
            Console.WriteLine();

            Console.WriteLine("printSlash");
            printSlash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("printSlash2");
            printSlash2("y", 4, false);
            Console.WriteLine();


        }
        public static void printChars(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }
        //Beispiel
        public static void printWhile(string symbol, int count)
        {
            int i = 0;
            while (i < count)
            {
                Console.Write(i);
                i++;
            }
        }



        public static void printSquare(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {


                for (int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();



            }

        }
        public static void printRectangle(string symbol, int cols, int rows)
        {
            for (int i = 0; i < rows; i++)
            {

                for (int k = 0; k < cols; k++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

            }
        }
        public static void printTriangleBottomLeft(string symbol, int rows)
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
        public static void printTriangleTopLeft(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {

                for (int j = rows - 1; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);

            }

        }
        public static void printTriangleTopRight(string symbol, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)

                {
                    Console.Write(" ");
                }
                for (int x = 0; x < height - i; x++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }
        public static void printTriangleBottomRight(string symbol, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = height - 1; j > i; j--)
                {
                    Console.Write(" ");


                }
                for (int z = -1; z < i; z++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

            }

        }
        public static void printEmptySquare(string symbol, int height)
        {
            printChars(symbol, height);


            Console.WriteLine();
            for (int z = 0; z < height - 2; z++)
            {
                Console.Write(symbol);
                for (int f = 0; f < height - 2; f++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
                Console.WriteLine();

            }

            printChars(symbol, height);
        }

        //Lehrer
        public static void printEmptySquare2(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == 0 || col == 0 || row == size - 1 || col == size - 1)
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
        //BSP
        public static void printEmptySquare3(string symbol, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == 0 || col == 0 || row == size - 1 || col == size - 1)
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
        public static void printSlash(string symbol, int size, bool Slash)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
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
        public static void printSlash2(string symbol, int size, bool BackSlash)
        {
            if (BackSlash == false)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = i; j < size; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
    }
}










