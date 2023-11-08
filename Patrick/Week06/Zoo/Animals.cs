using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.Zoo
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;

        public string Name
        {
            get => _Name; 
            set => _Name = value;
        }
        public string Genus
        {
            get => _Genus;
            set => _Genus = value;
        }

        public int Age
        {
            get => _Age;
            set => _Age = value;
        }

        public Animals(string name, string genus, int age)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;

        }

    }
}
