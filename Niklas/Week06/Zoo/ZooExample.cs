namespace Niklas.Week06.Zoo
{
    internal class ZooExample
    {
        public static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static double[] R4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static Random r4 = new Random();
        public static void Start()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            Random rand = new Random();



            DateTime t = DateTime.Now;
            Console.Write("  Heute ist: ");
            Console.WriteLine(t.ToString("dddd"));

            Zoo zoo = new Zoo("Park name", 1234);

            zoo.Name = "Tierpark Höchst";
            zoo.Year = 1982;

            TierArzt arzt1 = new TierArzt("Alex");
            TierArzt arzt2 = new TierArzt("Mannfred");
            TierArzt arzt3 = new TierArzt("Heinz");

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature", false);
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature", false);
            Enclosure aquarium = new Enclosure("Ocean", "Outdoor/Water", "Cold Temperature", false);

            ZooKeeper keeper1 = new ZooKeeper("Gyula", 40, 180, meadow.Name, "", "");
            ZooKeeper keeper2 = new ZooKeeper("Lukas", 35, 183, woods.Name, "", "");
            ZooKeeper keeper3 = new ZooKeeper("Sandro", 25, 185, aquarium.Name, "", "");

            zoo.AddEnclosure(meadow);
            zoo.AddEnclosure(woods);
            zoo.AddEnclosure(aquarium);

            Animal rabbit1 = new Animal("Peter", 2, "Rabbit", "Male", true, 30, false);
            Animal rabbit2 = new Animal("Hase", 1, "Rabbit", "Female", true, 30, false);
            Animal rabbit3 = new Animal("Richard", 1, "Rabbit", "Male", true, 30, false);
            Animal monkey1 = new Animal("Elisabeth", 3, "Monkey", "Male", true, 100, false);
            Animal monkey2 = new Animal("Lukas", 3, "Monkey", "Female", true, 100, false);
            Animal dolphin1 = new Animal("Hans", 6, "Dolphin", "Male", true, 140, false);
            Animal dolphin2 = new Animal("Jürgen", 8, "Dolphin", "Male", true, 140, false);
            Animal sealion = new Animal("Simba", 9, "Sealion", "Female", true, 200, false);
            Animal sealion2 = new Animal("Ralph", 11, "Sealion", "Male", true, 200, false);

            Food banana = new Food("Banana", 6, 2);
            Food fish = new Food("Fish", 12, 4);
            Food carrot = new Food("Carrot", 3, 1);

            zoo.AddZooKeeper(keeper1);
            zoo.AddZooKeeper(keeper2);
            zoo.AddZooKeeper(keeper3);

            keeper1.AddEnclosure(meadow);
            keeper2.AddEnclosure(woods);
            keeper3.AddEnclosure(aquarium);

            meadow.AddAnimals(rabbit1);
            meadow.AddAnimals(rabbit2);
            meadow.AddAnimals(rabbit3);
            woods.AddAnimals(monkey1);
            woods.AddAnimals(monkey2);
            aquarium.AddAnimals(dolphin1);
            aquarium.AddAnimals(dolphin2);
            aquarium.AddAnimals(sealion);
            aquarium.AddAnimals(sealion2);

            monkey1.AddFood(banana);
            monkey2.AddFood(banana);
            dolphin1.AddFood(fish);
            dolphin2.AddFood(fish);
            sealion.AddFood(fish);
            rabbit1.AddFood(carrot);
            rabbit2.AddFood(carrot);
            rabbit3.AddFood(carrot);

            for (int days = 0; days < 8; days++)
            {
                zoo.PrintZoo();

                Console.WriteLine();

                zoo.SimulateDay();

                Console.WriteLine();

                for (int i = 0; i < 9; i++)
                {
                    R4[i] = r4.Next(1, 15);
                }

                int R1 = r1.Next(0, 3);
                int R2 = r2.Next(0, 2);
                int R3 = r3.Next(0, 3);

                for (int i = 0; i < 9; i++)
                {
                    arr[i] = rand.Next(101);
                }

                zoo.FeedAnimals();

                if (monkey1.Hunger == false &&
                    monkey2.Hunger == false &&
                    dolphin1.Hunger == false &&
                    dolphin2.Hunger == false &&
                    sealion.Hunger == false &&
                    rabbit1.Hunger == false &&
                    rabbit2.Hunger == false &&
                    rabbit3.Hunger == false)
                {
                    if (R1 == 1)
                    {
                        keeper1.Favourite = $"{rabbit1.Name}";
                    }
                    else if (R1 == 1)
                    {
                        keeper1.Favourite = $"{rabbit2.Name}";
                    }
                    else
                    {
                        keeper1.Favourite = $"{rabbit3.Name}";
                    }

                    if (R2 == 0)
                    {
                        keeper2.Favourite = $"{monkey1.Name}";
                    }
                    else if (R2 == 1)
                    {
                        keeper2.Favourite = $"{monkey2.Name}";
                    }

                    if (R3 == 0)
                    {
                        keeper3.Favourite = $"{dolphin1.Name}";
                    }
                    else if (R3 == 1)
                    {
                        keeper3.Favourite = $"{dolphin2.Name}";
                    }
                    else
                    {
                        keeper3.Favourite = $"{sealion.Name}";
                    }
                }

                Console.WriteLine();

                zoo.Biting();

                zoo.BiteDamage();

                Console.WriteLine();

                zoo.DeadAnimal();

                Console.WriteLine();

                if (days == days++)
                {
                    Console.WriteLine("===End of day!===");
                }

                rabbit1.Biss = false; rabbit2.Biss = false; rabbit3.Biss = false; monkey1.Biss = false; monkey2.Biss = false; dolphin1.Biss = false; dolphin2.Biss = false; sealion.Biss = false;

                Console.WriteLine();
            }
            zoo.PrintZoo();

            Console.WriteLine();
            Console.WriteLine("---END OF WEEK---");

        }
    }
}