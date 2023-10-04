using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week02
{
    internal class Booleanexamples
    {
        public static void StartBooleanExamples()
        {
            Console.WriteLine("Aufgabe Print Chars");
            PrintChars("x", 5);
            Console.WriteLine();

            Console.WriteLine("Aufgabe Print Slash");
            PrintSlash("x", 3, true);
            Console.WriteLine();

            Console.WriteLine("Aufgabe Print Pyramid");
            PrintPyramid("x", 5);
            Console.WriteLine();


        }


        public static void PrintChars(String symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }


        public static void PrintSlash(String symbol, int count, bool cas)
        {
            if (cas == true)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int y = 0; y < i; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }

            if (cas == false)
            {
                count = 4;
                symbol = "y";

                for (int i = 0; i < count; i++)
                {
                    for (int y = i; y < count; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintPyramid(string symbol, int count)
        {
            for(int row = 0; row < count; row++)
            {
                for (int column = 0; column < count * 2; column++)
                {
                    Console.Write(".");
                    if (row + column == 4)
                    {
                        Console.Write(symbol);
                    }

                    else if (column == row)
                    {
                        Console.Write(symbol);
                    }

                    else if (column - row == 4)
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }

        }


    }
}
