using System.Text;

namespace Hassan.Week05
{
    public class FindSubString
    {
        public static void Start()
        {


            string text = "Heute wird ein guter Tag! Heute wird der beste Tag überhaupt! Heute wird ein spitzen super Tag!";
            string[] words = WordSplit(text, "Tag");
            Console.WriteLine(string.Join(Environment.NewLine, words));

            /*
            Console.WriteLine("Bitte gib Wort 1 ein:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Bitte gib Wort 2 ein:");
            string word2 = Console.ReadLine();

            string commonSubstring = FindLongestSubstring(word1, word2);

            Console.WriteLine($"Längster gemeinsamer Substring: {commonSubstring}");
            */
        }

        public static string FindLongestSubstring(string str1, string str2)
        {
            string longerStr;
            
            if (str1.Length > str2.Length){ longerStr = str1; }
            else
            {
                longerStr = str2;
            }

            string shorterStr;
            if (str1.Length > str2.Length){ shorterStr = str2; }
            else
            {
                shorterStr = str1;
            }

            int maxLength = 0;
            string longestSub = "";

            for (int i = 0; i < shorterStr.Length; i++)
            {
                for (int j = i + 1; j <= shorterStr.Length; j++)
                {
                    string subString = shorterStr.Substring(i, j - i);
                    if (longerStr.Contains(subString) && subString.Length > maxLength)
                    {
                        maxLength = subString.Length;
                        longestSub = subString;
                    }
                }
            }

            return longestSub;
        }




        static string[] WordSplit(string input, string separator)
        {
            string[] words = input.Split(separator);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {

                result.Append(word);
                result.Append(Environment.NewLine);


            }

            return result.ToString().Split(separator);
        }



    }
}
