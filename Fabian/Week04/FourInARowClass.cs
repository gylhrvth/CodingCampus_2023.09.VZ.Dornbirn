using static Fabian.Week02.ConsoleInput;
using static Fabian.Week03.TicTacToeClass;

namespace Fabian.Week04
{
    public class FourInARowClass
    {
        public static void Start()
        {
            FourInARow();
        }

        public static void FourInARow()
        {
            int count = 0;
            bool columnFull = false;
            int[,] playGround = new int[7, 6];

            // fill array with 0's
            for (int i = 0; i < playGround.GetLength(0); i++)
            {
                for (int j = 0; j < playGround.GetLength(1); j++)
                {
                    playGround[i, j] = 0;
                }
            }
            Print2DArray(playGround);

            while (true)
            {
                int p1 = UserInput("column", 1, 1, 6); //user input player 1
                int i = playGround.GetLength(0) - 1;
                do
                {
                    //Check what place in the column is free and place a 1
                    for (int j = 0; j < playGround.GetLength(0); j++)
                    {
                        if (playGround[0, p1 - 1] != 0)
                        {
                            columnFull = true;
                            break;
                        }
                        else if (i >= 0 && playGround[i, p1 - 1] == 0)
                        {
                            playGround[i, p1 - 1] = 1;
                            columnFull = false;
                            break;
                        }
                        i--;
                    }
                    if (columnFull)
                    {
                        Console.WriteLine("This column is already full!");
                        p1 = UserInput("column", 1, 1, 6); //input for the new column
                    }
                } while (columnFull);

                Print2DArray(playGround);

                if (CheckWinVertical(playGround) || CheckWinHorizontal(playGround) || CheckWinDiagonal(playGround))
                {
                    Console.WriteLine("player 1 won!");
                    if (AskToPlayAgain())
                        FourInARow();
                    else
                        return;
                }

                int p2 = UserInput("column", 2, 1, 6); //user input player 2
                int k = playGround.GetLength(0) - 1;
                do
                {
                    //Check what place in the column is free and place a 2
                    for (int j = 0; j < playGround.GetLength(0); j++)
                    {
                        if (playGround[0, p2 - 1] != 0)
                        {
                            columnFull = true;
                            break;
                        }
                        else if (k >= 0 && playGround[k, p2 - 1] == 0)
                        {
                            playGround[k, p2 - 1] = 2;
                            columnFull = false;
                            break;
                        }
                        k--;
                    }
                    if (columnFull)
                    {
                        Console.WriteLine("This column is already full!");
                        p2 = UserInput("column", 2, 1, 6); //input for the new column
                    }
                } while (columnFull);

                Print2DArray(playGround);
                count++;

                if (CheckWinVertical(playGround) || CheckWinHorizontal(playGround) || CheckWinDiagonal(playGround))
                {
                    Console.WriteLine("player 2 won!");
                    if (AskToPlayAgain())
                        FourInARow();
                    else
                        return;

                }

                //check if all 0's are overwritten
                if (count == 21)
                {
                    Console.WriteLine("You have no turns left!");
                    if (AskToPlayAgain())
                        FourInARow();
                    else
                        return;
                }

            }

        }       
        private static bool CheckWinVertical(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0 && arr[i, j] == arr[i + 1, j] && arr[i + 1, j] == arr[i + 2, j] && arr[i + 2, j] == arr[i + 3, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static bool CheckWinHorizontal(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 3; j++)
                {
                    if (arr[i, j] != 0 && arr[i, j] == arr[i, j + 1] && arr[i, j + 1] == arr[i, j + 2] && arr[i, j + 2] == arr[i, j + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static bool CheckWinDiagonal(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 3; j++)
                {
                    if ((arr[i, j] != 0 && arr[i, j] == arr[i + 1, j + 1] && arr[i + 1, j + 1] == arr[i + 2, j + 2] && arr[i + 2, j + 2] == arr[i + 3, j + 3]) || // top left to bottom right
                        arr[i, j + 3] != 0 && arr[i, j + 3] == arr[i + 1, j + 2] && arr[i + 1, j + 2] == arr[i + 2, j + 1] && arr[i + 2, j + 1] == arr[i + 3, j]) // top right to bottom left
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void Print2DArray(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (arr[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(arr[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }


    }
}
