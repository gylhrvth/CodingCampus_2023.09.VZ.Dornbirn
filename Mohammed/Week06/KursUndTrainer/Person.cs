using System;
namespace Mohammed.Week06.KursUndTrainer
{
	public class Person
	{
		private string _Name;
		private int _Age;
		private int _Height;
		private int _Weight;


		public string Name
		{
			get
			{
				return "\"" + _Name + "\"";
			}
			set
			{
				_Name = value;
			}
		}
		public int Height { get => _Height; }

		public Person(string name, int age, int height, int weight)
		{
			_Name = name;
			_Age = age;
			_Height = height;
			_Weight = weight;
		}

		public override string ToString()
		{
			//return string.Format("Perosn : {0}, age: {1}", _Name, _Age);
			return _Name;
			
		}

		public int Age { get => _Age; }//


		public int Weight { get => _Weight; }

		

	}
}

