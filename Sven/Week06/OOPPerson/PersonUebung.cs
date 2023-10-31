using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPPerson
{
    internal class Person
    {

        private float _Größe;
        private int _Alter;
        private string _Name;
        private float _Gewicht;

        public float Größe
        {
            get => _Größe;

        }
        public int Alter
        {
            get => _Alter;

        }
        public string Name
        {
            get => _Name;

        }
        public float Gewicht
        {
            get => _Gewicht;

        }
        public Person(float Größe, int Alter, string Name, float Gewicht)
        {
            _Größe = Größe;
            _Alter = Alter;
            _Name = Name;
            _Gewicht = Gewicht;
        }
        public override string ToString()
        {
            return string.Format("Größe: {0} cm\nAlter: {1}\nName: {2}\nGewicht: {3} kg",
                _Größe,
                _Alter,
                _Name,
                _Gewicht);
        }
    }
}
