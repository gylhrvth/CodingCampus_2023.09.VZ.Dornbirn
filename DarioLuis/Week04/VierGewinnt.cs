namespace DarioLuis.Week04
{

    class VierGewinnt
    {
        static char[,] board = new char[6, 7];
        static char currentPlayer = 'R'; // Startspieler ist Rot (R)
        
        public static void Start()
        {
            InitializeBoard();
            bool gameover = false;

            while (!gameover)
            {
                DisplayBoard();

                int column = GetPlayerMove();
                int row = PlaceDisc(column);

                if (CheckForWin(row, column))
                {
                    DisplayBoard();
                    Console.WriteLine($"Spieler {currentPlayer} hat gewonnen!");
                    gameover = true;
                }
                else if (CheckForDraw())
                {
                    DisplayBoard();
                    Console.WriteLine("Das Spiel endet unentschieden!");
                    gameover = true;
                }

                // Spielerwechsel
                currentPlayer = (currentPlayer == 'R') ? 'Y' : 'R';
            }
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void DisplayBoard()
        {
            Console.Clear();
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write("| " + board[row, col] + " ");
                }
                Console.WriteLine("|");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("  1   2   3   4   5   6   7");
        }

        static int GetPlayerMove()
        {
            int column;
            bool validInput = false;
            do
            {
                Console.Write($"Spieler {currentPlayer}, wählen Sie eine Spalte (1-7): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out column) && column >= 1 && column <= 7)
                {
                    column--; // Adjust to 0-based index
                    if (IsValidMove(column))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Diese Spalte ist bereits voll. Bitte wählen Sie eine andere.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 7 ein.");
                }
            } while (!validInput);

            return column;
        }

        static bool IsValidMove(int column)
        {
            return board[0, column] == ' ';
        }

        static int PlaceDisc(int column)
        {
            for (int row = 5; row >= 0; row--)
            {
                if (board[row, column] == ' ')
                {
                    board[row, column] = currentPlayer;
                    return row;
                }
            }
            return -1; // Column is already full (should not reach here)
        }

        static bool CheckForWin(int row, int column)
        {
            char disc = currentPlayer;

            // Check horizontal
            int count = 0;
            for (int i = -3; i <= 3; i++)
            {
                if (column + i >= 0 && column + i < 7 && board[row, column + i] == disc)
                {
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            // Check vertical
            count = 0;
            for (int i = -3; i <= 3; i++)
            {
                if (row + i >= 0 && row + i < 6 && board[row + i, column] == disc)
                {
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            // Check diagonal (from top-left to bottom-right)
            count = 0;
            for (int i = -3; i <= 3; i++)
            {
                if (row + i >= 0 && row + i < 6 && column + i >= 0 && column + i < 7 && board[row + i, column + i] == disc)
                {
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            // Check diagonal (from top-right to bottom-left)
            count = 0;
            for (int i = -3; i <= 3; i++)
            {
                if (row + i >= 0 && row + i < 6 && column - i >= 0 && column - i < 7 && board[row + i, column - i] == disc)
                {
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            return false;
        }

        static bool CheckForDraw()
        {
            for (int col = 0; col < 7; col++)
            {
                if (board[0, col] == ' ')
                {
                    return false; // There is an empty cell, so the game is not a draw.
                }
            }
            return true; // All columns are full, and no player has won, so the game is a draw.
        }
    }
}
