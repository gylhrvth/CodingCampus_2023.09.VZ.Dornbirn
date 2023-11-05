namespace Fabian.Week06._04Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new("Animalgarden Dornbirn", 2022);

            Food worms = new("Worms", "cups", 15);
            Food crickets = new("Crickets", "cups", 10);
            Food wheat = new("Wheat", "kg", 0.23);
            Food straw = new("Straw", "kg", 1.65);

            Enclosure enclosure1 = new("Alpine meadow");
            Enclosure enclosure2 = new("Reed");
            Enclosure enclosure3 = new("Terrarium (warm)");
            Enclosure enclosure4 = new("Aquarium");

            ZooKeeper franz = new("Franz", new List<Enclosure>{ enclosure1, enclosure2 });
            ZooKeeper hubert = new("Hubert", new List<Enclosure>{ enclosure3, enclosure4 });

            Animal paul = new("Paul", "Goat", wheat, 4, 40, 20);
            Animal bella = new("Bella", "Goat", wheat, 3, 30, 15);
            Animal rijska = new("Rijska", "Cow", wheat, 5, 50, 20);
            Animal garmond = new("Garmond", "Horse", straw, 5, 50, 20);
            Animal hugo = new("Hugo", "Horse", straw, 8, 80, 30);
            Animal idaxis = new("Idaxis", "Horse", straw, 2, 20, 10);
            Animal rex = new("Rex", "Chameleon", crickets, 1, 20, 10);
            Animal camo = new("Camo", "Chameleon", crickets, 2, 40, 20);
            Animal bro = new("Bro", "Chameleon", crickets, 1, 30, 15);
            Animal fishy = new("Fishy", "Fish", worms, 1, 10, 5);
            Animal goldie = new("Goldie", "Fish", worms, 2, 20, 10);

            zoo.Enclosures.Add(enclosure1);
            zoo.Enclosures.Add(enclosure2);
            zoo.Enclosures.Add(enclosure3);
            zoo.Enclosures.Add(enclosure4);
            zoo.ZooKeepers.Add(franz);
            zoo.ZooKeepers.Add(hubert);

            enclosure1.Animals.Add(rijska);
            enclosure1.Animals.Add(paul);
            enclosure1.Animals.Add(bella);
            enclosure2.Animals.Add(garmond);
            enclosure2.Animals.Add(hugo);
            enclosure2.Animals.Add(idaxis);
            enclosure3.Animals.Add(rex);
            enclosure3.Animals.Add(camo);
            enclosure3.Animals.Add(bro);
            enclosure4.Animals.Add(fishy);
            enclosure4.Animals.Add(goldie);

            camo.FoodList.Add(crickets);
            bro.FoodList.Add(crickets);
            rex.FoodList.Add(crickets);
            rijska.FoodList.Add(wheat);                    
            paul.FoodList.Add(wheat);                    
            bella.FoodList.Add(wheat);                    
            garmond.FoodList.Add(straw);
            hugo.FoodList.Add(straw);                       
            idaxis.FoodList.Add(straw);
            fishy.FoodList.Add(worms);
            goldie.FoodList.Add(worms);

            zoo.PrintStructure();
            Console.WriteLine();
            zoo.PrintZooStatistic();
            Console.WriteLine("\nSimulation: ");
            franz.Feed();
            Console.WriteLine();
            hubert.Feed();
            Console.WriteLine();
            zoo.FightStart();
            //Console.WriteLine();
            //zoo.PrintStructure();


        }
        
        
    }
}

