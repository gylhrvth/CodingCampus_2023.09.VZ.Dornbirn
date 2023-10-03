using System.Diagnostics.Metrics;
using System.Drawing;

namespace Cemal.Week01
{
    public class Methoden_Schleifen
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe Print Characters");
            PrintChars("x", 10);

            Console.WriteLine("\nAufgabe Print Square");
            PrintSquare("x", 10);

            Console.WriteLine("\nAufgabe Print Rectangle");
            PrintRectangle("x", 10, 3);

            Console.WriteLine("\nAufgabe Print Trinangle");
            PrintTrinangle("x", 1);

            Console.WriteLine("\nAufgabe Print Trinangle2");
            PrintTrinangle2("x", 5);

            Console.WriteLine("\nAufgabe Print Trinangle3");
            PrintTrinangle3("x", 5);

            Console.WriteLine("\nAufgabe Print Trinangle4");
            PrintTrinangle4("x", 5);

            Console.WriteLine("\nAufgabe Print Empty Square");
            PrintEmptySquare("A", 3);

            Console.WriteLine("\nAufgabe Print Pyramid");
            PrintPyramid("x", 3);
        }

        public static void PrintChars(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintSquare(String symbol, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }

        public static void PrintRectangle(String symbol, int width, int height)
        {
            for (int x = 1; x <= height; x++)
            {
                for (int z = 0; z < width; z++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }

        public static void PrintTrinangle(String symbol1, int count1)
        {
            int law = 1;
            while (law <= 5)
            {
                for (int ya = 1; ya <= count1; ya++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
                count1++;
                law++;
            }
        }
        public static void PrintTrinangle2(String symbol1, int count1)
        {
            int kol = 1;
            while (kol <= 5)
            {
                for (int z = 1; z <= count1; z++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
                count1--;
                kol++;
            }
        }

        public static void PrintTrinangle3(String symbol1, int count1)
        {
            for (int z = 0; z < count1; z++)
            {
                for (int i = 0; i < z; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < count1 - z; i++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
            }
        }


        public static void PrintTrinangle4(String symbol1, int count1)
        {
            for (int z = 0; z < count1; z++)
            {
                for (int i = 1; i < count1 - z; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= z; i++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
            }
                //for (int i = 0; i<count1 - z - 1; i++)
                //{
                //    Console.Write(" ");
                //}
                //for (int i = 0; i <= z* 2; i++)
                //{
                //    Console.Write(symbol1);
                //}
        }

        public static void PrintEmptySquare(String symbol1, int count1)
        {
            PrintChars(symbol1, count1);
            Console.WriteLine();
            for (int i = 2; i < count1; i++)
            {
                Console.Write(symbol1);
                for (int j = 0; j < count1 - 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = count1; k <= count1; k++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
            }
            PrintChars(symbol1, count1);
        }

        public static void PrintSlash()
        {

        }


        //public static void PrintPyramid(String symbol1, int count1)
        //{
        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //}
    }
}
