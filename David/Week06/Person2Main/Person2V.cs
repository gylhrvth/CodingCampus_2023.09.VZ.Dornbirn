using System;
using System.Xml.Linq;
using David.Week06.Person2;
namespace David.Week06.Person2Main
{
	public class Person2V
	{
		private List<Person> _Person;

		public Person2V(List<Person> people)
		{
			_Person = new List<Person>();
			_Person.AddRange(people);
            
        }

		public Person GetMaxHeight()
		{
			Person result = null;

			foreach (Person p in _Person)
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

