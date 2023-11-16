using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class ZooKeeper
    {
        public string _Name { get; private set; }

        private List<Enclosure> _EnclosureList = new();

        public ZooKeeper(string name, List<Enclosure> enclosures)
        {
            _Name = name;
            _EnclosureList = enclosures;
        }

        public List<Enclosure> EnclosureList
        {
            get => _EnclosureList;
        }

        public string Name
        {
            get => _Name;
        }

        public void PrintZooKeeper()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("│   ├── Zookeeper: {0}", _Name);
            Console.ResetColor();
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintAnimals();
            }
        }

        public void SimulateZookeeperWork()
        {   
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.SimulateTakeCareOfEnclosure(Name);

            }
        }
    }
}
