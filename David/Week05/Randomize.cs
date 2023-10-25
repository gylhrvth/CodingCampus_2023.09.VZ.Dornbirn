using System;
using System.Threading.Channels;
using Ressources;

namespace David.Week05
{
	public class Randomize
	{

		
		public static Random rand = new Random();
		public static void Start()
		{
			
			Console.Write("Please enter your text:");
			string text = Console.ReadLine();

			
			Console.WriteLine(RandomWord(text));

			

			//Erklärung Unterschied von Char und String von Hassan:


			//string s = "Apfel";
			//char[] chararr = s.ToCharArray();
			//foreach(char c in chararr)
			//{
			//	Console.WriteLine(c);
			//}
			


		}

		public static string RandomWord(string text)
		{
			char[] chararr = text.ToCharArray();

			

			for (int i = 0; i < chararr.Length; i++)
			{
				int randA = rand.Next(chararr.Length);
                int randB = rand.Next(chararr.Length);

				char temp = chararr[randA];
				chararr[randA] = chararr[randB];
                chararr[randB] = temp;


            }

            return new string(chararr);
		}
	}
}

