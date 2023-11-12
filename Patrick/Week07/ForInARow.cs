using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.SelfTest;

namespace Patrick.Week07
{
    internal class ForInARow
    {
        public static void Start()
        {
            string[][] playGround = Playground();
            bool p1P2 = true;
            PrintMethod(playGround);
            while (true) 
            {
                //changes bool to false --> stops loop!
                IsPlaygroundFull(playGround);

                //Player 1 
                if (p1P2 == true)
                {
                    PrintMethod(NextTurn(playGround, p1P2));
                    bool winVtk = CheckWinVertikal(playGround);
                    bool winHoz = CheckWinHorizontal(playGround);
                    bool winDia = CheckWinDiagonal(playGround);
                    if (winVtk == true || winHoz == true || winDia == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Gratulation Spieler 1, Sie haben gewonnen");
                        Console.ResetColor();
                        break;
                    }
                    p1P2 = false;
                }

                //Player 2 
                else if (p1P2 == false)
                {
                    PrintMethod(NextTurn(playGround, p1P2));
                    bool winVtk = CheckWinVertikal(playGround);
                    bool winHoz = CheckWinHorizontal(playGround);
                    bool winDia = CheckWinDiagonal(playGround);
                    if (winVtk == true || winHoz == true || winDia == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gratulation Spieler 2, Sie haben gewonnen");
                        Console.ResetColor();
                        break;
                    }
                    p1P2 = true;
                }              
            }
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
                    playground[i][j] = " ";
                }
            }
            return playground;
        }

        public static void PrintMethod(string[][] playground)
        {
            for (int i = 0; i < playground.Length; i++)
            {
                Console.WriteLine("=====================");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("|" + playground[i][j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1  2  3  4  5  6  7 ");
            Console.ResetColor();
        }

        public static bool CheckWinVertikal(string[][] playground)
        {
            for (int i = 0; i <= playground.Length - 4; i++)
            {
                for (int j = 0; j < playground.Length; j++)
                {
                    if (playground[i][j] == "X" && playground[i + 1][j] == "X" && playground[i + 2][j] == "X" && playground[i + 3][j] == "X")
                    {
                        return true;
                    }
                    else if (playground[i][j] == "O" && playground[i + 1][j] == "O" && playground[i + 2][j] == "O" && playground[i + 3][j] == "O")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool CheckWinDiagonal(string[][] playground)
        {
            for (int i = 0; i <= playground.Length - 4; i++)
            {
                for (int j = 0; j <= playground.Length - 4; j++)
                {
                    // Diagonal nach rechts oben
                    if (playground[i][j] == "X" && playground[i + 1][j + 1] == "X" && playground[i + 2][j + 2] == "X" && playground[i + 3][j + 3] == "X")
                    {return true;}

                    else if (playground[i][j] == "O" && playground[i + 1][j + 1] == "O" && playground[i + 2][j + 2] == "O" && playground[i + 3][j + 3] == "O")
                    { return true;}

                    // Diagonal nach rechts unten
                    if (playground[i + 3][j] == "X" && playground[i + 2][j + 1] == "X" && playground[i + 1][j + 2] == "X" && playground[i][j + 3] == "X")
                    { return true; }

                    else if (playground[i + 3][j] == "O" && playground[i + 2][j + 1] == "O" && playground[i + 1][j + 2] == "O" && playground[i][j + 3] == "O")
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
                    if (playgroung[i][j] == "X" && playgroung[i][j + 1] == "X" && playgroung[i][j + 2] == "X" && playgroung[i][j + 3] == "X")
                    {
                        return true;
                    }
                    else if (playgroung[i][j] == "O" && playgroung[i][j + 1] == "O" && playgroung[i][j + 2] == "O" && playgroung[i][j + 3] == "O")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsPlaygroundFull(string[][] playgroung)
        {
            for(int i = 0;i < playgroung.Length; i++)
            {
                for(int j = 0; j < playgroung[i].Length + 1; j++)
                {
                    if (playgroung[i][j] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string[][] NextTurn(string[][] playground, bool pl1Pl2)
        {
            //Spieler 1
            if (pl1Pl2 == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Spieler 1, Sie sind am Zug! Geben Sie die Reihe als Zahl an:");
                Console.ResetColor();

                int input = ReadNumberRow();
                if (input <= 0 || input > playground.Length + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Deine Zahl \"{input}\" ist nicht innerhalb des zugelassenen Bereiches, bitte versuchen Sie es nocheinmal!");
                    Console.ResetColor();
                }
                else
                {
                    if (input == 1) { FillPosition(playground, "X", input); }
                    else if (input == 2) { FillPosition(playground, "X", input); }
                    else if (input == 3) { FillPosition(playground, "X", input); }
                    else if (input == 4) { FillPosition(playground, "X", input); }
                    else if (input == 5) { FillPosition(playground, "X", input); }
                    else if (input == 6) { FillPosition(playground, "X", input); }
                    else { FillPosition(playground, "X", input); }
                }
                return playground;
            }

            //Spieler 2
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Spieler 2, Sie sind am Zug! Geben Sie die Reihe als Zahl an:");
                Console.ResetColor();

                int input = ReadNumberRow();
                if (input <= 0 || input > playground.Length + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Deine Zahl \"{input}\" ist nicht innerhalb des zugelassenen Bereiches, bitte versuchen Sie es nocheinmal!");
                    Console.ResetColor();
                }
                else
                {
                    if (input == 1) { FillPosition(playground, "O", input); }
                    else if (input == 2) { FillPosition(playground, "O", input); }
                    else if (input == 3) { FillPosition(playground, "O", input); }
                    else if (input == 4) { FillPosition(playground, "O", input); }
                    else if (input == 5) { FillPosition(playground, "O", input); }
                    else if (input == 6) { FillPosition(playground, "O", input); }
                    else { FillPosition(playground, "O", input); }
                }
                return playground;
            }
        }

        public static int ReadNumberRow()
        {
            while (true)
            {
                Console.Write(">>>>>");
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\"{input}\" ist keine Zahl, bitte nocheinmal versuchen");
                    Console.ResetColor();
                }
            }
        }

        public static string[][] FillPosition(string[][] playground, string symbol, int input)
        {
            if (playground[playground.Length - 1][input - 1] == " ")
            {
                playground[playground.Length - 1][input - 1] = symbol;
            }
            else if (playground[playground.Length - 1][input - 1] == "X" && playground[playground.Length - 2][input - 1] == " " || playground[playground.Length - 1][input - 1] == "O" && playground[playground.Length - 2][input - 1] == " ")
            {
                playground[playground.Length - 2][input - 1] = symbol;
            }
            else if (playground[playground.Length - 2][input - 1] == "X" && playground[playground.Length - 3][input - 1] == " " || playground[playground.Length - 2][input - 1] == "O" && playground[playground.Length - 3][input - 1] == " ")
            {
                playground[playground.Length - 3][input - 1] = symbol;
            }
            else if (playground[playground.Length - 3][input - 1] == "X" && playground[playground.Length - 4][input - 1] == " " || playground[playground.Length - 3][input - 1] == "O" && playground[playground.Length - 4][input - 1] == " ")
            {
                playground[playground.Length - 4][input - 1] = symbol;
            }
            else if (playground[playground.Length - 4][input - 1] == "X" && playground[playground.Length - 5][input - 1] == " " || playground[playground.Length - 4][input - 1] == "O" && playground[playground.Length - 5][input - 1] == " ")
            {
                playground[playground.Length - 5][input - 1] = symbol;
            }
            else if (playground[playground.Length - 5][input - 1] == "X" && playground[playground.Length - 6][input - 1] == " " || playground[playground.Length - 5][input - 1] == "O" && playground[playground.Length - 6][input - 1] == " ")
            {
                playground[playground.Length - 6][input - 1] = symbol;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Die Spalte \"{input}\" ist bereits voll! Bitte nocheinmal versuchen");
                Console.ResetColor();
            }

            return playground;
        }
    }
}

