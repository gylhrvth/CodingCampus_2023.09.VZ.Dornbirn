using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week04
{
    internal class QueenProblemGyula
    {
        public static void Start()
        {
            Queen(4);
        }

        public static void Queen(int size)
        {
            int[] pos = new int[size];
            
            AddQueen(0, pos, size);
        }

            
        public static void AddQueen(int col, int[] pos, int size)
        {
            Console.WriteLine("[{0}]", string.Join(", ", pos));
            if (col < size)
            {
                while (pos[col] < size)
                {
                    AddQueen(col + 1, pos, size);
                    ++pos[col];
                }
            }
        }
    }
}
