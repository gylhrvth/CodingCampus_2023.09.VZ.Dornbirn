using DarioLuis.Zoo;

namespace DarioLuis.Zoo_Dario
{
    public class Zoo_Main
    {
        public static void Start()
        {

            Zoo zoo = new("Animalgarden Gisingen", 2023);

            Food worms = new("Worms", "cups", 15);
            Food crickets = new("Crickets", "cups", 10);
            Food wheat = new("Wheat", "kg", 0.23);
            Food straw = new("Straw", "kg", 1.65);

            Enclosure enclosure1 = new("Alpine meadow");
            Enclosure enclosure2 = new("Reed");
            Enclosure enclosure3 = new("Terrarium (warm)");
            Enclosure enclosure4 = new("Aquarium");

            Zookeeper hassan = new("Hassan", new List<Enclosure> { enclosure1, enclosure2 });
            Zookeeper gyula = new("Gyula", new List<Enclosure> { enclosure3, enclosure4 });

            Animal fabian = new("Fabian", "Goat", wheat, 4, 40, 20);
            Animal dario = new("Dario", "Goat", wheat, 3, 30, 15);
            Animal cemal = new("Cemal", "Cow", wheat, 5, 50, 20);
            Animal timo = new("Timo", "Horse", straw, 5, 50, 20);
            Animal jovo = new("Jovo", "Horse", straw, 8, 80, 30);
            Animal riccardo = new("Riccardo", "Horse", straw, 2, 20, 10);
            Animal kerem = new("Kerem", "Chameleon", crickets, 1, 20, 10);
            Animal martin = new("Martin", "Chameleon", crickets, 2, 40, 20);
            Animal mehmet = new("Mehmet", "Chameleon", crickets, 1, 30, 15);
            Animal gheorghe = new("Gheorghe", "Fish", worms, 1, 10, 5);
            Animal eren = new("Eren", "Fish", worms, 2, 20, 10);

            zoo.Enclosures.Add(enclosure1);
            zoo.Enclosures.Add(enclosure2);
            zoo.Enclosures.Add(enclosure3);
            zoo.Enclosures.Add(enclosure4);
            zoo.Zookeepers.Add(hassan);
            zoo.Zookeepers.Add(gyula);

            enclosure1.Animals.Add(cemal);
            enclosure1.Animals.Add(fabian);
            enclosure1.Animals.Add(dario);
            enclosure2.Animals.Add(timo);
            enclosure2.Animals.Add(jovo);
            enclosure2.Animals.Add(riccardo);
            enclosure3.Animals.Add(kerem);
            enclosure3.Animals.Add(martin);
            enclosure3.Animals.Add(mehmet);
            enclosure4.Animals.Add(gheorghe);
            enclosure4.Animals.Add(eren);

            martin.FoodList.Add(crickets);
            mehmet.FoodList.Add(crickets);
            kerem.FoodList.Add(crickets);
            cemal.FoodList.Add(wheat);
            fabian.FoodList.Add(wheat);
            dario.FoodList.Add(wheat);
            timo.FoodList.Add(straw);
            jovo.FoodList.Add(straw);
            riccardo.FoodList.Add(straw);
            gheorghe.FoodList.Add(worms);
            eren.FoodList.Add(worms);

            zoo.PrintStructure();
            Console.WriteLine();
            zoo.PrintZooStatistic();
            Console.WriteLine("\nSimulation: ");
            hassan.Feed();
            Console.WriteLine();
            gyula.Feed();
            Console.WriteLine();
            zoo.FightStart();
            //Console.WriteLine();
            //zoo.PrintStructure();
        }
    }

}