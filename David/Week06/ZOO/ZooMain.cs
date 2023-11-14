using System;
using System.ComponentModel;

namespace David.Week06.ZOO
{
	public class ZooMain
	{
		public static void Start()
		{
			Zoo zoo = new Zoo("The Monkey Paradise", "Mars", 1879, 40);

			Enclosure forest = new Enclosure("Monkeyforest", "outdoor climate", "forest");
			Enclosure alienPlanet = new Enclosure("Alien Planet", "-456°C", "different galaxy");
			Enclosure underWaterWorld = new Enclosure("Mairmaid", "Carribian under water temperature", "it's underwater");

			Animals monkey1 = new Animals("Jonny", 14, "Gorilla", "male");
            Animals monkey2 = new Animals("Dorey", 12, "Gorilla", "female");

			Food foodMonkey1 = new Food("Bananas", "Bundle", 5.0);
            Food foodMonkey2 = new Food("Mangos", "Piece", 1.50);

            Animals alien1 = new Animals("Xylrup", 468, "Gray Alien", "???");
            Animals alien2 = new Animals("Nalxiniqup", 4791, "Insekt Alien", "Inter");

            Food foodAlien1 = new Food("Fruits", "Box", 7.0);
            Food foodAlien2 = new Food("Veggies", "Box", 6.0);

            Animals mairmaid1 = new Animals("Ariel", 29, "Pink Mairmaid", "Female");
            Animals mairmaid2 = new Animals("Ken", 33, "Blue Mairmaid", "Male");

            Food foodMairmaid1 = new Food("Sea Fruit", "500g box", 11.0);
            Food foodmairmaid2 = new Food("Sea Cucumber", "500g box", 10.0);



            zoo.AddEnclosure(forest);
			zoo.AddEnclosure(alienPlanet);
			zoo.AddEnclosure(underWaterWorld);

			forest.AddAnimals(monkey1);
            forest.AddAnimals(monkey2);

			monkey1.AddFood(foodMonkey1);
			monkey2.AddFood(foodMonkey2);

			alienPlanet.AddAnimals(alien1);
            alienPlanet.AddAnimals(alien2);

			alien1.AddFood(foodAlien1);
			alien2.AddFood(foodAlien2);

			underWaterWorld.AddAnimals(mairmaid1);
			underWaterWorld.AddAnimals(mairmaid2);

			mairmaid1.AddFood(foodMairmaid1);
			mairmaid2.AddFood(foodmairmaid2);

            zoo.PrintZoo();
		}

		
	}
}

