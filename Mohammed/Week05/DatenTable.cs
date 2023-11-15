using System;
namespace Mohammed.Week05
{
    public class DatenTable
    {
        public static void Start()
        {
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            int col = 5;
            bool[] isAlignedLeft = new bool[col];
            string[][] table = Create2DStringArray(1 + firstName.Length, col);

            MaxLengthPerColumn(table);
            PrintTable(table, isAlignedLeft);


        }


        public static int[] MaxLengthPerColumn(string[][] table)
        {
            int[] mWidth = new int[table[0].Length];

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    if (table[i][j].Length > mWidth[j])
                    {
                        mWidth[j] = table[i][j].Length;
                    }
                }
            }
            return mWidth;

        }

        public static void PrintTable(string[][] table, bool[] alignedLeft)
        {
            int[] widthperColum = MaxLengthPerColumn(table);
            Console.WriteLine(string.Join(", ", widthperColum));

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    int width = widthperColum[j];
                    if (alignedLeft[j])
                    {
                        width *= -1;
                    }

                    string formatString = string.Format("| {{0,{0}}} ", width);
                    Console.Write(formatString, table[i][j]);
                }
                Console.WriteLine("|");
            }

        }


        public static string[][] Create2DStringArray(int rows, int col)
        {
            string[][] result = new string[rows][];
            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = new string[col];
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = "Hello World!";
                }
            }
            return result;

        }


    }
}

