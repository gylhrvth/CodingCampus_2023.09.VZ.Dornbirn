using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week02
{
    public class Examples
    {
        public static void PrintTriangle(string symbol, int rows)
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine(symbol);
            }

        }

        
        public static void BerechneFakultaeten()
        {
            for (int i = 1; i <= 20; i++)
            {
                long fakultaet = 1;

                for (int j = 1; j <= i; j++)
                {
                    fakultaet *= j;
                }

                Console.WriteLine(i + "! = " + fakultaet);
            }
        }

        public static void PrintRhombus(string symbol, int size)
        {
            // Obere Hälfte des Rhombus
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(symbol);

                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                }

                Console.WriteLine();
            }

            // Untere Hälfte des Rhombus
            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(symbol);

                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(symbol);
                }

                Console.WriteLine();

            }
        }
        
        
    }
}
