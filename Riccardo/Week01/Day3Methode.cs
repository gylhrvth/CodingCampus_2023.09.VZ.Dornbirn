using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Riccardo.Week01
{
    public class Day3Methode
    {
        public Day3Methode()
        {
        }

        public static void Start()
        {
            printChars("x", 10);

            printSquare("x", 10);

            Console.WriteLine("printRect");

            printRect("x", 10, 3);

            Console.WriteLine("printTriangleBottomLeft");

            printTriangleBottomLeft("x", 4);

            Console.WriteLine("printTriangleTopLeft");

            printTriangleTopLeft("x", 5);

            Console.WriteLine("printTriangleTopRight");

            printTriangleTopRight("x", 5);
        }


        public static void printChars(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
                Console.Write(symbol);
        }


        public static void printSquare(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int y = 1; y < count; y++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }

        }

        public static void printRect(string symbol, int count, int column)
        {
            for (int x = 0; x < column; x++)
            {
                for (int v = 0; v < count; v++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        public static void printTriangleBottomLeft(string symbol, int height)
        {
            for (int x = 0; x < height; x++)
            {
                int symbolCount = x + 1;

                for (int y = 0; y < symbolCount; y++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();



            }
        }

        public static void printTriangleTopLeft(string symbol, int height)
        {
            for (int x = 0; x < height; x++)
            {
                int symbolCount = height - x;
                for (int y = 0; y < symbolCount; y++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void printTriangleTopRight(string symbol, int height)
        {
            for (int x = 0; x < height; x++)
            {
                int symbolCount = height - x;

                printChars(" ", x);
                printChars(symbol, symbolCount);


                Console.WriteLine();
            }


            /*
        for (int x = 0; x < height; x++)
        {
            int differenz = height - x;

            for (int y = 0; y < differenz ; y++)
            {
                    printChars(" ", x);
                    printChars(symbol, differenz);
                   

            }
            Console.WriteLine();
            */

            //for (int v = 0; v )

            /*
            string symboldiffernz = " ";

            for (int y = 0; y < height; y++)
            {
                Console.Write(symboldiffernz);
            }
            Console.WriteLine();
            */
        }
    }
}
