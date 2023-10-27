using System;
using System.Reflection.Metadata.Ecma335;

namespace David.Week05
{
	public class LaengsterSubstring
	{
		public static void Start()
		{
			String text1 = "Hello World!";
            String text2 = "Batlo Width";

			string longest = GetLongestSubstring(text1, text2);
			Console.WriteLine("{0}\n{1}\n{2}", text1, text2, longest);

			Console.WriteLine("-------------");
			string longestWord = GetLongestWord(text1, text2);
			Console.WriteLine("Longest Word; " );
        }

		//Längstes gemeinsames Wort
		public static string GetLongestWord(string text1, string text2)
		{
			string[] words1 = text1.Split(" ");
			string[] words2 = text2.Split(" ");

			string result = "";
			for (int i = 0; i < words1.Length; i++)
			{
				for (int j = 0; j < words2.Length; j++)
				{
					if (words1[i] == words2[j] && words1.Length > result.Length)
					{
						result = words1[i];
					}
				}
			}

            return result;
		}



        //zweite Aufgabe
        public static string GetLongestSubstring(string longText, string shortText)
        {
      

            
            if (longText.Length < shortText.Length)
            {
                return GetLongestSubstring(shortText, longText);
            }

            string result = "";
            int tartetLength = shortText.Length;
            while (tartetLength > 0 && result.Length == 0)
            {
                for (int startPos = 0; startPos < shortText.Length - tartetLength; startPos++)
                {
                    string textForSearch = shortText.Substring(startPos, tartetLength);

                    if (longText.Contains(textForSearch))
                    {
                        result = textForSearch;
                    }
                }
                --tartetLength;
            }
            return result;
        }
    }
}

