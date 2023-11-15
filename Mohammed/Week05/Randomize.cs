using System;
namespace Mohammed.Week05
{
    public class Randomize
    {
        public static Random rand = new Random();
        public static void Start()
        {
            Console.WriteLine("Willkommen zum Zufallsshuffle Programm!!!!!!!");
            Console.Write(">>>>");

            string text = Console.ReadLine();

            Console.WriteLine(RandomizeString(text));
        }

        public static string RandomizeString(string text)
        {
            char[] arr = text.ToCharArray();

            for (int i = 0; i < 3 * arr.Length; i++)
            {
                int posA = rand.Next(arr.Length);
                int posB = rand.Next(arr.Length);

                char temp = arr[posA];
                arr[posA] = arr[posB];
                arr[posB] = temp;
            }

            return new string(arr);
        }
    }
}

