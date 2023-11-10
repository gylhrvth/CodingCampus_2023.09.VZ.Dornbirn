using System.Text.RegularExpressions;
using static Fabian.Week02.ConsoleInput;
namespace Fabian.Week03
{
    class TicTacToeClass
    {
        const char player1 = 'X', player2 = 'O';
        static int player = 1;
        public static void Start()
        {
            TicTacToe();
        }

        private static void TicTacToe()
        {
            int count = 0;
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            PrintBoard(arr);
            while (true)
            {

                int input = ReadInt($"Enter a number between 1-9 (player {player}): ", 1, 9);
                while (arr[input] == player1 || arr[input] == player2)
                {
                    Console.WriteLine("This field is already taken!");
                    input = ReadInt($"Enter a number between 1-9 (player {player}): ", 1, 9);
                }
                arr[input] = (player == 1) ? player1 : player2;
                count++;

                PrintBoard(arr);
                if (CheckWin(arr))
                {
                    Console.WriteLine($"player {player} won! :)");
                    if (PlayAgain()) TicTacToe();
                    else return;
                }
                else if (count == 9)
                {
                    Console.WriteLine("It's a draw!");
                    if (PlayAgain()) TicTacToe();
                    else return;
                }

                player = (player == 1) ? 2 : 1;
            }
        }
        private static void PrintBoard(char[] arr)
        {
            Console.Clear();
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" -----------");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("| ");
                    if (arr[count] == player1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(arr[count++]);
                        Console.ResetColor();
                    }
                    else if (arr[count] == player2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(arr[count++]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arr[count++]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(" -----------");
        }

        private static bool CheckWin(char[] arr)
        {
            //vertical
            for (int i = 1; i < arr.Length; i += 3)
            {
                if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
                    return true;
            }
            //horizontal
            for (int i = 1; i <= 3; i++)
            {
                if (arr[i] == arr[i + 3] && arr[i + 3] == arr[i + 6])
                    return true;
            }
            //diagonal
            if (arr[1] == arr[5] && arr[5] == arr[9] ||
                arr[3] == arr[5] && arr[5] == arr[7])
                return true;

            return false;
        }
        private static bool PlayAgain()
        {
            string? restart = "";
            while (restart == "")
            {
                Console.WriteLine("Do you want to play again? (y/n)");
                restart = Console.ReadLine();

                if (Regex.IsMatch(restart, "^[yYnN]$"))
                {
                    if (restart == "y" || restart == "Y") return true;
                    else return false;
                }
                restart = "";
            }
            return false;
        }      
    }
}