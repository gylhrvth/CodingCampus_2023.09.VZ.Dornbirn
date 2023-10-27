namespace Fabian.Week05
{
    public class DataTable
    {
        public static void Start()
        {
            String[] headline = { "Firstname", "Lastname", "Age", "Place", "Distance from Capital" };
            String[] firstNames = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastNames = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] ages = { 40, 78, 5, 18, 81 };
            String[] places = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distancesFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            PrintDataInTable(firstNames, lastNames, ages, places, distancesFromCapital, headline);
        }

        public static void PrintDataInTable(String[] firstNames, String[] lastNames, int[] ages, String[] places, float[] distancesFromCapital, String[] headline)
        {
            // if the length of the highest value is bigger than the length of the name of the column = take the length of the highest value
            // else = take the length of the name of the column
            int firstNameMaxLength = Math.Max(headline[0].Length, GetMaxLength(firstNames));
            int lastNameMaxLength = Math.Max(headline[1].Length, GetMaxLength(lastNames));
            int ageMaxLength = Math.Max(headline[2].Length, GetMaxLength(ages));
            int placeMaxLength = Math.Max(headline[3].Length, GetMaxLength(places));
            int distanceMaxLength = Math.Max(headline[4].Length, GetMaxLength(distancesFromCapital));

            int totalLength = firstNameMaxLength + lastNameMaxLength + ageMaxLength + placeMaxLength + distanceMaxLength + 12;
            string line = new('-', totalLength);
            String formatString = string.Format("{{0,{0}}} | {{1,{1}}} | {{2,{2}}} | {{3,{3}}} | {{4,{4}} }", -1 * firstNameMaxLength, -1 * lastNameMaxLength, ageMaxLength, -1 * placeMaxLength, distanceMaxLength);

            Console.WriteLine(line);
            Console.WriteLine(formatString, headline[0], headline[1], headline[2], headline[3], headline[4]);
            Console.WriteLine(line);

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine(formatString, firstNames[i], lastNames[i], ages[i], places[i], distancesFromCapital[i]);
            }
        }

        // get length of the highest values
        public static int GetMaxLength(String[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max)
                {
                    max = arr[i].Length;
                }
            }
            return max;
        }
        public static int GetMaxLength(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().Length > max)
                {
                    max = arr[i].ToString().Length;
                }
            }
            return max;
        }
        public static int GetMaxLength(float[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().Length > max)
                {
                    max = arr[i].ToString().Length;
                }
            }
            return max;
        }


    }
}
