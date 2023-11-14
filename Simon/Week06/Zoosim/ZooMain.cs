using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public  class ZooMain
    {
        public static void Start()
        {
            Food water = new Food("water", "liter", 0.15);
            Food bread = new Food("broetle", "ammount", 2.40);

            Zoo zoo = new Zoo("Campus Monkeys", 2023, "Dornbirn", 23);

            Enclosure codingcamp = new Enclosure("Coding Monkys", "typing stuff", "chill");
            Enclosure sutty = new Enclosure("Animal Market", "where they get their food", "hectic");
            Enclosure company = new Enclosure("Hamsters inventing the wheel", "typing stuff", "formal");

            Animals monkey1 = new Animals("Fire", 4, "Monkey", "Hot", water, 4);
            Animals monkey2 = new Animals("Lilli", 1, "Monkey", "Female", bread, 2);


            zoo.AddEnclosure(codingcamp);
            zoo.AddEnclosure(sutty);
            zoo.AddEnclosure(company);

            codingcamp.AddAnimals(monkey1);
            codingcamp.AddAnimals(monkey2);
            company.AddAnimals(monkey1);
            
            zoo.PrintZoo();
            zoo.PrintFood();



        }
    }
}
