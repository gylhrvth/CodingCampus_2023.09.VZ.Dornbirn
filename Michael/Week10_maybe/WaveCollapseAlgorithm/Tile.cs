using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week10_maybe.WaveCollapseAlgorithm
{
    public enum Direction
    {
        Up, Right, Down, Left
    }


    public class has
    {
        public static Dictionary<(string, Direction), bool> Wall = new Dictionary<(string, Direction), bool>()
        {
            { ("╚═", Direction.Up), true }, { ("╚═", Direction.Right), true }, { ("╚═", Direction.Down), false }, { ("╚═", Direction.Left), false },
            { ("╔═", Direction.Up), false }, { ("╔═", Direction.Right), true }, { ("╔═", Direction.Down), true }, { ("╔═", Direction.Left), false },
            { ("╩═", Direction.Up), true }, { ("╩═", Direction.Right), true }, { ("╩═", Direction.Down), false }, { ("╩═", Direction.Left), true },
            { ("╦═", Direction.Up), false }, { ("╦═", Direction.Right), true }, { ("╦═", Direction.Down), true }, { ("╦═", Direction.Left), true },
            { ("╠═", Direction.Up), true }, { ("╠═", Direction.Right), true }, { ("╠═", Direction.Down), true }, { ("╠═", Direction.Left), false },
            { ("══", Direction.Up), false }, { ("══", Direction.Right), true }, { ("══", Direction.Down), false }, { ("══", Direction.Left), true },
            { ("╣ ", Direction.Up), true }, { ("╣ ", Direction.Right), false }, { ("╣ ", Direction.Down), true }, { ("╣ ", Direction.Left), true },
            { ("║ ", Direction.Up), true }, { ("║ ", Direction.Right), false }, { ("║ ", Direction.Down), true }, { ("║ ", Direction.Left), false },
            { ("╗ ", Direction.Up), false }, { ("╗ ", Direction.Right), false }, { ("╗ ", Direction.Down), true }, { ("╗ ", Direction.Left), true },
            { ("╝ ", Direction.Up), true }, { ("╝ ", Direction.Right), false }, { ("╝ ", Direction.Down), false }, { ("╝ ", Direction.Left), true },
            { ("╬═", Direction.Up), true }, { ("╬═", Direction.Right), true }, { ("╬═", Direction.Down), true }, { ("╬═", Direction.Left), true },
            { ("  ", Direction.Up), false }, { ("  ", Direction.Right), false }, { ("  ", Direction.Down), false }, { ("  ", Direction.Left), false }
        };

        public static List<string> Options = new List<string> { "╚═", "╔═", /*"╩═",*/ /*"╦═",*/ /*"╠═",*/ "══", "╬═", /*"╣ ",*/ "║ ", "╗ ", "╝ ", "  " };

        public static Direction Opposite(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up: return Direction.Down;
                case Direction.Right: return Direction.Left;
                case Direction.Down: return Direction.Up;
                case Direction.Left: return Direction.Right;
                default: return Direction.Up;
            }
        }
    }


    public class Tile
    {
        private Random rnd = new Random();

        private List<string> _probSpace = new List<string>(has.Options);

        private List<(Tile, Direction)> _Neighbors = new List<(Tile, Direction)>();

        private bool _Collapsed = false;

        public bool Collapsed { get => _Collapsed; }

        public Tile() { }


        public List<string> GetProbSpace()
        {
            return _probSpace;
        }


        public List<(Tile, Direction)> GetNeighbors()
        {
            return _Neighbors;
        }


        public bool AdjustProbSpace()
        {
            if (_Collapsed == true)
            {
                return false;
            }

            int maxOptions = has.Options.Count;
            bool skippable = true;
            foreach ((Tile, Direction) neighbor in _Neighbors)
            {
                List<string> probSpace = neighbor.Item1.GetProbSpace();

                if (probSpace.Count < maxOptions)
                {
                    skippable = false; ;
                    break;
                }
            }
            if (skippable) return false;


            bool somethingChanged = false;
            List<string> temp = new List<string>(_probSpace);

            for (int i = temp.Count - 1; i >= 0; i--)
            {
                string option = temp[i];
                bool valid = true;

                foreach ((Tile, Direction) neighbor in _Neighbors)
                {
                    Tile neighborTile = neighbor.Item1;
                    Direction neighborDirection = neighbor.Item2;

                    List<string> probSpace = neighborTile.GetProbSpace();

                    bool oneFits = false;
                    foreach (string element in probSpace)
                    {
                        if (has.Wall[(option, neighborDirection)] == has.Wall[(element, has.Opposite(neighborDirection))])
                        {
                            oneFits = true;
                            break;
                        }
                    }

                    valid = valid && oneFits;
                }

                if (!valid)
                {
                    temp.Remove(option);
                    somethingChanged = true;
                }


            }
            _probSpace = temp;
            return somethingChanged;
        }


        public void AddNeighbor(Tile neighbor, Direction direction)
        {
            _Neighbors.Add((neighbor, direction));
        }


        public void Collapse()
        {
            _probSpace = new List<string> { _probSpace[rnd.Next(_probSpace.Count)] };
            _Collapsed = true;
        }


        public override string ToString()
        {
            if (_probSpace.Count == 1)
            {
                return _probSpace[0];
            }
            else
            {
                return $"{_probSpace.Count,2}";
            }
        }



    }
}
