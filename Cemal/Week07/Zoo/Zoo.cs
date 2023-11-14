using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosures> _Enclosures;

        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _Enclosures = new List<Enclosures>();
        }

        public void addEnclosure(Enclosures enc)
        {
            _Enclosures.Add(enc);
        }

        public override string ToString()
        {
            return "Zoo: " + _Name + ", founded: " + _FoundingYear;
        }


        public void PrintStructure()
        {
            Console.WriteLine("├── Zoo: {0}, founded: {1}", _Name, _FoundingYear);
            foreach (Enclosures enc in _Enclosures)
            {
                enc.PrintStructure("|   ");
            }
        }
    }
}
