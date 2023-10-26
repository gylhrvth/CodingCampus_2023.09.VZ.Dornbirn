using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Selina.Week04.Aufgabe
{
    class Christbaum
    {

        public static void PrintChristmastree()
        {
            Console.Write("\nWie Groß soll Ihr Christmastree sein sein? ");
            int tree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int count = 0;
            count = tree - 1;
            for (int k = 1; k <= tree; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < tree; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int i = 0; i <= (tree / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i <= tree / 2; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
            for (int i = 0; i <= (tree / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i <= tree / 2; i++)
            {
                Console.Write("+");
            }
        }
    }
}
