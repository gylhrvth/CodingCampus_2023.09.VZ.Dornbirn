using System;
using Ressources;

namespace Mohammed.Week05
{
	public class Hesse
	{
		public static void Start()
		{
			string text = StringRessources.getHesse();
			Console.WriteLine(text);
			Console.WriteLine("count\"Hesse\"in text :{0}", CountSubstring(text, "Hesse"));
		}

		public static int CountSubstring(string text, string searchFor)
		{
			int count = 0;
			int startPos = 0;

			text.IndexOf(searchFor, 0);

			while(startPos > -1)
			{
				++count;
                Console.WriteLine(startPos);
				startPos = text.IndexOf(searchFor, 1 + startPos);
            }

			return count;
		}
	}
}

