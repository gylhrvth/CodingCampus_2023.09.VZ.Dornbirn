using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Pfleger
    {

        

        private string _Name;
        private List<Enclosure> _Enclosures = new();
        private Animals _FavouriteAnimal;



        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }
        public Animals FavouriteAnimal
        {
            get => _FavouriteAnimal;
            set => _FavouriteAnimal = value;
        }


        public Pfleger(string name, List<Enclosure> enclosures)
        {
            _Name = name;
            _Enclosures = enclosures;
            
            
        }

        public void PrintPfleger()
        {
            Console.WriteLine("│\t├──Pfleger:: {0}", _Name);
            foreach (var enclosure in _Enclosures)
            {
                enclosure.PrintEnclosure();
            }
        }
       

        public override string ToString()
        {
            return "Name: " + _Name;
        }

        public void PrintFoodSimulation()
        {
            foreach (Enclosure enclosure in Enclosures)
            {
                foreach (Animals animal in enclosure.Animals)
                {
                    Console.WriteLine($"{_Name} feeds the animal {animal.Genus} with the name {animal.Name}, in enclosure {enclosure.Description}, with the {animal.Food} ");
                }
            }

        }

    }


}
