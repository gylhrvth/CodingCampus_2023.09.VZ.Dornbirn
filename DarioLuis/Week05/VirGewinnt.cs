namespace DarioLuis.Week05
{
    public class VierGewinnt
    {
        static char[,] board = new char[6, 7];
        static char currentPlayer = 'R'; // Startspieler ist Rot (R)
        public static void Start()
        {
            InitializeBoard();
            DisplayBoard();


        }

        static int GetPlayerMove()
        {
            int column;
            bool validInput = false;

            do
            {
                Console.WriteLine($"{currentPlayer}, wählen Sie eine Spalte. (1-7)");
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




        
    }
}


