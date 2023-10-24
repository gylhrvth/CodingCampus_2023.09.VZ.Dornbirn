
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
            String fNameSpaces = GetSpacesFName(firstNames);
            String lNameSpaces = GetSpacesLName(lastNames);
            String ageSpaces = GetSpacesAge(ages);
            String placeSpaces = GetSpacesPlace(places);
            String distanceSpaces = GetSpacesDistance(distancesFromCapital);
            

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Firstname{fNameSpaces} | Lastname{lNameSpaces} | Age{ageSpaces} | Place{placeSpaces} | Distance from Capital{distanceSpaces}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{firstNames[i]}{fNameSpaces} | {lastNames[i]}{lNameSpaces} | {ages[i]}{ageSpaces} | {places[i]}{placeSpaces} | {distancesFromCapital[i]}{distanceSpaces}");
            }

        }

        public static String GetSpacesFName(String[] firstNames)
        {
            String spaces = "";
            int max = 0;
            for (int i = 0; i < firstNames.Length; i++)
            {
                if (firstNames[i].Length > max)
                {
                    max = firstNames[i].Length;
                }
            }

            for (int i = 0; i < max; i++)
            {
                spaces += " ";
            }

            return spaces;
        }

        public static String GetSpacesLName(String[] lastNames)
        {
            String spaces = "";
            int max = 0;
            for (int i = 0; i < lastNames.Length; i++)
            {
                if (lastNames[i].Length > spaces.Length)
                {
                    max = lastNames[i].Length;
                }
            }

            for (int i = 0; i < max; i++)
            {
                spaces += " ";
            }

            return spaces;
        }

        public static String GetSpacesAge(int[] ages)
        {
            String spaces = "";
            int max = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i].ToString().Length > max)
                {
                    max = ages[i].ToString().Length;
                }
            }

            for (int i = 0; i < max; i++)
            {
                spaces += " ";
            }

            return spaces;
        }

        public static String GetSpacesPlace(String[] places)
        {
            String spaces = "";
            int max = 0;
            for (int i = 0; i < places.Length; i++)
            {
                if (places[i].Length > max)
                {
                    max = places[i].Length;
                }
            }

            for (int i = 0; i < max; i++)
            {
                spaces += " ";
            }

            return spaces;
        }

        public static String GetSpacesDistance(float[] distances)
        {
            String spaces = "";
            float max = 0;
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i].ToString().Length > max)
                {
                    max = distances[i].ToString().Length;
                }
            }

            for (int i = 0; i < max; i++)
            {
                spaces += " ";
            }

            return spaces;
        }
    }
}
