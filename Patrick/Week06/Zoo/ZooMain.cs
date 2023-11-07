using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", "gegründet 2022");

            Enclosure enclosureAlps = new Enclosure("Alpenwiese");
            Enclosure enclosureForest = new("Wald");
            Enclosure enclosureIceLand = new("Eisland");
           
            zoo.EnclosureList.Add(enclosureAlps);
            zoo.EnclosureList.Add(enclosureForest);
            zoo.EnclosureList.Add(enclosureIceLand);


            //animals enclosureAlps
            Animals animalCow = new("Kuh", "Hilda", 10);
            Animals animalPig = new("Schwein", "Sabine", 3);

            //animals enclosureForest
            Animals animalFox = new("Fuchs", "Johannes", 2);
            Animals animalRabbit = new("Hase", "Norbert", 1);
            Animals animalBird = new("Vogel", "Kurt", 2);

            //animals enclosureIceLand
            Animals animalBear = new("Eisbär", "Robert", 8);
            Animals animalSeal = new("Robbe", "Sandra", 4);

            enclosureAlps.AnimalsList.Add(animalCow);
            enclosureAlps.AnimalsList.Add(animalPig);
            enclosureForest.AnimalsList.Add(animalFox);
            enclosureForest.AnimalsList.Add(animalRabbit);
            enclosureForest.AnimalsList.Add(animalBird);
            enclosureIceLand.AnimalsList.Add(animalBear);
            enclosureIceLand.AnimalsList.Add(animalSeal);

            zoo.PrintZoo();
            zoo.PrintEnclosure();

        }

    }
}
