using System;
namespace Mohammed.Week07.Vererbung
{
	public class Lung
	{
		private string _Name;
		private bool _Location;
		private string _Function;


       
        public Lung(string name, bool location, string function)
		{
			
			_Name = name;
			_Location = location;
			_Function = function;
		}

		public virtual void PrintMe()
		{
            
            //Console.WriteLine(_Name);  // da bringt nicht viel um die name zu drücken weil sowieso in Console siehe unten geschrieben!!!!
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{_Name}allow oxygen in the air to be taken into the body, while also letting the body get rid of carbon dioxide in the air breathed out.");
        }

	}
}

