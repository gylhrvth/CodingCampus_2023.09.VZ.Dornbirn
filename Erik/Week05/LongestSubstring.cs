using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week05
{
    internal class LongestSubstring
    {
        public static void Start()
        {

            String text1 = "Hello World!";
            String text2 = "Batlo Width";

            string longest = GetLongestSubstring(text1, text2);
            Console.WriteLine("{0}\n{1]\n{2}", text1, text2, longest);
        }

        public static string GetLongestSubstring(String longText, string shortText)
        {
            if (longText.Length < shortText.Length)
            {
                return GetLongestSubstring(shortText, longText);
            }

            string result = "";
            int targetLength = shortText.Length;
            while (targetLength > 0 && result.Length == 0)
            {
                for (int startPos = 0; startPos <= shortText.Length - targetLength; startPos++)
                {
                    string textForSearch = shortText.Substring(startPos, targetLength);

                    if (longText.Contains(textForSearch))
                    {
                        result = textForSearch;
                        Console.WriteLine(textForSearch);
                    }
                }
                --targetLength;
            }

            return result;
        }
    }
}
