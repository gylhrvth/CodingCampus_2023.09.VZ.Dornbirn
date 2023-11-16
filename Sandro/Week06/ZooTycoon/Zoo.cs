using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week06.ZooTycoon
{ 
    internal class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundingYear;
        private int _Capacity;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, string locality, int foundingYear, int capacity)
        {
            _Name = name;
            _Locality = locality;
            _FoundingYear = foundingYear;
            _Capacity = capacity;
            _EnclosureList = new List<Enclosure>();
        }

        public void AddEnclosure(Enclosure enclosure) {

            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZoo() {

            Console.WriteLine($"Zoo: {_Name}, Year: {_FoundingYear}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }



    }
}
