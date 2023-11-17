using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Michael.Chess;

namespace Michael.Class
{
    internal class ChessGame
    {
        public static void Start()
        {
            Console.WriteLine("Press any button to start");
            Console.Read();
            string player1 = "Player 1";
            string player2 = "Player 2";

            Piece[,] field = SetUpNewField(8);

            bool gameOver = false;
            int round = 1;
            Color playerColor = Color.White;
            string playerName = player1;

            
            while (!gameOver)
            {
                if (round % 2 == 1)
                {
                    playerColor = Color.White;
                    playerName = player1;
                }
                else
                {
                    playerColor = Color.Black;
                    playerName = player2;
                }

                //piece choice
                (int, int) choice = (0, 0);
                while (true)
                {                
                    Console.WriteLine($"{playerName}, you are {playerColor}, which piece do you want to move?\nChose a row/column (like B4)");
                    choice = GetUserInput();

                    if ( choice == (-1, -1) )
                    {
                        Console.Clear();
                        PrintField(field);
                        continue;
                    }
                    else if ( field[choice.Item1, choice.Item2] == null)
                    {
                        Console.Clear();
                        PrintField(field);
                        Console.WriteLine("Sorry, that is an empty field!");
                        continue;
                    }
                    else if (field[choice.Item1, choice.Item2].Color != playerColor)
                    {
                        Console.Clear();
                        PrintField(field);
                        Console.WriteLine("Sorry, this is not your piece to move!");
                    }
                    else
                    {
                        field[choice.Item1, choice.Item2].Highlighted = true;
                        PrintField(field);
                        break;
                    }
                }

                Console.Clear();
                PrintField(field);

                //piece movement
                (int, int) destination = (0, 0);
                while (true)
                {
                    Console.WriteLine($"Now, where do you want to move your {field[choice.Item1, choice.Item2].Type}?");
                    destination = GetUserInput();

                    if (destination == (-1, -1))
                    {
                        field[choice.Item1, choice.Item2].Highlighted = false;
                        round--;
                        Console.Clear();
                        PrintField(field);
                        break;
                    }
                    else if (field[destination.Item1, destination.Item2] == null)
                    {
                        if (!field[choice.Item1, choice.Item2].IsValidMove(choice, destination, field))
                        {
                            Console.Clear();
                            PrintField(field);
                            Console.WriteLine("Sorry, that is not a valid move!");
                            continue;
                        }
                        field[destination.Item1, destination.Item2] = field[choice.Item1, choice.Item2];
                        field[choice.Item1, choice.Item2] = null;
                        field[destination.Item1, destination.Item2].Highlighted = false;
                        Console.Clear();
                        PrintField(field);
                        break;
                    }
                    else if (!field[choice.Item1, choice.Item2].IsValidMove(choice, destination, field))
                    {
                        Console.Clear();
                        PrintField(field);
                        Console.WriteLine("Sorry, that is not a valid move!");
                        continue;
                    }
                    else if (field[destination.Item1, destination.Item2].Color == playerColor)
                    {
                        Console.Clear();
                        PrintField(field);
                        Console.WriteLine("Sorry, that is your own piece, can't attack that! ");
                        continue;
                    }
                    else if (field[destination.Item1, destination.Item2].Color != playerColor)
                    {
                        Piece deadOne = field[destination.Item1, destination.Item2];
                        field[destination.Item1, destination.Item2] = field[choice.Item1, choice.Item2];
                        field[choice.Item1, choice.Item2] = null;
                        field[destination.Item1, destination.Item2].Highlighted = false;
                        Console.Clear();
                        PrintField(field);
                        Console.WriteLine($"Congrats, you *murdered* the {deadOne.Color} {deadOne.Type}.");
                        break;
                    }
                }

                round++;
            }
        }


        public static (int, int) GetUserInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                input = input.Trim().Replace(" ", "").ToLower();

