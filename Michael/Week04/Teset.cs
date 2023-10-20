using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week04
{
    internal class CharacterWalk
    {
        public static Random rnd = new Random();


        public static void PrintArea(bool[,] field)
        {
            for (int y = 0; y < field.GetLength(1); y++)
            {
                for (int x =0; x < field.GetLength(0); x++)
                {
                    if (x == 0  || y == 0 || x == field.GetLength(0) - 1 || y == field.GetLength(1) - 1)
                    {
                        Console.Write("X ");
                    }
                    else if (field[x,y] == true)
                    {
                        Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                        Console.Write("O ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }



        public static void Start()
        {
            bool[,] field = { { false, false, false, false }, { false, false, false, false }, { false, false, true, false }, { false, false, false, false } };

            PrintArea(field);
        }

    }
}
