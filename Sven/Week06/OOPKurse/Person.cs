using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPKurse
{
    public class Person
    {
        private float _Größe;
        private int _Alter;
        private string _Name;
        private float _Gewicht;

        public Person(string Name, int Alter, float Größe, float Gewicht)
        {
            _Größe = Größe;
            _Alter = Alter;
            _Name = Name;
            _Gewicht = Gewicht;
        }
        public override string ToString()
        {
            return string.Format("{0}\nAlter: {1}\nGröße: {2} cm\nGewicht: {3} kg",
                _Name,
                _Alter,
                _Größe,             
                _Gewicht);
        }
    }
}
