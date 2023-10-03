using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size*2+1; j++)
                {
                    if (i == size-1 || j == size)
                    {
                        Console.Write(number);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

        }
    }

}
