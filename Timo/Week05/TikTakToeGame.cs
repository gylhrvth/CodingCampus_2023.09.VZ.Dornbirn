using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Timo.Week03;
using Timo.Week04;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timo.Week05
{
    internal class TikTakToeGame
    {
        public static void Start()
        {
            TikTakToe();
        }

        public static void TikTakToe()
        {
            int count = 1;
            //Erstellen des Musterfelds
            string[][] showField = Array2D.CreateEmptyArray(3, 3);
            showField[0][0] = "1";
            showField[0][1] = "2";
            showField[0][2] = "3";
            showField[1][0] = "4";
            showField[1][1] = "5";
            showField[1][2] = "6";
            showField[2][0] = "7";
            showField[2][1] = "8";
            showField[2][2] = "9";




            //Erstellen des Spielfelds
            //string[][] arr2D = Array2D.CreateEmptyArray(3, 3);
            //for (int row = 0; row < arr2D.Length; row++)
            //{
            //    for (int col = 0; col < arr2D[row].Length; col++)
            //    {
            //        arr2D[row][col] = " ";
            //    }
            //}

            string player1String = "X";
            string player2String = "O";
            int scorePlayerOne = 0;
            int scorePlayerTwo = 0;
            bool newRound = true;
            bool gameRunning = true;
            bool playerOneTurn = true;
            bool playerTwoTurn = false;

            while (newRound)
            {
                string[][] arr2D = Array2D.CreateEmptyArray(3, 3);
                for (int row = 0; row < arr2D.Length; row++)
                {
                    for (int col = 0; col < arr2D[row].Length; col++)
                    {
                        arr2D[row][col] = " ";
                    }
                }
                Console.WriteLine("Score: Player 1: {0}\t\tPlayer 2: {1}", scorePlayerOne, scorePlayerTwo);
                while (gameRunning)
                {
                    while (playerOneTurn)
                    {
                        PrintGameArea(showField);
                        Data(arr2D);
                        PrintGameArea(arr2D);
                        if (Solutions(arr2D, count) == true)
                        {
                            gameRunning = false;
                            scorePlayerOne++;
                            break;

                        }
                        count++;
                        playerOneTurn = false;
                        playerTwoTurn = true;

                    }
                    while (playerTwoTurn)
                    {
                        PrintGameArea(showField);
                        Data2(arr2D);
                        PrintGameArea(arr2D);
                        if (Solutions(arr2D, count) == true)
                        {
                            gameRunning = false;
                            scorePlayerTwo++;
                            break;

                        }
                        count++;
                        playerTwoTurn = false;
                        playerOneTurn = true;
                    }
                }
                while (true)
                {
                    Console.WriteLine();
                    string answer = ConsoleInputs.ReadString("If you want to end the game press 'e'.\nIf you want to start a new game press 'n'. \nIf you want to continue with the current score enter 'c'. ");
                    if (answer == "n")
                    {
                        scorePlayerOne = 0;
                        scorePlayerTwo = 0;
                        count = 0;
                        newRound = true;
                        gameRunning = true;
                        break;
                    }
                    else if (answer == "e")
                    {
                        Console.WriteLine("Hope to see you soon :)");
                        newRound = false;
                        break;
                    }
                    else if (answer == "c")
                    {
                        count = 0;
                        newRound = true;
                        gameRunning = true;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer");
                    }
                }
            }
        }

        public static string PrintGameArea(string[][] arr2D)
        {
            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | {0} | {1} | {2} | ", arr2D[0][0], arr2D[0][1], arr2D[0][2]);
            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | {0} | {1} | {2} | ", arr2D[1][0], arr2D[1][1], arr2D[1][2]);
            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | {0} | {1} | {2} | ", arr2D[2][0], arr2D[2][1], arr2D[2][2]);
            Console.WriteLine(" ------------- ");
            return "";
        }

        public static string[][] CreateEmptyArray(string[][] arr2D)
        {
            arr2D = Array2D.CreateEmptyArray(3, 3);
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    arr2D[row][col] = " ";
                }
            }
            return arr2D;
        }
        public static string[][] Data(string[][] arr2D)
        {
            bool notCorrectInput = true;
            string error = "Field alrerady taken, try another";
            while (notCorrectInput)
            {
                //ToDo: den code verbessert umsetzen!!!!!!!!!!!!
                //int number = ConsoleInputs.ReadNumber("It's Player 1's (X) turn: please enter a number ", 1, 9) - 1;
                //if (arr2D[number % 3][number / 3] == " ")
                //{
                //    arr2D[number % 3][number / 3] = 
                //    notCorrectInput = false;
                //}
                //else
                //{
                //    Console.WriteLine(error);
                //}


                int number = ConsoleInputs.ReadNumber("It's Player 1's (X) turn: please enter a number ", 1, 9);

                if (number == 1)
                {
                    if (arr2D[0][0] == " ")
                    {
                        arr2D[0][0] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 2)
                {
                    if (arr2D[0][1] == " ")
                    {
                        arr2D[0][1] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 3)
                {
                    if (arr2D[0][2] == " ")
                    {
                        arr2D[0][2] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 4)
                {
                    if (arr2D[1][0] == " ")
                    {
                        arr2D[1][0] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 5)
                {
                    if (arr2D[1][1] == " ")
                    {
                        arr2D[1][1] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 6)
                {
                    if (arr2D[1][2] == " ")
                    {
                        arr2D[1][2] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 7)
                {
                    if (arr2D[2][0] == " ")
                    {
                        arr2D[2][0] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 8)
                {
                    if (arr2D[2][1] == " ")
                    {
                        arr2D[2][1] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 9)
                {
                    if (arr2D[2][2] == " ")
                    {
                        arr2D[2][2] = "X";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            return arr2D;
        }
        public static string[][] Data2(string[][] arr2D)
        {
            bool notCorrectInput = true;
            string error = "Field alrerady taken, try another";
            while (notCorrectInput)
            {
                int number = ConsoleInputs.ReadNumber("It's Player 2's (O) turn: please enter a number ", 1, 9);
                if (number == 1)
                {
                    if (arr2D[0][0] == " ")
                    {
                        arr2D[0][0] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 2)
                {
                    if (arr2D[0][1] == " ")
                    {
                        arr2D[0][1] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 3)
                {
                    if (arr2D[0][2] == " ")
                    {
                        arr2D[0][2] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 4)
                {
                    if (arr2D[1][0] == " ")
                    {
                        arr2D[1][0] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 5)
                {
                    if (arr2D[1][1] == " ")
                    {
                        arr2D[1][1] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 6)
                {
                    if (arr2D[1][2] == " ")
                    {
                        arr2D[1][2] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 7)
                {
                    if (arr2D[2][0] == " ")
                    {
                        arr2D[2][0] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 8)
                {
                    if (arr2D[2][1] == " ")
                    {
                        arr2D[2][1] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                else if (number == 9)
                {
                    if (arr2D[2][2] == " ")
                    {
                        arr2D[2][2] = "O";
                        notCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            return arr2D;
        }
        public static bool Solutions(string[][] arr, int count)
        {
            if (arr[0][0] == "X" && arr[0][1] == "X" && arr[0][2] == "X" || arr[1][0] == "X" && arr[1][1] == "X" && arr[1][2] == "X" || arr[2][0] == "X" && arr[2][1] == "X" && arr[2][2] == "X" ||
            arr[0][0] == "X" && arr[1][0] == "X" && arr[2][0] == "X" || arr[0][1] == "X" && arr[1][1] == "X" && arr[2][1] == "X" || arr[0][2] == "X" && arr[1][2] == "X" && arr[2][2] == "X" ||
            arr[0][0] == "X" && arr[1][1] == "X" && arr[2][2] == "X" || arr[0][2] == "X" && arr[1][1] == "X" && arr[2][0] == "X")
            {
                Console.WriteLine("Player 1 WON!");
                return true;
            }
            else if (arr[0][0] == "O" && arr[0][1] == "O" && arr[0][2] == "O" || arr[1][0] == "O" && arr[1][1] == "O" && arr[1][2] == "O" || arr[2][0] == "O" && arr[2][1] == "O" && arr[2][2] == "O" ||
            arr[0][0] == "O" && arr[1][0] == "O" && arr[2][0] == "O" || arr[0][1] == "O" && arr[1][1] == "O" && arr[2][1] == "O" || arr[0][2] == "O" && arr[1][2] == "O" && arr[2][2] == "O" ||
            arr[0][0] == "O" && arr[1][1] == "O" && arr[2][2] == "O" || arr[0][2] == "O" && arr[1][1] == "O" && arr[2][0] == "O")
            {
                Console.WriteLine("Player 2 WON!");
                return true;
            }
            else if (count == 9)
            {
                Console.WriteLine("It's a draw!");
                return true;
            }
            return false;
        }
    }
}