using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class ZooExample
    {

        public static Random r1 = new Random(3);
        public static Random r2 = new Random(3);
        public static Random r3 = new Random(3);
        public static void Start()
        {



            Console.WriteLine(r1.Next(0, 3));

            DateTime t = DateTime.Now;
            Console.Write("  Heute ist: ");
            Console.WriteLine(t.ToString("dddd"));


            Zoo zoo = new Zoo("Park name", 0000);

            zoo.Name = "Tierpark Höchst";
            zoo.Year = 1982;

            ZooKeeper keeper1 = new ZooKeeper("Gyula", 40, 180, "Meadow", "", "");
            ZooKeeper keeper2 = new ZooKeeper("Lukas", 35, 183, "Woods", "", "");
            ZooKeeper keeper3 = new ZooKeeper("Sandro", 25, 185, "Aquarium", "", "");

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure aquarium = new Enclosure("Ocean", "Outdoor/Water", "Cold Temperature", "Dirty");

            Animals rabbit1 = new Animals("Peter", 2, "Rabbit", "Male", "hungry");
            Animals rabbit2 = new Animals("Hase", 1, "Rabbit", "Female", "hungry");
            Animals rabbit3 = new Animals("Richard", 1, "Rabbit", "Male", "hungry");
            Animals monkey1 = new Animals("Elisabeth", 3, "Monkey", "Male", "hungry");
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female", "hungry");
            Animals dolphin1 = new Animals("Hans", 6, "Dolphin", "Male", "hungry");
            Animals dolphin2 = new Animals("Jürgen", 8, "Dolphin", "Male", "hungry");
            Animals sealion = new Animals("Simba", 9, "Sealion", "Female", "hungry");

            Food banana = new Food("Banana", 6, 2);
            Food fish = new Food("Fish", 12, 4);
            Food carrot = new Food("Carrot", 3, 1);

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

            if (meadow.Status != "Clean" || woods.Status != "Clean" || aquarium.Status != "Clean")
            {
                meadow.Status = "Clean";
                woods.Status = "Clean";
                aquarium.Status = "Clean";
            }
            Console.WriteLine();
            keeper1.Feeding = "Hase";
            keeper1.Feeding = "Richard";
            keeper1.Feeding = "Peter";
            Console.WriteLine();
            keeper2.Feeding = "Elisabeth";
            keeper2.Feeding = "Lukas";
            Console.WriteLine();
            keeper3.Feeding = "Hans";
            keeper3.Feeding = "Jürgen";
            keeper3.Feeding = "Simba";

            monkey1.Hunger = "fed up";
            monkey2.Hunger = "fed up";
            dolphin1.Hunger = "fed up";
            dolphin2.Hunger = "fed up";
            sealion.Hunger = "fed up";
            rabbit1.Hunger = "fed up";
            rabbit2.Hunger = "fed up";
            rabbit3.Hunger = "fed up";
            zoo.PrintZoo();

            if (monkey1.Hunger == "fed up" &&
            monkey2.Hunger == "fed up" &&
            dolphin1.Hunger == "fed up" &&
            dolphin2.Hunger == "fed up" &&
            sealion.Hunger == "fed up" &&
            rabbit1.Hunger == "fed up" &&
            rabbit2.Hunger == "fed up" &&
            rabbit3.Hunger == "fed up")
            {
                keeper1.Favourite = "Hase";
                keeper2.Favourite = "Lukas";
                keeper2.Favourite = "Simba";
            }
        }
    }
}
