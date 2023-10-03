using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week02
{
    internal class Boolean
    {



        public static void StartBooleanExamples()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine("!false : " + !false);
            Console.WriteLine("!true  : " + !true);

            Console.WriteLine("true and true   :" + (true && true));
            Console.WriteLine("true and false  :" + (true && false));
            Console.WriteLine("false and true  :" + (false && true));
            Console.WriteLine("false and false :" + (false && false));

            Console.WriteLine("true or true   :" + (true || true));
            Console.WriteLine("true or false  :" + (true || false));
            Console.WriteLine("false or true  :" + (false || true));
            Console.WriteLine("false or false :" + (false || false));

            int iX = 5;
            Console.WriteLine("i == 5: " + (iX == 5));
            Console.WriteLine("i != 5: " + (iX != 5));
            Console.WriteLine("i <  7: " + (iX < 7));
            Console.WriteLine("i <= 7: " + (iX <= 7));
            Console.WriteLine("i >  7: " + (iX > 7));
            Console.WriteLine("i >= 7: " + (iX >= 7));
        }

        public static void Start()
        {
            Console.WriteLine("\nPrint Chars: ");
            Chars("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Square: ");
            Square("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Rectangle: ");
            Rectangle("x", 7, 3);
            Console.WriteLine();

            Console.WriteLine("\nPrint Triangle1: ");
            Triangle1("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Triangle2: ");
            Triangle2("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Triangle3: ");
            Triangle3("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Triangle4: ");
            Triangle4("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint EmptySquare: ");
            EmptySquare("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Slash: ");
            Slash("x", 7, false);
            Console.WriteLine();

            Console.WriteLine("\nPrint Pyramid: ");
            Pyramid("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint Rhombus: ");
            Rhombus("x", 13);
            Console.WriteLine();

            Console.WriteLine("\nPrint Rhombus neu: ");
            RhombusNeu("x", 13);
            Console.WriteLine();

            Console.WriteLine("\nPrint X: ");
            X("x", 7);
            Console.WriteLine();

            Console.WriteLine("\nPrint ChistmasTree: ");
            ChristmasTree(7);
            Console.WriteLine();

            Console.WriteLine("\nPrint CirclePythagoras: ");
            CirclePythagoras(20);
            Console.WriteLine();

        }

        static void Chars(String number, int size)
        {

            for (int i = 0; i <= size; i++)
            {
                Console.Write(number);
            }
        }
        static void Square(String number, int size)
        {

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();

            }
        }
        static void Rectangle(String number, int size, int rows)
        {

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();

            }

        }

        static void Triangle1(String number, int size)
        {

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(number);
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }

        static void Triangle2(String number, int size)
        {
            for (int i = size; i >= 0; i--)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(number);
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Triangle3(String number, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write(number);
                    }
                }
                Console.WriteLine();

            }
        }
        static void Triangle4(String number, int size)
        {
            for (int i = size; i >= 0; i--)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write(number);
                    }
                }
                Console.WriteLine();
            }
        }

        static void EmptySquare(String number, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i == 1 || i == size || j == 1 || j == size)
                    {
                        Console.Write(number);
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }
        }
        static void Slash(String number, int size, bool cases)
        {
            if (cases == true)
            {
                for (int n = 0; n < size; n++)
                {
                    for (int o = 0; o < n + 1; o++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(number);
                }
            }
            else
            {
                for (int n = 0; n < size; n++)
                {
                    for (int o = 0; o < size - n - 1; o++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(number);
                }
            }
        }
        static void Pyramid(String number, int size)
        {
            int i, f, n = size;

            for (i = 0; i < size; i++)
            {
                for (f = n - i; f > 1; f--)
                    Console.Write(" ");

                for (f = 0; f <= 2 * i; f++)
                {
                    if (f < 2 * i && f > 0 && i != (n - 1))
                        Console.Write(" ");
                    else
                        Console.Write(number);
                }
                Console.WriteLine();
            }
        }

        static void Rhombus(String number, int size)
        {
            int i, j, n = size / 2;
            for (i = 0; i < n; i++)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(number);
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
                        Console.Write(number);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void RhombusNeu(string number, int size)
        {
            int n = size / 2;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i + j == n || i - n == j || i + n == j || i + j == n * 3)
                    {
                        Console.Write("X ");
                    }

                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }


        static void X(String number, int size)
        {
            int i, j, n = size / 2;
            for (i = n; i >= 0; i--)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(number);
                }
                Console.WriteLine();
            }

            for (i = 1; i <= n; i++)
            {

                for (j = n - i; j > 0; j--)
                    Console.Write(" ");


                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                        Console.Write(" ");
                    else
                        Console.Write(number);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ChristmasTree(int size)
        {
            if (size % 2 == 0)
            {
                size++;
            }
            else { }

            int i, f, n = size;

            for (i = 0; i < size; i++)
            {
                for (f = n - i; f > 1; f--)
                    Console.Write(" ");

                for (f = 0; f <= 2 * i; f++)
                {
                    if (f < 2 * i && f > 0 && i != (n - 1) && i == size)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int a = 0; a < size; a++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int b = 0; b <= size / 4; b++)
            {
                for (int j = 1; j <= size / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < size; a++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void CirclePythagoras(int size)
        {
            int n = size / 2;
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (i + j == size / 4 || i - j == n || i + size / 4 == j)
                    {
                        Console.Write("X  ");
                    }
                    else
                    {
                        Console.Write(".  ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
