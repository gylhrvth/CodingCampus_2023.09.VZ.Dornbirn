using static Ressources.StringRessources;

namespace Mohammed.Selftest
{
    public class StringManipulation
    {
        public static void Start()
        {
            string[] texte = new string[]
            {
                "Apfel",
                "regallager",
                "hanna",
                "reittier"
            };

            foreach (string text in texte)
            {
                Console.WriteLine("{0} is palindrome: {1}",
                    text,
                    IsPalindrome(text));
            }

        }

        public static bool IsPalindrome(string text)
        {
            text = text.ToLower();
            char[]  chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[text.Length - 1 - i];
            }

            string result = new string(chars);
            if(result == text)
            {
                return true;
            }
            return false;
        }

        public static string GetLongestWord(string text1, string text2)
        {
            string text = text1 + " " + text2;
            char[] chars = { ' ', ',', '-', '!', '?', '.','"' };
            string[] word = text.Split(chars, '-');


            return text;
        }

}   }

