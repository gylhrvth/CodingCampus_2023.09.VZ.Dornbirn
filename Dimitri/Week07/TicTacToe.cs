using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07
{
    internal class TicTacToe
    {
        public static void Main()
        {
            string[][] field = FillField(CreateField());
            PlayerAction(field);

        }

        public static string[][] CreateField()
        {
            string[][] field = new string[3][];

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = new string[3];
            }

            return field;

        }

        public static string[][] FillField(string[][] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    field[i][j] = " ";
                }
            }

            return field;
        }

        public static void PrintField(string[][] field)
        {
            Console.WriteLine("TicTacToe");
            Console.WriteLine();
            Console.WriteLine("       C   O   L");
            Console.WriteLine();
            Console.WriteLine("       0   1   2");
            string[] row = new string[3] { "R", "O", "W" };

            Console.WriteLine("     -------------");
            for (int i = 0; i < field.Length; i++)
            {
                Console.Write("{0}  {1} |", row[i], i);
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(" {0} |", field[i][j]);
                }
                Console.Write("\n");
                Console.WriteLine("     -------------");

            }

        }

        public static bool playerTurn = true;

        public static string[][] PlayerAction(string[][] arr)
        {
            PrintField(arr);
            string playerSymbol = "";
            int row = int.MinValue;
            int col = int.MinValue;
            if (playerTurn)
            {
                playerSymbol = "x";
                Console.WriteLine("Player one in which row you wanna place your symbol?(0-2)");
                Console.Write(">>>");
                row = FourInRows.CheckAndReturnPlayerInput("Choose in which row you wanna place your symbol.", 0, 2);
                Console.WriteLine("Player one in which column you wanna place your symbol?(0-2)");
                Console.Write(">>>");
                col = FourInRows.CheckAndReturnPlayerInput("Choose in which column you wanna place your symbol.", 0, 2);
                playerTurn = false;
            }
            else
            {
                playerSymbol = "o";
                Console.WriteLine("Player two in which row you wanna place your symbol?(0-2)");
                Console.Write(">>>");
                row = FourInRows.CheckAndReturnPlayerInput("Choose in which row you wanna place your symbol.", 0, 2);
                Console.WriteLine("Player two in which column you wanna place your symbol?(0-2)");
                Console.Write(">>>");
                col = FourInRows.CheckAndReturnPlayerInput("Choose in which column you wanna place your symbol.", 0, 2);
                playerTurn = true;
            }


            Console.Clear();


            FindEmptyField(arr, row, col, playerSymbol);
            if (!CheckIfPlayerWon(arr, playerSymbol, playerTurn))
            {
                PlayerAction(arr);
            } else
            {
                string player = "";
                if (!playerTurn)
                {
                    player = "one";
                }
                else
                {
                    player = "two";
                }
                Console.Clear();
                PrintField(arr);
                Console.WriteLine();
                Console.WriteLine("Player {0} won!", player);
            }

            return arr;
        }

        public static string[][] FindEmptyField(string[][] field, int row, int column, string playerSymbol)
        {
            if (field[row][column].Contains(" "))
            {
                field[row][column] = playerSymbol;
            }
            else
            {
                Console.WriteLine("This field is already used. Choose a new one.");
                Console.WriteLine();
                if (playerTurn)
                {
                    playerTurn = false;
                }
                else
                {
                    playerTurn = true;
                }
            }

            return field;
        }

        public static bool CheckIfPlayerWon(string[][] field, string playerSymbol, bool playerTurn)
        {
            string player = "";
            if (!playerTurn)
            {
                player = "one";
            }
            else
            {
                player = "two";
            }

            //Horizontal
            for (int i = 0; i < field.Length; i++)
            {
                if ((field[i][0].Contains(playerSymbol) && field[i][1].Contains(playerSymbol) && field[i][2].Contains(playerSymbol)))
                {
                    Console.WriteLine("Player {0} won!", player);
                    return true;
                }
            }

            //vertikal
            for (int i = 0; i < field.Length; i++)
            {
                if ((field[0][i].Contains(playerSymbol) && field[1][i].Contains(playerSymbol) && field[2][i].Contains(playerSymbol)))
                {
                    Console.WriteLine("Player {0} won!", player);
                    return true;
                }
            }

            //diagonal rechts unten
            if (field[0][0].Contains(playerSymbol) && field[1][1].Contains(playerSymbol) && field[2][2].Contains(playerSymbol))
            {
                Console.WriteLine("Player {0} won!", player);
                return true;
            }

            //Diagonal links unten

            if (field[0][2].Contains(playerSymbol) && field[1][1].Contains(playerSymbol) && field[2][0].Contains(playerSymbol))
            {
                Console.WriteLine("Player {0} won!", player);
                return true;
            }

            return false;
        }

    }
}
