using System;
namespace Gyula.Week05
{
	public class TableExample
	{
		public static void Start()
		{
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
            string[] origin = { "Austria", "Cuba", "Columbien", "Nigeria", "Hungary" };

            int columns = 6;
            bool[] isAlignedLeft = new bool[columns];
            string[][] table = Create2DStringArray(1 + firstName.Length, columns);
            AddColumn(table, isAlignedLeft, 0, "First name", firstName);
            AddColumn(table, isAlignedLeft, 1, "Last name", lastName);
            AddColumn(table, isAlignedLeft, 2, "Age", age);
            AddColumn(table, isAlignedLeft, 3, "Place", place);
            AddColumn(table, isAlignedLeft, 4, "Distance", distanceFromCapital);
            AddColumn(table, isAlignedLeft, 5, "Origin", origin);

            PrintTable(table, isAlignedLeft);
        }

        public static int[] MaxLenghtPerColumn(string[][] table)
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

        public static void PrintTable(string[][] table, bool[] alignLeft)
        {
            int[] widthPerColum = MaxLenghtPerColumn(table);
        
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    int width = widthPerColum[j];
                    if (alignLeft[j])
                    {
                        width *= -1;
                    }
                    string formatString = string.Format("|| {{0,{0}}} ", width);
                    Console.Write(formatString, table[i][j]);
                }
                Console.WriteLine("|");
            }
        }

        public static string[][] Create2DStringArray(int rows, int columns)
        {
            string[][] result = new string[rows][];
            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = new string[columns];
            }
            return result;
        }

        public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, string[] values)
        {
            table[0][column] = headline;
            alignLeft[column] = true;
            for (int i = 0; i < values.Length; ++i)
            {
                table[1 + i][column] = values[i];
            }
        }

        public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, int[] values)
        {
            table[0][column] = headline;
            alignLeft[column] = false;
            for (int i = 0; i < values.Length; ++i)
            {
                table[1 + i][column] = string.Format("{0}", values[i]);
            }
        }

        public static void AddColumn(string[][] table, bool[] alignLeft, int column, string headline, float[] values)
        {
            table[0][column] = headline;
            alignLeft[column] = false;
            for (int i = 0; i < values.Length; ++i)
            {
                table[1 + i][column] = string.Format("{0:N1}", values[i]);
            }
        }
    }
}

