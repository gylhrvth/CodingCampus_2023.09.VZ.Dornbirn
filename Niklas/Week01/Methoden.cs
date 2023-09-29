using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Threading.Channels;

namespace Niklas.Week01
{
    public class Methoden
    {

        public static void Start()
        {
            Console.WriteLine("\nprint chars: ");
            PrintChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("\nprint Square: ");
            PrintSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("\nprint Rectangle: ");
            PrintRect("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("\nprint Triangle Bottom Left: ");
            PrintTriangleBottomLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nprint Triangle Top Left: ");
            PrintTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nprint Triangle Top Right: ");
            PrintTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nprint Triangle Bottom Right: ");
            PrintTriangleBottomRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("\nprint Empty Square: ");
            PrintEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("\nprint Slash: ");
            PrintSlash("x", 5, false);
            Console.WriteLine();

            Console.WriteLine("\n print Triangle: ");
            PrintTriangle("x", 5);
            Console.WriteLine();

            Console.WriteLine("\n print Rhombus: ");
            PrintRhombus("x", 10);
            Console.WriteLine();

            Console.WriteLine("\n print X: ");
            PrintX("x", 10);
            Console.WriteLine();

            Console.WriteLine("\n print Christmastree: ");
            PrintTree(9);
            Console.WriteLine();
        }

        static void PrintChars(String character, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }

        }



        static void PrintSquare(String character, int times)
        {
            for (int k = 0; k < times; k++)
            {
                for (int j = 0; j < times; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        static void PrintRect(String character, int times, int rows)
        {
            for (int l = 0; l < rows; l++)
            {
                for (int m = 0; m < times; m++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleBottomLeft(String character, int times)
        {
            for (int n = 0; n < times; n++)
            {
                for (int o = 0; o <= n; o++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleTopLeft(String character, int times)
        {
            for (int n = 0; n < times; n++)
            {
                for (int o = times; o > n; o--)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleTopRight(String character, int times)
        {
            for (int n = 0; n < times; n++)
            {
                for (int o = times; o > n; o--)
                {
                    Console.Write(character);
                }
                Console.WriteLine();

                for (int o = 0; o <= n; o++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void PrintTriangleBottomRight(String character, int times)
        {
            for (int n = 0; n <= times; n++)
            {
                for (int o = 0; o < n; o++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();

                for (int o = times; o > n + 1; o--)
                {
                    Console.Write(" ");
                }
            }
        }
        static void PrintEmptySquare(String character, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }

            for (int k = 2; k < times; k++)
            {
                Console.WriteLine();
                Console.Write(character);
                for (int i = 2; i < times; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(character);
            }
            Console.WriteLine();
            for (int i = 0; i < times; i++)
            {
                Console.Write(character);
            }
        }
        static void PrintSlash(String character, int times, bool cases)
        {
            if (cases == true)
            {
                for (int n = 0; n < times; n++)
                {
                    for (int o = 0; o < n + 1; o++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(character);
                }
            }
            else
            {
                for (int n = 0; n < times; n++)
                {
                    for (int o = 0; o < times - n - 1; o++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(character);
                }
            }
        }

        static void PrintTriangle(String character, int times)
        {
            int i, j, n = times;
            for (i = 0; i < n; i++)
            {

                for (j = n - i; j > 1; j--)
                    Console.Write(" ");

                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0 && i != (n - 1))
                        Console.Write(" ");
                    else
                        Console.Write(character);
                }
                Console.WriteLine();
            }

        }

        static void PrintRhombus(String character, int times)
        {
            int i, j, n = times / 2;
            for (i = 0; i < n; i++)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(character);
                }
                Console.WriteLine();
            }

            for (i = n; i >= 0; i--)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(character);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static void PrintX(String character, int times)
        {
            int i, j, n = times/2 / 2;
            for (i = n; i >= 1; i--)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(character);
                }
                Console.WriteLine();
            }


            for (i = 0; i <= n; i++)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(character);
                }
                Console.WriteLine();
            }
        }





        static void PrintTree(int times)
        {
            if (times % 2 == 0)
            {
                times++;
            }
            else { }
            int i, j, n = times;


            for (i = 0; i < n; i++)
            {

                for (j = n - i; j > 1; j--)
                    Console.Write(" ");

                for (j = 0; j <= 2 * i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int a = 0; a < times; a++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int t = 0; t < 2; t++)
            {
                for (int a = 0; a < times / 2; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < times; a++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }

    }
}