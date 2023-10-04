using System;
namespace Mohammed.Week01
{
    public class Day03Methoden
    {

        public Day03Methoden()
        {
        }

        public static void Start()
        {
            Console.WriteLine("Writing line of characters:");
            PrintChars("n", 10);
            Console.WriteLine();

            Console.WriteLine("Writing line character square:");
            PrintSquare("x", 9);
            Console.WriteLine();

            Console.WriteLine("Writing Rectangle:");
            printRect("z", 10, 3);
            Console.WriteLine();


            Console.WriteLine("writing Trinangle:");
            //printTriangleBottomLeft("a", 4);
            Console.WriteLine();
        }

        

        public static void PrintChars(string symbol, int count)
        {
            for (int n = 0; n < count; n++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSquare(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {

                PrintChars(symbol, count);
                Console.WriteLine(symbol);
            }
        }

        public static void printRect(string symbol, int column, int rows)
        {

            for (int z = 0; z < rows; z++)
            {
                PrintChars(symbol, column);
                Console.WriteLine(symbol);
            }
        }


        public static void printTriangleBottomLeft(string symbol, int rows, int column)
        {
            for (int a = 0; a < rows; a++)
            {
                PrintChars(symbol,rows);
                Console.WriteLine(column); 
            }
        }
        



    }
}


