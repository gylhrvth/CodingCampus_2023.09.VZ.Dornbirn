using Mehmet.ZOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.Zoo
{
    internal class Cage
    {
        public static Random rand = new Random();
        public static Random randBiteRate = new Random();
        public static Random randHitDMG = new Random();
        private string _Name;
        private List<Animal> _AnimalList;
        private List<Worker> _WorkerList;
        private int _Health = 100;
        private bool _Look = true;
        int awa = rand.Next(1, 4);
        int count = 0;


        public Cage(string name)
        {
            _Name = name;
            _AnimalList = new List<Animal>();
            _WorkerList = new List<Worker>();

        }

        public void AddAnimal(Animal animal)
        {
            _AnimalList.Add(animal);
        }

        public void AddWorker(Worker worker)
        {
            _WorkerList.Add(worker);
        }

   
        public void PrintStrukture()
        {
            Console.WriteLine("   └──┬┤ Gehege: {0}",
                _Name);
            foreach (Animal animal in _AnimalList)
            {
                animal.PrintStrukture();
            }

        }

        public void SimulateDay()
        {
            Console.WriteLine("    fängt mit Gehege: {0} an", _Name);
            foreach (Animal animal in _AnimalList)
            {
                animal.SimulateDay();
                count = count + 1;

                if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }
                else if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }
                else if (awa == count && _Look == true)
                {
                    animal.LookAtAnimal();
                    _Look = false;
                }

                int biterate = randBiteRate.Next(0, 101);
                int hit = randHitDMG.Next(6, 10);


                if (biterate < 41)
                {
                    _Health = _Health - hit;
                    Console.WriteLine("{0} erhält {1} schaden aktuelle Lebenspunkte {2}",animal,hit,_Health);
                    if (_Health <= 0)
                    {
                        Console.WriteLine("ist gestorben");
                        _AnimalList.Remove(animal);
                    }
                }



            }
            _Look = true;
            count = 0;
            awa = rand.Next(1, 4);
        }


    }
}
