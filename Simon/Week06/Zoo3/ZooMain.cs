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

            AnimalFood koerner = new AnimalFood("Körner", "kg", 0.90);
            AnimalFood heu = new AnimalFood("Heu", "Ballen", 1.35);
            AnimalFood fleisch = new AnimalFood("Fleisch", "kg", 23);
            AnimalFood schokolade = new AnimalFood("Schoki", "Tafeln", 1.30);

            Animals bert = new Animals("Bert", "Adler", fleisch, 1.25);
            Animals stick = new("Stick", "Uhu", koerner, 0.468);
            Animals elsa = new("Elsa", "Ziege", heu, 1.5);
            Animals fridolin = new("Fridolin", "Hängebauchschwein", schokolade, 2);
            Animals fridolin2 = new("Fridolin", "Hängebauchschwein", schokolade, 2);
            Animals fridge = new("Fridge", "Kuh", heu, 3);
            Animals fred = new("Fred", "MiniSchwein", schokolade, 15);

            wildpark.AddEnclosure(streichelgehege);
            wildpark.AddEnclosure(vogelkaefig);
            wildpark.AddEnclosure(schweinestall);

            schweinestall.AddAnimals(fridolin2);
            schweinestall.AddAnimals(fred);

            streichelgehege.AddAnimals(elsa);
            streichelgehege.AddAnimals(fridolin);
            streichelgehege.AddAnimals(fridge);

            vogelkaefig.AddAnimals(bert);
            vogelkaefig.AddAnimals(stick);

            

            wildpark.PrintZoo();
            wildpark.GetFoodStatistics();


        }


    }
}
