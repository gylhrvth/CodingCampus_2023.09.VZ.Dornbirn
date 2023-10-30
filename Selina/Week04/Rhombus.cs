using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Selina.Week04.Arrays.Menü
{
    internal class Rhombus
    {

        public static void PrintRhombus()
        {
            Console.Write("\nWie Groß soll Ihr Rhombus sein sein? ");
            int rhombus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            int i, j, n = rhombus / 2;

            for (i = 0; i < n; i++)
            {
                for (j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= 2 * i; j++)
                {
                    if (j < 2 * i && j > 0)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("x");

                }
                Console.WriteLine();
            }
            for (i = n; i >= 0; i--)
            {
                for (j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= 2 * i - 1; j++)
                {
                    if (j < 2 * i && j > 0)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("x");
                }
                Console.WriteLine("x");
            }

        }
    }
}