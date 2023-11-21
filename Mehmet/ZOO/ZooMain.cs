using Mehmet.Zoo;
using Mehmet.ZOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Mehmet.Zoo
{
    internal class ZooMain
    {
        public static Random rand = new Random();

        public static void Start()
        {
            Zoo z = new Zoo("BzBahnhof", 1951);

            Cage c1 = new Cage("Jungle");
            Cage c2 = new Cage("Ice");

            Worker w1 = new Worker("BAAA", "Jungle");
            Worker w2 = new Worker("Fernando", "Jungle");
            Worker w3 = new Worker("Adam", "Ice");
            Worker w4 = new Worker("APU", "Ice");

            Doc doc1 = new Doc("DaRtH VaDeR");


            //Dictionary<Worker, Cage> dictWorkList = new Dictionary<Worker, Cage>();
            //dictWorkList.Add(w1, c1); dictWorkList.Add(w2, c1); dictWorkList.Add(w3, c2); dictWorkList.Add(w4, c2);

            Animal a1 = new Animal("Affe", "Gustavo");
            Animal a2 = new Animal("Affe", "Pablo");
            Animal a3 = new Animal("Affe", "Eduard");
            Animal a4 = new Animal("Pinguin", "Sanchez");
            Animal a5 = new Animal("Pinguin", "Rosalita");
            Animal a6 = new Animal("Pinguin", "Wilson");

            //Dictionary<Animal,Cage> dictAnimalList = new Dictionary<Animal, Cage>();
            //dictAnimalList.Add(a1, c1); dictAnimalList.Add(a2, c1); dictAnimalList.Add(a3, c1); dictAnimalList.Add(a4, c2); dictAnimalList.Add(a5, c2); dictAnimalList.Add(a6, c2);

            int food1001 = rand.Next(1, 8); int food1002 = rand.Next(1, 8); int food1003 = rand.Next(1, 8);
            int food2001 = rand.Next(1, 8); int food2002 = rand.Next(1, 8); int food2003 = rand.Next(1, 8);

            int totalprice1 = food1001 * 3; int totalprice2 = totalprice1 + food1002 * 3; int totalprice3 = totalprice2 + food1003 * 3;
            int totalprice4 = totalprice3 + food2001 * 2; int totalprice5 = totalprice4 + food2002 * 2; int totalprice6 = totalprice5 + food2003 * 2;

            Food f1001 = new Food("Banane", food1001, food1001 * 3, totalprice1);
            Food f1002 = new Food("Banane", food1002, food1002 * 3, totalprice2);
            Food f1003 = new Food("Banane", food1003, food1003 * 3, totalprice3);
            Food f2001 = new Food("Fisch", food2001, food2001 * 2, totalprice4);
            Food f2002 = new Food("Fisch", food2002, food2002 * 2, totalprice5);
            Food f2003 = new Food("Fisch", food2003, food2003 * 2, totalprice6);


            z.AddCage(c1); z.AddCage(c2);
            z.AddWorker(w1); z.AddWorker(w2); z.AddWorker(w3); z.AddWorker(w4);

            w1.AddCage(c1); w2.AddCage(c1); w3.AddCage(c2); w4.AddCage(c2);

            c1.AddAnimal(a1); c1.AddAnimal(a2); c1.AddAnimal(a3);
            c2.AddAnimal(a4); c2.AddAnimal(a5); c2.AddAnimal(a6);
            c1.AddWorker(w1); c1.AddWorker(w2); c2.AddWorker(w3); c2.AddWorker(w4);

            a1.AddFood(f1001); a2.AddFood(f1002); a3.AddFood(f1003);
            a4.AddFood(f2001); a5.AddFood(f2002); a6.AddFood(f2003);

            c1.AddDoc(doc1);c2.AddDoc(doc1);
            doc1.AddCage(c1);

            //doc1.AddAnimal(a1); doc1.AddAnimal(a2); doc1.AddAnimal(a3); doc1.AddAnimal(a4); doc1.AddAnimal(a5); doc1.AddAnimal(a6);

            z.PrintStrukture();

            int days = 10;

            for (int i = 1; i <= days; i++)
            {
                z.SimulateDay(i);
                a1.Fed = false; a2.Fed = false; a3.Fed = false; a4.Fed = false; a5.Fed = false; a6.Fed = false; 
                doc1.HealAnimal();
                if (i == days) 
                {
                    c1.TheEndStory();
                }
            }
        }
    }
}
