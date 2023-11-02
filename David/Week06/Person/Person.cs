using System;
namespace David.Week06.PersonExample
{
	public class Person
	{
		private string _Name;
		private string _Alter;
		private string _Gewicht;

		public string Gewicht
		{
			get => _Gewicht;
			set
			{
				Console.WriteLine("The weight did change to: " + value);
				_Gewicht = value;
			}
		}

        public int Groesse;
		public int Schuhgroesse;
		private int _SchuhgroessePrivate;

        public Person(string Name, string Alter, int size)
		{
			_Name = Name;
			_Alter = Alter;
			Groesse = 180;
			Schuhgroesse = 42;
			_SchuhgroessePrivate = size;
			
		}

		public override string ToString()
		{
			return string.Format("Name: {0}\nAlter: {1}\nGröße: {2}\nGewicht: {3}\nSchuhgröße: {4}\nPrivateSchuhGröße: {5}",
				_Name,
				_Alter,
				Groesse,
				_Gewicht,
				Schuhgroesse,
				_SchuhgroessePrivate);
		}

		//public override string ToString()
		//{
		//	return string.Format("Name: {0}\nGewicht: {1}",
		//		_Name,
		//		_Gewicht);
		//}
    }
}

