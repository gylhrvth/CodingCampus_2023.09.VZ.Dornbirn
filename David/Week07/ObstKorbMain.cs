using System;
namespace David.Week07
{
	public class ObstKorbMain
	{
		public static void Start()
		{
			List<Obst> korb = new List<Obst>();

			korb.Add(new Obst("Apfel", "Red", 1));
			korb.Add(new Obst("Banane", "Yelllow", 1));
			korb.Add(new Obst("Birne", "Green", 2));
			korb.Add(new Ananas("Ananas", "Yellow", 3, "Leafs"));

			foreach (Obst obst in korb)
			{
				obst.PrintObst();
			}
		}
	}
}

