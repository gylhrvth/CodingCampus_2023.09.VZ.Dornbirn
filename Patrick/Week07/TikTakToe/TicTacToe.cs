using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week07.TikTakToe
{
    internal class TicTacToe
    {
        public static bool P1 = true;
        public static void Start()
        {

            //Spielfeldinitialisierung
            int rows = 3;
            int columns = 3;
            char[][] board = CreateBoard(rows, columns);

            //Print
            DisplayBoard(board);
            NextTurn(board);

        }

        static char[][] CreateBoard(int rows, int columns)
        {
            char[][] board = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                board[i] = new char[columns];
                for (int j = 0; j < columns; j++)
                {
                    board[i][j] = ' '; // Leeres Zeichen für den Anfang
                }
            }
            return board;
        }

        static void DisplayBoard(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(" =============");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{i + 1}");
                Console.ResetColor();
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write($"| {board[i][j]} ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine((" ============="));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(("   A   B   C  "));
            Console.ResetColor();
        }




        static char[][] NextTurn(char[][] displayboard)
        {
            char player1 = (char)9632;
            char player2 = (char)216;

            if (P1)
            {
                Console.WriteLine($"Spieler 1 \"{player1}\" geben Sie eine Zahl für die Reihe ein!");
                int inputRow = InputRow();
                Console.WriteLine($"Spieler 1 \"{player1}\" geben Sie einen Buchstaben für Die Spalte ein!");
                int inputColumn = InputColumn();
                Console.Clear();
                DisplayBoard(FillField(displayboard, inputRow, inputColumn, player1));

                if (CheckWin(displayboard, player1) == false)
                {
                    P1 = false;
                    NextTurn(displayboard);
                }
                else
                {
                    Console.WriteLine("Gratulation Spieler 1, Sie haben gewonnen!");
                }
            }
            else
            {
                Console.WriteLine($"Spieler 2 \"{player2}\" geben Sie eine Zahl für die Reihe ein!");
                int inputRow = InputRow();
                Console.WriteLine($"Spieler 2 \"{player2}\" geben Sie einen Buchstaben für Die Spalte ein!");
                int inputColumn = InputColumn();
                Console.Clear();
                DisplayBoard(FillField(displayboard, inputRow, inputColumn, player2));

                if (CheckWin(displayboard, player2) == false)
                {
                    P1 = true;
                    NextTurn(displayboard);
                }
                else
                {
                    Console.WriteLine("Gratulation Spieler 2, Sie haben gewonnen!");
                }
            }
            return displayboard;
        }

        static char[][] FillField(char[][] displayboard, int inputRow, int inputColumn, char player)
        {
            if (displayboard[inputRow - 1][inputColumn] == ' ')
            {
                displayboard[inputRow - 1][inputColumn] = player;
            }
            else
            {
                Console.WriteLine("Dieses Feld ist bereits belegt, bitte nochmals versuchen!");
                NextTurn(displayboard);
            }
            return displayboard;
        }

        static int InputRow()
        {
            string inputRow = " ";
            while (true)
            {
                Console.Write(">>>>>");
                inputRow = Console.ReadLine();
                if (inputRow == "1" || inputRow == "2" || inputRow == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sie müssen eine Zahl zwischen 1 und 3 eingeben!");
                }
            }
            return Convert.ToInt32(inputRow);
        }

        static int InputColumn()
        {
            int inputCol = int.MaxValue;
            while (true)
            {
                Console.Write(">>>>>");
                string input = Console.ReadLine();
                if (input == "a")
                {
                    inputCol = 0; break;
                }
                else if (input == "b")
                {
                    inputCol = 1; break;
                }
                else if (input == "c")
                {
                    inputCol = 2; break;
                }
                else
                {
                    Console.WriteLine("Sie müssen entweder \"a\", \"b\" oder \"c\" eingeben!");
                }
            }
            return inputCol;
        }

        static bool CheckWin(char[][] displayboard, char player)
        {
            for(int i = 0; i < displayboard.Length; i++)
            {
                // Check Row Player
                if ((displayboard[i][0] == player && displayboard[i][1] == player && displayboard[i][2] == player))
                {
                    return true;
                }
                // Check Column Player
                else if ((displayboard[0][i] == player && displayboard[1][i] == player && displayboard[2][i] == player))
                {
                    return true;
                }
                // Check to top right Player
                else if ((displayboard[2][0] == player && displayboard[1][1] == player && displayboard[0][2] == player))
                {
                    return true;
                }
                // Check to bottom right Player
                else if ((displayboard[0][0] == player && displayboard[1][1] == player && displayboard[2][2] == player))
                {
                    return true;
                }

            }
            return false;
        }
    }

}

