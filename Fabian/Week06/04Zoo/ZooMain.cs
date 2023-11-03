namespace Fabian.Week06._04Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new("Tiergarten Dornbirn", 2022);

            Food wheat = new("Wheat", "kg", 0.23);
            Food straw = new("Straw", "kg", 1.65);

            Enclosure enclosure1 = new("Alpenwiese");
            Enclosure enclosure2 = new("Ried");
            Enclosure enclosure3 = new("Terrarium (warm)");

            ZooKeeper franz = new("Franz", new List<Enclosure>{ enclosure1, enclosure2});
            ZooKeeper hubert = new("Hubert", new List<Enclosure>{ enclosure2, enclosure3 });

            Animal rijska = new("Rijska", "Cow", wheat, 5);
            Animal garmond = new("Garmond", "Horse", straw, 5);
            Animal hugo = new("Hugo", "Horse", straw, 8);
            Animal idaxis = new("Idaxis", "Horse", straw, 2);

            zoo.Enclosures.Add(enclosure1);
            zoo.Enclosures.Add(enclosure2);
            zoo.Enclosures.Add(enclosure3);
            zoo.ZooKeepers.Add(franz);
            zoo.ZooKeepers.Add(hubert);

            enclosure1.Animals.Add(rijska);
            enclosure2.Animals.Add(garmond);
            enclosure2.Animals.Add(hugo);
            enclosure2.Animals.Add(idaxis);

            rijska.FoodList.Add(wheat);                    
            garmond.FoodList.Add(straw);
            hugo.FoodList.Add(straw);                       
            idaxis.FoodList.Add(straw);

            zoo.PrintStructure();
            Console.WriteLine();
            zoo.PrintZooStatistic();
            Console.WriteLine();
            franz.Feed();
            Console.WriteLine();
            hubert.Feed();


        }
        
        
    }
}

