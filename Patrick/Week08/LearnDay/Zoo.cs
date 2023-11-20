using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearnDay
{

    internal class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _EnclosureList;
        private List<ZooKeeper> _KeeperList;



        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _KeeperList = new List<ZooKeeper>();
            _EnclosureList = new List<Enclosure>();
        }

        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"├── Zoo: {_Name}, gegründet: {_FoundingYear} ");
            Console.ResetColor();
            foreach (ZooKeeper keeper in _KeeperList)
            {
                keeper.PrintZookeeper();
            }
        }

        public void PrintEnclosure()
        {
            foreach (Enclosure enclosure in _EnclosureList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"│   ├── Gehege: {enclosure}");
            }
        }


        public void FillKeeperList(ZooKeeper zooKeeper)
        {
            if (!_KeeperList.Contains(zooKeeper))
            {
                _KeeperList.Add(zooKeeper);
            }
        }

        public void SimulateDay(int day)
        {
           
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.WasKeeperHere();
            }

            Console.WriteLine($"Simulation Tag {day} startet.");

            foreach (ZooKeeper keeper in _KeeperList)
            {
                keeper.ZooKeeperDay();
                
            }

        }

    }
}
