using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patrick.Week06.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private string _FoundingYear;
        private List<Enclosure> _EnclosureList;
        private List<ZooKeeper> _ZooKeeperList;

        //Properties
        public List<Enclosure> EnclosureList
        {
            get => _EnclosureList;
        }

        public List<ZooKeeper> ZooKeeperList
        {
            get => _ZooKeeperList;
        }

        public string Name
        {
            get => _Name;
        }

        public string FoundingYear
        {
            get => _FoundingYear;
        }

        //Konstruktor
        public Zoo(string name, string foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _EnclosureList = new List<Enclosure>();
            _ZooKeeperList = new List<ZooKeeper>();

        }

        public void PrintZooStatistic()
        {
            Dictionary<Food, float> dic = new();
            foreach (var enclosure in _EnclosureList)
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nahrungsbedarf pro Tag:");
            Console.ResetColor();
            float cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food._Name, -11} : {dic[food], -4} {food._Unit} pro kg: {food._Price} Euro ");
                float amount = dic[food];
                float price = food._Price * amount;
                cost += price;
            }           
            Console.WriteLine("=======================================================");
            Console.WriteLine("Gesamtkosten pro Tag: {0:N2}$", cost);
        }


        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"├── Zoo: {_Name} || {_FoundingYear}");
            Console.ResetColor();
        }


        public void PrintStructure()
        {
            PrintZoo();
            foreach (var keeper in ZooKeeperList)
            {
                keeper.PrintZooKeeper();
            }
        }

    }
}
