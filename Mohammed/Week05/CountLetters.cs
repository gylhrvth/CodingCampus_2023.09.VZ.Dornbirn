using System;
using Ressources;// es geht um Ressources

namespace Mohammed.Week05
{
	public class CountLetters
	{
		public static void Start()
		{
			String a = StringRessources.getText();
			Console.WriteLine(a);

			int[] count = CountLet(a);
			PrintRes(count);

			//string a = "Bnna";

			//int[] count = CountLet(a);
			//PrintRes(count);

        }

		public static void PrintRes(int[] count)
		{
			for (int i = 0; i < count.Length; i++)
			{
				if (count[i] > 0)
				{
					char a = (char) i;
					Console.WriteLine(a + ": " + count [i]);
				}
			}
		}

		public static int[] CountLet(string text)
		{
			int[] count = new int[char.MaxValue];

			for (int i = 0; i < text.Length; i++)
			{
				char a = text[i];
				++count[a];
			}
			return count;
		}
	}
}

