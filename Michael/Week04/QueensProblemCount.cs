using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week04
{
    internal class QueensProblemCount
    {
        public static int numberOfSolutions = 0;
        public static int toPlaceQueens = 0;


        public static int Start(int numberOfQueens)
        {
            numberOfSolutions = 0;
            toPlaceQueens = numberOfQueens;
            bool[,] field = new bool[numberOfQueens, numberOfQueens];

            for (int i = 0; i < toPlaceQueens; i++)
            {
                PlaceNext(field, (0, i), 1);
            }
            return numberOfSolutions;
        }


        public static bool PlaceNext(bool[,] field, (int,int) newQueen, int nthQueen)
        {
            field[newQueen.Item1, newQueen.Item2] = true;

            if (nthQueen == toPlaceQueens)
            {
                numberOfSolutions++;
                //PrintField(field);
                //Console.WriteLine();
                return true;
            }

            (int, int) currentPosition = (newQueen.Item1 + 1, 0);

            while (currentPosition.Item2 < toPlaceQueens)
            {
                if (IsSafe(field, currentPosition))
                {
                    if(PlaceNext(field, currentPosition, nthQueen + 1))
                    {
                        currentPosition.Item2++;
                    }
                    else
                    {
                        currentPosition.Item2++;
                    }

                }
                else
                {
                    currentPosition.Item2++;
                }
            }
            field[newQueen.Item1, newQueen.Item2] = false;
            return false;
        }


        public static void PrintField(bool[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int column = 0; column < field.GetLength(1); column++)
                {
                    if (field[row, column])
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static bool IsSafe(bool[,] field, (int, int) location)
        {
            bool safe = true;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] && location != (i, j))
                    {
                        if ((location.Item2 == j) ||
                            (location.Item1 == i) ||
                            (location.Item1 + location.Item2 == i + j) ||
                            (location.Item1 - location.Item2 == i - j))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
