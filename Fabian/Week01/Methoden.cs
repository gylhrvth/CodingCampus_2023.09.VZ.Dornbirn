using System;


namespace Fabian.Week01
{
    public class Methoden
    {

       
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;

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
            Console.WriteLine();
            PrintEmptySquare("A", 3);

            Console.WriteLine("\n print slash");
            PrintSlash("x", 3, true);
            Console.WriteLine();
            PrintSlash("y", 4, false);

            Console.WriteLine("\n print triangle");
            PrintPyramid("x", 3);
            Console.WriteLine();
            PrintPyramid("x", 5);
            Console.WriteLine();
            PrintPyramid("x", 1);

            Console.WriteLine("print rhombus");
            PrintRhombus("x", 7);

            Console.WriteLine("print x");
            PrintX("x", 11);

            Console.WriteLine("print christmas tree");
            PrintChristmasTree(9);

            /*
            bool toggle = true;
            int i = 0;
            Console.Write("\u001b[31m");
            while (true)
            {
                if(toggle)
                {
                    i++;
                }
                else
                {
                    i--;
                }

                if (i== 30|| i == 0)
                {
                    toggle = !toggle;
                }

                PrintTriangle("x", i);
                Thread.Sleep(1);
                Console.Clear();
            }

            Console.Write("\u001b[31m");
           */
        } 


        //print characters
        public static void PrintChars(String character, int times, bool lineBreak = false)
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
            for (int i = 0; i < rows; i++)
            {
                PrintChars(character, columns);
                Console.WriteLine();
            }
        }

        //´print triangle 1
        static void PrintTriangleBottomLeft(String character, int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                PrintChars(character, i, true);
            }
        }

        //print triangle 2 
        static void PrintTriangleTopLeft(String character, int rows)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = rows; j > i; j--)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
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

            for (int i = 0; i <= anzahl; i++)
            {
                PrintChars(" ", anzahl - i );
                PrintChars(x, i , true);
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

        //print slash
        public static void PrintSlash(String character, int count, bool backSlash)
        {
            if(backSlash)
            {
                for(int i = 0; i < count; i++)
                {
                    PrintChars(" ", i);
                    Console.WriteLine(character);
                }
            }
            else
            {
                for(int i = 0; i < count; i++)
                {
                    PrintChars(" ", count - i - 1);
                    Console.WriteLine(character);
                }
            }
        }

        //print triangle
        public static void PrintPyramid(String character, int height)
        {
            if(height == 1)
            {
                Console.WriteLine(character);
                return;
            }
            else if (height <= 0)
            {
                return;
            }

            PrintChars(" ", height - 1);
            Console.WriteLine(character);
            for (int i = 1; i < height - 1; i++)
            {
                PrintChars(" ", height - i - 1);
                Console.Write(character);
    
                PrintChars(" ", i * 2 - 1);
                Console.WriteLine(character);
            }
            PrintChars(character, height * 2 - 1);
        }

        //print rhombus

        public static void PrintRhombus(String character, int height)
        {
            height /= 2;

            PrintChars(" ", height);
            Console.WriteLine(character);
            for (int i = 1; i < height; i++)
            {

                PrintChars(" ", height - i);
                Console.Write(character);

                PrintChars(" ", i * 2 - 1);
                Console.WriteLine(character);
            }
            for (int j = 0; j < height; j++)
            {
                PrintChars(" ", j);
                Console.Write(character);

                PrintChars(" ", ((height - j) * 2) - 1);
                Console.WriteLine(character);
            }
            PrintChars(" ", height);
            Console.WriteLine(character);
        }

        public static void PrintX(String character, int height)
        {
            height = height / 2 + 1;
            for (int j = 1; j < height; j++)
            {
                PrintChars(" ", j);
                Console.Write(character);

                PrintChars(" ", ((height - j) * 2) - 1);
                Console.WriteLine(character);
            }
            PrintChars(" ", height);
            Console.WriteLine(character);
            for (int i = 1; i < height; i++)
            {
                PrintChars(" ", height - i);
                Console.Write(character);

                PrintChars(" ", i * 2 - 1);
                Console.WriteLine(character);
            }

        }

        //print christmas tree
        public static void PrintChristmasTree(int width)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (width == 1)
            {
                Console.WriteLine("*");
                return;
            }
            else if (width <= 0)
            {
                return;
            }

            PrintChars(" ", width);
            Console.WriteLine("*");
            for (int i = 1; i < width; i++)
            {
                PrintChars(" ", width - i);
                Console.Write("*");

                PrintChars("*", i * 2 - 1);
                Console.WriteLine("*");
            }
            PrintChars("*", width * 2 + 1, true);
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintChars("O ", width + 1, true);
            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < 2; i++) {

                PrintChars(" ", width - ((width - 1)/4));
                PrintChars("+", width - ((width - 1)/2), true);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
