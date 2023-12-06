using System;
namespace Mohammed.Week08.UebungOOP
{
	public class PersonMain
	{
		public static void Start()
		{
			Persons person = new Persons("Sandro", 30, "male");
			Persons person2 = new Persons("David", 35, "divers");
			Persons person3 = new Persons("Patrick", 30, "male");
			Persons person4 = new Persons("Dimitri", 33, "male");
			Persons person5 = new Persons("Harald", 63, "male");
			Persons person6 = new Persons("Hanna", 29, "female");
			Persons person7 = new Persons("Lisa", 15, "female");
			Persons person8 = new Persons("Paul", 10, "male");
			Persons person9 = new Persons("yousuf", 93, "male");
			Persons person10 = new Persons("Anna", 32, "female");

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


            //Haus

           // House house1 = new House(4, 4, "karlstraße12", "Sandro", 30, "male");
           // Console.WriteLine(house1.ToString());



           //house1.AddPerson(new Persons("Sandro", 34, "male"));
           //house1.AddPerson(new Persons("David", 34, "devers"));
           //house1.AddPerson(new Persons("Patrick", 28, "male"));
           //house1.AddPerson(new Persons("Dimitri", 33, "male"));

           // Console.WriteLine(house1);
            

        }
	}
}

