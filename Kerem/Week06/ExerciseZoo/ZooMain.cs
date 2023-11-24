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
        
            Enclosure Desert = new Enclosure("Desert", "Outdoor/Ground", "Outside Temperature 45°");
            Enclosure mountain = new Enclosure("Mountain", "Outdoor/Ground", "Outside Temperature 15°");
            Enclosure fishtank = new Enclosure("Fishtank", "Aquarium", "Salty Temperature 25°");
            Enclosure sky = new Enclosure("Skypia", "Clouds", "humidity 80%");


            Food SMILEfruit = new Food("SMILEfruit", "pieces", 34);
            Food CottonCandy = new Food("CottonCandy", "multitude", 86);
            Food Sand = new Food("Sand", "kg", 39);
            Food Apple = new Food("Apple", "pieces", 27);
            Food Sake = new Food("Sake", "liter", 10);
            Food fish = new Food("Fish", "pieces", 22);

            Pfleger Vivi = new Pfleger("Vivi", new List<Enclosure>{ Desert, mountain });
            Pfleger Rebecca = new Pfleger("Rebecca", new List<Enclosure> { fishtank, sky });

            Animals mythic = new Animals("Kaido", 56, "Mythic", Sake ,11, "ROROROROR");
            Animals Uglyfish = new Animals("Arlong", 44, "Fishman", fish , 7,"KUSCHKUSCHSKSHUCH");
            Animals Flamingo = new Animals("Don Quichotte de Flamingo", 34, "Stringman", SMILEfruit, 26,"HEHEHEHEHEH");
            Animals Thunder = new Animals("Enel", 43, "Earlobeman", Apple, 20, "HAHDIHDAIHD");
            Animals Croco = new Animals("Sir Crocodile", 35, "Hookman", Sand, 32,"OHOHAOSDHAODH");
            Animals Deer = new Animals("Chopper", 15, "TonyTony", CottonCandy, 53, "HIHIHIHIHIH");


            z.Pfleger.Add(Vivi);
            z.Pfleger.Add(Rebecca);


            z.addEnclosure(Desert);
            z.addEnclosure(mountain);
            z.addEnclosure(sky);
            z.addEnclosure(fishtank);
            
            Desert.addAnimals(Croco);

            sky.addAnimals(Thunder);

            mountain.addAnimals(Flamingo);
            mountain.addAnimals(Deer);

            fishtank.addAnimals(mythic);
            fishtank.addAnimals(Uglyfish);
            
            z.PrintZoo();
   
            z.PrintZooStatistic();
            Console.WriteLine("Simulation:");
         



        }


    }
}
