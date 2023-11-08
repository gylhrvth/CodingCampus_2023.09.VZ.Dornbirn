using System;
using System.ComponentModel;

namespace David.Week06.ZOO
{
	public class ZooMain
	{
		public static void Start()
		{
			Zoo zoo = new Zoo("The Monkey Paradise", "Mars", 1879, 40);

			zoo.AddEnclosures(new Enclosure("Monkeyforest", "outdoor climate", "forest"));
			//Enclosure forest = new Enclosure("Monkeyforest", "outdoor climate", "forest");

			Enclosure alienPlanet = new Enclosure("Alien Planet", "-456°C", "different galaxy");
			Enclosure underWaterWorld = new Enclosure("Mairmaid", "Carribian under water temperature", "it's realy wet!");

			zoo.AddEnclosures(underWaterWorld);
			zoo.AddEnclosures(alienPlanet);
			zoo.PrintZoo();
		}

		
	}
}

