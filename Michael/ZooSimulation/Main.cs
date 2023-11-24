using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.ZooSimulation
{
    internal class ZooMain
    {

        public static void Start()
        {
            Zoo ExampleZoo = new Zoo("TestZoo", 1997);
            Veterenarian v1 = new Veterenarian("Sandro");

            Food f1 = new Food("pizza", "slice", 2);
            Food f2 = new Food("sushi", "piece", 100);
            Food f3 = new Food("fish", "fish", 10000000);

            Animal a00 = new Animal("Blah", "Cow", 200, (10,50), f1);
            Animal a01 = new Animal("Rijska", "Cow", 200, (10, 50), f1);
            Animal a02 = new Animal("Muh", "Cow", 200, (10, 50), f1);

            Animal a10 = new Animal("Garmond", "Storh", 200, (50,100),f2);
            Animal a11 = new Animal("Rayman", "Storh", 200, (50, 100), f2);
            Animal a12 = new Animal("Gerald", "Storh", 200, (50, 100), f2);

            Animal a20 = new Animal("Polo", "Pinguin", 100, (20, 25), f3);
            Animal a21 = new Animal("Pala", "Pinguin", 100, (20, 25), f3);
            Animal a22 = new Animal("Pele", "Pinguin", 100, (20, 25), f3);
            Animal a23 = new Animal("Pulu", "Pinguin", 100, (20, 25), f3);
            Animal a24 = new Animal("Pili", "Pinguin", 100, (20, 25), f3);
            Animal a25 = new Animal("Gustaf", "Pinguin", 100, (20, 25), f3);

            Carer c1 = new Carer("Erik");
            Carer c2 = new Carer("Martin");

            ExampleZoo.AddCarers( new List<Carer> { c1, c2 });
            ExampleZoo.AddVets(v1);

            Enclosure e1 = new Enclosure("Steppe");
            Enclosure e2 = new Enclosure("Sky");
            Enclosure e3 = new Enclosure("Iceroom");

            e1.AddAnimals(new List<Animal>{ a00, a01, a02});
            e2.AddAnimals(new List<Animal> { a10, a11, a12 });
            e3.AddAnimals(new List<Animal> { a20, a21, a22, a23, a24, a25 });

            c1.AddEnclosures(new List<Enclosure> { e1, e2 });
            c2.AddEnclosures(new List<Enclosure> { e2, e3 });

            ExampleZoo.AddEnclosures(new List<Enclosure> { e1, e2 , e3});

            ExampleZoo.SimulateMultipleDays(7);

            
        }
    }
}
