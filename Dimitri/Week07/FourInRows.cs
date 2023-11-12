using Dimitri.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dimitri.Week07
{
    internal class FourInRows
    {
        public static void Main()
        {

            string[][] arr = CreateField();
            //PrintField(arr);
            Console.WriteLine("Four in a Row:");
            PlayerAction(arr);

        }

        public static string[][] CreateField()
        {
            string[][] arr = new string[6][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[7];
            }

            for (int j = 0; j < arr.Length; j++)
            {


                for (int k = 0; k < arr[j].Length; k++)
                {
                    arr[j][k] = " ";
                }
            }


            return arr;
        }

        public static void PrintField(string[][] arr)
        {

            Console.WriteLine("-----------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" {0} |", arr[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
            for (int k = 0; k <= arr.Length; k++)
            {
                Console.Write("  {0} ", k);
            }
            Console.WriteLine();

        }

        public static bool playerTurn = true;

        public static string[][] PlayerAction(string[][] arr)
        {
            PrintField(arr);
            string playerSymbol = "";

            if (!playerTurn)
            {
                playerSymbol = "O";
                Console.WriteLine("Player two where you wanna set your stone?(0-6)");
                Console.Write(">>>");
                playerTurn = true;
            }
            else if (playerTurn)
            {
                playerSymbol = "X";
                Console.WriteLine("Player one where you wanna set your stone?(0-6)");
                Console.Write(">>>");
                playerTurn = false;
            }

            string input = Console.ReadLine();
            int inputInt = int.MinValue;
            while (true)
            {
                try
                {
                    inputInt = Convert.ToInt32(input);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Input not allowed. Type in a number between 0 and 6:");
                    Console.Write(">>>");
                    input = Console.ReadLine();
                }
                if (inputInt > 6 || inputInt < 0)
                {
                    Console.WriteLine("Input not allowed. Type in a number between 0 and 6:");
                    Console.Write(">>>");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            FindEmptyField(arr, inputInt, playerSymbol);

            if (!CheckIfPlayerWon(arr))
            {
                Console.Clear();
                Console.WriteLine("Four in a Row:");
                PlayerAction(arr);

            }
            else if (CheckIfPlayerWon(arr))
            {
                Console.Clear();
                Console.WriteLine("Four in a Row:");
                Console.WriteLine();
                PrintField(arr);
                Console.WriteLine();
                Console.WriteLine("Player {0} won!", player);


                return arr;
            }

            return arr;
        }
        public static string[][] FindEmptyField(string[][] arr, int inputPlayer, string playerSymbol)
        {

            int i = arr.Length - 1;
            while (i >= 0)
            {
                if (arr[i][inputPlayer].Contains(" ") == true)
                {
                    arr[i][inputPlayer] = playerSymbol;
                    i = -1;
                }
                else if (arr[0][inputPlayer].Contains(" ") == false)
                {
                    RowFull();
                    return arr;
                }
                i--;
            }
            return arr;

        }

        public static void RowFull()
        {
            Console.WriteLine();
            Console.WriteLine("Row is full please choose a different one!");
            Console.WriteLine();
        }

        public static string player = "";

        public static bool CheckIfPlayerWon(string[][] arr)
        {

            int countO = 0;
            int countX = 0;


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j].Contains("X"))
                    {
                        countX++;
                        countO = 0;
                    }
                    else if (arr[i][j].Contains("O"))
                    {
                        countO++;
                        countX = 0;
                    }
                    else
                    {
                        countO = 0;
                        countX = 0;
                    }

                    if (countX == 4)
                    {
                        player = "one";
                        return true;
                    }
                    else if (countO == 4)
                    {
                        player = "two";
                        return true;

                    }

                }
            }

            for (int j = 0; j < arr[0].Length; j++)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i][j].Contains("X"))
                    {
                        countX++;
                        countO = 0;
                    }
                    else if (arr[i][j].Contains("O"))
                    {
                        countO++;
                        countX = 0;
                    }
                    else
                    {
                        countO = 0;
                        countX = 0;
                    }

                    if (countX == 4)
                    {
                        player = "one";
                        return true;
                    }
                    else if (countO == 4)
                    {
                        player = "two";
                        return true;

                    }

                }
            }
            //int i = arr.Length - 1;
            //while (i >= 0)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        if (arr[i][j].Contains("X"))
            //        {
            //            countX++;
            //            countO = 0;
            //        }
            //        else if (arr[i][j].Contains("O"))
            //        {
            //            countO++;
            //            countX = 0;
            //        }
            //        else
            //        {
            //            countO = 0;
            //            countX = 0;
            //        }
            //        i--;


            //        if (countX == 4)
            //        {
            //            player = "one";
            //            return true;
            //        }
            //        else if (countO == 4)
            //        {
            //            player = "two";
            //            return true;

            //        }
            //    }
            //}

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    for (int j = arr[i].Length - 1; j >= 0; j--)
            //    {
            //        while (i >= 0)
            //        {
            //            if (arr[i][j].Contains("X"))
            //            {
            //                countX++;
            //                countO = 0;
            //            }
            //            else if (arr[i][j].Contains("O"))
            //            {
            //                countO++;
            //                countX = 0;
            //            }
            //            else
            //            {
            //                countO = 0;
            //                countX = 0;
            //            }
            //            i--;
            //        }
            //        if (countX == 4)
            //        {
            //            player = "one";
            //            return true;
            //        }
            //        else if (countO == 4)
            //        {
            //            player = "two";
            //            return true;

            //        }
            //    }
            //}

            //for (int i = 0; i <= arr.Length - 4; i++)
            //{
            //    for (int j = 0; j <= arr[i].Length - 4; j++)
            //    {
            //        // Diagonal nach rechts oben
            //        if (arr[i][j] == "X" && arr[i + 1][j + 1] == "X" && arr[i + 2][j + 2] == "X" && arr[i + 3][j + 3] == "X")
            //        {
            //            player = "one";
            //            return true; }

            //        else if (arr[i][j] == "O" && arr[i + 1][j + 1] == "O" && arr[i + 2][j + 2] == "O" && arr[i + 3][j + 3] == "O")
            //        {
            //            player = "two";
            //            return true; }

            //        // Diagonal nach rechts unten
            //        if (arr[i + 3][j] == "X" && arr[i + 2][j + 1] == "X" && arr[i + 1][j + 2] == "X" && arr[i][j + 3] == "X")
            //        {
            //            player = "one";
            //            return true; }

            //        else if (arr[i + 3][j] == "O" && arr[i + 2][j + 1] == "O" && arr[i + 1][j + 2] == "O" && arr[i][j + 3] == "O")
            //        {
            //            player = "two";
            //            return true; }
            //    }
            for (int i = arr.Length - 1; i >= arr.Length - 3; i--)
            {
                for (int j = 0; j < arr[i].Length - 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (arr[i - k][j + k].Contains("X"))
                        {
                            countX++;
                            countO = 0;
                        }
                        else if (arr[i - k][j + k].Contains("O"))
                        {
                            countO++;
                            countX = 0;
                        }
                        else
                        {
                            countO = 0;
                            countX = 0;
                        }

                        if (countX == 4)
                        {
                            player = "one";
                            return true;
                        }
                        else if (countO == 4)
                        {
                            player = "two";
                            return true;

                        }

                    }
                }

            }

            for (int i = arr.Length - 1; i >= arr.Length - 3; i--)
            {
                for (int j = arr[i].Length - 1; j > arr.Length - 4; j--)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (arr[i - k][j - k].Contains("X"))
                        {
                            countX++;
                            countO = 0;
                        }
                        else if (arr[i - k][j - k].Contains("O"))
                        {
                            countO++;
                            countX = 0;
                        }
                        else
                        {
                            countO = 0;
                            countX = 0;
                        }

                        if (countX == 4)
                        {
                            player = "one";
                            return true;
                        }
                        else if (countO == 4)
                        {
                            player = "two";
                            return true;

                        }

                    }
                }

            }
            return false;
        }







    }

}


