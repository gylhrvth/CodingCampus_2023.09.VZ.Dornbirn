using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearnDay
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Davids ProgrammierZoo", 2023);

            Enclosure alps = new Enclosure("In den Bergen");
            Enclosure programmierZimmer = new Enclosure("in Davids Wohnzimmer");
            Enclosure einkaufShop = new Enclosure("Lidl gegenüber");


            Animals fox = new Animals("Hassan", "Ziege", 7, "männlich");
            Animals hawk = new Animals("Sandro", "Falke", 3, "männlich");
            Animals person1 = new Animals("David", "Codinghero", 35, "männlich");
            Animals person2 = new Animals("Mohammed", "CodingHero", 27, "männlich");
            Animals person3 = new Animals("Patrick", "JuniorCoder", 29, "weiblich");
            Animals verkäufer1 = new Animals("Sandra", "Kassiererin", 38, "weiblich");
            Animals verkäufer2 = new Animals("Sabine", "Bäckerin", 19, "weiblich");

            ZooKeeper keeper1 = new ZooKeeper("Johannes");
            ZooKeeper keeper2 = new ZooKeeper("Sebastian");


            alps.FillAnimalList(fox);
            alps.FillAnimalList(hawk);
            programmierZimmer.FillAnimalList(person1);
            programmierZimmer.FillAnimalList(person2);
            programmierZimmer.FillAnimalList(person3);
            einkaufShop.FillAnimalList(verkäufer2);
            einkaufShop.FillAnimalList(verkäufer1);


            zoo.FillKeeperList(keeper1);
            zoo.FillKeeperList(keeper2);

            keeper1.FillEnclosureList(alps);
            keeper1.FillEnclosureList(einkaufShop);
            keeper2.FillEnclosureList(einkaufShop);
            keeper2.FillEnclosureList(programmierZimmer);


            //Print
            zoo.PrintStructure();

            Console.WriteLine();
            Console.WriteLine();


            zoo.SimulateDay(1);

        }
    }
}
