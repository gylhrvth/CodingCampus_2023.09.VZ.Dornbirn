using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week13
{
    internal class baum
    {
        public static void Start()
        {
            int size = 15;
            string symbol = "*";

            Baum(size, symbol);
        }
        public static void Baum(int size, string symbol)
        {
            if (size % 2 == 0)
            {
                size++;
            }
            for (int i = size; i > 0; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k < size; k++)
                {
                    Console.Write(symbol);
                }
                for (int k = i; k <= size; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++) { Console.Write("O "); }
            Console.WriteLine();
            for (int a = 0; a < size/4; a++)
            {
                for (int i = size / 2; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (int i = size; i > 0; i--)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

        }

    }

}
