using System;
using System.Linq.Expressions;
using System.Security;

namespace Erik.Week05
{
    public class StringTableSort
    {
        public static void Start()
        {

            String[] firstName = { "Alfonso", "Beatrix-Eleonos", "Cecil", "Dafghgfdghjgfdfghjgfdfghjniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 75, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };
            ToSort(firstName, lastName, age, place, distanceFromCapital, SortForLongestWord(firstName));

        }
        public static void ToSort(String[] firstName, String[] lastName, int[] age, String[] place, float[] distanceFromCapital, int longestWordDigit)
        {
            MiddleLines(longestWordDigit);

            //Console.WriteLine($"|{"FIRSTNAME",-16}|{"LASTNAME",-20} |{"AGE",-14} |{"PLACE",-17}|{"DISTANCE FROM CAPITAL",-31}|");
            String formatString = string.Format("|{{0,{0}}}|{{1,-20}} |{{2,-14}} |{{3,-17}}|{{4,-31}}|", -1*longestWordDigit);
            Console.WriteLine(formatString, "FIRSTNAME", "LASTNAME", "AGE", "PLACE", "DISTANCE FROM CAPITAL");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < firstName.Length; i++)
            {
                String formatString2 = string.Format("|{{0,{0}}}|{{1,-20}} |{{2,-14}} |{{3,-17}}|{{4,-31}}|", -1 * longestWordDigit);
                Console.WriteLine(formatString, firstName[i], lastName[i], age[i], place[i], distanceFromCapital[i]);
                //Console.WriteLine($"|{firstName[i],-16}|{lastName[i],-21}|{age[i],-15}|{place[i],-17}|{distanceFromCapital[i],-31}|");
            }
            Console.WriteLine("-");
        }

        public static int SortForLongestWord(String[] firstName)
        {
            int n = firstName.Length;
            int longestNumberDigits;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (firstName[j].Length > firstName[j + 1].Length)
                    {
                        string tmp = firstName[j];
                        firstName[j] = firstName[j + 1];
                        firstName[j + 1] = tmp;
                    }
                }
            }
            longestNumberDigits = firstName[firstName.Length -1].Length;
            Console.WriteLine(longestNumberDigits);
            return longestNumberDigits; 
        }

        public static void MiddleLines(int longestNumberDigit)
        {
            for (int i = 0; i < longestNumberDigit; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
