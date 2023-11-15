using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michael.Chess;

namespace Michael.Class
{
    internal class ChessGame
    {
        public static void Start()
        {
            Piece[,] field = SetUpNewField(8);

            field[1, 2].Highlighted = true;


            PrintField(field);



        }

        public static void PrintField(Piece[,] field)
        {
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
                Console.WriteLine();
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

            for(int i = 0; i < size; i++)
            {
                newField[1, i] = new Piece(Chess.Type.Pawn, Color.Black);
                newField[size - 2, i] = new Piece(Chess.Type.Pawn, Color.White);
            }

            newField[0,0] = newField[0, size - 1] = new Piece(Chess.Type.Rook, Color.Black);
            newField[size - 1, 0] = newField[size - 1, size - 1] = new Piece(Chess.Type.Rook, Color.White);

            newField[0, 1] = newField[0, size - 2] = new Piece(Chess.Type.Knight, Color.Black);
            newField[size - 1, 1] = newField[size - 1, size - 2] = new Piece(Chess.Type.Knight, Color.White);

            newField[0, 2] = newField[0, size - 3] = new Piece(Chess.Type.Bishop, Color.Black);
            newField[size - 1, 2] = newField[size - 1, size - 3] = new Piece(Chess.Type.Bishop, Color.White);

            newField[0, 3] = new Piece(Chess.Type.Queen, Color.Black);
            newField[size - 1, 3] = new Piece(Chess.Type.Queen, Color.White);

            newField[0, size - 4] = new Piece(Chess.Type.King, Color.Black);
            newField[size - 1, size - 4] = new Piece(Chess.Type.King, Color.White);

            return newField;
        }
    }
}
