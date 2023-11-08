using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", "gegründet 2022");

            Enclosure enclosureAlps = new Enclosure("Alpenwiese", "Außentemperatur");
            Enclosure enclosureForest = new("Wald", "Waldtemperatur");
            Enclosure enclosureIceLand = new("Eisland", "Eiskalt");
            Enclosure enclosureFishTank = new("Seaworld", "Mittelmeertemperatur");

            zoo.EnclosureList.Add(enclosureAlps);
            zoo.EnclosureList.Add(enclosureForest);
            zoo.EnclosureList.Add(enclosureIceLand);
            zoo.EnclosureList.Add(enclosureFishTank);


            //Food for the animals
            Food meat = new("Fleisch", "kg", 100f);
            Food fishFood = new("Fischfutter", "kg", 40f);
            Food grain = new("Getreide", "kg", 15f);
            Food birdFood = new("Vogelfutter", "kg", 10);
            Food karrots = new("Karotten", "kg", 18f);
            Food fish = new("Fisch", "kg", 115f);


            //animals enclosureAlps
            Animals animalCow = new("Kuh", "Hilda", "10 Jahre alt", 10f, grain);
            Animals animalPig = new("Schwein", "Sabine", "3 Jahre alt", 3f, karrots);

            //animals enclosureForest
            Animals animalFox = new("Fuchs", "Johannes", "2 Jahre jung", 0.4f, meat);
            Animals animalRabbit = new("Hase", "Norbert", "1 Jahre jung", 0.3f, karrots);
            Animals animalBird = new("Vogel", "Kurt", "2 Jahre jung", 0.05f, birdFood);

            //animals enclosureIceLand
            Animals animalBear = new("Eisbär", "Robert", "8 Jahre alt", 3.8f, meat);
            Animals animalSeal = new("Robbe", "Sandra", "4 Jahre alt", 1.5f, fish);

            //animals fishTank
            Animals animalShark = new("Hammerhai", "Hans", "3 Jahre alt", 3.5f, fish);
            Animals animalTuna = new("Thunfisch", "Susanne", "20 Jahre alt", 2f, meat);
            Animals animalClownfish = new("Clownfisch", "Theodor", "1 Jahr jung", 0.08f, fishFood);

            animalCow.FoodList.Add(grain);
            animalPig.FoodList.Add(karrots);
            animalFox.FoodList.Add(meat);
            animalRabbit.FoodList.Add(karrots);
            animalBird.FoodList.Add(birdFood);
            animalBear.FoodList.Add(meat);
            animalSeal.FoodList.Add(fish);
            animalShark.FoodList.Add(fish);
            animalTuna.FoodList.Add(meat);
            animalClownfish.FoodList.Add(fishFood);


            enclosureAlps.AnimalsList.Add(animalCow);
            enclosureAlps.AnimalsList.Add(animalPig);
            enclosureForest.AnimalsList.Add(animalFox);
            enclosureForest.AnimalsList.Add(animalRabbit);
            enclosureForest.AnimalsList.Add(animalBird);
            enclosureIceLand.AnimalsList.Add(animalBear);
            enclosureIceLand.AnimalsList.Add(animalSeal);
            enclosureFishTank.AnimalsList.Add(animalShark);
            enclosureFishTank.AnimalsList.Add(animalTuna);
            enclosureFishTank.AnimalsList.Add(animalClownfish);

            ZooKeeper zooKeeper1 = new("Andreas", new List<Enclosure> { enclosureAlps, enclosureForest });
            ZooKeeper zooKeeper2 = new("Daniela", new List<Enclosure> { enclosureIceLand });
            ZooKeeper zooKeeper3 = new("Robert Marc Lehmann", new List<Enclosure> { enclosureFishTank });

            zoo.ZooKeeperList.Add(zooKeeper1);
            zoo.ZooKeeperList.Add(zooKeeper2);
            zoo.ZooKeeperList.Add(zooKeeper3);


            Dictionary<Animals, Food> foodStatistic = new();
            //foodStatistic.Add()


            //Print
            zoo.PrintStructure();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=======================================================");
            Console.WriteLine("=======================================================");
            Console.ResetColor();
            zoo.PrintZooStatistic();
        }

    }
}
