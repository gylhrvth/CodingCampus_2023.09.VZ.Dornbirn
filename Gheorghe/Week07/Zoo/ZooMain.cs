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


            Food bannanas = new Food("Bananas", "Pieces", 1.80);
            Food fleisch = new Food("Fleisch", "Kilo", 18);
            Food fisch = new Food("Fisch", "kilo", 10);


            Animals monkey1 = new Animals("Eugen", 3, "Monkey", "Male", bannanas, 10);
            Animals monkey2 = new Animals("Brigitte", 3, "Monkey", "Female", bannanas, 10);
            Animals tieger = new Animals("Sherkaan", 10, "Tiger", "Male", fleisch, 18);
            Animals crocodil = new Animals("Kroko", 3, "Crocodil", "Male", fisch, 10);



            ZooKeeper gheorghe = new("Gheorghe");
            ZooKeeper luiza = new("Luiza");
            ZooKeeper andrei = new("Andrei");
            ZooKeeper daniel = new("Daniel");

            luiza.AnimalObserve();
            gheorghe.AnimalObserve();
            andrei.AnimalObserve();
            daniel.AnimalObserve();


            zoo.AddZooKeeper(luiza);
            zoo.AddZooKeeper(gheorghe);
            zoo.AddZooKeeper(andrei);
            zoo.AddZooKeeper(daniel);

            woods.AddZookeeper(gheorghe);
            meadow.AddZookeeper(luiza);
            swamp.AddZookeeper(andrei);
            terrarium.AddZookeeper(daniel);


            gheorghe.AddEnclosure(woods);
            andrei.AddEnclosure(swamp);
            luiza.AddEnclosure(meadow);
            daniel.AddEnclosure(terrarium);



            zoo.AdddEnclosure(meadow);
            zoo.AdddEnclosure(woods);
            zoo.AdddEnclosure(swamp);
            zoo.AdddEnclosure(terrarium);



            woods.AddAnimals(monkey1);
            meadow.AddAnimals(monkey2);
            swamp.AddAnimals(tieger);
            terrarium.AddAnimals(crocodil);



            zoo.PrintZoo();

            for (int i = 1; i <= 6; i++)
            {
                zoo.Simulation(i);

            }

        }
    }
}
