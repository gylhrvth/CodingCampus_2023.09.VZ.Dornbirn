using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo z = new Zoo("Wano Kuni", 2018);

            Enclosure Desert = new Enclosure("Desert: ", "Outdoor/Ground", "Outside Temperature 45°");
            Enclosure mountain = new Enclosure("Mountain: ", "Outdoor/Ground", "Outside Temperature 15°");
            Enclosure fishtank = new Enclosure("Fishtank: ", "Aquarium", "Salty Temperature 25°");
            Enclosure sky = new Enclosure("Skypia", "Clouds", "humidity 80%");


            Food SMILEfruit = new Food("SMILEfruit", "pieces", 1.000);
            Food CottonCandy = new Food("CottonCandy", "multitude", 50);
            Food Sand = new Food("Sand", "kg", 22);
            Food Apple = new Food("Apple", "pieces", 80);
            Food Sake = new Food("Sake", "liter", 32);
            Food fish = new Food("Fish", "pieces", 17);

            Pfleger Vivi = new Pfleger("Vivi", new List<Enclosure>{ Desert, mountain });
            Pfleger Rebecca = new Pfleger("Rebecca", new List<Enclosure> { fishtank, sky });

            Animals mythic = new Animals("Kaido", 56, "Mythic", Sake ,300);
            Animals Uglyfish = new Animals("Arlong", 44, "Fishman", fish , 200);
            Animals Flamingo = new Animals("Don Quichotte de Flamingo", 40, "Stringman", SMILEfruit, 100);
            Animals Thunder = new Animals("Enel", 43, "Earlobeman", Apple, 30);
            Animals Croco = new Animals("Sir Crocodile", 35, "Hookman", Sand, 46);
            Animals Deer = new Animals("Chopper", 15, "TonyTony", CottonCandy, 18);



            z.addEnclosure(Desert);
            Desert.addAnimals(Croco);

            z.addEnclosure(mountain);
            mountain.addAnimals(Flamingo);
            mountain.addAnimals(Deer);

            z.addEnclosure(sky);
            sky.addAnimals(Thunder);

            z.addEnclosure(fishtank);            
            fishtank.addAnimals(mythic);
            fishtank.addAnimals(Uglyfish);

            z.Pfleger.Add(Vivi);
            z.Pfleger.Add(Rebecca);


            z.PrintZoo();

        }


    }
}
