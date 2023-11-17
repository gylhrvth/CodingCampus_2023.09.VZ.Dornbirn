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
        private Random rand = new Random();

        private string _name;
        private List<Enclosure> _enclosure = new();
        private Animals _favouriteanimal;

        public List<Enclosure> Enclosure
        {
            get => _enclosure;
            set => _enclosure = value;
        }
        public Animals FavouriteAnimal
        {
            get => _favouriteanimal;
            set => _favouriteanimal = value;
        }


        public Pfleger(string name, List<Enclosure> enclosure)
        {
            _name = name;
            _enclosure = enclosure;
            _favouriteanimal = FavouriteAnimal;
        }
        public void PrintZooPfleger()
        {
            Console.Write($"│   ├──ZooPfleger name: {_name} ist zuständig für:");

            foreach (var enclosure in _enclosure)
            {
                Console.Write($" {enclosure.Name}");
            }
            Console.WriteLine();
        }

        //public void Feed()
        //{

        //    foreach (var enclosure in _enclosure)
        //    {
        //        if (!enclosure.IsFed)
        //        {
        //            Console.WriteLine($"{_name} is feeding the {enclosure.Name} enclosure");
        //            enclosure.IsFed = true;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{_name} tried to feed the {enclosure.Name} enclosure but it's already fed");
        //        }
        //        FavouriteAnimal ??= enclosure.Animals[rand.Next(enclosure.Animals.Count)];
        //    }
        //    Console.WriteLine($"{_name} is spectating his favourite animal: {FavouriteAnimal}");


        //}

    }
}
