using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.SelfTest;

namespace Patrick.Week07.ForInARow
{
    internal class ForInARow
    {
        private static bool P1 = true;
        public static void Start()
        {
            string[][] playGround = Playground();
            PrintMethod(playGround);
            GameLogic(playGround);
        }

        public static string[][] Playground()
        {
            string[][] playground = new string[6][];

            for (int i = 0; i < 6; i++)
            {
                playground[i] = new string[7];
            }

            for (int i = 0; i < playground.Length; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    playground[i][j] = "   ";
                }
            }
            return playground;
        }

        public static bool IsColumnFull(string[][] playground, int column)
        {
            // Überprüfen, ob die oberste Position in der Spalte belegt ist
            return playground[0][column] != "   ";
        }

        public static void PrintMethod(string[][] playground)
        {
            for (int i = 0; i < playground.Length; i++)
            {
                Console.WriteLine("=====================================");
                Console.Write("|");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("|");
                    if (playground[i][j].ToLower().Contains("x"))               //ToLower() --> für Großklein Schreibung kein unterschied // Contains() --> enthält das Symbol?
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(playground[i][j]);
                    Console.ResetColor();
                    Console.Write("|");

                }
                Console.WriteLine("|");
            }
            Console.WriteLine("=====================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   1    2    3    4    5    6    7   ");
            Console.ResetColor();
        }

        public static bool CheckWinVertikal(string[][] playground)
        {
            for (int i = 0; i <= playground.Length - 4; i++)
            {
                for (int j = 0; j < playground.Length; j++)
                {
                    if (playground[i][j] != "   " && playground[i][j] == playground[i + 1][j] && playground[i + 1][j] == playground[i + 2][j] && playground[i + 2][j] == playground[i + 3][j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool CheckWinDiagonal(string[][] playground)
        {
            for (int i = 0; i < playground.Length - 3; i++)
            {
                for (int j = 0; j < playground[i].Length - 3; j++)
                {
                    // Diagonal nach rechts unten
                    if (playground[i][j] != "   " && playground[i][j] == playground[i + 1][j + 1] && playground[i + 1][j + 1] == playground[i + 2][j + 2] && playground[i + 2][j + 2] == playground[i + 3][j + 3])
                    { return true; }
                }
            }
            for (int i = 3; i < playground.Length; i++)
            {
                for (int j = 0; j < playground[i].Length - 3; j++)
                {
                    // Diagonal nach rechts oben
                    if (playground[i][j] != "   " && playground[i][j] == playground[i - 1][j + 1] && playground[i - 1][j + 1] == playground[i - 2][j + 2] && playground[i - 2][j + 2] == playground[i - 3][j + 3])
                    { return true; }
                }
            }
            return false;
        }

        public static bool CheckWinHorizontal(string[][] playgroung)
        {
            for (int i = 0; i < playgroung.Length; i++)
            {
                for (int j = 0; j < playgroung.Length - 4; j++)
                {
                    if (playgroung[i][j] != "   " && playgroung[i][j] == playgroung[i][j + 1] && playgroung[i][j + 1] == playgroung[i][j + 2] && playgroung[i][j + 2] == playgroung[i][j + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void GameLogic(string[][] playground)
        {
            string playerName;
            string symbol;
            System.ConsoleColor color;                                  // Erstellt eine Variable und der DateiTyp ist: System.ConsoleColor 
            if (P1)
            {
                playerName = "Spieler 1";
                symbol = " X ";
                color = ConsoleColor.Blue;
            }
            else
            {
                playerName = "Spieler 2";
                symbol = " O ";
                color = ConsoleColor.Green;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(playerName + ", Sie sind am Zug! Geben Sie die Spalte als Zahl an:");
            Console.ResetColor();

            int input = ReadNumberRange(playground);

            FillPosition(playground, symbol, input);

            PrintMethod(playground);

            if (CheckWinDiagonal(playground) == true || CheckWinHorizontal(playground) == true || CheckWinVertikal(playground) == true)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("Gratulation " + playerName + ", Sie haben gewonnen!");
                Console.ResetColor();
            }
            else
            {
                P1 = !P1;                                   //bool wird gedreht, für den Spielerwechsel
                GameLogic(playground);
            }
        }

        public static int ReadNumberRange(string[][] playground)
        {
            while (true)
            {
                int input = ReadInteger();
                if (input <= 0 || input > playground.Length + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Deine Zahl \"{input}\" ist nicht innerhalb des zugelassenen Bereiches, bitte versuchen Sie es nocheinmal!");
                    Console.ResetColor();
                }
                else
                {
                    return input;
                }
            }
        }

        public static int ReadInteger
            
            ()
        {
            while (true)
            {
                Console.Write(">>>>>");
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\"{input}\" ist keine Zahl, bitte nocheinmal versuchen");
                    Console.ResetColor();
                }
            }
        }

        public static string[][] FillPosition(string[][] playground, string symbol, int input)
        {
            int column = input - 1;

            if (!IsColumnFull(playground, column))
            {
                // Füge das Symbol in die Spalte ein
                for (int i = playground.Length - 1; i >= 0; i--)
                {
                    if (playground[i][column] == "   ")
                    {
                        playground[i][column] = symbol;
                        Console.Clear();                            //Für einen neuen Spielzug
                        return playground;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Die Spalte {input} ist voll, bitte wählen Sie eine andere Spalte!");
                Console.ResetColor();
                GameLogic(playground);
            }
            Console.Clear();
            return playground;
        }

    }
}

