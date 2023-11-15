using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fabienne.Week07.Zoo
{
    public class Enclosure
    {
        private string _Name;
        private string _Climate;
        private string _Description;
        private List<Animal> _Animals;

        //Dictionary<int, string> dict = new Dictionary<int, string>();
        /*
        public void Dict()
        {
            dict.Add(10, "Mushrooms");
            dict.Add(40, "Whiskey");
            dict.Add(28, "Salmon");
            dict.Add(7, "Cigarette");
            dict.Add(15, "Cake");
            dict.Add(20, "Wine");
            dict.Add(9, "Chicken");
            dict.Add(10000, "Child");
            dict.Add(20, "Spaghetti");
            dict.Add(10, "Miso-Soup");
            dict.Add(420, "Nuke");
            dict.Add(60, "Dog");
            dict.Add(100, "Whaleflesh");
            dict.Add(10, "Noodle-Soup");
            dict.Add(13, "Rice with Vegetables");
            dict.Add(3, "Skittles");
            dict.Add(5, "Hotpockets");
            dict.Add(4, "Whopper");
            dict.Add(2, "Coca-Cola");
            dict.Add(3, "Can of Beans");
            dict.Add(4, "Wilburger");
            dict.Add(4, "Tubburger");
            dict.Add(3, "Quesadilla");
            dict.Add(5, "Cheese");
            dict.Add(3, "Can of frosting");
            dict.Add(7, "Sushi");
        }
        */
        public Enclosure(string name, string climate, string desctription)
        {
            _Name = name;
            _Climate = climate;
            _Description = desctription;
            _Animals = new List<Animal>();
        }
        public string Name
        {
            get => _Name;
        }
        public void AddAnimals(Animal animals)
        {
            if (!_Animals.Contains(animals))
            {
                _Animals.Add(animals);
            }
        }
        public void PrintAnimals()
        {
            foreach (Animal animal in _Animals)
            {
                animal.PrintAnimals();
            }
        }

        public void ReportFoodRequest(Dictionary<Food, double> report)
        {
            foreach (Animal ani in _Animals)
            {
                ani.ReportFoodRequest(report);
            }
        }
    }
}
