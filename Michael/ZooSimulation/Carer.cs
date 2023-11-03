using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michael.Week06;

namespace Michael.ZooSimulation
{
    internal class Carer
    {
        private string _Name;
        public string Name {  get => _Name; }


        private string _FavoriteAnimal;
        public string FavoriteAnimal {  get => FavoriteAnimal; }


        private List<Enclosure> _Enclosures = new List<Enclosure>();
        public List<Enclosure> Enclosures { get => _Enclosures; }


        public Carer(string name, List<Enclosure> enclosures = null)
        {
            _Name = name;

            if (enclosures != null)
            {
                Enclosures.AddRange(enclosures);
            }
        }


        public bool Feeds(Animal animal, Food food)
        {
            return animal.Feed(food);
        }


        public bool FeedNext(Dictionary<Carer, int> checkedEnclosures, string prefix)
        {
            while(checkedEnclosures[this] < _Enclosures.Count)
            {
                Enclosure currentEnclosure = _Enclosures[checkedEnclosures[this]];
                Console.WriteLine(prefix + $"Carer {_Name} is going to the {currentEnclosure} enclosure.");

                if (this.checksEnclosureIfFed(currentEnclosure))
                {
                    Console.WriteLine(prefix + $"Nothing needed feeding.");
                    checkedEnclosures[this]++;
                }
                else
                {
                    Console.WriteLine(prefix + $"It was not yet fed.");
                    checkedEnclosures[this]++;
                    return currentEnclosure.GetsFed(this, prefix + "    ");

                }
            }
            return false;
        }


        public bool checksEnclosureIfFed(Enclosure enclosure)
        {
            foreach (Animal animal in enclosure.Animals)
            {
                if (!animal.Fed) return false;
            }
            return true;
        }


        public void AddEnclosures(Enclosure enc)
        {
            _Enclosures.Add(enc);
        }


        public void AddEnclosures(List<Enclosure> enc)
        {
            _Enclosures.AddRange(enc);
        }

    }
}
