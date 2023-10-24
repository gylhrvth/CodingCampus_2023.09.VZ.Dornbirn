using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week04
{
    internal class QueensProblem
    {
        public static void Start(int goal)
        {
            successQueen = false;
            switch (goal)
            {
                case 4:
                case 6:
                    Console.WriteLine("sorry, 4 and 6 are paid DLC");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("sorry, 2 and 3 have no solutions!");
                    break;
                default:
                    bool[,] field = new bool[goal, goal];
                    (int, int) firstQueen = (0, 0);
                    field[firstQueen.Item1, firstQueen.Item2] = true;
            
                    while (true)
                    {
                        if (AddQueen(field, goal, 0, firstQueen))
                        {
                            Console.WriteLine("sucess!");
                            break;
                        }
                        firstQueen = MoveOneAhead(field, firstQueen);
                    }
                    PrintField(field);
                    break;
            }
        }


        public static void PrintField(bool[,] field)
        {
            for (int x = 0; x < field.GetLength(1); x++)
            {
                for (int y = 0; y < field.GetLength(0); y++)
                {
                    if (field[y, x])
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
                    if (field[i, j] && location != (i,j))
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


        public static (int, int) MoveOneAhead(bool[,] field, (int, int) location)
        {
            if (location.Item1 == field.GetLength(0) - 1)
            {
                if (location.Item2 == field.GetLength(0) - 1)
                {
                    field[location.Item1, location.Item2] = false;
                    return (-1, -1);
                }
                else
                {
                    field[location.Item1, location.Item2] = false;
                    location = (0, location.Item2 + 1);
                }
            }
            else
            {
                field[location.Item1, location.Item2] = false;
                location = (location.Item1 + 1, location.Item2);
            }
            field[location.Item1, location.Item2] = true;
            return location;
        }


        public static (int, int) MoveOneBack(bool[,] field, (int,int) location)
        {
            if (location.Item1 == 0)
            {
                if (location.Item2 == 0)
                {
                    field[location.Item1, location.Item2] = false;
                    return (-1, -1);
                }
                else
                {
                    field[location.Item1, location.Item2] = false;
                    location = (field.GetLength(0) - 1, location.Item2 - 1);
                }
            }
            else
            {
                field[location.Item1, location.Item2] = false;
                location = (location.Item1 -1, location.Item2);
            }
            field[location.Item1, location.Item2] = true;
            return location;
        }


        public static bool successQueen = false;


        public static bool AddQueen(bool[,] field, int goal, int placed, (int, int) currentQueen)
        {
            if ((placed >= goal - 1) || successQueen)
            {
                successQueen = true;
                return true;

            }

            if (currentQueen.Item2 == field.GetLength(0) - 1)
            {
                return false;
            }

            (int, int) testPosition = (0, currentQueen.Item2 + 1);

            while (testPosition != (-1, -1))
            {
                if (!IsSafe(field, testPosition))
                {
                    (int, int) testTestPosition;
                    testTestPosition = MoveOneAhead(field, testPosition);

                    if (testTestPosition == (-1, -1))
                    {
                        return false;
                    }
                    else
                    {
                        testPosition = testTestPosition;
                    }
                    continue;
                }

                bool success = AddQueen(field, goal, placed + 1, testPosition);

                if (!success)
                {
                    testPosition = MoveOneAhead(field, testPosition);
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}

