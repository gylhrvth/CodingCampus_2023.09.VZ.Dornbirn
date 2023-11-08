using System;
using David.Week06.Person2;
namespace David.Week06.Person2Main
{
	public class Person2VOOP
	{
		public static void Start()
		{
            Person2V pt = new Person2V(new List<Person>()
			{
			new Person("David", 35, 42, 68),
			new Person("Mohammed", 22, 45, 80)

			});

			Console.WriteLine(pt.GetMaxHeight().Name);
        }


	}
	
}

