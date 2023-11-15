using Mehmet.ZOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Zoo
{
    internal class Cage
    {
        private string _name;
        private List<Animal> _AnimalList;
        private List<Worker> _WorkerList;

        public Cage(string name)
        {
            _name = name;
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
                _name); 
            foreach (Animal animal in _AnimalList)
            {
                animal.PrintStrukture();
            }

        }

    }
}
