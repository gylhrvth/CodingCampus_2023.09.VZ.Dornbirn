using static Fabian.Week03.Arrays;
using static Fabian.Week03.TicTacToeClass;

namespace Fabian.Week04
{
    public class TicTacToeAlgorithm
    {
        public static void Start()
        {
            TicTacToe();
        }

        public static void TicTacToe()
        {
            int[,] board = new int[3, 3];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 0;
                }
            }

            int pcGuess;
        }
    }
}
