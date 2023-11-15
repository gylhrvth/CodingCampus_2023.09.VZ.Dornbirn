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
            Zoo z = new Zoo ("BzBahnhof",1951);

            Cage c1 = new Cage("Jungle");
            Cage c2 = new Cage("Ice");

            Worker w1 = new Worker("BAAA","Jungle");
            Worker w2 = new Worker("APU","Ice");

            Animal a1 = new Animal("Affe","Gustavo");
            Animal a2 = new Animal("Affe", "Pablo");
            Animal a3 = new Animal("Affe", "Eduard");

            Animal a4 = new Animal("Pinguin", "Sanchez");
            Animal a5 = new Animal("Pinguin", "Rosalita");
            Animal a6 = new Animal("Pinguin", "Wilson");

            int food1001 = rand.Next(1, 8); int food1002 = rand.Next(1, 8); int food1003 = rand.Next(1, 8);
            int food2001 = rand.Next(1, 8); int food2002 = rand.Next(1, 8); int food2003 = rand.Next(1, 8);

            Food f1001 = new Food("Banane",food1001,food1001*3);
            Food f1002 = new Food("Banane", food1002, food1002 * 3);
            Food f1003 = new Food("Banane", food1003, food1003 * 3);
            Food f2001 = new Food("Fisch", food2001,food2001*2);
            Food f2002 = new Food("Fisch", food2002, food2002 * 2);
            Food f2003 = new Food("Fisch", food2003, food2003 * 2);

            z.AddCage(c1); z.AddCage(c2);
            z.AddWorker(w1);z.AddWorker(w2);           

            c1.AddAnimal(a1); c1.AddAnimal(a2); c1.AddAnimal(a3);
            c2.AddAnimal(a4); c2.AddAnimal(a5); c2.AddAnimal(a6);
            c1.AddWorker(w1); c1.AddWorker(w2);

            a1.AddFood(f1001); a2.AddFood(f1002); a3.AddFood(f1003);
            a4.AddFood(f2001); a5.AddFood(f2002); a6.AddFood(f2003);

            z.PrintStrukture();


        }
    }
}
