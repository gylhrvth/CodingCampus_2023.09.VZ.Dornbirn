using System;
namespace David.Week04.Udemy
{
	public class uebung2
	{
		public static void Start()
		{
			List<string> names = new List<string>()
			{
				"David", "Camilo", "Josè"
			};

			Console.WriteLine(names[1]);
			Console.WriteLine("--------");

			foreach (string element in names)
			{
				Console.WriteLine(element);
			}
            Console.WriteLine("--------");

            names[0] = "Gebbl";

            foreach (string element in names)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------");

			names.Add("Maya");
            names.Insert(0, "David");

            foreach (string element in names)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------");

        }
	}
}

