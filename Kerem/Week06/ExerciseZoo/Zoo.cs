using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Zoo
    {
        private string _Name;
        private int _Established;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, int established)
        {
            _Name = name;
            _Established = established;
            _EnclosureList = new List<Enclosure>();
        }
        public void addEnclosure(Enclosure enc)
        {
            _EnclosureList.Add(enc);
        }
        public void PrintZoo()
        {
            Console.WriteLine($"├── Zoo: {_Name}, Established {_Established}");

            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();
            }
        }
    }
}
