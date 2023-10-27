using System;
namespace David.Week05
{
	public class TabellarischDarstellen
	{
		public static void Start()
		{
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };


            Create2DStringArray(5, 5);
        }
       // public static void PrintTable(stri)

        public static string[][] Create2DStringArray(int row, int col)
        {
            string[][] table = new string[row][];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new string[col];
            }
            return table;
        }


	}
}

