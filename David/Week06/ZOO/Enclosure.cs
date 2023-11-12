using System;
namespace David.Week06.ZOO
{
	public class Enclosure
	{
		private string _Description;
		private string _Climate;
		private string _Name;
        private List<Animals> _Animals;


        public Enclosure(string name, string climate, string description)
		{
			_Description = description;
			_Climate = climate;
			_Name = name;
            _Animals = new List<Animals>();
        }

        public void AddAnimals(Animals animals)
        {
            if (!_Animals.Contains(animals))
            {
                _Animals.Add(animals);
            }
        }

        public void PrintEnclosure()
		{
            if (_Animals != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"   ||--> Name: {_Name}, Climate: {_Climate}, Description: {_Description}");

                foreach (Animals ani in _Animals)
                {
                    ani.PrintAnimals();
                }
            }
        }
	}
}

