using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
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
            PrintTriangleBottomLeft("x", 4);
            Console.WriteLine("\n");
            Console.WriteLine("Printing Triangle top left:");
            PrintTriangleTopLeft("x", 5);
            Console.WriteLine("\n");
            Console.WriteLine("Printing Triangle top right:");
            PrintTrianlgeTopRight("x", 5);
            Console.WriteLine("\n");
            Console.WriteLine("Printing Triangle Bottom Right:");
            PrintTriangleBottomRight("x", 5);
            Console.WriteLine("\n");

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
            } while (counter < 10);

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

            for (int k = 0; k < length; k++)
            {


                PrintTheChars(" ", k);
                PrintTheChars(letter, length - k );
                Console.WriteLine("");
               




            }




        }
    }
}



