using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    internal class ZooMain
    {
        public static void Start()
        {
            Food energydrink = new Food("Carrot", "Dose", 3.50);
            Food bread = new Food("Broetle", "Anzahl", 2.40);

            Zoo zoo = new Zoo("Campus Monkeys", 2023);

            Gehege codingcamp = new Gehege("Coding Monkys", "typing stuff");

            Animals monkey1 = new Animals("Fire", 4, "Monkey", "Hot", energydrink, 4);
            Animals monkey2 = new Animals("Lilli", 1, "Monkey", "Female", bread, 2);

            //Food energydrink = new Food("Carrot", "Dose", 3.50);
            //Food bread = new Food("Broetle", "Anzahl", 2.40);


            //zoo.AddGehege(codingcamp);

            codingcamp.AddAnimals(monkey1);
            codingcamp.AddAnimals(monkey2);
            

            zoo.PrintZoo();
        }
    }
}
