using System;
using Ressources;
namespace David.Week05
{
	public class Hesse
	{
		public static void Start()
		{
			string text = StringRessources.getHesse();
			//ODER: oben kein "using Ressorces" und hier mit ...= Ressorces.StringRessor....

			Console.WriteLine(text);
			Console.WriteLine("Count \"Hesse\" in text : {0}", CountSubString(text, "Hesse"));


		}

		public static int CountSubString(string text, string searchFor)
		{
			int count = 0;
			int startPos = text.IndexOf(searchFor, 0);

			while(startPos > -1)
			{
				++count;
                startPos = text.IndexOf(searchFor, 1 + startPos);

            }
			Console.WriteLine(startPos);


			return count;
		}
	}
}

