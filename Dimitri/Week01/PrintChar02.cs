using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class PrintChar02
    {
        public static void Main()
        {
            PrintEmptySquare("x", 10);
        }

        public static void PrintTriangleBottomLeft(string symbol, int row)
        {
            for (int i = 0; i <= row; i++)
            {
                for (int numrow = 0; numrow <= i; numrow++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
        public static void PrintTriangleTopLeft(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int numrow = 0; numrow < i; numrow++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void PrintTriangleTopRight(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int numspace = row; numspace > i; numspace--)
                {
                    Console.Write(" ");
                }
                for (int numsym = 0; numsym < i; numsym++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        public static void PrintTriangleBottomRight(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                for (int numspace = 0; numspace < i; numspace++)
                {
                    Console.Write(" ");
                }
                for (int numsym = row; numsym >= i; numsym--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void PrintEmptySquare(string symbol, int row)
        {
            for (int i = row; i > 0; i--)
            {
                if (i == 1)
                {
                    for (int j = row; j > 0; j--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                else if (i == row)
                {
                    for (int j = row; j > 0; j--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                } else
                {
                    for (int j = row; j > 0; j--)
                    {
                        for () 
                        {
                        }
                        for () 
                        {
                        }
                        for ()
                        {
                        }
                    }
                    Console.WriteLine();
                }
            }
        }



    }
}
