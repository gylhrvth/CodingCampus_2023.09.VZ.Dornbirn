using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class ZooExample
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Park name", 0000);

            zoo.Name = "Tierpark Höchst";
            zoo.Year = 1982;

            ZooKeeper keeper1 = new ZooKeeper("Gyula", 40, 180, "Meadow");
            ZooKeeper keeper2 = new ZooKeeper("Lukas", 35, 183, "Woods"); 
            ZooKeeper keeper3 = new ZooKeeper("Sandro", 20, 185, "Aquarium");

            enclosure meadow = new enclosure("Meadow", "Outdoor/Ground", "Outside Temperature");
            enclosure woods = new enclosure("Wood", "Outdoor/Ground", "Outside Temperature");
            enclosure aquarium = new enclosure("Ocean", "Outdoor/Water", "Cold Temperature");

            Animals rabbit1 = new Animals("Peter", 2, "Rabbit", "Male");
            Animals rabbit2 = new Animals("Hase", 1, "Rabbit", "Female");
            Animals rabbit3 = new Animals("Richard", 1, "Rabbit", "Male");
            Animals monkey1 = new Animals("Eliabeth", 3, "Monkey", "Male");
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female");
            Animals dolphin1 = new Animals("Hans", 6, "Dolphin", "Male");
            Animals dolphin2 = new Animals("Jürgen", 8, "Dolphin", "Male");
            Animals sealion = new Animals("Simba", 9, "Sealion", "Female");

            Food banana = new Food("Banana", 10, 5);
            Food fish = new Food("Fish", 20, 8);
            Food carrot = new Food("Carrot", 7, 3);

            zoo.AddZooKeeper(keeper1);
            zoo.AddZooKeeper(keeper2);
            zoo.AddZooKeeper(keeper3);

            keeper1.AddEnclosure(meadow);
            keeper2.AddEnclosure(woods);
            keeper3.AddEnclosure(aquarium);

            meadow.AddAnimals(rabbit1);
            meadow.AddAnimals(rabbit2);
            meadow.AddAnimals(rabbit3);

            woods.AddAnimals(monkey1);
            woods.AddAnimals(monkey2);

            aquarium.AddAnimals(dolphin1);
            aquarium.AddAnimals(dolphin2);
            aquarium.AddAnimals(sealion);

            monkey1.AddFood(banana);
            monkey2.AddFood(banana);

            dolphin1.AddFood(fish);
            dolphin2.AddFood(fish);
            sealion.AddFood(fish);

            rabbit1.AddFood(carrot);
            rabbit2.AddFood(carrot);
            rabbit3.AddFood(carrot);

            zoo.PrintZoo();
        }
    }
}
