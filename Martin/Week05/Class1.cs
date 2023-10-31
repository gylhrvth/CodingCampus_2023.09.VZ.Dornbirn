using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week05
{
    internal class Class1
    {
        public static void Start()
        {
            String text1 = "Hallo Weld";
            String text2 = "Batlo Width";

            string longest = GetLongestSubstring(text1, text2);
            Console.WriteLine("{0}\n{1}\n{2}", text1,text2,longest);

            Console.WriteLine("===============================");

            string stringLongword = GetLongestWord(text1, text2);
            Console.WriteLine("Longest Word: {0}", stringLongword);
        }

        public static string GetLongestWord(string text1, string text2)
        {
            string[] words1 = text1.Split(" ");
            string[] words2 = text2.Split(" ");

            Console.WriteLine("[{0}]", string.Join(", ",words1));
            Console.WriteLine("[{0}]", string.Join(", ", words2));

            string result = "";

            for(int i = 0; i < words1.Length;i++)
            {
                for(int j = 0; j < words2.Length; j++)
                {
                    Console.WriteLine("{0} - {1}", words1[i], words2[j]);
                    if (words1[i] == words2[j] && (words1.Length > result.Length))
                    {
                        result = words1[i];
                    }
                }
            }

            return result;
        }

        public static string GetLongestSubstring(string LongText, string shortText)
        {
            if(LongText.Length < shortText.Length)
            {
                return GetLongestSubstring(shortText, LongText);
            }

            string result = "";

            int targetLenght = shortText.Length;
            while(targetLenght > 0 && result.Length == 0)
            {
      
                for(int startpos = 0; startpos <= shortText.Length - targetLenght; startpos++)
                {
                    string textForSearch = shortText.Substring(startpos, targetLenght);
                    Console.WriteLine(textForSearch);

                    if(LongText.Contains(textForSearch))
                    {
                        result = textForSearch;
                    }
                }
                --targetLenght;
            }

            return result;
        }

    }
}
