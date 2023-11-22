using System;
namespace Mohammed.Week07.Zoo02
{
	public class Enclosure
	{
		private readonly Random random = new Random();

		private string _Name;
		private string _Climate;
		private List<Animals> _Animallist;
		private List<Enclosure> _Enclosures;
		private bool _IsFaid;

		public string Name
		{
			get => _Name;
		}

		public List<Animals> Animallist
		{
			get => _Animallist;
		}

		public string Climate
		{
			get => _Climate;
			
		}

		public bool IsFaid
		{
			get => _IsFaid;
			set => _IsFaid = value;
		}

		public Enclosure(string name, string climante)
		{
			_Name = name;
			_Climate = climante;
			_Animallist = new List<Animals>();
			_Enclosures = new List<Enclosure>();
			_IsFaid = false;
		}

        public void PrintEnclosure()
        {
            Console.WriteLine($"    ├──{_Name}, {_Climate}");
			Console.WriteLine();
			foreach(Animals animal in _Animallist)
			{
				animal.PrintAnimals();
			}
        }

		public void FillAnimalList(Animals animal)
		{
			if (!_Animallist.Contains(animal))
			{
				_Animallist.Add(animal);
			}
		}



    }
}

