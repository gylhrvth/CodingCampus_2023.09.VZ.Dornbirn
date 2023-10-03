using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week02
{
    internal class Triangle_V2
    {
        public static void Start()
        {
            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPrint Characters");
            PrintChars('x', 10);

            Console.WriteLine("\nPrint Triangle Bottom Left");
            PrintTriangleBottomLeft('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Leftv2");
            PrintTriangleBottomLeftv2('x', 5);

            Console.WriteLine("\nPrint Triangle Top Left");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\nPrint Triangle Top Leftv2");
            //PrintTriangleTopLeftv2('x', 5);

            Console.WriteLine("\nPrint Triangle Top Right");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\nPrint Triangle Top Rightv2");
            //PrintTriangleTopRightv2('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Right");
            PrintTriangleBottomRight('x', 5);

            Console.WriteLine("\nPrint Triangle Bottom Rightv2");
            //PrintTriangleBottomRightv2('x', 5);


        }
        // Aufgabe Print Characters
        public static void PrintChars(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
            }
        }
        // Aufgbe Print Triangle Bottom Left
        public static void PrintTriangleBottomLeft(char symbol, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintChars(symbol, i);
                Console.WriteLine();
            }
        }
        //V2
        



        // Aufgabe Print Triangle Top Left
        public static void PrintTriangleTopLeft(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number - i);
                Console.WriteLine();
            }
        }
        //Aufgabe Print Triangle Top Right
        public static void PrintTriangleTopRight(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(symbol, number - i);
                Console.WriteLine();
                PrintChars(' ', i + 1);
            }
        }
        //Aufgabe Print Triangle Bottom Right
        public static void PrintTriangleBottomRight(char symbol, int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintChars(' ', number - i);
                PrintChars(symbol, i + 1);
                Console.WriteLine();
            }
        }


    }
}
