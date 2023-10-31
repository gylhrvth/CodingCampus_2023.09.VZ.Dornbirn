using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week05
{
    internal class TableExample
    {
        public static void Start()
        {
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            

        }

        public static int[] MaxLenghtColumn(string[][] table)
        {
            int[] maxWidth = new int[table[0].Length];

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    if (table[i][j].Length > maxWidth[j])
                    {
                        maxWidth[j] = table[i][j].Length;
                    }

                }
            }
            return maxWidth;
        }

    }
}
