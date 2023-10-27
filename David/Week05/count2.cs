using System;
using Ressources;
namespace David.Week05
{
	public class count2
	{
		public static void Start()
		{
			string text = StringRessources.getText();
			Console.WriteLine(text);

			int[] count = CountText(text);
			PrintResult(count);
		}

		public static int[] CountText(string text)
		{
			int[] marieCount = new int[char.MaxValue];

			for (int i = 0; i < text.Length; i++)
			{
				char count = text[i];
				++marieCount[count];
			}
			return marieCount;

		}

		public static void PrintResult(int[] count)
		{
			for (int i = 0; i < count.Length; i++)
			{
				if (count[i] > 0)
				{
					char c = (char)i;
					Console.WriteLine(c + " " + count[i]);
				}
			}
		}
	}
}

// get Text
// methode
// zählen
// print