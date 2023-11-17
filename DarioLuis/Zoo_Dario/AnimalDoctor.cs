using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Zoo_Dario
{
    public class AnimalDoctor
    {
        private string _Name;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public AnimalDoctor(string name)
        {
            _Name = name;
        }
    }
}
