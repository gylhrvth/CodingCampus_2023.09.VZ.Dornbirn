using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week01
{
    internal class Methoden01
    {
        public static void Start()
        {
            PrintSquare("x", 8);
        }
        public static void PrintSquare(String symbol, int count)

        {
            for (int line = 0; line < count; line++)
            {
                
                for (int column = 0; column < count; column++)
                {
                    Console.Write(symbol);
                }
                    Console.WriteLine();

            }
        }

    }
}
