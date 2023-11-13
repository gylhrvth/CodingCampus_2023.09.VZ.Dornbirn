using System;
using Gyula.Week06.CourseList;

namespace Gyula.Week06
{
	public class PersonTwoMain
	{
		public static void Start()
		{
			PersonTwoOOP pt = new PersonTwoOOP(new List<Person>()
			{
				new Person("Gyula", 44, 172, 85),
				new Person("Lukas", 38, 175, 82),
				new Person("Sandro", 28, 174, 90)
			});


			Console.WriteLine(pt.GetMaxHeight().Name);
		}
	}
}

