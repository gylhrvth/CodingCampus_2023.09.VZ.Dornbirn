using System;
namespace Mohammed.Week08.UebungOOP
{
	public class Persons
	{
		private string _Name;
		private int _Age;
		private string _Gender;
		

		private string Name
		{
	
            get => _Name;
			set { Name = value; }
        }

		private int Age
		{
			get => _Age;
			set { Age = value; }
		}

		private string Gender
		{
			get => _Gender;
			set { Gender = value; }
			
		}

		public Persons(string Name, int Age, string Gender)
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

