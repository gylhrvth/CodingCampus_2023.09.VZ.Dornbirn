using System;

namespace DarioLuis.Week04
{
    public class TicTacToev2
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int currentPlayer = 1; // Spieler 1 ist der menschliche Spieler
        static int choice;
        static bool isGameOver = false;

        public static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Spieler 1: X und Spieler 2: O");
                Console.WriteLine("\n");

                if (currentPlayer % 2 == 0)
                {
                    Console.WriteLine("Spieler 2 ist an der Reihe (KI)");
                    choice = GetComputerMove();
                }
                else
                {
                    Console.WriteLine("Spieler 1 ist an der Reihe (Mensch)");
                    choice = GetPlayerMove();
                }

                char symbol = (currentPlayer % 2 == 0) ? 'O' : 'X';

                if (IsValidMove(choice))
                {
                    board[choice - 1] = symbol;
                    currentPlayer++;
                }

                isGameOver = CheckForWin() || CheckForDraw();

            } while (!isGameOver);

            Console.Clear();
            Console.WriteLine("Das Spiel ist vorbei!");
            DisplayBoard();
        }

        public static int GetPlayerMove()
        {
            DisplayBoard();
            int move;
            bool isValid = false;
            do
            {
                Console.Write("Geben Sie eine Zahl (1-9) ein, um Ihr Zeichen zu platzieren: ");
                if (int.TryParse(Console.ReadLine(), out move))
                {
                    if (IsValidMove(move))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Das Feld ist bereits belegt.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 9 ein.");
                }
            } while (!isValid);
            return move;
        }

        public static int GetComputerMove()
        {
            // Einfache KI-Logik: Die KI versucht, ein freies Feld zu finden und es zu belegen.
            for (int i = 0; i < board.Length; i++)
            {
                if (IsValidMove(i + 1))
                {
                    return i + 1;
                }
            }
            return -1; // Fallback, sollte normalerweise nicht erreicht werden
        }

        public static bool IsValidMove(int move)
        {
            return move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O';
        }

        public static bool CheckForWin()
        {
            // Überprüfen Sie auf Gewinnbedingungen (8 mögliche Wege zu gewinnen)
            return (board[0] == board[1] && board[1] == board[2]) ||
                   (board[3] == board[4] && board[4] == board[5]) ||
                   (board[6] == board[7] && board[7] == board[8]) ||
                   (board[0] == board[3] && board[3] == board[6]) ||
                   (board[1] == board[4] && board[4] == board[7]) ||
                   (board[2] == board[5] && board[5] == board[8]) ||
                   (board[0] == board[4] && board[4] == board[8]) ||
                   (board[2] == board[4] && board[4] == board[6]);
        }

        public static bool CheckForDraw()
        {
            return board[0] != '1' && board[1] != '2' && board[2] != '3' &&
                   board[3] != '4' && board[4] != '5' && board[5] != '6' &&
                   board[6] != '7' && board[7] != '8' && board[8] != '9';
        }

        public static void DisplayBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }
    }
}
   