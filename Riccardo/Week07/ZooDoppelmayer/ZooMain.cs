using Riccardo.Week07.ZooDoopelmayer;
using System;

namespace Riccardo.Week07.ZooDoppelmayer
{
    public class ZooMain
    {
        public static void Start()
        {

            Zoo zoo = new Zoo("Campus", "Dornbirn", 2023, 23);


            Food carrot = new Food("Carrot", "Stack", 20);
            Food bannanas = new Food("Bannanas", "Pieces", 1.80);

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature");
            Enclosure swamp = new Enclosure("Swamp", "Outdoor/Water", "Outside Temperature");
            Enclosure terrarium = new Enclosure("Reptile Terrarium", "Indoor", "Warm/Moist");
            Enclosure fishtank = new Enclosure("Fish Tank", "Indoor", "Saltwater 24-28°C");

            Animals monkey1 = new Animals("Eliabeth", 3, "Monkey", "Male", bannanas, 10);
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female", bannanas, 67);


            /*
            Zoo z = new Zoo("DoppelmayerZoo", 1963);

            z.SearchAndCreate("Vogelgehege");
            z.SearchAndCreate("Hünner");
            z.SearchAndCreate("Alpaka");

            z.PrintStructure();
            */
        }
    }
}

