using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class PrintChar
    {
        public static void main()
        {
            PrintChars("x", 10, 3);
        }

        public static void PrintChars(string symbol, int count, int row)
        {
            for (int k = 0; k <= row; k++)
            {
                for (int i = 0; i <= count; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }


    }
}
