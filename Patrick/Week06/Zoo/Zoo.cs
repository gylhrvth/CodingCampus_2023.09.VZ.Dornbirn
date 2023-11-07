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

        public List<Enclosure> EnclosureList
        {
            get => _EnclosureList;
            set => _EnclosureList = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string FoundingYear
        {
            get => _FoundingYear;
            set => _FoundingYear = value;
        }

        public Zoo(string name, string foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _EnclosureList = new List<Enclosure>();

        }        

        public void PrintEnclosure()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                Console.WriteLine($"│   ├── Gehege: {enclosure._Name} ");
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine($"├── Zoo: {_Name}, {_FoundingYear}");
        }

    }
}
