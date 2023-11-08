using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Zoo
    {
        private string _name;
        private int _year;
        private string _day;
        private List<ZooKeeper> _ZooKeeper;
        public string Name
        {
            get => _name;

            set
            {
                Console.Write("  " + Convert.ToChar(9556) + "Zoo: " + value);
                _name = value;
            }
        }

        public int Year
        {
            get => _year;

            set
            {
                Console.WriteLine(", gegründet: " + value);
                _year = value;
            }
        }

        public string Day
        {
            get => _day;
            set
            {
                Console.Write("");
            }
        }

        public Zoo(string name, int year)
        {
            name = _name;
            year = _year;
            _ZooKeeper = new List<ZooKeeper>();
        }
        public void AddZooKeeper(ZooKeeper zooKeeper)
        {
            if (!_ZooKeeper.Contains(zooKeeper))
            {
                _ZooKeeper.Add(zooKeeper);
            }
        }

        public void PrintZoo()
        {

            foreach (ZooKeeper zooKeeper in _ZooKeeper)
            {
                zooKeeper.PrintZoo();
            }
        }
    }
}
