using System;
namespace Mohammed.Week05
{
	public class LongestSubstring
	{
		public static void Start()
		{
			string text1 = "Hello World";
			string text2 = "Batlo width Hello Apfel Saft";

			string longest = GetlongestSubstring(text1, text2);

			Console.WriteLine("{0}\n{1}\n{2}", text1, text2, longest);

			Console.WriteLine("====================");
			string longestWord = GetlongestWord(text1, text2);
		}


		public static string GetlongestWord(string text1, string text2)
		{
			string[] words1 = text1.Split(" ");
			string[] words2 = text2.Split(" ");

			Console.WriteLine("[{0}]", string.Join(", ", words1));
            Console.WriteLine("[{0}]", string.Join(", ", words2));

			string result = "";

			for (int i =0; 0 < words1.Length; i++)
			{
				for (int j =0; 0 < words2.Length; j++)
				{
					result = words1[i];
				}
			}
			return result;

        }



		public static string GetlongestSubstring(string longText, string shortText)
		{
			if (longText.Length < shortText.Length)
			{
				return GetlongestSubstring(shortText, longText);

			}

			string result = " ";
			int targetLength = shortText.Length;
			while (targetLength > 0)
			{
				for (int startpos = 0; startpos <= shortText.Length - targetLength; startpos++)
				{
					string textForSearch = shortText.Substring(startpos, targetLength);
					if (longText.Contains(textForSearch))
					{
						result = textForSearch;
					}
					Console.WriteLine(textForSearch);
				}
                --targetLength;
            }

			return result;
		}
	}
}

