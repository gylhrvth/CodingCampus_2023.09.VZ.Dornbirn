using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class Enclosure
    {


        private string _name;
        private string _type;
        private bool _isFed;
        private List<Animal> _animalsList;
        private List<Pfleger> _pflegerlist;
        private Pfleger _pfleger;
        int TagesKosten = 0;

        private Dictionary<Futter, int> FoodDictionary = new Dictionary<Futter, int>();

        public Enclosure(string name, string type, Pfleger pfleger,bool IsFed)
        {
            _name = name;
            _type = type;
            _isFed = IsFed;
            _pfleger = pfleger;
            _animalsList = new List<Animal>();
            _pflegerlist = new List<Pfleger>();
        }

        public void AddAnimal(Animal animal)
        {
            _animalsList.Add(animal);
        }

        public void AddPfleger(Pfleger pfleger)
        {
            _pflegerlist.Add(pfleger);
        }

        public int PrintAnimals()
        {
            foreach (Pfleger pfleger in _pflegerlist)
            {
                pfleger.PrintPfleger();
            }


            foreach (Animal animal in _animalsList)
            {

                if (!FoodDictionary.ContainsKey(animal.FoodClass))
                {
                    FoodDictionary.Add(animal.FoodClass, animal.FoodClass.EinHeitPreis);
                }

                Console.WriteLine($"    |-----Name:{animal.Name}..Art: {animal.Art}");

                int kosten = FoodDictionary[animal.FoodClass] * animal.UnitPrice;

                TagesKosten += kosten;

            }

            return TagesKosten;
        }

        public void Feed()
        {
            if (_pflegerlist.Count == 0)
            {
                Console.WriteLine("Es gibt niemand der das gehege füttern kann");
                return;
            }

            Pfleger randomPfleger = _pflegerlist[new Random().Next(_pflegerlist.Count)];

            foreach (Animal animal in _animalsList)
            {
                randomPfleger.FeedAnimal(animal); //wird gefüttert
                //animal.isFeedBy(randomPfleger);
            }
        }

        public void ReportFoodRequest(Dictionary<Futter, int> report)
        {
            foreach (Animal ani in _animalsList)
            {
                ani.FoodRequest(report);
            }
        }


        public bool IsFed
        {
            get => _isFed;
            set => _isFed = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }


        public string Type
        {
            get => _type;
            set => _type = value;
        }

    }
}
