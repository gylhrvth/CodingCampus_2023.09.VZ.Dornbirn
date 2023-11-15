namespace Sven.Week07
{
    internal class ZooMain
    {

        public static void Start()
        {

            Zoo zoo = new Zoo("HalliGalli", "Leipzig", 1902);

            Enclosure savanna = new Enclosure("Savanne", "Warm und Trocken", "Namek");
            Enclosure aqua = new Enclosure("Aquarium", "Salzwasser", "Neptun");
            Enclosure tropical = new Enclosure("Urwald", "Tropisch", "Soul Society");
            Enclosure swamp = new Enclosure("Sumpf", "Schlamm", "Demon Continent");


            zoo.AddEnclosure(savanna);
            zoo.AddEnclosure(aqua);
            zoo.AddEnclosure(tropical);
            zoo.AddEnclosure(swamp);



            zoo.PrintZoo();
        }

    }

}

