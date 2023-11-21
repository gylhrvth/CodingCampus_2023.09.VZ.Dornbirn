using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06.Person
{
    public class PersonAufgabe
    {

        private int _groesse;
        private int _alter;
        private string _name;
        private int _gewicht;



        public string Name
        {
            get => _name;

             set => _name = value;
    
        }

        public int Groesse
        {
            get => _groesse;
            set => _groesse = value;
        }

        public int Alter
        {
            get => _alter;
            set => _alter = value;
        }

        public int Gewicht
        {
            get => _gewicht;
            set => _gewicht = value;
        }
        public PersonAufgabe(int groesse, int alter, string name, int gewicht)
        {

            _groesse = groesse;
            _alter = alter;
            _name = name;
            _gewicht = gewicht;
            

        }

       

        public override string ToString()
        {
            return string.Format("Grösse: {0}\n Alter: {1}\n Name: {2}\n Gewicht: {3}",_groesse,_alter,_name,_gewicht);
        }
    }
}
