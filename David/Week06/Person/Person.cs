using System;
namespace David.Week06.PersonExample
{
	public class Person
	{
		private string _Name;
		public string Name
		{
			get => _Name;
		}
		private int _Alter;
		private int _Gewicht;

		public int Gewicht
		{
			get => _Gewicht;
			set
			{
				Console.WriteLine("The weight did change to: " + value);
				_Gewicht = value;
			}
		}

        private int _Groesse;
		public int Schuhgroesse;
		private int _SchuhgroessePrivate;

        public Person(string Name, int Alter, int Schuhsize)
		{
			_Name = Name;
			_Alter = Alter;
			_Groesse = 180;
			_Gewicht = 70;
			Schuhgroesse = 42;
			_SchuhgroessePrivate = Schuhsize;
			
		}

		public override string ToString()
		{
			return string.Format("Name: {0}\nAlter: {1}\nGröße: {2}\nGewicht: {3}\nSchuhgröße: {4}\nPrivateSchuhGröße: {5}",
				_Name,
				_Alter,
				_Groesse,
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

