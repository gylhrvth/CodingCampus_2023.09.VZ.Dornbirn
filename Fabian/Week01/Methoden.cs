using System;

namespace Fabian.Week01
{
    public class Methoden
    {

       
        public static void Start()
        {
            Console.WriteLine("\nprint chars: ");
            PrintChars("x", 10, true);

            Console.WriteLine("\nprint square: ");
            PrintSquare("x", 10);

            Console.WriteLine("\nprint rectangle: ");
            PrintRectangle("x", 10, 3);

            Console.WriteLine("\n print triangle (1)");
            PrintTriangleBottomLeft("x", 4);

            Console.WriteLine("\n print triangle (2)");
            PrintTriangleTopLeft("x", 5);

            Console.WriteLine("\n print triangle (3)");
            PrintTriangleTopRight("x", 5);

            Console.WriteLine("\n print triangle(4) ");
            PrintTriangleBottomRight("x", 5);

            Console.WriteLine("\n print empty square");
            PrintEmptySquare("x", 10);


        }


        //print characters
        static void PrintChars(String character, int times, bool lineBreak = false)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }

            if (lineBreak)
            {
                Console.WriteLine();
            }
        }

        //print square
        static void PrintSquare(String character, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Methoden.PrintChars(character, rows);
                Console.WriteLine();
            }
        }

        //print rectangle
        static void PrintRectangle(String  character, int columns, int rows)
        {
            for (int i = 0;i < rows; i++)
            {
                Methoden.PrintChars(character, columns);
                Console.WriteLine();
            }
        }

        //´print triangle 1
        static void PrintTriangleBottomLeft(String character, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Methoden.PrintChars(character, i);
                Console.WriteLine(character);
            }
        }

        //print triangle 2 
        static void PrintTriangleTopLeft(String character, int rows)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = rows-1; j > i; j--)
                {
                    Console.Write(character);
                }
                Console.WriteLine(character);
            }
        } 


        //print triangle 3

        public static void PrintTriangleTopRight(String x, int anzahl)
        {

            for (int j = 0; j < anzahl; j++)
            {
                PrintChars(" ", j);
                PrintChars(x, anzahl - j, true);

            }
        }

        //print triangle 4

        public static void PrintTriangleBottomRight(String x, int anzahl)
        {

            for (int i = 0; i < anzahl; i++)
            {
                PrintChars(" ", anzahl - i - 1);
                PrintChars(x, i + 1, true);
            }
        }

        //print empty square
        public static void PrintEmptySquare(String character, int width)
        {
            if(width == 1)
            {
                Console.WriteLine(character);
                return;         
            }
            else if(width <= 0)
            {
                return;
            }
            PrintChars(character, width, true);

            for(int i = 0;i < width-2;i++)
            {
                Console.Write(character);
                PrintChars(" ", width - 2);
                Console.WriteLine(character);
            }

            PrintChars(character, width, true);
        }


    }
}
