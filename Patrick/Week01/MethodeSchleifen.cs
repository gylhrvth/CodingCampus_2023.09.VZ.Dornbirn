﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick.Week01
{
    internal class MethodeSchleifen
    {
        public static void Start()
        {
            printChars("x", 10);
            printSquare("x", 10);
            printRect("x", 20, 8);
            printTriangleBottomLeft("x", 5);
            printTriangleTopLeft("x", 5);
            printTriangleTopRight("x", 5);
            printTriangleBottomRight("x", 5);
            printEmptySquare("x", 10);
            printEmptySquare1("A", 3);
            printSlash("x", 3);
            printSlash1("y", 4);
            printTriangle("x", 5);
        }


        public static void printChars(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                Console.Write(symbol);
            }
        }


        public static void printSquare(string symbol, int count)
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            for (int y = 0; y < count; y++)
            {
                Console.Write(symbol);
                for (int x = 1; x < count; x++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printRect(string symbol, int countx, int county)
        {
            for (int y = 0; y < county; y++)
            {
                Console.Write(symbol);

                for (int x = 0; x < countx - 1; x++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printTriangleBottomLeft(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {

                for (int y = 0; y < x + 1; y++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printTriangleTopLeft(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int y = count - x; y > 0; y--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printTriangleTopRight(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (x == 0 || x <= y)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printTriangleBottomRight(string symbol, int count)
        {
            for (int x = 0; x < count + 1; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (y >= count - x)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printEmptySquare(string symbol, int count)
        {
            printChars(symbol, count);
            Console.WriteLine();

            for (int x = 0; x < count - 2; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (y == 0 || y == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            printChars(symbol, count);
            Console.WriteLine();

            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printEmptySquare1(string symbol, int count)
        {
            printChars(symbol, count);
            Console.WriteLine();

            for (int x = 0; x < count - 2; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (y == 0 || y == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            printChars(symbol, count);
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printSlash(string symbol, int count)
        {

            for (int x = 0; x < count; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (y == x)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printSlash1(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (x == count - y - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
        }

        public static void printTriangle(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                for (int y = 0; y < count + 2; y++)
                {
                    if (x == 0 && y == count  )
                    {
                        Console.Write(symbol);
                    }
                    else if (x ==  && y % 2 == 1)
                    {
                        Console.Write(symbol);
                    }
                    else if ( x == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

           // printChars(symbol, count + 2);

        }


    }
}




