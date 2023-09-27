using System;
namespace Fabienne.Week01
{
    public class Printcharacters
    {
        public static void Start()
        {

            PrintChars('x', 10, true);
            Console.WriteLine();
            PrintChars2('x', 10);
            Console.WriteLine();
            PrintRect('x', 10, 3);
            Console.WriteLine();
            PrintTriangleBottomLeft('x', 4);
            Console.WriteLine();
            PrintTriangleTopLeft('x', 5);
            Console.WriteLine();
            PrintTriangleTopRight('x', 5);
            Console.WriteLine();

        }

        //print chars

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

        //print square

        public static void PrintChars2(char x, int anzahl)
        {

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = 1; i < anzahl; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print rectangle

        public static void PrintRect(char x, int anzahl, int row)
        {

            for (int j = 0; j < row; j++)
            {
                for (int i = 1; i < anzahl; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print triangle

        public static void PrintTriangleBottomLeft(char x, int anzahl)
        {
            for (int j = 0; j < anzahl; j++)
            {
                for (int i = 0; i < j; i++)
                {

                    Console.Write(x);
                }
                Console.WriteLine(x);
            }
        }

        //print triangle 2

        public static void PrintTriangleTopLeft(char x, int anzahl)
        {
            
        }

        //print triangle 3

        public static void PrintTriangleTopRight(char x, int anzahl)
        {

            for (int j = 0; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                PrintChars(x, anzahl - j, true);
               
            }
        }
    }
}
