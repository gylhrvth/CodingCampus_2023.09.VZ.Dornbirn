using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06.Person
{
    public class Person
    {
        private float _Height;
        private float _Age;
        private string _Name;
        private float _Weight;

        public Person(float Height, float Age, string Name, float Weight)
        {
            _Height = Height;
            _Age = Age;
            _Name = Name;
            _Weight = Weight;
        }

        public override string ToString()
        {
            return string.Format("Größe: {0} cm\nAlter: {1} Jahre\nName: {2}\nGewicht: {3} kg", _Height, _Age, _Name, _Weight);
        }
    }
}
