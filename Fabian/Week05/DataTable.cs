namespace Fabian.Week05
{
    public class DataTable
    {
        public static void Start()
        {
            String[] firstNames = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastNames = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] ages = { 40, 78, 5, 18, 81 };
            String[] places = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distancesFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            PrintDataInTable(firstNames, lastNames, ages, places, distancesFromCapital);
        }

        public static void PrintDataInTable(String[] firstNames, String[] lastNames, int[] ages, String[] places, float[] distancesFromCapital)
        {
            // if the length of the highest value is bigger than the length of the name of the column = take the length of the highest value
            // else = take the length of the name of the column
            int firstNameMaxLength = Math.Max(9, GetMaxLength(firstNames));
            int lastNameMaxLength = Math.Max(8, GetMaxLength(lastNames));
            int ageMaxLength = Math.Max(3, GetMaxLength(ages));
            int placeMaxLength = Math.Max(5, GetMaxLength(places));
            int distanceMaxLength = Math.Max(21, GetMaxLength(distancesFromCapital));
         
            int totalLength = firstNameMaxLength + lastNameMaxLength + ageMaxLength + placeMaxLength + distanceMaxLength + 12;
            string line = new('-', totalLength);

            // print table
            Console.WriteLine(line);
            Console.WriteLine($"Firstname{new string(' ', firstNameMaxLength - 9)} | Lastname{new string(' ', lastNameMaxLength - 8)} | Age{new string(' ', ageMaxLength - 3)} | Place{new string(' ', placeMaxLength - 5)} | Distance from Capital");
            Console.WriteLine(line);
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{firstNames[i]}{new string(' ', firstNameMaxLength - firstNames[i].Length)} | {lastNames[i]}{new string(' ', lastNameMaxLength - lastNames[i].Length)} | {ages[i]}{new string(' ', ageMaxLength - ages[i].ToString().Length)} | {places[i]}{new string(' ', placeMaxLength - places[i].Length)} | {distancesFromCapital[i]}");
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
