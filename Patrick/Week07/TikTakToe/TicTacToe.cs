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
        public static void Start()
        {
            //Symbole aus dem Ascii Code f. p1 und p2
            char player1 = (char)142;
            char player2 = (char)216;

            //Spielfeldinitialisierung
            int rows = 3;
            int columns = 3;
            char[][] board = CreateBoard(rows, columns);

            //Programmablauf
            bool p1P2 = true;
            DisplayBoard(board);
            while (true)
            {
                int inputRow = InputRow(p1P2);
                int inputColumn = InputColumn();
                //Spieler 1
                if (p1P2 == true)
                {
                    DisplayBoard(NextTurn(board, inputRow, inputColumn, player1));         
                    if (CheckWin(NextTurn(board, inputRow, inputColumn, player1), player1, player2) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Gratuliere Spieler 1 hat gewonnen!");
                        Console.ResetColor();
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                    }
                    p1P2 = false;
                }
                //Spieler 2
                else
                {
                    DisplayBoard(NextTurn(board, inputRow, inputColumn, player2));
                    if (CheckWin(NextTurn(board, inputRow, inputColumn, player2), player1, player2) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Gratuliere Spieler 2 hat gewonnen!");
                        Console.ResetColor();
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                    }
                    p1P2 = true;
                }
            }
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

        static char[][] NextTurn(char[][] displayboard, int inputRow, int inputCol, char player)
        {
            if (displayboard[inputRow - 1][inputCol] == ' ')
            {
                Console.Clear();
                displayboard[inputRow - 1][inputCol] = player;       //füllt mit player1 oder player2
            }
            else
            {
                Console.WriteLine("Diese Zelle ist bereits belegt. Bitte wählen Sie eine andere.");     
            }

            return displayboard;
        }

        static int InputRow(bool p1P2)
        {
            string inputRow = "0";
            if (p1P2 == true)
            {
                while (true)
                {
                    Console.WriteLine("Spieler 1 Sie sind am Zug, bitte geben Sie eine Zahl für die Reihe an:");
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
            }
            else if (p1P2 == false)
            {
                while (true)
                {
                    Console.WriteLine("Spieler 2 Sie sind am Zug, bitte geben Sie eine Zahl für die Reihe an:");
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
            }    
            return Convert.ToInt32(inputRow);
        }

        static int InputColumn()
        {
            int input = int.MaxValue;
            while (true)
            {
                Console.WriteLine("Bitte geben Sie einen Buchstaben für die Spalte an:");
                Console.Write(">>>>>");
                string inputCol = Console.ReadLine();
                if (inputCol == "a")
                {
                    input = 0; break;
                }
                else if (inputCol == "b")
                {
                    input = 1; break;
                }
                else if (inputCol == "c")
                {
                    input = 2; break;
                }
                else
                {
                    Console.WriteLine("Sie müssen entweder \"a\", \"b\" oder \"c\" eingeben!");
                }
            }
            return input;
        }


        static bool CheckWin(char[][] displayboard, char player1, char player2)
        {
            while (true)
            {
                // Check Row Player 1
                if ((displayboard[0][0] == player1 && displayboard[0][1] == player1 && displayboard[0][2] == player1))                   
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler1");
                    return true;
                }
                // Check Column Player 1
                else if ((displayboard[0][0] == player1 && displayboard[1][0] == player1 && displayboard[2][0] == player1))    
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler1");
                    return true;
                }
                // Check to top right Player 1
                else if ((displayboard[2][0] == player1 && displayboard[1][1] == player1 && displayboard[0][2] == player1))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler1");
                    return true;
                }
                // Check to bottom right Player 1
                else if ((displayboard[0][0] == player1 && displayboard[1][1] == player1 && displayboard[2][2] == player1))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler1");
                    return true;
                }
                // Check Row Player 2
                if ((displayboard[0][0] == player2 && displayboard[0][1] == player2 && displayboard[0][2] == player2))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler2");
                    return true;
                }
                // Check Column Player 2
                else if ((displayboard[0][0] == player2 && displayboard[1][0] == player2 && displayboard[2][0] == player2))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler2");
                    return true;
                }
                // Check to top right Player 2
                else if ((displayboard[2][0] == player2 && displayboard[1][1] == player2 && displayboard[0][2] == player2))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler2");
                    return true;
                }
                // Check to bottom right Player 2
                else if ((displayboard[0][0] == player2 && displayboard[1][1] == player2 && displayboard[2][2] == player2))
                {
                    Console.WriteLine($"Gratuliere zum Sieg! Spieler2");
                    return true;
                }
                return false;
            }
        }
    }

}

