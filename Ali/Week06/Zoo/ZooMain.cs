using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class ZooMain

    {

        public static void Start()
        {

            Zoo zoo = new Zoo("FreeForAll", "Götzis", 2020, 500);


            

            
            Food bannanas = new Food("Bannanas", "Pieces", 1.80);
            Food crops = new Food("Crops", "Pieces", 1.10);
            Food meat = new Food("Meat", "Kg", 15);
            Food fruit = new Food("Fruit", "Kg", 10);
            Food bugs = new Food("Bugs", "Pieces", 0.50);
            Food mice = new Food("Mice", "Pieces", 3);

            

            Enclosure flatland = new Enclosure("Outside Temperature", "Outdoor/Ground", "Flatland", "Moritz");
            Enclosure jungle = new Enclosure("Outside Temperatur", "Outdoor/Ground", "Jungle", "Josef");
            Enclosure swamp = new Enclosure("Outside Temperature", "Outdoor/Water", "Swamp", "Maria");
            Enclosure terrarium = new Enclosure("Warm/Moist", "Indoor","Reptile Terrarium", "Anna");

            Pfleger Moritz = new Pfleger("Moritz", flatland);
            Pfleger Josef = new Pfleger("Gustaf", jungle);
            Pfleger Maria = new Pfleger("Maria", swamp);
            Pfleger Anna = new Pfleger("Anna", terrarium);




            Animal monkey1 = new Animal("Eren", 3, "Monkey", "Male", bannanas, 500);
            Animal monkey2 = new Animal("Kerem", 3, "Monkey", "Female", bannanas, 250);
            Animal monkey3 = new Animal("ErenÜc", 3, "Monkey", "Female", bannanas, 234);

            Animal deer1 = new Animal("Martin", 2, "Deer", "Male", crops, 150);
            Animal boar1 = new Animal("Robom", 5, "Boar", "Male", crops, 400);
            Animal bear1 = new Animal("Teddy", 4, "Bear", "Male", meat, 14);

            Animal hippopotamus1 = new Animal("Johanna", 4, "Hippopotamus", "Female", fruit, 30);
            Animal hippopotamus2 = new Animal("Josef", 4, "Hippopotamus", "Male", fruit, 37);
            Animal crocodile = new Animal("Magnus", 12, "Crocodile", "Male", meat, 2);

            Animal gecko = new Animal("Moria", 42, "Gecko", "Male", bugs, 30);
            Animal snake = new Animal("Erdol", 12, "Snake", "Female", mice, 3);
            Animal chameleon = new Animal("Lara", 3, "Chameleon", "Female", bugs, 49);







            zoo.AddEnclosure(flatland);
            zoo.AddEnclosure(jungle);
            zoo.AddEnclosure(swamp);
            zoo.AddEnclosure(terrarium);

            flatland.AddAnimals(deer1);
            flatland.AddAnimals(boar1);
            flatland.AddAnimals(bear1);

            jungle.AddAnimals(monkey1);
            jungle.AddAnimals(monkey2);
            jungle.AddAnimals(monkey3);

            swamp.AddAnimals(hippopotamus1);
            swamp.AddAnimals(hippopotamus2);
            swamp.AddAnimals(crocodile);

            terrarium.AddAnimals(snake);
            terrarium.AddAnimals(chameleon);
            terrarium.AddAnimals(gecko);

            




            zoo.PrintZoo();
            zoo.PrintFoodReport();


            //for(int i = 0; i < 10; i++)
            {
                //zoo.PrintZoo();
            }

        }
    }
}
