
namespace Jovo.Week05
{
    internal class DatenTabellarischdarstellen
    {
        public static void Start()
        {
            string[] firstNames = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastNames = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] ages = { 40, 78, 5, 18, 81 };
            string[] places = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] CapitalDistance = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            PrintDataInTable(firstNames, lastNames, ages, places, CapitalDistance);

            Console.WriteLine("X{0, -20}X", "Hello World!");
        }

        public static void PrintDataInTable(string[] firstNames, string[] lastNames, int[] ages, string[] places, float[] CapitalDistance)
        {
            Console.WriteLine("MaximaleLänge" + GetMaxLength(firstNames));

            int FirstNameMaxLenght = GetMaxLength(firstNames);
            int lastNamesMaxLength = GetMaxLength(lastNames);
            int ageMaxLength = GetMaxLengthNR(ages);
            int placesMaxLength = GetMaxLength(places);
            int Capitaldistances = GetMaxLengthNRF(CapitalDistance);

            Console.WriteLine();



        }



        //Länge von names und places
        public static int GetMaxLength(string[] arr)
        {
            int maxLength = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (maxLength < arr[i].Length)
                {
                    maxLength = arr[i].Length;
                }


            }
            return maxLength;
        }
        //Länge agecd
        public static int GetMaxLengthNR(int[] arr)
        {
            int maxLength = 0;
            for ( int i = 0; i < arr.Length; ++i )
            {
                if (maxLength < arr[i].ToString().Length)
                {
                    maxLength = arr[i].ToString().Length;
                }
            }
            return maxLength;
        }

        //Länge CapitalDistance
        public static int GetMaxLengthNRF(float[] arr)
        {
            int maxLength = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (maxLength < arr[i].ToString().Length)
                {
                    maxLength = arr[i].ToString().Length;
                }
            }
            return maxLength;
        }


    }
}
