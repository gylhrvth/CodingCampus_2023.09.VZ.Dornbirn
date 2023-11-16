using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Pfleger
    {
        private string _Name;
        
        private List <Enclosure> _EnclosureList;

        public Pfleger(string name, Enclosure enclosure)

        {
            _Name = name;
           
            _EnclosureList = new List<Enclosure>();
           
        }



        public override string ToString()
        {
            return $"{_Name}";
        }
    }

}
