using System;
namespace David.Week07.ZooNew
{
	public class Enclosure
	{
        private readonly Random random = new Random();

        private string _Name;
        private string _Climate;
        private List<Animals> _AnimalsList;

        public Enclosure(string name, string climate)
		{
			_Name = name;
			_Climate = climate;
            _AnimalsList = new List<Animals>();
		}

        public void PrintEnclosure()
        {
            Console.WriteLine();
            Console.WriteLine($"  --->{_Name}, {_Climate}");
            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintAnimals();
            }
        }

        public void FillAnimalList(Animals animal)
        {
            if (!_AnimalsList.Contains(animal))
            {
                _AnimalsList.Add(animal);
            }
        } 
    }
}

