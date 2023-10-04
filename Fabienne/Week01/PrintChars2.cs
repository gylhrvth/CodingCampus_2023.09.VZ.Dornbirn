using System;
namespace Fabienne.Week01
{
    internal class PrintChars2
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            PrintChars('x', 10, true);
            Console.WriteLine();

            PrintTriangleTopLeft('x', 5);
            Console.WriteLine();

            PrintTriangleTopRight('x', 5);
            Console.WriteLine();

            PrintTriangleBottomLeft('x', 4);
            Console.WriteLine();

            Triangle("x", 7);

           // HalfTriangle("x", 7);
            HalfTriangle("x", 4);

            PrintcirclePythagoras(10);
        }

        public static void PrintChars(char x, int anzahl, bool newline)
        {


            for (int i = 0; i < anzahl; i++)
            {
                Console.Write(x);
            }
            if (newline)
            {
                Console.WriteLine();
            }
        }

        public static void PrintTriangleTopLeft(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleTopLeft (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = anzahl - 1; i > j; i--)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        public static void PrintTriangleTopRight(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleTopRight (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                PrintChars(x, anzahl - j, true);
            }
        }

        public static void PrintTriangleBottomLeft(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleBottomLeft (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("-");
                }

                for ( int k = 9; k > anzahl - 1; k--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();

            }
        }

        public static void Triangle(String symbol, int size)
        {
            Console.WriteLine("Triangle (\'" + symbol + "\', " + size + ")");

            for (int row = 0; row < size; row++)
            {

                for (int col  = 0; col < size * 2 - 1; col++)
                {
                    
                    if (row + size == col + 1 || row == size - col - 1 || row == size - 1)
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

       /* public static void HalfTriangle (String symbol, int size)
        {
            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                for(int col = 0; col < size * 2 - 1; col++)
                {
                    if (row == col || col == size - 1 || row == col - 1 )
                    {
                        Console.Write(symbol);
                    }
                    
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }*/



        public static void HalfTriangle(String symbol, int size)
        {
            Console.WriteLine();

            Console.WriteLine("Half Triangle (\'" + symbol + "\', " + size + ")");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row <= col)
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

        public static void PrintcirclePythagoras(int size)
        {
            Console.WriteLine();

            Console.WriteLine("PrintcirclePythagoras ('x' " + size + ")");

            for(int row = 1 ;row < size * 2; row++)
            {
                for(int col = 1; col < size * 2; col++)
                {
                    if((row - size) * (row - size) + (col - size) * (col - size) <= size * size)
                    {
                        Console.Write("x");
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
