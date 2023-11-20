using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.OOP.Zoo
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

            zoo.AddEnclosure(enclosureAlps);
            zoo.AddEnclosure(enclosureForest);
            zoo.AddEnclosure(enclosureIceLand);
            zoo.AddEnclosure(enclosureFishTank);


            //Food for the animals
            Food meat = new("Fleisch", "kg", 100f);
            Food fishFood = new("Fischfutter", "kg", 40f);
            Food grain = new("Getreide", "kg", 15f);
            Food birdFood = new("Vogelfutter", "kg", 10f);
            Food karrots = new("Karotten", "kg", 18f);
            Food fish = new("Fisch", "kg", 115f);

            //animals enclosureAlps
            Animal animalCow = new("Kuh", "Hilda", "10 Jahre alt", 10f, grain, 100, 30);
            Animal animalPig = new("Schwein", "Sabine", "3 Jahre alt", 3f, karrots, 100, 20);

            //animals enclosureForest
            Animal animalFox = new("Fuchs", "Johannes", "2 Jahre jung", 0.4f, meat, 100, 20);
            Animal animalRabbit = new("Hase", "Norbert", "1 Jahre jung", 0.3f, karrots, 100, 5);
            Animal animalBird = new("Vogel", "Kurt", "2 Jahre jung", 0.05f, birdFood, 20, 2);

            //animals enclosureIceLand
            Animal animalBear = new("Eisbär", "Robert", "8 Jahre alt", 3.8f, meat, 250, 40);
            Animal animalSeal = new("Robbe", "Sandra", "4 Jahre alt", 1.5f, fish, 150, 20);

            //animals fishTank
            Animal animalShark = new("Hammerhai", "Hans", "3 Jahre alt", 3.5f, fish, 300, 80);
            Animal animalTuna = new("Thunfisch", "Susanne", "20 Jahre alt", 2f, meat, 200, 50);
            Animal animalClownfish = new("Clownfisch", "Theodor", "1 Jahr jung", 0.08f, fishFood, 30, 5);


            enclosureAlps.AddAnimal(animalCow);
            enclosureAlps.AddAnimal(animalPig);
            enclosureForest.AddAnimal(animalFox);
            enclosureForest.AddAnimal(animalRabbit);
            enclosureForest.AddAnimal(animalBird);
            enclosureIceLand.AddAnimal(animalBear);
            enclosureIceLand.AddAnimal(animalSeal);
            enclosureFishTank.AddAnimal(animalShark);
            enclosureFishTank.AddAnimal(animalTuna);
            enclosureFishTank.AddAnimal(animalClownfish);

            ZooKeeper zooKeeper1 = new("Andreas", new List<Enclosure> { enclosureIceLand, enclosureForest });
            ZooKeeper zooKeeper2 = new("Daniela", new List<Enclosure> { enclosureAlps, enclosureIceLand });
            ZooKeeper zooKeeper3 = new("Robert Marc", new List<Enclosure> { enclosureFishTank, enclosureIceLand });

            zoo.AddZookeeper(zooKeeper1);
            zoo.AddZookeeper(zooKeeper2);
            zoo.AddZookeeper(zooKeeper3);


            VeterinarySurgeon veterinarySurgeon1 = new VeterinarySurgeon("Sebastian");
            VeterinarySurgeon veterinarySurgeon2 = new VeterinarySurgeon("David");


            zoo.AddVeterinarySurgeon(veterinarySurgeon1);
            zoo.AddVeterinarySurgeon(veterinarySurgeon2);


            //Print
            zoo.PrintStructure();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=======================================================");
            Console.WriteLine("=======================================================");
            Console.ResetColor();
            zoo.PrintZooStatistic();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=======================================================");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            for (int i = 0; i < 3; i++)
            {
                zoo.SimulateDay(i + 1);
            }









        }

    }
}
