
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Selina.Week04.Arrays.Menü
{
    internal class Quader
    {
        public static void PrintEmptySquare1()
        {
            Console.Write("\nWie Groß soll Ihr Quader sein? ");
            int square = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int y = 1; y <= square; y++)
            {
                Console.Write("x");
            }

            Console.WriteLine();

            for (int y = 1; y <= square - 2; y++)
            {
                Console.Write("x");

                for (int i = 1; i <= square - 2; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("x");
            }

            for (int i = 1; i <= square; i++)
            {
                Console.Write("x");
            }

        }
    }
}