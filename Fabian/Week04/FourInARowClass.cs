using static Fabian.Week03.Arrays;
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
            Week03.TicTacToeClass.Print2DArray(playGround);

            while (true)
            {
                try
                {
                    int p1 = UserInput4IR(1); //user input player 1
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
                            p1 = UserInput4IR(1); //input for the new column
                        }
                    } while (columnFull);

                    Week03.TicTacToeClass.Print2DArray(playGround);

                    if (CheckWinVertical4IR(playGround, 1) || CheckWinHorizontal4IR(playGround, 1) || CheckWinDiagonal4IR(playGround, 1))
                    {
                        Console.WriteLine("player 1 won!");
                        if (AskToPlayAgain())
                        {
                            FourInARow();
                        }
                        else
                        {
                            return;
                        }
                    }

                    int p2 = UserInput4IR(2); //user input player 2
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
                            p2 = UserInput4IR(2); //input for the new column
                        }
                    } while (columnFull);

                    Week03.TicTacToeClass.Print2DArray(playGround);
                    count++;

                    if (CheckWinVertical4IR(playGround, 2) || CheckWinHorizontal4IR(playGround, 2) || CheckWinDiagonal4IR(playGround, 2))
                    {
                        Console.WriteLine("player 1 won!");
                        if (AskToPlayAgain())
                        {
                            FourInARow();
                        }
                        else
                        {
                            return;
                        }
                    }

                    //check if all 0's are overwritten
                    if (count == 21)
                    {
                        Console.WriteLine("You have no turns left!");
                        if (AskToPlayAgain())
                        {
                            FourInARow();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }

            }

        }
        public static int UserInput4IR(int player)
        {
            int num = 0;
            while (num != 1 && num != 2 && num != 3 && num != 4 && num != 5 && num != 6)
            {
                try
                {
                    Console.WriteLine($"Enter column between 1-6 (player {player}): ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
            return num;
        }
        public static bool CheckWinVertical4IR(int[,] arr, int player)
        {
            for (int i = 0; i < arr.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == player && arr[i + 1, j] == player && arr[i + 2, j] == player && arr[i + 3, j] == player)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckWinHorizontal4IR(int[,] arr, int player)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 3; j++)
                {
                    if (arr[i, j] == player && arr[i, j + 1] == player && arr[i, j + 2] == player && arr[i, j + 3] == player)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckWinDiagonal4IR(int[,] arr, int player)
        {
            for (int i = 0; i < arr.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == player && arr[i + 1, j - 1] == player && arr[i + 2, j - 2] == player && arr[i + 3, j - 3] == player)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
