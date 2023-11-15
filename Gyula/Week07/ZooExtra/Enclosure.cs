using System;
namespace Gyula.Week07.ZooExtra
{
	public class Enclosure
	{
		private string _Name;
		public string Name { get => _Name; }

		public Enclosure(string name)
		{
			_Name = name;
		}

        public void PrintStructure()
        {
            Console.WriteLine("│   ├── Gehege: {0}",
                _Name);
        }
    }
}

