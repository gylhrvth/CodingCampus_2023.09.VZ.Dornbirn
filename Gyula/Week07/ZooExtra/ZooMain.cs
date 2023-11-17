using System;
namespace Gyula.Week07.ZooExtra
{
	public class ZooMain
	{
		public static void Start()
		{
			Zoo z = new Zoo("Zauberzoo", 1234);

			z.SearchAndCreate("Eisenzeitladen");
            z.SearchAndCreate("Luftschloss");
            z.SearchAndCreate("Feuer in Topf");

            z.PrintStructure();
		}
	}
}

