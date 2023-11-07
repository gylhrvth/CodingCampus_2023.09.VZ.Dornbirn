using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Tier
    {
        private string _Name;
        private string _Species;

        public Tier(string Name, string Species)
        {
            _Name = Name;
            _Species = Species;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Species
        {
            get { return _Species; }
            set { _Species = value; }
        }

        public void PrintTier()
        {
            Console.WriteLine("│\t\t├── {0}, {1}", _Name, _Species);
        }
    }
}
