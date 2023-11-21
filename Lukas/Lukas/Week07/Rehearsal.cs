using System;
namespace Lukas.Week07
{
	public class Rehearsal
	{
		public static void Start()
		{
			Person p = new Person("Musterfrau", "Max");

			Person p1 = new Person("Mikesson", "Mike", new DateTime(1900, 01, 01));

			Person p2 = new Person("Parker", "Peter", new DateTime(1969, 04, 20), "Divers");

			Person.Shout();


			p.Shout2();
			p1.Shout2();
			p2.Shout2();

			Console.WriteLine("Persons created: " + Person.GetPersonCreationCounter());
		}
	}
}

