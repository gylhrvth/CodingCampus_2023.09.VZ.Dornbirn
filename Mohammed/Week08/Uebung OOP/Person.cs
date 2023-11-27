using System;
namespace Mohammed.Week08.UebungOOP
{
	public class Person
	{
		private string _Name;
		private int _Age;
		private string _Gender;
		

		private string Name
		{
	
            get => _Name;
        }

		private int Age
		{
			get => _Age;
		}

		private string Gender
		{
			get => _Gender;
			
			
		}

		public Person(string Name, int Age, string Gender)
		{
           
            _Name = Name;
			_Age = Age;
			_Gender = Gender;
		}

		public string ToString()
        {
			
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}", _Name, _Age, _Gender);
		
        }

    }
}

