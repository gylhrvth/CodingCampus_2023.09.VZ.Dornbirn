using System;
using System.Drawing;
using System.Net.WebSockets;

namespace Fabian.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {

            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine($"!false : {!false}");
            Console.WriteLine($"!true : {!true}");
            Console.WriteLine();

            Console.WriteLine($"true and false  : {true && true}");
            Console.WriteLine($"false and true  : {false && true}");
            Console.WriteLine($"false and true  : {false && true}");
            Console.WriteLine($"false and false : {false && false}");
            Console.WriteLine();

            Console.WriteLine($"true and false  : {true || true}");
            Console.WriteLine($"false and true  : {false || true}");
            Console.WriteLine($"false and true  : {false || true}");
            Console.WriteLine($"false and false : {false || false}");
            Console.WriteLine();

            int iX = 5;
            Console.WriteLine($"i == 5 {iX == 5}");
            Console.WriteLine($"i != 5 {iX != 5}");
            Console.WriteLine($"i < 7 {iX < 7}");
            Console.WriteLine($"i <= 7 {iX <= 7}");
            Console.WriteLine($"i > 7 {iX > 7}");
            Console.WriteLine($"i >= 7 {iX >= 7}");
            Console.WriteLine();

            int size = 7;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            PrintTriangleBottomLeft(7);
            Console.WriteLine();
            PrintTriangleTopLeft(7);
            Console.WriteLine();
            PrintTriangleTopRight(7);
            Console.WriteLine();
            PrintTriangleBottomRight(7);
            Console.WriteLine();
            PrintRhombus(7);
        }

        public static void PrintTriangleBottomLeft(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleTopLeft(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = size; j > 0; j--)
                {
                    if (j > i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleTopRight(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleBottomRight(int length)
        {
            for (int i = 0; i <= length; i++)
            {
                for (int j = length; j > 0; j--)
                {
                    if (j <= i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintRhombus(int height)
        {
            height /= 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > 0; j--)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 0; j < height; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < height + 1; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = height; j >= 0; j--)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