                if (input == "return")
                {
                    return (-1, -1);
                }
                else if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Please enter a valid string");
                    continue;
                }
                else if (input.Length == 1)
                {
                    Console.WriteLine("Input too short, please enter both row and column!");
                    continue;
                }
                else if (input.Length > 2)
                {
                    Console.WriteLine("Input too long, please enter only row and column!");
                    continue;
                }

                int row = 0;
                int column = 0;

                if (int.TryParse(input[0].ToString(), out row))
                {
                    if (int.TryParse(((int)input[1] - 96).ToString(), out column))
                    {
                        //NOOP
                    }
                    else
                    {
                        Console.WriteLine("Could not understand your column input. Please enter both a digit AND A LETTER");
                        continue;
                    }
                }
                else if (int.TryParse(input[1].ToString(), out row))
                {
                    if (int.TryParse(((int)input[0] - 96).ToString(), out column))
                    {
                        //NOOP
                    }
                    else
                    {
                        Console.WriteLine("Could not understand your column input. Please enter both a digit AND A LETTER");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Could not understand your column input. Please enter both a letter AND A DIGIT");
                    continue;
                }

                column -= 1;
                row = 8 - row;

                if (-1 < row && row < 8 && -1 < column && column < 8)
                {
                    return (row, column);
                }
                else
                {
                    Console.WriteLine("Sorry, that's outside the field!");
                    continue;
                }
            }
        }


        public static void PrintField(Piece[,] field)
        {
            for (int column = 0; column < field.GetLength(1); column++)
            {
                Console.Write($" {(char)(column + 65)} ");
            }
            Console.WriteLine();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int column = 0; column < field.GetLength(1);  column++)
                {
                    Console.BackgroundColor = ( (row + column) % 2 == 0) ? ConsoleColor.Gray : ConsoleColor.DarkGray;

                    bool highlighted = false;

                    if (field[row, column] != null)
                    {
                        Console.ForegroundColor = (field[row, column].Color == Color.White) ? ConsoleColor.Red : ConsoleColor.Blue;
                        highlighted = field[row,column].Highlighted;
                    }

                    Console.Write($"{((highlighted) ? '╠' : ' ')}{((field[row, column] != null) ? field[row, column] : ' ')}{((highlighted) ? '╣' : ' ')}");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" {8 - row}");
            }
        }


        public static Piece[,] SetUpNewField(int size)
        {
            Piece[,] newField = new Piece[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    newField[row, column] = null;
                }
            }

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(1000);

            for (int i = 0; i < size; i++)
            {
                newField[1, i] = new Piece(Chess.Type.Pawn, Color.Black);
                newField[size - 2, i] = new Piece(Chess.Type.Pawn, Color.White);
                Console.SetCursorPosition(0, 0);
                PrintField(newField);
                Thread.Sleep(100);
            }

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            newField[0,0] = newField[0, size - 1] = new Piece(Chess.Type.Rook, Color.Black);
            newField[size - 1, 0] = newField[size - 1, size - 1] = new Piece(Chess.Type.Rook, Color.White);

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            newField[0, 1] = newField[0, size - 2] = new Piece(Chess.Type.Knight, Color.Black);
            newField[size - 1, 1] = newField[size - 1, size - 2] = new Piece(Chess.Type.Knight, Color.White);

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            newField[0, 2] = newField[0, size - 3] = new Piece(Chess.Type.Bishop, Color.Black);
            newField[size - 1, 2] = newField[size - 1, size - 3] = new Piece(Chess.Type.Bishop, Color.White);

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            newField[0, 3] = new Piece(Chess.Type.Queen, Color.Black);
            newField[size - 1, 3] = new Piece(Chess.Type.Queen, Color.White);

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            newField[0, size - 4] = new Piece(Chess.Type.King, Color.Black);
            newField[size - 1, size - 4] = new Piece(Chess.Type.King, Color.White);

            Console.SetCursorPosition(0, 0);
            PrintField(newField);
            Thread.Sleep(500);

            return newField;
        }
    }
}
