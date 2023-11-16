using System;

namespace Erik.Week08
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo doppelmayrZoo = new Zoo("Doppelmayr Zoo Dornbirn", 2003, 100);

            //Food                   Name /  Unit / Price
            Food Banana = new Food("Banana", 700, 5);   
            doppelmayrZoo.AddFoodList(Banana);
            Food Meat = new Food("Meat", 2000, 10);
            doppelmayrZoo.AddFoodList(Meat);
            Food Fruits = new Food("Fruits", 500, 5);
            doppelmayrZoo.AddFoodList(Fruits);
            Food Grass = new Food("Grass", 20000, 3);
            doppelmayrZoo.AddFoodList(Grass);

            Keeper keeper1 = new Keeper("Johannes");
            Keeper keeper2 = new Keeper("Peter");
            Keeper keeper3 = new Keeper("Jasmin");

            Animal martin = new Animal("Martin", "Gorilla", "Male", Banana, 100,5);
            Animal thomas = new Animal("Thomas", "Loxodonta", "Male", Banana,100,5);
            Animal susanne = new Animal("Susanne", "Sibirian Tiger", "Female", Meat,100, 10);
            Animal luis = new Animal("Luis", "Sibirian Tiger", "Male", Meat, 100, 15);
            Animal michael = new Animal("Michael", "Gorilla", "Male", Banana, 100, 15);
            Animal peter = new Animal("Peter", "Mountain Zebra", "Male", Grass, 100, 10);
            Animal sabine = new Animal("Sabine", "Mountain Zebra", "Female", Grass, 100, 5);
            Animal steffen = new Animal("Steffen", "Mountain Zebra", "Male", Fruits, 100, 8);
            Animal sara = new Animal("Sara", "Mountain Zebra", "Female", Fruits,100, 10);

            Enclosure monkeyEnclosure = (new Enclosure("Monkey", 500));
            Enclosure lionEnclosure = (new Enclosure("Lion", 780));
            Enclosure elephantEnclosure = (new Enclosure("Elephant", 530));
            Enclosure tigerEnclosure = (new Enclosure("Tiger", 150));
            Enclosure spiderEnclosure = (new Enclosure("Spider", 5));
            Enclosure zebraEnclosure = (new Enclosure("Zebra", 450));

            //Monkey Enclosure
            monkeyEnclosure.AddAnimals(martin);
            monkeyEnclosure.AddAnimals(michael);
            monkeyEnclosure.AddKeeper(keeper1);
            monkeyEnclosure.AddKeeper(keeper2);

            //Elephant Enclosure
            elephantEnclosure.AddAnimals(thomas);
            elephantEnclosure.AddKeeper(keeper2);


            //Tiger Enclosure
            tigerEnclosure.AddAnimals(susanne);
            tigerEnclosure.AddAnimals(luis);
            tigerEnclosure.AddKeeper(keeper3);

            //Zebra Enclosure
            zebraEnclosure.AddAnimals(peter);
            zebraEnclosure.AddAnimals(sabine);
            zebraEnclosure.AddAnimals(steffen);
            zebraEnclosure.AddAnimals(sara);
            zebraEnclosure.AddKeeper(keeper1);


            //Lion Enclosure

            //Spider Enclosure

            doppelmayrZoo.add(zebraEnclosure);
            doppelmayrZoo.add(monkeyEnclosure);
            doppelmayrZoo.add(lionEnclosure);
            doppelmayrZoo.add(elephantEnclosure);
            doppelmayrZoo.add(tigerEnclosure);
            doppelmayrZoo.add(spiderEnclosure);
            

            doppelmayrZoo.PrintZoo("├──");
            Console.WriteLine();
            doppelmayrZoo.PrintFoodList();
            
            PressToContinue.Start("Press ENTER to start simulation!");
            Console.Clear();
            doppelmayrZoo.LoopToFeedAnimal();
            doppelmayrZoo.PrintZoo("├──");
            doppelmayrZoo.PrintFoodList();



        }
    }
}
