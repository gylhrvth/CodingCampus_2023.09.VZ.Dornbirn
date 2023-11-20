using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Enclosure
    {
        private string _name;
        private List<Animal> _animals;
        private List<Worker> _workers;

        public Enclosure(string name)
        {
            _name = name;
            _animals = new List<Animal>();
            _workers = new List<Worker>();
        }

        public void addAnimals(Animal ams)
        {
            _animals.Add(ams);
        }

        public void addWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void CalculateFoodReport(Dictionary<Food, int> report)
        {
            foreach (Animal ani in _animals)
            {
                ani.CalculateFoodReport(report);
            }
        }


        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|   ├── Gehege: {0}", _name);

            foreach (Worker worker in _workers)
            {
                worker.PrintStructure();
            }

            foreach (Animal ams in _animals)
            {
                ams.PrintStructure();
            }
        }
    }
}
