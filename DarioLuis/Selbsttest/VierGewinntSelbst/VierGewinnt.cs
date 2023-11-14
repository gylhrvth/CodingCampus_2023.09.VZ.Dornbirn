class VierGewinntSelbst
{
    static int numRows = 6;
    static int numCols = 7;
    static char[,] board = new char[numRows, numCols];
    static char currentPlayer = 'X';

    public static void Main()
    {
        InitializeBoard();
        bool gameOver = false;

        while (!gameOver)
        {
            Console.Clear();
            PrintBoard();
            int col = GetPlayerInput();

            if (IsValidMove(col))
            {
                int row = AnimateMove(col);
                PrintBoard();
                if (CheckWin(row, col))
                {
                    Console.WriteLine("Spieler " + currentPlayer + " gewinnt!");
                    gameOver = true;
                }
                else if (IsBoardFull())
                {
                    Console.WriteLine("Unentschieden! Das Spielfeld ist voll.");
                    gameOver = true;
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Zug. Bitte erneut versuchen.");
            }
        }
    }

    static void InitializeBoard()
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine("  1 2 3 4 5 6 7");
        for (int row = 0; row < numRows; row++)
        {
            Console.Write("|");
            for (int col = 0; col < numCols; col++)
            {
                Console.Write(board[row, col]);
                Console.Write("|");
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------");
    }

    static int GetPlayerInput()
    {
        int col = -1;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Spieler " + currentPlayer + ", wähle eine Spalte (1-7): ");
            if (int.TryParse(Console.ReadLine(), out col) && col >= 1 && col <= numCols)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl zwischen 1 und 7 eingeben.");
            }
        }
        return col - 1; // Spaltennummer von 0 bis 6
    }

    static bool IsValidMove(int col)
    {
        return col >= 0 && col < numCols && board[0, col] == ' ';
    }

    static int AnimateMove(int col)
    {
        int row = 0;
        while (row < numRows - 1 && board[row + 1, col] == ' ')
        {
            row++;
            Console.Clear();
            PrintBoard();
            Thread.Sleep(100); // Verzögerung für die Animation
            board[row - 1, col] = ' ';
            board[row, col] = currentPlayer;
        }
        return row;
    }

    static bool CheckWin(int row, int col)
    {
        // Check horizontal
        int count = 1;
        count += CountConsecutive(row, col, 0, 1) + CountConsecutive(row, col, 0, -1);
        if (count >= 4) return true;

        // Check vertical
        count = 1;
        count += CountConsecutive(row, col, 1, 0);
        if (count >= 4) return true;

        // Check diagonal (up-right and down-left)
        count = 1;
        count += CountConsecutive(row, col, -1, 1) + CountConsecutive(row, col, 1, -1);
        if (count >= 4) return true;

        // Check diagonal (up-left and down-right)
        count = 1;
        count += CountConsecutive(row, col, -1, -1) + CountConsecutive(row, col, 1, 1);
        if (count >= 4) return true;

        return false;
    }

    static int CountConsecutive(int row, int col, int dr, int dc)
    {
        int count = 0;
        int r = row + dr;
        int c = col + dc;
        while (r >= 0 && r < numRows && c >= 0 && c < numCols && board[r, c] == currentPlayer)
        {
            count++;
            r += dr;
            c += dc;
        }
        return count;
    }
    static bool IsBoardFull()
    {
        for (int col = 0; col < numCols; col++)
        {
            if (board[0, col] == ' ')
            {
                return false;
            }
        }
        return true;
    }
}
