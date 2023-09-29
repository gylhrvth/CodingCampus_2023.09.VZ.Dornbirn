using System;
namespace Fabienne.Week01
{
    internal class PrintChars2
    {
        public static void Start()
        {

            PrintChars('x', 10, true);
            Console.WriteLine();

            PrintTriangleTopLeft('x', 5);
            Console.WriteLine();

            PrintTriangleTopRight('x', 5);
            Console.WriteLine();

            PrintTriangleBottomLeft('x', 4);
            Console.WriteLine();
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


    }
}
