using System;

namespace Erik.Week08
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo DoppelmayrZoo = new Zoo("Doppelmayr Zoo Dornbirn", 2003);

            //Food                   Name /  Unit / Price
            Food Banana = new Food("Banana", 700, 100);
            Food Meat = new Food("Meat", 1500, 350);
            Food Fruits = new Food("Fruits", 500, 50);
            Food Grass = new Food("Gras", 20000, 500);
            Banana.FoodList(Banana);


            
            Keeper Keeper1 = new Keeper("Johannes");
            Keeper Keeper2 = new Keeper("Peter");
            Keeper Keeper3 = new Keeper("Jasmin");

            Animal Martin = new Animal("Martin", "Gorilla", "Male", Banana);
            Animal Thomas = new Animal("Thomas", "Loxodonta", "Male",Banana);
            Animal Susanne = new Animal("Susanne", "Sibirian Tiger", "Female",Meat);
            Animal Luis = new Animal("Luis", "Sibirian Tiger", "Male",Meat);
            Animal Michael = new Animal("Michael", "Gorilla", "Male",Banana);
            Animal Peter = new Animal("Peter", "Mountain Zebra", "Male",Grass);
            Animal Sabine = new Animal("Sabine", "Mountain Zebra", "Female",Grass);
            Animal Steffen = new Animal("Steffen", "Mountain Zebra", "Male", Fruits);
            Animal Sara = new Animal("Sara", "Mountain Zebra", "Female",Fruits);

            Enclosure MonkeyEnclosure = (new Enclosure("Monkey", 500, Keeper1));
            Enclosure LionEnclosure = (new Enclosure("Lion", 780, null));
            Enclosure ElephantEnclosure = (new Enclosure("Elephant", 530, Keeper2));
            Enclosure TigerEnclosure = (new Enclosure("Tiger", 150, Keeper3));
            Enclosure SpiderEnclosure = (new Enclosure("Spider", 5, null));
            Enclosure ZebraEnclosure = (new Enclosure("Zebra", 450, Keeper3));

            //Monkey Enclosure
            MonkeyEnclosure.AddAnimals(Martin);
            MonkeyEnclosure.AddAnimals(Michael);


            //Elephant Enclosure
            ElephantEnclosure.AddAnimals(Thomas);


            //Tiger Enclosure
            TigerEnclosure.AddAnimals(Susanne);
            TigerEnclosure.AddAnimals(Luis);

            //Zebra Enclosure
            ZebraEnclosure.AddAnimals(Peter);
            ZebraEnclosure.AddAnimals(Sabine);
            ZebraEnclosure.AddAnimals(Steffen);
            ZebraEnclosure.AddAnimals(Sara);


            //Lion Enclosure
            //Spider Enclosure

            DoppelmayrZoo.addEncolsureToZoo(ZebraEnclosure);
            DoppelmayrZoo.addEncolsureToZoo(MonkeyEnclosure);
            DoppelmayrZoo.addEncolsureToZoo(LionEnclosure);
            DoppelmayrZoo.addEncolsureToZoo(ElephantEnclosure);
            DoppelmayrZoo.addEncolsureToZoo(TigerEnclosure);
            DoppelmayrZoo.addEncolsureToZoo(SpiderEnclosure);


                 
            DoppelmayrZoo.PrintZoo("├──");

            PressToContinue.Start("Press Enter to feed the Animals!");
            




        }
    }
}
