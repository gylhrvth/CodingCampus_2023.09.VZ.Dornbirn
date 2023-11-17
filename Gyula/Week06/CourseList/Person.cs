using System;
namespace Gyula.Week06.CourseList
{
	public class Person
	{
        private string _Name;
        private int _Age;
		private int _Height;
		private int _Weight;

		public string Name
		{
			get => "\"" + _Name + "\"";
		}

		public int Height
		{
			get => _Height;
		}

		public Person(string name, int age, int height, int weigth)
		{
			_Name = name;
			_Age = age;
			_Height = height;
			_Weight = weigth;
		}

        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}", _Name, _Age);
        }
    }
}

