using static Ressources.StringRessources;

namespace Fabian.Selftest_SP
{
    public class StringTasks
    {
        public static void Start()
        {
            Console.WriteLine("Apfel = " + CheckPalindrome("Apfel"));
            Console.WriteLine("Regallager = " + CheckPalindrome("Regallager"));
            Console.WriteLine("Hanna = " + CheckPalindrome("Hanna"));
            Console.WriteLine("Reittier = " + CheckPalindrome("Reittier"));
            Console.WriteLine();

            Console.WriteLine("Longest word: " + FindLongestWord(getHesse(), getText())); 
            Console.WriteLine("Shortest word: " + FindShortestWord(getHesse(), getText())); 

        }
        public static bool CheckPalindrome(string word)
        {
            word = word.ToLower();
            char[] chars = word.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = word[word.Length - 1 - i];
            }
            string result = new(chars);

            if (result == word) return true;
            return false;
        }
        public static string FindLongestWord(string text1, string text2 = "")
        {
            string text = text1 + " " + text2;
            char[] seperators =  { ' ', ',', '!', '?', '-', '.', ';', ':', '"' };
            string[] words = text.Split(seperators);
            string max = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max.Length) max = words[i];
            }
            return max;
        }
        public static string FindShortestWord(string text1, string text2 = "")
        {
            string text = text1 + " " + text2;
            char[] seperators = { ' ', ',', '!', '?', '-', '.', ';', ':', '"' };
            string[] words = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            string min = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < min.Length) min = words[i];
            }
            return min;
        }
    }
}
