using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week01
{
    public class Methoden2
    {

        public static void PrintMeinRhombus(string symbol, int size)
        {

            for (int row = 0; row < 2 * size - 1; row++)
            {
                for (int col = 0; col < 2 * size - 1; col++)
                {
                    if (row + col == size - 1)
                    {
                        Console.Write("A ");
                    }
                    else if (row + size - 1 == col)
                    {
                        Console.Write("B ");
                    }
                    else if (row == col + size - 1)
                    {
                        Console.Write("C ");
                    }
                    else if (row + col == 3 * size - 3)
                    {
                        Console.Write("D ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }

                Console.WriteLine();
            }

        }




        public static void PrintTheFinalPyramid (string symbol, int size)
        {

            for (int row = 0; row < size; row++)
            {

                for ( int col = 0; col < size *2 - 1; col++)
                {
                    
                    if (col == row + size - 1)
                    {
                        Console.Write("a");
                    }
                    else if (col + row == size - 1)
                    {
                        Console.Write("s");

                    }
                    else if (row == size - 1)
                    {

                        Console.Write("f");
                    }

                    
                    else
                    {
                        Console.Write(".");
                    }


                }
                Console.WriteLine();



            }
        }

    }
}
