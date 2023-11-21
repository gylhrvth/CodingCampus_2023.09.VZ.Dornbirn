using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace David.Week06.ZOO
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
            set => _EnclosureList = value;
        }


        public void PrintZooKeeper(bool printEnclosures = true)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-- Zookeeper: {0}", _Name);
            Console.ResetColor();
            if (printEnclosures)
            {
                foreach (Enclosure enclosure in _EnclosureList)
                {
                    enclosure.PrintAnimals();
                }
            }
        }

        //public void ZooKeeperWithResponsabilities()
        //{
        //    Console.WriteLine("Zookeeper: {0}, main enc.: , 2ndary enc", _Name);
        //}

        public void SimulateZookeeperWork()
        {
            foreach (Enclosure enc in _EnclosureList)
            {
                enc.SimulateTakeCareOfEnclosure(_Name);
            }
        }

        public override string ToString()
        {
            return _Name;
        }
    }
}


