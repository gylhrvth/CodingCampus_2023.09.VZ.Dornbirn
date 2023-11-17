using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week06.Person1
{
    internal class Person
    {
        private int _Größe;
        private int _Alter;
        private string _Name;
        private double _Gewicht;

        public int Größe
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
        public double Gewicht
        {
            get => _Gewicht;
        }
        public Person(int Größe, int Alter, string Name, double Gewicht) 
        {
            _Größe = Größe;
            _Alter = Alter;
            _Name = Name;
            _Gewicht = Gewicht;
        }
        public override string ToString() 
        {
            return string.Format("Größe: {0} cm\nAlter: {1} Jahre\nName: {2}\nGewicht: {3} kg", _Größe, _Alter, _Name, _Gewicht);
        }
    }
}
