using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sven.Week07
{
    internal class Zoo
    {

        private string _Name;
        private string _Location;
        private int _FoundingYear;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, string location, int foundingyear)
        {

            _Name = name;
            _Location = location;
            _FoundingYear = foundingyear;
            _EnclosureList = new List<Enclosure>();

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

            Console.WriteLine($"├── Zoo: {_Name}, Year: {_FoundingYear}, Location, {_Location}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }
        }
    }
}
