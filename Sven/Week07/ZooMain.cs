namespace Sven.Week07
{
    internal class ZooMain
    {

        public static void Start()
        {

            Zoo zoo = new Zoo("HalliGalli", "Leipzig", 1902);

            Food balls = new Food("Dragonballs", 200, "pieces");
            Food grain = new Food("Grain", 2, "kg");
            Food worms = new Food("Worms", 15, "kg");

            Enclosure moon = new Enclosure("Moon", "Cold / without Oxigen", "Namek");
            Enclosure aqua = new Enclosure("Aquarium", "Saltwater", "Neptun");
            Enclosure tropical = new Enclosure("Ancient Forrest", "Tropical", "Soul Society");
            Enclosure swamp = new Enclosure("Swamp", "Mud", "Demon Continent");


            Animal dragon1 = new Animal("Shen Long", 5485, "Spacedragon", "???", balls, 7);
            Animal axolotl1 = new Animal("Axel", 2, "Deep sea Axolotl", "Male", worms, 1);
            Animal blubird1 = new Animal("Blu", 4, "Ice Bird", "Female", grain, 2);
            Animal explofrog1 = new Animal("Frogston", 7, "Bomb Frog", "Male", worms, 5);

            Keeper k1 = new Keeper("Goku", new List<Enclosure> {moon, aqua});
            Keeper k2 = new Keeper("Gojo", new List<Enclosure> {tropical, swamp });

            zoo.AddEnclosure(moon);
            moon.AddAnimals(dragon1);

            zoo.AddEnclosure(aqua);
            aqua.AddAnimals(axolotl1);

            zoo.AddEnclosure(tropical);
            tropical.AddAnimals(blubird1);

            zoo.AddEnclosure(swamp);
            swamp.AddAnimals(explofrog1);

            
            zoo.PrintZoo();
            zoo.PrintFoodStatistic();

            k1.PrintFoodSimulation();
            k2.PrintFoodSimulation();   

        }

    }

}

