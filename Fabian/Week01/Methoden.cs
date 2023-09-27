using System;

namespace Fabian.Week01
{
    public class Methoden
    {

       
        public static void Start()
        {
            PrintChars("x", 10);
            PrintSquare("x", 10);
            PrintRectangle("x", 10, 3);
        }


        //Aufgabe Print Characters
        static void PrintChars(String character, int times)
        {
            Console.WriteLine("\nprint chars: ");
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }
        }

        //Aufgabe Print Square
        static void PrintSquare(String character, int rows)
        {
            Console.WriteLine("\nprint square: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine(character);
            }
        }

        //Aufgabe Print Rectangle
        static void PrintRectangle(String  character, int columns, int rows)
        {
            Console.WriteLine("\nprint rectangle: ");
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine(character);
            }
        }

        //Aufgabe Print Triangle (1)
        static void PrintTriangle1BottomLeft(String character)
        {

        }
    }
}
