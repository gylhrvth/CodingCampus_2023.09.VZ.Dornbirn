using static Fabian.Week02.ConsoleInput;
namespace Fabian.Selftest_SP
{
    public class TowersOfHanoi
    {
        public static void Start()
        {
            TowersOfHanoiStart();
        }
        private static void TowersOfHanoiStart()
        {
            int tries = 0;
            int size = ReadInt("How much layers should the tower have? (3 - 9): ", 3, 9);
            int[,] board = InitializeBoard(size);
            PrintBoard(board);

            while (true)
            {
                Console.WriteLine($"tries: {tries}");
                int from = ReadInt("Which tower do u want to select? (1-3): ", 1, 3);
                int to = ReadInt("Where do you want to move the piece? (1-3): ", 1, 3);
                while (from == to)
                {
                    SetConsoleColor(ConsoleColor.Red, "You can't select the same tower twice!\n");
                    from = ReadInt("Which tower do u want to select? (1-3): ", 1, 3);
                    to = ReadInt("Where do you want to move the piece? (1-3): ", 1, 3);
                }

                int? result = HanoiMove(board, from, to);
                if (result != null)
                {
                    PrintBoard(board);
                    if (result == 0)
                        SetConsoleColor(ConsoleColor.Red, "That disc is too big!\n");

                    if (CheckWin(board))
                    {
                        SetConsoleColor(ConsoleColor.Green, $"You won with {tries} tries! :)\n");
                        if (AskToPlayAgain()) TowersOfHanoiStart();
                        else return;
                    }
                }
                else
                    SetConsoleColor(ConsoleColor.Red, "Invalid move!\n");
                tries++;
            }
        }
        private static int[,] InitializeBoard(int size)
        {
            int[,] board = new int[3, size];
            for (int i = 0; i < board.GetLength(1); i++)
            {
                board[0, i] = i + 1;
            }
            return board;
        }
        private static void PrintBoard(int[,] board)
        {
            Console.Clear();
            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    Console.Write($"{board[j, i], -4}");
                }
                Console.WriteLine();
            }
        }
        private static int? HanoiMove(int[,] board, int from, int to)
        {
            from--;
            to--;
            int size = board.GetLength(1) - 1;

            if (board[from, size] == 0) return null; // all elements in the tower are 0

            // get index of the first element that isnt 0 in the tower
            int firstElementIndex = 0;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[from, i] != 0)
                {
                    firstElementIndex = i;
                    break;
                }
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                // if last element in tower is 0, set it to the new value
                if (board[to, size] == 0)
                {
                    board[to, size] = board[from, firstElementIndex];
                    break;
                }
                // get first element that isnt 0 + set the index - 1 to the new value
                else if (board[to, i] != 0)
                {
                    if (board[from, firstElementIndex] > board[to, i])
                        return 0; // disc is too big
                    else
                    {
                        board[to, i - 1] = board[from, firstElementIndex];
                        break;
                    }
                }
            }
            board[from, firstElementIndex] = 0; // delete the used disc
            return 1; //succesfull
        }
        private static bool CheckWin(int[,] board)
        {
            for (int i = 1; i < board.GetLength(0); i++)
            {
                bool win = true;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    // if there is a 0 in the tower its not a win
                    if (board[i, j] == 0) 
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }
            return false;
        }
        public static void SetConsoleColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}