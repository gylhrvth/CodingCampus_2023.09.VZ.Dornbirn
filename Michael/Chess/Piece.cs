using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Chess
{
    internal enum Color
    {
        White, Black
    }

    internal enum Type
    {
        King, Queen, Bishop, Knight, Rook, Pawn
    }

    internal class Piece
    {
        private Type _type;
        private Color _color;
        private bool _highlighted;
        private char _symbol;


        public Color Color { get => _color; }
        public bool Highlighted { get => _highlighted; set => _highlighted = value; }
        public Type Type { get => _type; }


        public Piece(Type type, Color color)
        {
            _type = type;
            _color = color;
            _highlighted = false;
            
            switch (_type)
            {
                case Type.Queen:
                    _symbol = 'Q';
                    break;

                case Type.King:
                    _symbol = 'K';
                    break;

                case Type.Bishop:
                    _symbol = 'B';
                    break;

                case Type.Knight:
                    _symbol = 'H';
                    break;

                case Type.Rook:
                    _symbol = 'R';
                    break;

                case Type.Pawn:
                    _symbol = 'P';
                    break;
            }
        }


        public void GetsBeaten(Piece piece)
        {
            Console.WriteLine($"{piece.Color} {piece.Type} beats the {_color} {_type}");
        }


        public void MoveFromTo((int, int) start, (int, int) goal, Piece[,] field)
        {
            field[goal.Item1, goal.Item2] = this;
            field[start.Item1, start.Item2] = null;
        }
         

        public bool IsValidMove((int, int) start, (int, int) end, Piece[,] field)
        {
            bool allowed = false;
            bool isKnight = false;

            switch (_type)
            {
                case Type.King:
                    allowed = Math.Abs(start.Item1 - end.Item1) < 2 &&
                               Math.Abs(start.Item2 - end.Item2) < 2;
                    break;

                case Type.Queen:
                    allowed = start.Item1 == end.Item1 ||
                              start.Item2 == end.Item2 ||
                              Math.Abs(start.Item1 + start.Item2) == Math.Abs(end.Item1 + end.Item2);
                    break;

                case Type.Bishop:
                    allowed = Math.Abs(start.Item1 + start.Item2) == Math.Abs(end.Item1 + end.Item2);
                    break;

                case Type.Knight: 
                    allowed = Math.Abs(start.Item1 - end.Item1) == 1 && Math.Abs(start.Item2 - end.Item2) == 2 ||
                              Math.Abs(start.Item1 - end.Item1) == 2 && Math.Abs(start.Item2 - end.Item2) == 1;

                    isKnight = true;

                    break;

                case Type.Rook:
                    allowed = start.Item1 == end.Item1 ||
                              start.Item2 == end.Item2;
                    break;

                case Type.Pawn:

                    if (_color == Color.White)
                    {
                        if ((start.Item1 == end.Item1 + 1 && start.Item2 == end.Item2) ||
                             (start.Item1 == field.GetLength(0) - 2 && start.Item1 == end.Item1 + 2 && start.Item2 == end.Item2) ||
                             (field[end.Item1, end.Item2] != null && field[end.Item1, end.Item2].Color == Color.Black && start.Item1 == end.Item1 + 1 && Math.Abs(start.Item2 - end.Item2) == 1))
                        {
                            allowed = true;
                        }

                    }
                    else
                    {
                        if ((start.Item1 == end.Item1 - 1 && start.Item2 == end.Item2) ||
                             (start.Item1 == 1 && start.Item1 == end.Item1 - 2 && start.Item2 == end.Item2) ||
                             (field[end.Item1, end.Item2] != null && field[end.Item1, end.Item2].Color == Color.White && start.Item1 == end.Item1 - 1 && Math.Abs(start.Item2 - end.Item2) == 1))
                        {
                            allowed = true;
                        }
                    }

                    break;
            }

            int rowDiff = start.Item1 - end.Item1;
            int colDiff = start.Item2 - end.Item2;

            for (int steps = 1; steps < Math.Abs(rowDiff); steps++)
            {
                try
                {
                    allowed = allowed && (field[start.Item1 - Math.Sign(rowDiff) * steps, start.Item2 + Math.Sign(colDiff) * steps] == null || isKnight);
                }
                catch { }

            }

            return allowed;
        }


        public override string ToString()
        {
            return _symbol.ToString();
        }

    }
}





