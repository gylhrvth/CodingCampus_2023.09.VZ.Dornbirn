using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Selina.Week06.Zoo
{
    public class Gehege
    {
        public string _AnimalEnclosures;

        public string AnimalEnclosures
        {
            get => _AnimalEnclosures;
            set => _AnimalEnclosures = value;
        }
        public Gehege(string name)
        {
            this._AnimalEnclosures = name;
        }
    }
}
