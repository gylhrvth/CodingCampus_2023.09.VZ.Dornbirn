using System;
using Gyula.Week06.CourseList;


namespace Gyula.Week06
{
	public class PersonTwoOOP
	{
		private List<Person> _Persons;

        public PersonTwoOOP(List<Person> list)
		{
			_Persons = new List<Person>();
			_Persons.AddRange(list);
		}

		public Person GetMaxHeight()
		{
			Person result = null;
			foreach (Person p in _Persons)
			{
				if (result == null || result.Height < p.Height)
				{
					result = p;
				}
			}
			return result;
		}
	}
}

