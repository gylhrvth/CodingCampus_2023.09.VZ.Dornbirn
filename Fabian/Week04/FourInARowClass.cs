using static Fabian.Week02.ConsoleInput;
namespace Fabian.Week04
{
    public class FourInARowClass
    {
        const char player1 = 'X', player2 = 'O';
        public static void Start()
        {
            FourInARow();
        }

        private static void FourInARow()
        {
            int player = 1;
            int count = 0;
            char[,] board = InitializeBoard();
            PrintBoard(board);

            while (true)
            {
                int input = ReadInt($"\nEnter a column between 1-6 (player {player}): ", 1, 6) - 1;
                int i = board.GetLength(0) - 1;
                while (board[i, input] != '_')
                {
                    if (board[0, input] != '_')
                    {
                        Console.WriteLine("This column is full!");
                        input = ReadInt($"\nEnter a column between 1-6 (player {player}): ", 1, 6) - 1;
                    }
                    else i--;
                }

                board[i, input] = (player == 1) ? player1 : player2;
                count++;
                PrintBoard(board);

                if (CheckWin(board))
                {
                    Console.WriteLine($"player {player} won! :)");
                    if (AskToPlayAgain()) FourInARow();
                    else return;
                }
                else if (count == 42)
                {
                    Console.WriteLine("It's a draw!");
                    if (AskToPlayAgain()) FourInARow();
                    else return;
                }

                player = (player == 1) ? 2 : 1;
            }
        }
        private static void PrintBoard(char[,] board)
        {
            Console.Clear();
            Console.WriteLine("  1 2 3 4 5 6");
            Console.WriteLine("+-------------+");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == player1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (board[i, j] == player2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write($" {board[i, j]}");

                    Console.ResetColor();
                }
                Console.WriteLine(" |");
            }
            Console.WriteLine("+-------------+");
        }
        private static char[,] InitializeBoard()
        {
            char[,] board = new char[7, 6];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '_';
                }
            }
            return board;
        }
        private static bool CheckWin(char[,] board)
        {
            //vertical
            for (int i = 0; i < board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != '_' && board[i, j] == board[i + 1, j] && board[i + 1, j] == board[i + 2, j] && board[i + 2, j] == board[i + 3, j])
                        return true;
                }
            }
            //horizontal
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    if (board[i, j] != '_' && board[i, j] == board[i, j + 1] && board[i, j + 1] == board[i, j + 2] && board[i, j + 2] == board[i, j + 3])
                        return true;
                }
            }
            //diagonal
            for (int i = 0; i < board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    if ((board[i, j] != '_' && board[i, j] == board[i + 1, j + 1] && board[i + 1, j + 1] == board[i + 2, j + 2] && board[i + 2, j + 2] == board[i + 3, j + 3]) ||
                        (board[i, j + 3] != '_' && board[i, j + 3] == board[i + 1, j + 2] && board[i + 1, j + 2] == board[i + 2, j + 1] && board[i + 2, j + 1] == board[i + 3, j]))
                        return true;
                }
            }

            return false;
        }
    }
}
