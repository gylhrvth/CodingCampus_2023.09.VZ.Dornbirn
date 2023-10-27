using System;
using Ressources;

namespace Gyula.Week05
{
	public class CountHesse
	{
		public static void Start()
		{
			String text = StringRessources.getHesse();
			Console.WriteLine(text);
			Console.WriteLine("Count \"Hesse\" in text: {0}", CountSubstring(text, "Hesse"));
		}


		public static int CountSubstring(string text, string searchFor)
		{
			int count = 0;
			int startPos = text.IndexOf(searchFor, 0);

			while (startPos > -1)
			{
				++count;
                startPos = text.IndexOf(searchFor, 1 + startPos);
            }

			return count;
		}
	}
}

