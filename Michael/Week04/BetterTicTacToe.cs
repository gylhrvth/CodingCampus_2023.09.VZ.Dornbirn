using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michael.Week01;

namespace Michael.Week04
{
    internal class BetterTicTacToe
    {
        public static void Start()
        {
            int[,] field = new int[3, 3];
            (int, int) coordinates = (-1, -1);
            int userInput = 0;
            bool firstRound = true;
            Console.WriteLine("you are player 1. your symbol will be X");

            TutorialField();

            for (int round = 0; round < 9; round++)
            {
                int currentPlayer = round % 2 + 1;

                //input of human player
                if (currentPlayer == 1)
                {
                    firstRound = true;
                    do
                    { 
                        if (firstRound)
                        {
                            Console.WriteLine();
                            firstRound = false;
                        }
                        else
                        {
                            Console.Write("sorry, number out of bounds!");
                        }
                        Console.WriteLine("where do you want to place your X?");
                        coordinates = InputToCoordinates(ConsoleInputs.IntInput("", "not a valid number"));
                    } while (coordinates == (-1, -1));
                }
                //input of 'AI' player
                else
                {
                    coordinates = BestNextMove(field, 2);
                }

                Console.WriteLine("checkpoint");

                field[coordinates.Item1, coordinates.Item2] = currentPlayer;

                Console.Clear();

                printField(field, 'X', 'O');
            }
        }


        public static void TutorialField()
        {
            Console.WriteLine(@"
 7 | 8 | 9 
 - + - + - 
 4 | 5 | 6 
 - + - + - 
 1 | 2 | 3
");
        }


        public static (int,int) InputToCoordinates(int choice)
        {
            switch (choice)
            {
                case 1:
                    return (2, 0);
                    break;
                case 2:
                    return (2, 1);
                    break;
                case 3:
                    return (2, 2);
                    break;
                case 4:
                    return (1, 0);
                    break;
                case 5:
                    return (1, 1);
                    break;
                case 6:
                    return (1, 2);
                    break;
                case 7:
                    return (0, 0);
                    break;
                case 8:
                    return (0, 1);
                    break;
                case 9:
                    return (0, 2);
                    break;
            }
            return (-1, -1);
        }


        public static (int,int) BestNextMove(int[,] field, int player)
        {
            //TODO
            return (player, player);
        }


        public static void printField(int[,] field, char player1, char player2)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (field[y, x] == 1)
                    {
                        Console.Write(player1 + " ");
                    }
                    else if (field[y, x] == 2)
                    {
                        Console.Write(player2 + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    if (x < 2)
                    {
                        Console.Write("| ");
                    }
                }

                Console.WriteLine();

                if (y < 2)
                {
                    Console.WriteLine("- + - + - ");
                }
            }
        }


        public static bool winsTicTacToe(int[,] field)
        {
            if (field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2] && field[1, 1] != 0 ||
                field[2, 0] == field[1, 1] && field[1, 1] == field[0, 2] && field[1, 1] != 0)
            {
                return true;
            }
            for (int i = 0; i < 3; i++)
            {
                if (field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2] && field[i, 0] != 0 ||
                    field[0, i] == field[1, i] && field[1, i] == field[2, i] && field[0, i] != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
