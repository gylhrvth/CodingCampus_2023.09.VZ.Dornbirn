using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearningDay
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Davids ProgrammierZoo", 2023);

            Enclosure alps = new Enclosure("In den Bergen");
            Enclosure programmierZimmer = new Enclosure("in Davids Wohnzimmer");
            Enclosure einkaufShop = new Enclosure("Lidl gegenüber");

            zoo.AddEnclosure(alps);
            zoo.AddEnclosure(programmierZimmer);
            zoo.AddEnclosure(einkaufShop);

            Food nuts = new Food("Nüsse", "Gramm", 0.5f);
            Food heu = new Food("Häu", "Gramm", 0.05f);
            Food haribo = new Food("Haribo", "Gramm", 0.3f);
            Food tea = new Food("Chai Tee", "Gramm", 1.958f);


            Animals fox = new Animals("Hassan", "Ziege", 7, "männlich", 1024.5f, heu);
            Animals hawk = new Animals("Sandro", "Falke", 3, "männlich", 102456.879f, haribo);
            Animals person1 = new Animals("David", "Codinghero", 35, "männlich", 154.7f, nuts);
            Animals person2 = new Animals("Mohammed", "CodingHero", 27, "männlich", 1748.6f, tea);
            Animals person3 = new Animals("Patrick", "JuniorCoder", 29, "weiblich", 157.456f, haribo);
            Animals verkäufer1 = new Animals("Sandra", "Kassiererin", 38, "weiblich", 100.5f, nuts);
            Animals verkäufer2 = new Animals("Sabine", "Bäckerin", 19, "weiblich", 1574.4f, nuts);

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

            zoo.PrintStatistic();

            Console.WriteLine();
            Console.WriteLine();

            zoo.SimulateDay(1);

        }
    }
}
