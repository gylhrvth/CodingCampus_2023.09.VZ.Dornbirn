using Riccardo.Week07.ZooDoppelmayer;
using System;

namespace Riccardo.Week07.ZooDoopelmayer
{
    public class Zoo
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

        public void AddEnclosure(Enclosure enclosure)
        {

            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZoo()
        {

            Console.WriteLine($"Zoo: {_Name}, Year: {_FoundingYear}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
               // enclosure.PrintZoo();

            }


        }

        /*
        private string _Name;
        private int _Established;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, int established)
        {
            _Name = name;
            _Established = established;
            _EnclosureList = new List<Enclosure>();
        }

        public void PrintStructure()
        {
            Console.WriteLine("├── Zoo: {0}, gegründet {1}",
                _Name,
                _Established);
            foreach (Enclosure enc in _EnclosureList)
            {
                enc.PrintStructure();
            }
        }
        
        public Enclosure SearchAndCreate(string name)
        {
            foreach (Enclosure enc in _EnclosureList)
            {
                if (enc.Name == name)
                {
                    return enc;
                }
            }
            Enclosure newenc = new Enclosure(name);
            _EnclosureList.Add(newenc);
            return newenc;
        }
        */

    }

}

