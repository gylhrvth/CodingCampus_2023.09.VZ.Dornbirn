using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearningDay
{
    internal class ZooKeeper
    {
        private string _Name;
        private List<Enclosure> _EnclosureList;


        public ZooKeeper(string name)
        {
            _Name = name;
            _EnclosureList = new List<Enclosure>();           
        }
        public string Name
        {
            get => _Name;
        }


        public void FillEnclosureList(Enclosure enclosure)
        {
            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZookeeper()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"   ├── Der Wärter {_Name} ");
            Console.ResetColor();
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintAllAnimal();
            }
        }

        public void ZooKeeperDay()
        {
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.KeeperMovingEnclosure(Name);
            }
        }

    }
}
