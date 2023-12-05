using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Michael.Week09.Sudoku
{
    internal class Sudoku
    {
        public static List<int>[,] Field = new List<int>[9, 9];

        public static void Start()
        {
            for(int row = 0; row < Field.GetLength(0); row++)
            {
                for(int col = 0; col < Field.GetLength(1); col++)
                {
                    Field[row, col] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
            }

            bool somethingHappened = true;

            Field[0,2] = new List<int> { 3};
            Field[1,3] = new List<int> { 1};
            Field[1,4] = new List<int> { 9};
            Field[1,5] = new List<int> { 5};
            Field[2,2] = new List<int> { 8};
            Field[2,7] = new List<int> { 6};
            Field[3,0] = new List<int> { 8};
            Field[3,4] = new List<int> { 6};
            Field[4,1] = new List<int> { 4};
            Field[4,3] = new List<int> { 8};
            Field[4,8] = new List<int> { 1};
            Field[5,4] = new List<int> { 2};
            Field[6,1] = new List<int> { 6};
            Field[6,6] = new List<int> { 2};
            Field[6,7] = new List<int> { 8};
            Field[7,3] = new List<int> { 4};
            Field[7,4] = new List<int> { 1};
            Field[7,5] = new List<int> { 9};
            Field[7,8] = new List<int> { 5};
            Field[8,7] = new List<int> { 7};

            while (somethingHappened)
            {
                somethingHappened = false;
                for (int row = 0; row < Field.GetLength(0); row++)
                {
                    for (int col = 0; col < Field.GetLength(1); col++)
                    {
                        for (int i = Field[row, col].Count - 1; i >= 0; i--)
                        {
                            int num = Field[row, col][i];

                            if (InRow(num, row, col) || InCol(num, row, col) || InBox(num, row, col))
                            {
                                Field[row, col].Remove(num);
                                somethingHappened = true;
                            }
                        }
                    }
                }
            }

            PrintField();
        }


        public static void PrintField()
        {
            for (int row = 0; row < Field.GetLength(0); row++)
            {
                for (int col = 0; col < Field.GetLength(1); col++)
                {
                    if (Field[row, col].Count == 1)
                    {
                        Console.Write(Field[row, col][0] + " ");
                    }
                    else if (Field[row, col].Count == 0)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Field[row, col].Count + " ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }


        public static bool InRow(int num, int row, int col)
        {
            for (int colIn = 0; colIn < Field.GetLength(1); colIn++)
            {
                if (Field[row, colIn].Count == 1)
                {
                    if (Field[row, colIn][0] == num && col != colIn) return true;
                }
            }

            return false;
        }


        public static bool InCol(int num, int row, int col)
        {
            for (int rowIn = 0; rowIn < Field.GetLength(0); rowIn++)
            {
                if (Field[rowIn, col].Count == 1)
                {
                    if (Field[rowIn, col][0] == num && row != rowIn) return true;
                }
            }

            return false;
        }


        public static bool InBox(int num, int row, int col)
        {
            int boxRow = row / 3;
            int boxCol = col / 3;

            for (int rowOff = 0; rowOff < 3; rowOff++)
            {
                for (int colOff = 0; colOff < 3; colOff++)
                {
                    int rowPos = 3 * boxRow + rowOff;
                    int colPos = 3 * boxCol + colOff;
                    if (Field[rowPos, colPos].Count == 1 && !(rowPos == row && colPos == col))
                    {
                        if (Field[rowPos, colPos][0] == num) return true;
                    }
                }
            }

            return false;
        }



    }
}
