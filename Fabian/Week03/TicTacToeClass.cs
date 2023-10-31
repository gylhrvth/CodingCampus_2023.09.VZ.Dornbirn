using static Fabian.Week04.FourInARowClass;
using static Fabian.Week02.ConsoleInput;
namespace Fabian.Week03
{
    public class TicTacToeClass
    {
        public static void Start()
        {
            TicTacToe();
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
            Print2DArray(playGround);

            while (true)
            {
                try
                {
                    int p1Row = 0;
                    int p1Col = 0;
                    int p2Row = 0;
                    int p2Col = 0;

                    //enter numbers
                    p1Row = UserInput("row", 1, 1, 3);
                    p1Col = UserInput("column", 1, 1, 3);

                    //check if field is taken
                    while (playGround[p1Row - 1, p1Col - 1] != 0)
                    {
                        Console.WriteLine("This field is already taken!");
                        Print2DArray(playGround);
                        p1Row = UserInput("row", 1, 1, 3);
                        p1Col = UserInput("column", 1, 1, 3);
                    }
                    //print the 1
                    playGround[p1Row - 1, p1Col - 1] = 1;

                    Print2DArray(playGround);
                    count++;

                    //check if player 1 won
                    if (CheckWin(playGround))
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
                    p2Row = UserInput("row", 2, 1, 3);
                    p2Col = UserInput("column", 2, 1, 3);

                    //check if field is taken
                    while (playGround[p2Row - 1, p2Col - 1] != 0)
                    {
                        Console.WriteLine("This field is already taken!");
                        Print2DArray(playGround);
                        p2Row = UserInput("row", 2, 1, 3);
                        p2Col = UserInput("column", 2, 1, 3);
                    }
                    //print the 2
                    playGround[p2Row - 1, p2Col - 1] = 2;

                    Print2DArray(playGround);
                    count++;

                    //check if player 2 won
                    if (CheckWin(playGround))
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
       
        public static int UserInput(string text, int player, int min, int max)
        {
            int num = Int32.MinValue;
            while (num == Int32.MinValue)
            {
                try
                {
                    Console.WriteLine($"Enter a {text} between {min}-{max} (player {player}): ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < min || num > max)
                    {
                        Console.WriteLine($"{num} is not between {min} and {max}");
                        num = Int32.MinValue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("number was too high!");
                }

            }
            return num;
        }
        private static bool CheckWin(int[,] arr)
        {
            //horizontal
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 2; j++)
                {
                    if (arr[i, j] != 0 && arr[i, j] == arr[i, j + 1] && arr[i, j + 1] == arr[i, j + 2])
                    {
                        return true;
                    }
                }
            }
            //vertical
            for (int i = 0; i < arr.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0 && arr[i, j] == arr[i + 1, j] && arr[i + 1, j] == arr[i + 2, j])
                    {
                        return true;
                    }
                }
            }
            //diagonal
            for (int i = 0; i < arr.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 2; j++)
                {
                    if ((arr[i, j] != 0 && arr[i, j] == arr[i + 1, j + 1] && arr[i + 1, j + 1] == arr[i + 2, j + 2]) || // top left to bottom right
                        (arr[i, j + 2] != 0 && arr[i, j + 2] == arr[i + 1, j + 1] && arr[i + 1, j + 1] == arr[i + 2, j])) // top right to bottom left
                    {
                        return true;
                    }                  
                }
            }
            return false;
        }
    }
}
