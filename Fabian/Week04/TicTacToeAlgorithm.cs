namespace Fabian.Week04
{
    class TicTacToeAlgorithm
    {
        class Move
        {
            public int row, col;
        };

        static char player = 'x', opponent = 'o';

        // Driver code 
        public static void Start()
        {
            TicTacToeAI();
        }

        public static void TicTacToeAI()
        {
            int currentPlayer = 1;
            char[,] board = CreateEmptyBoard();
            bool gameOver = false;

            while (!gameOver)
            {
                PrintBoard(board);

                gameOver = CheckWin(board);
                if (gameOver)
                {
                    if (currentPlayer == 1)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("The Computer won!");
                    }
                }
            }
        }





        // This function returns true if there are moves 
        // remaining on the board. It returns false if 
        // there are no moves left to play. 
        static Boolean IsMovesLeft(char[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '_')
                        return true;
            return false;
        }

        // This is the evaluation function as discussed 
        static int Evaluate(char[,] b)
        {
            // Checking for Rows for X or O victory. 
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] == b[row, 1] &&
                    b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == player)
                        return +10;
                    else if (b[row, 0] == opponent)
                        return -10;
                }
            }

            // Checking for Columns for X or O victory. 
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] == b[1, col] &&
                    b[1, col] == b[2, col])
                {
                    if (b[0, col] == player)
                        return +10;

                    else if (b[0, col] == opponent)
                        return -10;
                }
            }

            // Checking for Diagonals for X or O victory. 
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == player)
                    return +10;
                else if (b[0, 0] == opponent)
                    return -10;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == player)
                    return +10;
                else if (b[0, 2] == opponent)
                    return -10;
            }

            // Else if none of them have won then return 0 
            return 0;
        }

        // This is the minimax function. It considers all 
        // the possible ways the game can go and returns 
        // the value of the board 
        static int Minimax(char[,] board, int depth, Boolean isMax)
        {
            int score = Evaluate(board);

            // If Maximizer has won the game  
            // return his/her evaluated score 
            if (score == 10)
                return score;

            // If Minimizer has won the game  
            // return his/her evaluated score 
            if (score == -10)
                return score;

            // If there are no more moves and  
            // no winner then it is a tie 
            if (IsMovesLeft(board) == false)
                return 0;

            // If this maximizer's move 
            if (isMax)
            {
                int best = -1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = player;

                            // Call minimax recursively and choose 
                            // the maximum value 
                            best = Math.Max(best, Minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }

            // If this minimizer's move 
            else
            {
                int best = 1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = opponent;

                            // Call minimax recursively and choose 
                            // the minimum value 
                            best = Math.Min(best, Minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }
        }

        // This will return the best possible 
        // move for the player 
        static Move FindBestMove(char[,] board)
        {
            int bestVal = -1000;
            Move bestMove = new Move();
            bestMove.row = -1;
            bestMove.col = -1;

            // Traverse all cells, evaluate minimax function  
            // for all empty cells. And return the cell  
            // with optimal value. 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Check if cell is empty 
                    if (board[i, j] == '_')
                    {
                        // Make the move 
                        board[i, j] = player;

                        // compute evaluation function for this 
                        // move. 
                        int moveVal = Minimax(board, 0, false);

                        // Undo the move 
                        board[i, j] = '_';

                        // If the value of the current move is 
                        // more than the best value, then update 
                        // best/ 
                        if (moveVal > bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }
            return bestMove;
        }

        public static int GetComputerMove(char[,] board)
        {
            int bestMove = Minimax(board, opponent, true);

            return bestMove;
        }

        public static int ReadNumber(string msg, int min, int max)
        {
            int num = Int32.MinValue;
            while (num == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine(msg);
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < min || num > max)
                    {
                        Console.WriteLine($"{num} is not between {min} and {max}!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }
            return num;
        }

        public static char[,] CreateEmptyBoard()
        {
            char[,] board = new char[3, 3];

            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    board[i, j] = '_';

            return board;
        }
        public static void PrintBoard(char[,] board)
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (board[i, j] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(board[i, j] + " | ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");

        }

        public static int[] GetHumanMove(char[,] board)
        {
            int row = Int32.MinValue;
            int column = Int32.MinValue;
            bool isValid = false;

            while (!isValid)
            {
                row = ReadNumber("Please enter a number between 1-3: ", 1, 3);
                column = ReadNumber("Please enter a number between 1-3: ", 1, 3);

                if (board[row, column] == '_')
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("This field is already taken!");
                }
            }

            return new int[] { row, column };
        }

        public static bool CheckWin(char[,] board)
        {
            //horiontal
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '_')
                    {
                        return true;
                    }
                }
            }

            //vertical
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != '_')
                    {
                        return true;
                    }
                }
            }

            //diagonal
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '_') ||
                (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != '_'))
            {
                return true;
            }

            return false;

        }
    }
}