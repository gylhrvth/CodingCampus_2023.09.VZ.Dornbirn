namespace Fabian.Week06._04Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new("Tiergarten Dornbirn", 2022);
            Enclosure enclosure1 = new("Alpenwiese");
            enclosure1.Animals.Add(new("Rijska", "Kuh"));

            Enclosure enclosure2 = new("Ried");
            enclosure2.Animals.Add(new("Garmond", "Storh"));
            enclosure2.Animals.Add(new("Hugo", "Storh"));
            enclosure2.Animals.Add(new("Idaxis", "Storh"));

            Enclosure enclosure3 = new("Terrarium (warm)");
            zoo.Enclosures.Add(enclosure1);
            zoo.Enclosures.Add(enclosure2);
            zoo.Enclosures.Add(enclosure3);

            PrintStructure(zoo);

        }
        public static void PrintStructure(Zoo zoo)
        {
            Console.WriteLine($"├── Zoo: {zoo.Name}, founded: {zoo.FoundingYear}");
            foreach (var enclosure in zoo.Enclosures)
            {
                Console.WriteLine($"│   ├── Enclosure: {enclosure.Name}");
                foreach (var animal in enclosure.Animals)
                {
                    Console.WriteLine($"│       ├── {animal.Name}, {animal.Type}");
                }
            }


        }
    }
}

