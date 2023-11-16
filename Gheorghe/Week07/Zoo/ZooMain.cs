using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week07.Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Wild Park", "Feldkirch", 2023);


           
            

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature");
            Enclosure swamp = new Enclosure("Swamp", "Outdoor/Water", "Outside Temperature");
            Enclosure terrarium = new Enclosure("Reptile Terrarium", "Indoor", "Warm/Moist");
            Enclosure fishtank = new Enclosure("Fish Tank", "Indoor", "Saltwater 24-28°C");

            Food bannanas = new Food("Bannas", "Pieces", 1.80);

            Animals monkey1 = new Animals("Eugen", 3, "Monkey", "Male", bannanas, 10);
            Animals monkey2 = new Animals("Brigitte", 3, "Monkey", "Female",bannanas,10);


           

            ZooKeeper gheorghe = new("Gheorghe");
            ZooKeeper luiza = new("Luiza");

          

            zoo.AddZooKeeper(gheorghe);
            woods.AddZookeeper(gheorghe);
            meadow.AddZookeeper(luiza);
            swamp.AddZookeeper(gheorghe);

          

            zoo.AdddEnclosure(meadow);
            zoo.AdddEnclosure(woods);
            zoo.AdddEnclosure(swamp);

         

            woods.AddAnimals(monkey1);
            meadow.AddAnimals(monkey2);


           

            


    

            zoo.PrintZoo();

            for (int i = 1; i <= 10; i++)
            {
                zoo.Simulation(i);
            }

        }
    }
}
