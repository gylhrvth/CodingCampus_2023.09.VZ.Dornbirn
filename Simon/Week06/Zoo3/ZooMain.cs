using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo wildpark = new Zoo("Wildpark Feldkirch", 1965);

            Enclosure streichelgehege = new Enclosure("Streichelgehege");
            Enclosure vogelkaefig = new Enclosure("Vogelkäfig");
            Enclosure schweinestall = new Enclosure("Schweinestall");
            Enclosure spielgruppefuerpaul = new Enclosure("SpielgruppeFeurPaul");

            AnimalFood koerner = new AnimalFood("Körner", "kg", 0.90);
            AnimalFood heu = new AnimalFood("Heu", "Ballen", 1.35);
            AnimalFood fleisch = new AnimalFood("Fleisch", "kg", 23);
            AnimalFood schokolade = new AnimalFood("Schoki", "Tafeln", 1.30);

            Animal bert = new Animal("Bert", "Adler", fleisch, 1.25, 50, 45);
            Animal stick = new("Stick", "Uhu", koerner, 0.468, 50, 45);
            Animal elsa = new("Elsa", "Ziege", heu, 1.5, 150, 10);
            Animal fridolin = new("Fridolin", "Hängebauchschwein", schokolade, 2, 250, 50);
            Animal fridolin2 = new("Fridolin clone", "Hängebauchschwein", schokolade, 2, 250, 5);
            Animal fridge = new("Fridge", "Kuh", heu, 3, 350, 15);
            Animal fred = new("Fred", "MiniSchwein", schokolade, 15, 100, 1);

            Zookeeper manfred = new("Manfred", new List<Enclosure> { streichelgehege, schweinestall }, fridolin);
            Zookeeper sabrina = new("Sabrina", new List<Enclosure> { vogelkaefig }, fred);
            Zookeeper paul = new("Paul", new List<Enclosure> { schweinestall, vogelkaefig, spielgruppefuerpaul }, bert);

            AnimalDoctor lucia = new("Lucia");
            AnimalDoctor noah = new("Noah");

            wildpark.AddEnclosure(streichelgehege);
            wildpark.AddEnclosure(vogelkaefig);
            wildpark.AddEnclosure(schweinestall);

            wildpark.AddZookeeper(manfred);
            wildpark.AddZookeeper(sabrina);
            wildpark.AddZookeeper(paul);

            wildpark.AddAnimalDoctor(lucia);
            wildpark.AddAnimalDoctor(noah);

            schweinestall.AddAnimals(fridolin2);
            schweinestall.AddAnimals(fred);

            streichelgehege.AddAnimals(elsa);
            streichelgehege.AddAnimals(fridolin);
            streichelgehege.AddAnimals(fridge);

            vogelkaefig.AddAnimals(bert);
            vogelkaefig.AddAnimals(stick);

            wildpark.PrintZoo();
            Console.WriteLine();
            wildpark.GetFoodStatistics();
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nTag {0}", i);
                wildpark.GetFoodStatistics();
                wildpark.PrintFight();
                wildpark.FeedEnclosures();
                wildpark.RestoreHP();
                wildpark.FoodReset();
            }




        }
    }
}
