using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearningDay
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

        public void AddEnclosure(Enclosure enc)
        {
            if (!_EnclosureList.Contains(enc))
            {
                _EnclosureList.Add(enc);
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

        public void PrintStatistic()
        {
            Dictionary<Food, float> dic = new Dictionary<Food, float>();
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.GetStatistic(dic);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nahrungsbedarf pro Tag");
            Console.ResetColor();
            float cost = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================================");
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"||{food.Name, -10} || {dic[food], -10} || {food.Price, -5} || {food.Unit, -1}||");
                float amount = dic[food];
                float price = food.Price * dic[food];
                cost += price;
            }
            Console.WriteLine("==============================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GesamtKosten pro Tag = " + cost + " Euronen");
            Console.ResetColor();
        }

    }
}
