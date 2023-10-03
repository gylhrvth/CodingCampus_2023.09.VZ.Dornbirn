using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Erik.Week01
{

    public class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("Printing line:");
            PrintTheChars("x", 10);
            Console.WriteLine("\n");

            Console.WriteLine("Printing square:");
            PrintSquare("x", 10);
            Console.WriteLine("\n");

            Console.WriteLine("Printing rectangle:");
            PrintRectangle("x", 10, 3);
            Console.WriteLine("\n");

            Console.WriteLine("Printing Triangle bottom left:");
            PrintTriangleBottomLeft("x", 5);
            Console.WriteLine("\n");

            Console.WriteLine("Printing Triangle top left:");
            PrintTriangleTopLeft("x", 5);
            Console.WriteLine("\n");

            Console.WriteLine("Printing Triangle top right:");
            PrintTrianlgeTopRight("x", 5);
            Console.WriteLine("\n");

            Console.WriteLine("Printing Triangle Bottom Right:");
            PrintTriangleBottomRight("x", 10);
            Console.WriteLine("\n");

            Console.WriteLine("Printing Empty Square");
            PrintEmptySquare("A", 3);
            Console.WriteLine("\n");

            Console.WriteLine("Printing the Slash");
            PrintSlash("y", 5, false);
            Console.WriteLine();

            Console.WriteLine("Printing the Triangle");
            PrintTriangle("x", 5);
            Console.WriteLine("");

            Console.WriteLine("Printing the Rhombus");
            PrintRhombus("x", 7);
            Console.WriteLine();

            Console.WriteLine("Printing the X");
            PrintX("x", 5);
            Console.WriteLine();

            Console.WriteLine("Printing the Christmas Tree");
            PrintChristmasTree(9);
            Console.WriteLine();



        }


        public static void PrintTheChars(String letter, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(letter);
            }

        }

        public static void PrintSquare(String letter, int length)
        {
            int counter = 0;
            do
            {
                PrintTheChars(letter, length);
                Console.WriteLine();
                counter++;
            } while (counter <= length);

        }

        public static void PrintRectangle(String letter, int length, int height)
        {
            for (int m = 0; m < height; m++)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine(letter);
            }

        }

        public static void PrintTriangleBottomLeft(String letter, int length)
        {

            for (int k = 0; k < length; k++)
            {

                PrintTheChars(letter, k + 1);
                Console.WriteLine("");


            }
        }

        public static void PrintTriangleTopLeft(String letter, int length)
        {

            for (int k = length; k > 0; k--)
            {

                PrintTheChars(letter, k);
                Console.WriteLine("");

            }

        }
        public static void PrintTrianlgeTopRight(String letter, int length)
        {


            for (int k = 0; k < length; k++)
            {

                PrintTheChars(" ", k);
                PrintTheChars(letter, length - k);
                Console.WriteLine();

            }

        }

        public static void PrintTriangleBottomRight(String letter, int length)
        {
            for (int i = 1; i <= length; i = i + 1)
            {

                //  int letterCount = i + 1;
                //  int spaceCount = length - i - 1;

                PrintTheChars(" ", length - i);
                PrintTheChars(letter, i);
                Console.WriteLine();
            }
        }

        public static void PrintEmptySquare(String letter, int length)
        {
            int squareHeight = length - 2;


            PrintTheChars(letter, length);
            Console.WriteLine();

            for (int i = 0; i < squareHeight; i++)
            {
                Console.Write(letter);
                PrintTheChars(" ", squareHeight);
                Console.WriteLine(letter);
            }

            PrintTheChars(letter, length);
        }




        public static void PrintSlash(String letter, int length, bool isActiv)
        {

            if (isActiv)
            {
                for (int i = 0; i < length; i++)
                {

                    PrintTheChars(" ", i);
                    Console.Write(letter);
                    Console.WriteLine();

                }
            }

            else
            {

                for (int i = 0; i < length; i++)
                {

                    PrintTheChars(" ", length - i - 1);
                    Console.WriteLine(letter);


                }

            }
        }

        public static void PrintTriangle(String letter, int length)
        {

            PrintTheChars(" ", length - 1);
            PrintTheChars(letter, 1);
            Console.WriteLine();




            for (int i = 1; i < length - 1; i++)
            {
                PrintTheChars(" ", length - i - 1);
                PrintTheChars(letter, 1);
                PrintTheChars(" ", 2 * i - 1);
                PrintTheChars(letter, 1);
                Console.WriteLine();

            }

            PrintTheChars(letter, length * 2 - 1);
            Console.WriteLine();




        }


        public static void PrintRhombus(String letter, int length)
        {

            length = length / 2;

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    PrintTheChars(".", i + length - 1);
                    PrintTheChars(letter, 1);   //erster letter
                    Console.WriteLine();

                }
                else if (i < length)                 //obere hälfte 
                {
                    PrintTheChars(".", length - i - 1);
                    PrintTheChars(letter, 1);

                    PrintTheChars(".", 2 * i - 1);
                    PrintTheChars(letter, 1);
                    Console.WriteLine();

                }
            }

            for (int k = 1; k <= length - 1; k++)
            {
                if (k == length - 1)
                {
                    PrintTheChars(".", length - 1);
                    PrintTheChars(letter, 1);   //erster letter
                    Console.WriteLine();

                }
                else
                {
                    PrintTheChars("*", k);
                    PrintTheChars(letter, 1);

                    PrintTheChars("*", 2 * length - 2 * k - 3);                        //PrintTheChars("*", length - 2 * k + 2);
                    PrintTheChars(letter, 1);
                    Console.WriteLine();

                }

            }

        }

        public static void PrintX(String letter, int length)
        {


                if (m == 0)
                {

                    PrintTheChars(letter, 1);
                    PrintTheChars("*", length - 2);
                    PrintTheChars(letter, 1);
                    Console.WriteLine();

                }
                else
                {


                    PrintTheChars(letter, 1);
                    PrintTheChars(".", (length + 1) / 2);
                    PrintTheChars(letter, 1);
                    Console.WriteLine();

                }




            }


        }

    }
}


            //for (int m = 0; m < length; m++)
            //{

            //    if (m < length)
            //    {
            //        PrintTheChars(letter, 1);
            //        PrintTheChars(".", (length + 1) / 2);
            //        PrintTheChars(letter, 1);
            //        Console.WriteLine();

            //    }
            //    else
            //    {


            //        PrintTheChars(letter, 1);
            //        PrintTheChars(".", (length + 1) / 2);
            //        PrintTheChars(letter, 1);
            //        Console.WriteLine();

            //    }




        }
        public static void PrintChristmasTree (int starLength)
        {

            starLength = starLength / 2;

            for (int i = 0; i < starLength; i++)
            {

                PrintTheChars("."  , starLength - i - 1);






            }







        }


    }

}
