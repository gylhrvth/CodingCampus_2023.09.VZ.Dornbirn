using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    internal class Gehege
    {
        private string _Name;
        private string _Descritpion;
        private List<Animals> _AnimalsList;

        public Gehege(string name, string descritpion)
        {
            _Descritpion = descritpion;
            _Name = name;
            _AnimalsList = new List<Animals>();
        }

        public void PrintZoo()
        {
            Console.WriteLine("Zoo: {0}\nYear: {1}", _Name, _Descritpion);
        }

        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }

        }

        //public void PrintZoo()
        //{
        //    Console.WriteLine(" ---> Gehege: {0} {1}", _Name, _FoundingYear);

        //    foreach (Gehege gehege in _Gehege)
        //    {
        //        gehege.PrintZoo();
        //    }
        //}
    }
}
