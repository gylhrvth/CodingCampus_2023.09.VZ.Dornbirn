using System;
namespace Gyula.Week07.Vererbung
{
	public class ObstKorbMain
	{
		public static void Start()
		{
			List<Obst> korb = new List<Obst>();

			korb.Add(new Obst("Banane", false));
			korb.Add(new Apfel("Idared", true, 75));
            korb.Add(new Obst("Erdbeere", true));
            korb.Add(new Obst("Zitrone", true));
            korb.Add(new Obst("Kirsche", true));

			foreach (Obst obst in korb)
			{
				obst.PrintMe();
			}
        }
    }
}

