using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class EnclosureClass
    {
  

        private string _name;
        private string _type;
        private List<AnimalClass> _animalsList = new List<AnimalClass>();

        int TagesKosten = 0;

        private Dictionary<Futter, int> FoodDictionary = new Dictionary<Futter, int>();
  
        public EnclosureClass(string name, string type)
        {
            _name = name;
            _type = type;
            _animalsList = new List<AnimalClass>();
        }

        public void AddAnimal(AnimalClass animal)
        {
            _animalsList.Add(animal);
        }

        public int PrintAnimals()
        {

            foreach (AnimalClass animal in _animalsList)
            {

                if (!FoodDictionary.ContainsKey(animal.FoodClass))
                {
                    FoodDictionary.Add(animal.FoodClass, animal.FoodClass.EinHeitPreis);
                }

                Console.WriteLine($"    |-----Name:{animal.Name}..Art: {animal.Art}");

                    Console.WriteLine($"        |---Name:{animal.Name} hat hunger und hat: {animal.FoodClass.Name} {animal.Unit} gegessen |");

                    int kosten = FoodDictionary[animal.FoodClass] * animal.Unit;

                    Console.WriteLine(animal.Name + " verbrauchte " + kosten + " weg vom Zoo");

                    TagesKosten += kosten;


               
            }

            return TagesKosten;
        }

        public void ReportFoodRequest(Dictionary<Futter, int> report)
        {
            foreach(AnimalClass ani in _animalsList)
            {
                ani.FoodRequest(report);
            }
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
