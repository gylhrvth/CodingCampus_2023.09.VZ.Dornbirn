using System;
namespace Gyula.Week06.Zoo
{
	public class ZooMain
	{
		public static void Start()
		{
			Zoo tpFeldkirch = new Zoo("Tierpark Feldkirch", 1963);

			tpFeldkirch.addEnclosure(new Enclosure("Savanna"));
            tpFeldkirch.addEnclosure(new Enclosure("Alps"));

            tpFeldkirch.PrintStructure("");
		}
	}
}

