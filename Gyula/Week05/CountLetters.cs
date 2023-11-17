using System;
using Ressources;

namespace Gyula.Week05
{
	public class CountLetters
	{
		public static void Start()
		{
			String s = StringRessources.getText();
			Console.WriteLine(s);

			int[] count = countLetters(s);
			PrintResult(count);

		}

		public static void PrintResult(int[] count)
		{
			for (int i = 0; i < count.Length; ++i)
			{
				if (count[i] >= 0) {
					char c = (char)i;
                    Console.WriteLine(c + " " + count[i]);
                }
            }
		}

		public static int[] countLetters(string text)
		{
			int[] count = new int[char.MaxValue];
            for (int i = 0; i < text.Length; i++)
            {
				char c = text[i];
				++count[c];
            }

			return count;
        }
	}
}

