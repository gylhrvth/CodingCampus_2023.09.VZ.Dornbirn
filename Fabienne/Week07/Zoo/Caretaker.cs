using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class Caretaker
    {
        private string _Name;
        private string _Gender;

        List<Enclosure> EnclosureList;
        
        public Caretaker(string name, Enclosure enclosures)
        {
            _Name = name;
           // _Enclosure = enclosures; 
        }
    }
}
