using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {

            Zoo zoo = new Zoo("Zootastiko", "Dornbirn", 2020, 11);

            Food Bannanas = new Food("Bannanas", "KG", 5);
            Food Gras = new Food("Gras", "bales of grass", 75 );
            Food Meat = new Food("Meat", "KG", 15);
            Food Fish = new Food("Fish", "KG", 17);

            

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature: 20°");
            Enclosure woods = new Enclosure("Wood", "Outdoor/Ground", "Outside Temperature: 20°");
            Enclosure swamp = new Enclosure("Swamp", "Outdoor/Water", "Outside Temperature: 28°");
            Enclosure iceberg = new Enclosure("Iceberg", "Indoor/Ice/Water", "Indoor Temperature: -5°");
            Enclosure savanna = new Enclosure("Savanna", "Indoor/Desert", "Indoor Temperature: 30°");

            Pfleger Mero = new Pfleger("Mero","Cow" ,new List<Enclosure> { meadow,swamp,savanna });
            Pfleger Anna = new Pfleger("Anna", "Pinguin", new List<Enclosure> { woods, iceberg, savanna });

            ZooDoc Rato = new ZooDoc("Rato");
            ZooDoc Allania = new ZooDoc("Allania");


            zoo.AddKeeper(Mero);
            zoo.AddKeeper(Anna);

            Animals cow1 = new Animals("Sora", 15, "Cow","Female", Gras, 1, 5, 100,100, "MUUHHH");
            Animals cow2 = new Animals("Meto", 16, "Cow", "Male", Gras, 1, 15, 100, 100, "MUUHHH") ;
            Animals monkey1 = new Animals("Rebo", 7, "Monkey", "Male", Bannanas, 2, 20, 100, 100,"UHAHAHAHA");
            Animals monkey2 = new Animals("Annika", 8, "Monkey", "Female", Bannanas, 3, 20, 100, 100,"UHAAHAHAH");
            Animals Snake1 = new Animals("Billy", 5, "Snake", "Male", Meat, 1, 100, 100, 100,"PSSSSSSS");
            Animals Snake2 = new Animals("Zoe", 5, "Snake", "Female", Meat, 1, 100, 100, 100,"PSSSSSSS");
            Animals Pinguin1 = new Animals("Pingo", 13, "Pinguin", "Male", Fish, 2, 5, 100, 100,"PIUPIU");
            Animals Pinguin2 = new Animals("Louise", 11, "Pinguin", "Female", Fish, 2, 5, 100, 100, "PIUPIU");
            Animals Pinguin3 = new Animals("Larry", 1, "Baby Pinguin", "Male", Fish, 2,5 , 100, 100, "PIUPIU");
            Animals Lion1 = new Animals("Simba", 15, "Lion", "Male", Meat, 3, 50,100, 100, "RAAAWWRRR");
            Animals Lion2 = new Animals("Leo", 13, "Lion", "Female", Meat, 3, 50, 100, 100,"RAAAWRRR");



           

            //Enclosure aufrufen im Zoo
            zoo.AddEnclosure(meadow);
            zoo.AddEnclosure(woods);
            zoo.AddEnclosure(swamp);
            zoo.AddEnclosure(iceberg);
            zoo.AddEnclosure(savanna);
            

            //Animals aufrufen im Enclosure
            meadow.AddAnimals(cow1);
            meadow.AddAnimals(cow2);

            woods.AddAnimals(monkey1);
            woods.AddAnimals(monkey2);

            swamp.AddAnimals(Snake1);
            swamp.AddAnimals(Snake2);

            iceberg.AddAnimals(Pinguin1);
            iceberg.AddAnimals(Pinguin2);
            iceberg.AddAnimals(Pinguin3);

            savanna.AddAnimals(Lion1);
            savanna.AddAnimals(Lion2);

            zoo.ZooDocList.Add(Rato);
            zoo.ZooDocList.Add(Allania);

            zoo.PrintZoo();
            Console.WriteLine();

            //kosten ausprinten
            zoo.PrintZooStatistic();

            Console.WriteLine();

            Rato.AddAnimal(cow1);
            Rato.AddAnimal(cow2);


          

            int day = 10;
            for (int i = 1; i <= day; i++)
            {
                Console.WriteLine("Day " + i + ": ");
                zoo.Simulate();
                Console.WriteLine("========================================");

                zoo.FightStart();
                Console.WriteLine("=====================================");
                zoo.HealDaily();
            }

            

        }
    }
}
