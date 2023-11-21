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
        List<Enclosure> _Enclosure;

        public string Name
        {
            get => _Name;
        }
        public Caretaker(string name, Enclosure enclosure)
        {
            _Name = name;
            _Enclosure = new List<Enclosure>();
        }
    }
}
