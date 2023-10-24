using System;
using Ressources;

namespace Gyula.Week05
{
	public class StringExample
	{
		public static void Start()
		{
			string text = "Hello World!";

			string result = text + text;
			Console.WriteLine("+ : {0}", result);

			result = string.Concat(text, "ABC");
            Console.WriteLine("Concat : {0}", result);


			Console.WriteLine("Contains : {0}", text.Contains("Wor"));
            Console.WriteLine("Contains : {0}", text.Contains("WorWor"));

            Console.WriteLine("ToLower : {0}", text.ToLower());
            Console.WriteLine("ToUpper : {0}", text.ToUpper());

			Console.WriteLine(string.Format("{0, 20}", text));

            Console.WriteLine("SubString : {0}", text.Substring(1,3));


        }
    }
}

