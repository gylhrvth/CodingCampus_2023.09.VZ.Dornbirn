using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week06.ZooTycoon
{
    internal class ZooMain
    {
        public static void Start() {

            Zoo zoo = new Zoo("Campus", "Dornbirn", 2023, 23);


            Food carrot = new Food("Carrot", "Stack", 20);
            Food bannanas = new Food("Bannanas", "Pieces", 1.80);

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature");
            Enclosure swamp = new Enclosure("Swamp", "Outdoor/Water", "Outside Temperature");
            Enclosure terrarium = new Enclosure("Reptile Terrarium", "Indoor", "Warm/Moist");
            Enclosure fishtank = new Enclosure("Fish Tank", "Indoor", "Saltwater 24-28°C");

            Animals monkey1 = new Animals("Eliabeth", 3, "Monkey", "Male", bannanas, 10);
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female", bannanas,67);

            




            zoo.AddEnclosure(meadow);
            zoo.AddEnclosure(woods);
            zoo.AddEnclosure(swamp);

            woods.AddAnimals(monkey1);
            woods.AddAnimals(monkey1);
            woods.AddAnimals(monkey2);
            woods.AddAnimals(monkey2);

























            zoo.PrintZoo();



        }


    }
}
