using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Michael.Week04
{
    internal class Recursions
    {
        public static Random rnd = new Random();


        public static void Start()
        {
            QueensProblemAlt(4);
        }


        public static (int, int)[] makeACopyAlt((int, int)[] original)
        {
            (int, int)[] myArray = new (int, int)[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }
            return myArray;
        }


        public static int SumTo(int n)
        {
            if (n == 0) return 0;

            return n + SumTo(n - 1);
        }


        public static int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }


        public static int Fibonacci(int n)
        {
            if (n <= 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        public static void QueensProblem(int size)
        {
            //initialize playing field, queen locations, and the first queen
            int[,] field = new int[size, size];

            (int, int)[] queens = new (int, int)[size];
            (int, int) firstQueen = (rnd.Next(size), rnd.Next(size));

            for (int i = 0; i < size; i++)
            {
                queens[i] = firstQueen;
            }


            //add the last queen and print the field
            queens = AddQueen(queens, size, size);

            PrintField(queens);
        }


        public static void QueensProblemAlt(int size)
        {
            bool[,] field = new bool[size, size];

            Console.WriteLine(AddQueenAlt(field, size));

            Console.WriteLine("rec done");

            PrintFieldAlt(field);
        }


        public static void PrintField((int, int)[] queens)
        {
            int size = queens.Length;

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    bool queenLocation = false;
                    foreach ((int, int) queen in queens)
                    {
                        if (i == queen.Item1 && j == queen.Item2)
                        {
                            queenLocation = true;
                        }
                    }

                    if (!queenLocation)
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void PrintFieldAlt(bool[,] field)
        {
            for (int y = 0; y < field.GetLength(1); y++)
            {
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    if (field[x, y])
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


        public static (int, int)[] AddQueen((int, int)[] queens, int nthQueen, int size)
        {
            if (nthQueen == 1)
            {
                return queens;
            }

            queens = AddQueen(queens, nthQueen - 1, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bool safe = true;
                    foreach ((int, int) queen in queens)
                    {
                        if ((!safe) ||
                            (i == queen.Item1) ||
                            (j == queen.Item2) ||
                            (i - j == queen.Item1 - queen.Item2) ||
                            (i + j == queen.Item1 + queen.Item2))
                        {
                            safe = false;
                        }
                    }

                    if (safe)
                    {
                        queens[nthQueen - 1] = (i, j);
                        return queens;
                    }
                }
            }
            return queens;
        }


        public static int recursionCalls = 0;


        public static bool IsSafe(bool[,] field, (int,int) location)
        {
            bool safe = true;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j])
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


        public static bool AddQueenAlt(bool[,] field, int goal)
        {
            int size = goal - 1;
            (int, int) currentLocation = (0, 0);

            while (true)
            {
                field[currentLocation.Item1, currentLocation.Item2] = true;
                bool success = AddQueenAlt(field, 0, goal, currentLocation);

                if (!success)
                {
                    field[currentLocation.Item1, currentLocation.Item2] = false;
                    if (currentLocation == (size, size))
                    {
                        return false;
                    }
                    else if (currentLocation.Item1 == size)
                    {
                        currentLocation.Item1 = 0;
                        currentLocation.Item2++;
                    }
                    else
                    {
                        currentLocation.Item1++;
                    }
                }
                else
                {
                    return true;
                }
            }






        }


        public static bool AddQueenAlt(bool[,] field, int placed, int goal, (int,int) lastQueen)
        {
            int size = goal - 1;
            Console.WriteLine();
            Console.WriteLine(recursionCalls++);

            PrintFieldAlt(field);


            (int, int) currentLocation = (0, 0);

            if (lastQueen.Item2 == size)
            {
                return false;
            }
            else
            {
                currentLocation = (0, lastQueen.Item2 + 1);
            }

            if (placed >= goal)
            {
                return true;
            }

            while (true)
            {
                while(!IsSafe(field, currentLocation))
                {
                    if (currentLocation == (size, size))
                    {
                        return false;
                    }
                    else if (currentLocation.Item1 == size)
                    {
                        currentLocation.Item1 = 0;
                        currentLocation.Item2++;
                    }
                    else
                    {
                        currentLocation.Item1++;
                    }
                }

                field[currentLocation.Item1, currentLocation.Item2] = true;
                placed++;

                bool nextStepSucceeds = AddQueenAlt(field, placed, goal, currentLocation);

                if (nextStepSucceeds)
                {
                    return true;
                }
                else
                {
                    field[currentLocation.Item1, currentLocation.Item2] = false;

                    if (currentLocation == (size, size) && placed == 0)
                    {
                        return false;
                    }
                    else if (currentLocation.Item1 == size)
                    {
                        currentLocation.Item1 = 0;
                        currentLocation.Item2++;
                    }
                    else
                    {
                        currentLocation.Item1++;
                    }
                    placed--;
                }
            }
        }


    }
}
