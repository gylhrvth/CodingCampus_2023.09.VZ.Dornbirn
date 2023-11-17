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
            Random rand = new Random();
            Random r4 = new Random();
            double[] R4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            DateTime t = DateTime.Now;
            Console.Write("  Heute ist: ");
            Console.WriteLine(t.ToString("dddd"));

            Zoo zoo = new Zoo("Park name", 1234);

            zoo.Name = "Tierpark Höchst";
            zoo.Year = 1982;

            TierArzt arzt1 = new TierArzt("Alex");
            TierArzt arzt2 = new TierArzt("Mannfred");
            TierArzt arzt3 = new TierArzt("Heinz");

            ZooKeeper keeper1 = new ZooKeeper("Gyula", 40, 180, "Meadow", "", "");
            ZooKeeper keeper2 = new ZooKeeper("Lukas", 35, 183, "Woods", "", "");
            ZooKeeper keeper3 = new ZooKeeper("Sandro", 25, 185, "Aquarium", "", "");

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature", "Dirty");
            Enclosure aquarium = new Enclosure("Ocean", "Outdoor/Water", "Cold Temperature", "Dirty");

            Animals rabbit1 = new Animals("Peter", 2, "Rabbit", "Male", "hungry", 30, false);
            Animals rabbit2 = new Animals("Hase", 1, "Rabbit", "Female", "hungry", 30, false);
            Animals rabbit3 = new Animals("Richard", 1, "Rabbit", "Male", "hungry", 30, false);
            Animals monkey1 = new Animals("Elisabeth", 3, "Monkey", "Male", "hungry", 100, false);
            Animals monkey2 = new Animals("Lukas", 3, "Monkey", "Female", "hungry", 100, false);
            Animals dolphin1 = new Animals("Hans", 6, "Dolphin", "Male", "hungry", 140, false);
            Animals dolphin2 = new Animals("Jürgen", 8, "Dolphin", "Male", "hungry", 140, false);
            Animals sealion = new Animals("Simba", 9, "Sealion", "Female", "hungry", 200, false);

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

            for (int days = 0; days < 7; days++)
            {
                zoo.PrintZoo();

                Console.WriteLine();

                meadow.Status = "Dirty";
                woods.Status = "Dirty";
                aquarium.Status = "Dirty";

                rabbit1.Hunger = "Hungry";
                rabbit2.Hunger = "Hungry";
                rabbit3.Hunger = "Hungry";
                monkey1.Hunger = "Hungry";
                monkey2.Hunger = "Hungry";
                dolphin1.Hunger = "Hungry";
                dolphin2.Hunger = "Hungry";
                sealion.Hunger = "Hungry";
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
                    if (rabbit1.Biss == true && rabbit2.Health > 0)
                    {
                        Console.WriteLine($"{rabbit2.Name} wurde gebissen!");
                        rabbit2.Health -= (rabbit2.Maxhealth * (R4[0] / 100));
                    }
                    if (rabbit2.Biss == true && rabbit3.Health > 0)
                    {
                        Console.WriteLine($"{rabbit3.Name} wurde gebissen!");
                        rabbit3.Health -= (rabbit3.Maxhealth * (R4[1] / 100));
                    }
                    if (rabbit3.Biss == true && rabbit1.Health > 0)
                    {
                        Console.WriteLine($"{rabbit1.Name} wurde gebissen!");
                        rabbit1.Health -= (rabbit1.Maxhealth * (R4[2] / 100));
                    }
                    if (monkey1.Biss == true && monkey2.Health > 0)
                    {
                        Console.WriteLine($"{monkey2.Name} wurde gebissen!");
                        monkey2.Health -= (monkey2.Maxhealth * (R4[4] / 100));
                    }
                    if (monkey2.Biss == true && monkey1.Health > 0)
                    {
                        Console.WriteLine($"{monkey1.Name} wurde gebissen!");
                        monkey1.Health -= (monkey1.Maxhealth * (R4[5] / 100));
                    }
                    if (dolphin1.Biss == true && sealion.Health > 0)
                    {
                        Console.WriteLine($"{sealion.Name} wurde gebissen!");
                        sealion.Health -= (sealion.Maxhealth * (R4[6] / 100));
                    }
                    if (dolphin2.Biss == true && dolphin1.Health > 0)
                    {
                        Console.WriteLine($"{dolphin1.Name} wurde gebissen!");
                        dolphin1.Health -= (dolphin1.Maxhealth * (R4[7] / 100));
                    }
                    if (sealion.Biss == true && dolphin2.Health > 0)
                    {
                        Console.WriteLine($"{dolphin2.Name} wurde gebissen!");
                        dolphin2.Health -= (dolphin2.Maxhealth * (R4[8] / 100));
                    }
                }

                Console.WriteLine();
                for (int removeDeadAnimal = 0; removeDeadAnimal < 1; removeDeadAnimal++)
                {
                    if (rabbit1.Health <= 0)
                    {
                        Console.WriteLine($"{rabbit1.Name} is dead!");
                        meadow.RemoveAnimals(rabbit1);
                    }
                    if (rabbit2.Health <= 0)
                    {
                        Console.WriteLine($"{rabbit2.Name} is dead!");
                        meadow.RemoveAnimals(rabbit2);
                    }
                    if (rabbit3.Health <= 0)
                    {
                        Console.WriteLine($"{rabbit3.Name} is dead!");
                        meadow.RemoveAnimals(rabbit3);
                    }
                    if (monkey1.Health <= 0)
                    {
                        Console.WriteLine($"{monkey1.Name} is dead!");
                        woods.RemoveAnimals(monkey1);
                    }
                    if (monkey2.Health <= 0)
                    {
                        Console.WriteLine($"{monkey2.Name} is dead!");
                        woods.RemoveAnimals(monkey2);
                    }
                    if (dolphin1.Health <= 0)
                    {
                        Console.WriteLine($"{dolphin1.Name} is dead!");
                        aquarium.RemoveAnimals(dolphin1);
                    }
                    if (dolphin2.Health <= 0)
                    {
                        Console.WriteLine($"{dolphin2.Name} is dead!");
                        woods.RemoveAnimals(dolphin2);
                    }
                    if (sealion.Health <= 0)
                    {
                        Console.WriteLine($"{sealion.Name} is dead!");
                        aquarium.RemoveAnimals(sealion);
                    }
                }

                Console.WriteLine();


                rabbit1.Biss = false; rabbit2.Biss = false; rabbit3.Biss = false; monkey1.Biss = false; monkey2.Biss = false; dolphin1.Biss = false; dolphin2.Biss = false; sealion.Biss = false;

                Console.WriteLine();
            }
            zoo.PrintZoo();

            Console.WriteLine();
            Console.WriteLine("---END OF WEEK---");

        }
    }
}