using System;
namespace Mohammed.Week07.Vererbung
{
	public class OrganHumanMain
	{
		public static void Start()
		{
			List<Lung> human = new List<Lung>();

			
			human.Add(new Lung("Apex pulmonis: ", true, " "));
			human.Add(new Lung("Middle lobe: ", true, " "));
			human.Add(new Lung("infrior lobe: ", true, " "));
			human.Add(new Lung("Superior lobe:", true, " "));
			human.Add(new Lung("inferior e fissure: ", true, " "));
			human.Add(new Heart("Superior vene cava: ", "left" ,false));
            foreach (Lung lung in human)
            {
				Console.ForegroundColor = ConsoleColor.Magenta;
                lung.PrintMe();
			
			}

		}
	}
}

