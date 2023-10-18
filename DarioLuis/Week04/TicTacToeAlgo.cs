using System;
using System.Linq;

namespace DarioLuis.Week04
{


    class TicTacToeAlgo
    {
        public static void Main()
        {
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            char humanPlayer = 'X';
            char aiPlayer = 'O';

            PrintBoard(board);

            while (true)
            {
                Console.WriteLine("Dein Zug (0-8): ");
                int move = int.Parse(Console.ReadLine());

                if (board[move] == ' ')
                {
                    board[move] = humanPlayer;
                    PrintBoard(board);
                    if (CheckWin(board, humanPlayer))
                    {
                        Console.WriteLine("Du hast gewonnen!");
                        break;
                    }

                    if (IsBoardFull(board))
                    {
                        Console.WriteLine("Unentschieden!");
                        break;
                    }

                    int aiMove = Minimax(board, aiPlayer).Move;
                    board[aiMove] = aiPlayer;
                    PrintBoard(board);

                    if (CheckWin(board, aiPlayer))
                    {
                        Console.WriteLine("Der Computer hat gewonnen!");
                        break;
                    }

                    if (IsBoardFull(board))
                    {
                        Console.WriteLine("Unentschieden!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültiger Zug. Das Feld ist bereits belegt.");
                }
            }
        }

        public static void PrintBoard(char[] board)
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }

        public static bool CheckWin(char[] board, char player)
        {
            return (board[0] == player && board[1] == player && board[2] == player) ||
                   (board[3] == player && board[4] == player && board[5] == player) ||
                   (board[6] == player && board[7] == player && board[8] == player) ||
                   (board[0] == player && board[3] == player && board[6] == player) ||
                   (board[1] == player && board[4] == player && board[7] == player) ||
                   (board[2] == player && board[5] == player && board[8] == player) ||
                   (board[0] == player && board[4] == player && board[8] == player) ||
                   (board[2] == player && board[4] == player && board[6] == player);
        }

        public static bool IsBoardFull(char[] board)
        {
            return board.All(cell => cell != ' ');
        }

        public static int Evaluate(char[] board)
        {
            if (CheckWin(board, 'O')) return 1;
            if (CheckWin(board, 'X')) return -1;
            return 0;
        }

        public static (int Score, int Move) Minimax(char[] board, char player)
        {
            if (CheckWin(board, 'O')) return (1, -1);
            if (CheckWin(board, 'X')) return (-1, -1);
            if (IsBoardFull(board)) return (0, -1);

            int bestScore = (player == 'O') ? int.MinValue : int.MaxValue;
            int bestMove = -1;

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == ' ')
                {
                    board[i] = player;
                    int score = Minimax(board, (player == 'O') ? 'X' : 'O').Score;
                    board[i] = ' ';

                    if (player == 'O' && score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                    else if (player == 'X' && score < bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }

            return (bestScore, bestMove);
        }
    }
}
