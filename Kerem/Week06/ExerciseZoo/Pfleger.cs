using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Pfleger
    {
        private string _name;
        private List<Enclosure> _enclosure = new();
        private List<Animals> _favouriteanimal;

        public List<Enclosure> Enclosure
        {
            get => _enclosure;
            set => _enclosure = value;
        } 
        public List<Animals> FavouriteAnimal
        {
            get => _favouriteanimal;
            set => _favouriteanimal = value;
        }


        public Pfleger(string name, List<Enclosure> enclosure ) 
        {
            _name = name;
            _enclosure = enclosure;
            _favouriteanimal = FavouriteAnimal; 
        }
        public void PrintZooPfleger()
        {
            Console.WriteLine($"│\t ├── ZooPfleger name: {_name}");

            foreach(var enclosure in _enclosure )
            {
                enclosure.PrintZoo();
            }

        }
    }
}
