﻿using static Fabian.Week03.Arrays;

namespace Fabian.Week03
{
    public class TicTacToeClass
    {
        public static void Start()
        {

        }

        public static void TicTacToe()
        {
            int count = 0;
            int[,] playGround = new int[3, 3];

            //fill array with 0's
            for (int i = 0; i < playGround.GetLength(0); i++)
            {
                for (int j = 0; j < playGround.GetLength(1); j++)
                {
                    playGround[i, j] = 0;
                }
            }
            Print2DArrayTTT(playGround);

            while (true)
            {
                try
                {
                    int p1Row = 0;
                    int p1Col = 0;
                    int p2Row = 0;
                    int p2Col = 0;

                    //enter numbers
                    p1Row = UserInputTTT("row", 1);
                    p1Col = UserInputTTT("column", 1);

                    //check if field is taken
                    while (playGround[p1Row - 1, p1Col - 1] != 0)
                    {
                        Console.WriteLine("This field is already taken!");
                        Print2DArrayTTT(playGround);
                        p1Row = UserInputTTT("row", 1);
                        p1Col = UserInputTTT("column", 1);
                    }
                    //print the 1
                    playGround[p1Row - 1, p1Col - 1] = 1;

                    Print2DArrayTTT(playGround);
                    count++;

                    //check if player 1 won
                    if (CheckWinTTT(playGround, 1))
                    {
                        Console.WriteLine("Player 1 won!");
                        if (AskToPlayAgain())
                        {
                            TicTacToe();
                        }
                        else
                        {
                            return;
                        }
                    }
                    //check if draw
                    else if (count == 9)
                    {
                        Console.WriteLine("its a draw!");
                        if (AskToPlayAgain())
                        {
                            TicTacToe();
                        }
                        else
                        {
                            return;
                        }
                    }

                    //enter numbers
                    p2Row = UserInputTTT("row", 2);
                    p2Col = UserInputTTT("column", 2);

                    //check if field is taken
                    while (playGround[p2Row - 1, p2Col - 1] != 0)
                    {
                        Console.WriteLine("This field is already taken!");
                        Print2DArrayTTT(playGround);
                        p2Row = UserInputTTT("row", 2);
                        p2Col = UserInputTTT("column", 2);
                    }
                    //print the 2
                    playGround[p2Row - 1, p2Col - 1] = 2;

                    Print2DArrayTTT(playGround);
                    count++;

                    //check if player 2 won
                    if (CheckWinTTT(playGround, 2))
                    {
                        Console.WriteLine("Player 2 won!");
                        if (AskToPlayAgain())
                        {
                            TicTacToe();
                        }
                        else
                        {
                            return;
                        }
                    }
                    //check if draw
                    else if (count == 9)
                    {
                        Console.WriteLine("its a draw!");
                        if (AskToPlayAgain())
                        {
                            TicTacToe();
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
        public static bool AskToPlayAgain()
        {
            string playAgain = "";

            while (playAgain != "Y" && playAgain != "N")
            {
                try
                {
                    Console.WriteLine("Do you want to play again? (Y/N)");
                    playAgain = Console.ReadLine();
                    playAgain = playAgain.ToUpper();

                    if (playAgain == "Y")
                    {
                        return true;
                    }
                    else if (playAgain == "N")
                    {
                        return false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid character");
                }
            }

            return false;
        }
        public static int UserInputTTT(string dimension, int player)
        {
            int num = 0;
            while (num != 1 && num != 2 && num != 3)
            {
                try
                {
                    Console.WriteLine($"Enter {dimension} between 1-3 (player {player}): ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
            return num;
        }
        public static bool CheckWinTTT(int[,] arr, int player)
        {
            //horizontal
            if ((arr[0, 0] == player && arr[0, 1] == player && arr[0, 2] == player) || (arr[1, 0] == player && arr[1, 1] == player && arr[1, 2] == player) || (arr[2, 0] == player && arr[2, 1] == player && arr[2, 2] == player))
            {
                return true;
            }
            //vertical
            else if ((arr[0, 0] == player && arr[1, 0] == player && arr[2, 0] == player) || (arr[0, 1] == player && arr[1, 1] == player && arr[2, 1] == player) || (arr[0, 2] == player && arr[1, 2] == player && arr[2, 2] == player))
            {
                return true;
            }
            //diagonal
            else if ((arr[0, 0] == player && arr[1, 1] == player && arr[2, 2] == player) || (arr[0, 2] == player && arr[1, 1] == player && arr[2, 0] == player))
            {
                return true;
            }
            return false;
        }
    }
}