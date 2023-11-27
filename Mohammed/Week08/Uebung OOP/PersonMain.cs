using System;
namespace Mohammed.Week08.UebungOOP
{
	public class PersonMain
	{
		public static void Start()
		{
			Person person = new Person("Sandro", 30, "male");
			Person person2 = new Person("David", 35, "divers");
			Person person3 = new Person("Patrick", 30, "male");
			Person person4 = new Person("Dimitri", 33, "male");
			Person person5 = new Person("Harald", 63, "male");
			Person person6 = new Person("Hanna", 29, "female");
			Person person7 = new Person("Lisa", 15, "female");
			Person person8 = new Person("Paul", 10, "male");
			Person person9 = new Person("yousuf", 93, "male");
			Person person10 = new Person("Anna", 32, "female");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(person.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(person2.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(person3.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(person4.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(person5.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(person6.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(person7.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(person8.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(person9.ToString());
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(person10.ToString());
			
			
            
		}
	}
}

