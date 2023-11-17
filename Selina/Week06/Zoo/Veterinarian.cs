using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Zoo
{
    public class Veterinarian
    {
        private string _Name;
        private int _Age;

        public Veterinarian(string name, int age)
        {
            _Name = name;
            _Age = age;
        }
        public override string ToString()
        {
            return $"{_Name}";
        }
    }
}
