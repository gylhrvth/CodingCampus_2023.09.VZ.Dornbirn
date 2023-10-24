using Selina.Week04.Arrays;
using Selina.Week04.Ausagbe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week04.TikTakToe
{

    internal class TikTakToe
    {
        static Random rand = new Random();
        public static void Start()
        {

            Ausgabe.Output("Aufgabe: TicTacToe \n", ConsoleColor.DarkMagenta);

            char[,] board = new char[3, 3];
            const char PLAYER = 'X';
            const char COMPUTER = '0';
            char winner = ' ';
            char repeat = 'J';

            do
            {
                ResetBoard(board);

                while (winner == ' ' && CheckFreeSpaces(board) != 0)
                {
                    PrintBoard(board);
                    PayerMove(board, PLAYER);
                    winner = CheckWinner(board);
                    if (winner != ' ' || CheckFreeSpaces(board) == 0)
                    {
                        break;
                    }

                    ComputerMove(board, COMPUTER, PLAYER);
                    winner = CheckWinner(board);
                    if (winner != ' ' || CheckFreeSpaces(board) == 0)
                    {
                        break;
                    }
                }

                PrintBoard(board);
                PrintWinner(winner, PLAYER, COMPUTER);

                if (winner == PLAYER || winner == COMPUTER)
                {
                    Console.Write("Möchtest du nochmal spielen?");
                    repeat = Convert.ToChar(Console.ReadLine());

                    if (repeat == 'N' || repeat == 'n')
                    {
                        repeat = 'N';
                        Console.Clear();
                    }

                    winner = ' ';
                }

            } while (repeat == 'J' || repeat == 'j');

        }

        //Aufagbe 15: TikTacToe
        public static void ResetBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }
        public static void PrintBoard(char[,] board)
        {
            Console.Write($"\n  {board[0, 0]}  | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine($"\n  -----------\t");
            Console.Write($"  {board[1, 0]}  | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine($"\n  -----------\t");
            Console.Write($"  {board[2, 0]}  | {board[2, 1]} | {board[2, 2]}");
            Console.Write("\n");
        }
        public static int CheckFreeSpaces(char[,] board)
        {
            int freeSpaces = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != ' ')
                    {
                        freeSpaces--;
                    }
                }
            }

            return freeSpaces;
        }
        public static void PayerMove(char[,] board, char PLAYER)
        {
            int x;
            int y;
            do
            {
                Console.Write("\nBitte gib eine Zahl von 1-3 ein:");
                x = Convert.ToInt32(Console.ReadLine());
                x--;
                Console.Write("Bitte gib eine Zahl von 1-3 ein:");
                y = Convert.ToInt32(Console.ReadLine());
                y--;

                if (board[x, y] != ' ')
                {
                    Console.WriteLine("Das kann nicht durchgeführt werden!");
                }
                else
                {
                    board[x, y] = PLAYER;
                    break;
                }
            } while (board[x, y] != ' ');
        }
        public static void ComputerMove(char[,] board, char COMPUTER, char PLAYER)
        {
            int x;
            int y;

            if (CheckFreeSpaces(board) > 0)
            {
                do
                {
                    x = rand.Next(0, 3);
                    y = rand.Next(0, 3);

                } while (board[x, y] != ' ');

                board[x, y] = COMPUTER;
            }
            else
            {
                PrintWinner(' ', PLAYER, COMPUTER);
            }

        }
        public static char CheckWinner(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    return board[i, 0];
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[0, j] == board[2, j])
                {
                    return board[0, j];
                }
            }

            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                return board[0, 0];
            }
            if (board[0, 2] == board[1, 1] && board[0, 0] == board[2, 0])
            {
                return board[0, 2];
            }

            return ' ';
        }
        public static void PrintWinner(char winner, char PLAYER, char COMPUTER)
        {
            if (winner == PLAYER)
            {
                bool visible = true;
                do
                {
                    string text = "\nDu hast gewonnen!";
                    Console.ForegroundColor = visible ? ConsoleColor.Cyan : ConsoleColor.Magenta;
                    visible = !visible;
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine(text);
                } while (true);
            }
            else if (winner == COMPUTER)
            {
                Console.WriteLine("Du hast verloren!");
            }
            else
            {
                Console.WriteLine("Niemand hat gewonnen!");
            }
        }
    }
}
