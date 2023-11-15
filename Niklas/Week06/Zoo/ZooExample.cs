namespace Niklas.Week06.Zoo
{
    internal class ZooExample
    {
        public static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void Start()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            Random random = new Random();

            int R1 = r1.Next(0, 3);
            int R2 = r2.Next(0, 2);
            int R3 = r3.Next(0, 3);

            DateTime t = DateTime.Now;
            Console.Write("  Heute ist: ");
            Console.WriteLine(t.ToString("dddd"));

            Zoo zoo = new Zoo("Park name", 1234);

            zoo.Name = "Tierpark Höchst";
            zoo.Year = 1982;

            ZooKeeper keeper1 = new ZooKeeper("Gyula", 40, 180, "Meadow", "", "");
            ZooKeeper keeper2 = new ZooKeeper("Lukas", 35, 183, "Woods", "", "");
            ZooKeeper keeper3 = new ZooKeeper("Sandro", 25, 185, "Aquarium", "", "");

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure aquarium = new Enclosure("Ocean", "Outdoor/Water", "Cold Temperature", "Dirty");

            Animals rabbit1 = new Animals("Peter", 2, "Rabbit", "Male", "hungry", 100, false);
            Animals rabbit2 = new Animals("Hase", 1, "Rabbit", "Female", "hungry", 100, false);
            Animals rabbit3 = new Animals("Richard", 1, "Rabbit", "Male", "hungry", 100, false);
            Animals monkey1 = new Animals("Elisabeth", 3, "Monkey", "Male", "hungry", 100, false);
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female", "hungry", 100, false);
            Animals dolphin1 = new Animals("Hans", 6, "Dolphin", "Male", "hungry", 100, false);
            Animals dolphin2 = new Animals("Jürgen", 8, "Dolphin", "Male", "hungry", 100, false);
            Animals sealion = new Animals("Simba", 9, "Sealion", "Female", "hungry", 100, false);

            for (int i = 0; i < 9; i++)
            {
                arr[i] = random.Next(101);
            }

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


            monkey1.AddFood(banana);
            monkey2.AddFood(banana);
            dolphin1.AddFood(fish);
            dolphin2.AddFood(fish);
            sealion.AddFood(fish);
            rabbit1.AddFood(carrot);
            rabbit2.AddFood(carrot);
            rabbit3.AddFood(carrot);

            zoo.PrintZoo();

            if (meadow.Status != "Clean" || woods.Status != "Clean" || aquarium.Status != "Clean")
            {
                meadow.Status = "Clean";
                woods.Status = "Clean";
                aquarium.Status = "Clean";
            }

            Console.WriteLine();
            keeper1.Feeding = "Hase";
            keeper1.Feeding = "Richard";
            keeper1.Feeding = "Peter";
            Console.WriteLine();
            keeper2.Feeding = "Elisabeth";
            keeper2.Feeding = "Lukas";
            Console.WriteLine();
            keeper3.Feeding = "Hans";
            keeper3.Feeding = "Jürgen";
            keeper3.Feeding = "Simba";
            Console.WriteLine();
            monkey1.Hunger = "fed up";
            monkey2.Hunger = "fed up";
            dolphin1.Hunger = "fed up";
            dolphin2.Hunger = "fed up";
            sealion.Hunger = "fed up";
            rabbit1.Hunger = "fed up";
            rabbit2.Hunger = "fed up";
            rabbit3.Hunger = "fed up";
            Console.WriteLine();

            if (monkey1.Hunger == "fed up" &&
                monkey2.Hunger == "fed up" &&
                dolphin1.Hunger == "fed up" &&
                dolphin2.Hunger == "fed up" &&
                sealion.Hunger == "fed up" &&
                rabbit1.Hunger == "fed up" &&
                rabbit2.Hunger == "fed up" &&
                rabbit3.Hunger == "fed up")
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
            for (int bissChance = 0; bissChance < 1; bissChance++)
            {
                if (arr[0] < 40 && rabbit1.Health > 0)
                {
                    rabbit1.Biss = true;
                }
                if (arr[1] < 40 && rabbit2.Health > 0)
                {
                    rabbit2.Biss = true;
                }
                if (arr[2] < 40 && rabbit3.Health > 0)
                {
                    rabbit3.Biss = true;
                }
                if (arr[3] < 40 && monkey1.Health > 0)
                {
                    monkey1.Biss = true;
                }
                if (arr[4] < 40 && monkey2.Health > 0)
                {
                    monkey2.Biss = true;
                }
                if (arr[5] < 40 && dolphin1.Health > 0)
                {
                    dolphin1.Biss = true;
                }
                if (arr[7] < 40 && dolphin2.Health > 0)
                {
                    dolphin2.Biss = true;
                }
                if (arr[8] < 40 && sealion.Health > 0)
                {
                    sealion.Biss = true;
                }
            }
            Console.WriteLine();
            for (int bissVictim = 0; bissVictim < 1; bissVictim++)
            {
                if (rabbit1.Biss == true)
                {
                    rabbit2.Health -= 15;
                }
                if (rabbit2.Biss == true)
                {
                    rabbit3.Health -= 15;
                }
                if (rabbit3.Biss == true)
                {
                    rabbit1.Health -= 15;
                }
                if (monkey1.Biss == true)
                {
                    monkey2.Health -= 15;
                }
                if (monkey2.Biss == true)
                {
                    monkey1.Health -= 15;
                }
                if (dolphin1.Biss == true)
                {
                    sealion.Health -= 15;
                }
                if (dolphin2.Biss == true)
                {
                    dolphin1.Health -= 15;
                }
                if (sealion.Biss == true)
                {
                    dolphin2.Health -= 15;
                }
            }
            Console.WriteLine();
            zoo.PrintZoo();
        }
    }
}
