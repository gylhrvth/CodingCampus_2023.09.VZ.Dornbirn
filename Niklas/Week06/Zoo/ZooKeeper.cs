using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Niklas.Week06.Zoo
{
    internal class ZooKeeper
    {
        private string _name;
        private int _age;
        private int _height;
        private string _enclosure;
        private string _favourite;
        private string _feeding;
        private List<Enclosure> _EnclosureList;

        public ZooKeeper(string name, int age, int height, string enclosure, string favourite, string feeding)
        {
            _name = name;
            _age = age;
            _height = height;
            _enclosure = enclosure;
            _EnclosureList = new List<Enclosure>();
            _favourite = favourite;
            _feeding = feeding;
        }
        public string Feeding
        {
            get => _feeding;

            set
            {
                Console.WriteLine($"{_name} is feeding {value}.");
                _feeding = value;
            }
        }
        public string Favourite
        {
            get => _favourite;
            set
            {
                Console.WriteLine($"{_name}s favourite animal is {value}. He is admiring it.");
                value = _favourite;
            }
        }
        public void AddEnclosure(Enclosure enclosure)
        {
            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZoo()
        {
            string space = new string(Convert.ToChar(9644), 61);
            Console.WriteLine(Convert.ToChar(9556) + "" + Convert.ToChar(9552) + Convert.ToChar(9565) + space);
            Console.WriteLine(Convert.ToChar(9562) + "" + Convert.ToChar(9559) + $"Zookeeper: {_name}, {_age}, {_height}, {_enclosure}");
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();
            }
        }

    }
}
