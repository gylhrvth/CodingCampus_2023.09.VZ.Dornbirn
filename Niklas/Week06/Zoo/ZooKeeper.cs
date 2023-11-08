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
        private List <enclosure> _EnclosureList;

        public ZooKeeper(string name, int age, int height, string enclosure)
        {
            _name = name;
            _age = age;
            _height = height;
            _enclosure = enclosure;
            _EnclosureList = new List <enclosure>();
        }
        public void AddEnclosure(enclosure enclosure)
        {
            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZoo()
        {
            Console.WriteLine(Convert.ToChar(9556) + "" + Convert.ToChar(9565));
            Console.WriteLine(Convert.ToChar(9562) + "" + Convert.ToChar(9559) + $"Zookeeper: {_name}, {_age}, {_height}, {_enclosure}");
            foreach (enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();
            }
        }
    }
}
