using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week01
{
    public class Methoden
    {
        public static void Start()
        {
            Console.WriteLine("PrintAufgabe1");
            printChars("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintAufgabe2");
            printSquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintTriangleAufgabe1");
            printTriangle1("x", 5);
            Console.WriteLine();

            Console.WriteLine("PrintAufgabe2.1");
            printSquare2("x", 10);
            Console.WriteLine();

            Console.WriteLine("PrintRectangle");
            printRectangle("x", 10, 3);
            Console.WriteLine();

            Console.WriteLine("PrintTrianglebottomleft");
            printTrianglebottomleft("x", 4);
            Console.WriteLine();

            Console.WriteLine("printTriangleTopLeft");
            printTriangleTopLeft("x", 5);
            Console.WriteLine();

            Console.WriteLine("printTriangleTopRight");
            printTriangleTopRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("printTriangleBottomRight");
            printTriangleBottomRight("x", 5);
            Console.WriteLine();

            Console.WriteLine("printEmptySquare");
            printEmptySquare("x", 10);
            Console.WriteLine();

            Console.WriteLine("printEmptySquareA");
            printEmptySquareA("A", 3);
            Console.WriteLine();

            Console.WriteLine("printSlash");
            printSlash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("printSlash");
            printSlash2("y", 4, false);
            Console.WriteLine();

            Console.WriteLine("printPyramid");
            printPyramid("x", 3);
            Console.WriteLine();
           

        }

        public static void printChars(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void printSquare(string symbol, int count)
        {
            //for (int i = 0; i < count * count; i++)
            {
                //if (i % count == 0)
                {
                    //Console.WriteLine();
                }
                //Console.Write(symbol);


                for (int x = 0; x < count; x++)
                {
                    printChars(symbol, count);
                    Console.WriteLine();
                }
            }
        }

        public static void printTriangle1(string symbol, int count)
        {
            for (int i = 1; i <= count - 1; i++)
            {
                Console.WriteLine(new string('x', i));
            }
        }

        public static void printSquare2(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void printRectangle(string symbol, int count, int line)
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
        public static void printTrianglebottomleft(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }
        }
        public static void printTriangleTopLeft(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = row - 1; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }
        }

        public static void printTriangleTopRight(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < row - i; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(" ");
            }
        }
        public static void printTriangleBottomRight(string symbol, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = row - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = row - i; k < row + 1; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void printEmptySquare(string symbol, int row)
        {
            printChars(symbol, row);

            Console.WriteLine();

            for (int i = 0; i < row - 2; i++)
            {

                Console.Write(symbol);


                for (int j = 0; j < row - 2; j++)
                {
                    Console.Write(" ");

                }
                Console.Write(symbol);
                Console.WriteLine();

            }
            printChars(symbol, row);


        }

        public static void printEmptySquareA(string symbol, int row)
        {
            //printEmptySquare(symbol, row);//

            //Console.WriteLine();//
            {
                printChars(symbol, row);

                Console.WriteLine();

                for (int i = 0; i < row - 2; i++)
                {
                    Console.Write(symbol);

                }

                for (int j = 0; j < row - 2; j++)
                {
                    Console.Write(" ");

                }
                Console.Write(symbol);
                Console.WriteLine();

            }
            printChars(symbol, row);
        }
        public static void printSlash(string symbol, int row, bool newline)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i == j)
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

        }
        public static void printSlash2(string symbol, int row, bool backslash)
        {
            if (backslash == false)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = i; j < row; j++)
                    {

                        {
                            Console.Write(" ");

                        }
                       
                    }
                    Console.Write(symbol);
                    Console.WriteLine();

                }
            }
        }
        public static void printPyramid(string symbol, int row)
        {
            for(int i = 0; i <row; i++)
            {
                for(int j = 0; j<row; j++)
                {
                    if (j == i)
                    {
                        Console.WriteLine(symbol);
                        
                    }
                    else
                    {
                        Console.Write(" ");
                        
                    } 
                    
                    
                    
                        
                    
                }
            }
        }
    }
}































