using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace David.Week06.ZOO
{
	internal class ZooMain
	{
		public static void Start()
		{
			Zoo zoo = new Zoo("The Galaxy Zoo", "Mars", 1879);

			//Enclosures
			Enclosure forest = new Enclosure("Monkeyforest", "outdoor climate");
			Enclosure alienPlanet = new Enclosure("Alien Planet", "indoor temperature");
			Enclosure underWaterWorld = new Enclosure("Mairmaid", "temperatured water");
			Enclosure sky = new Enclosure("Birds", "outdoor climate");

			zoo.EnclosureList.Add(forest);
			zoo.EnclosureList.Add(alienPlanet);
			zoo.EnclosureList.Add(underWaterWorld);
			zoo.EnclosureList.Add(sky);

			//Food for animals
			Food meat = new("meat", "kg", 100f);
			Food fish = new("Fish", "kg", 40f);
			Food veggies = new("Veggies", "kg", 18f);
			Food fruit = new("Fruit", "kg", 25f);

			//animals Forest
			Animals monkey1 = new("Jonny", 14, "Gorilla", "Male", 2, fruit, 100, 50);
			Animals monkey2 = new("Dorey", 12, "Gorilla", "Female", 2, fruit, 100, 50);

			//animals AlienPlanet
			Animals alien1 = new("Xylrup", 468, "Gray Alien", "Female", 4, veggies, 500, 60);
			Animals alien2 = new("Nalxiniqup", 4791, "Insekt Alien", "Male", 6, meat, 500, 60);

			//animals UnderWater
			Animals mairmaid1 = new("Ariel", 29, "Pink Mairmaid", "Female", 7, fish, 400, 40);
			Animals mairmaid2 = new("Ken", 33, "Blue Mairmaid", "Male", 8, fish, 400, 40);

			//animals in the sky
			Animals giantBird1 = new("Susan", 16, "Eagle", "Female", 4, fruit, 250, 30);
			Animals giantBird2 = new("Bob", 14, "Eaele", "Male", 6, veggies, 250, 30);

			

			forest.AnimalsList.Add(monkey1);
			forest.AnimalsList.Add(monkey2);
			alienPlanet.AnimalsList.Add(alien1);
			alienPlanet.AnimalsList.Add(alien2);
			underWaterWorld.AnimalsList.Add(mairmaid1);
			underWaterWorld.AnimalsList.Add(mairmaid2);
			sky.AnimalsList.Add(giantBird1);
			sky.AnimalsList.Add(giantBird2);

			ZooKeeper zooKeeper = new("David", new List<Enclosure> { forest, underWaterWorld });
			ZooKeeper zooKeeper1 = new("Patrick", new List<Enclosure> { underWaterWorld, sky });
			ZooKeeper zooKeeper2 = new("Mohammed", new List<Enclosure> { sky, underWaterWorld });
            ZooKeeper zooKeeper3 = new("George", new List<Enclosure> { alienPlanet, forest });
            ZooKeeper zooKeeper4 = new("Dimitri", new List<Enclosure> { alienPlanet, sky });

			zoo.ZooKeeperList.Add(zooKeeper);
			zoo.ZooKeeperList.Add(zooKeeper1);
			zoo.ZooKeeperList.Add(zooKeeper2);
			zoo.ZooKeeperList.Add(zooKeeper3);
            zoo.ZooKeeperList.Add(zooKeeper4);



            //Print
            zoo.PrintStructure();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine();
			Console.WriteLine("--------------");
			Console.ResetColor();

			zoo.PrintZooStatistic();

			Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.ResetColor();

			zoo.SimulateDay(1);

			zoo.PrintListZooKeeper();
			//zoo.PrintZooKeeperWithResponsabilities();


        }
    }
}

