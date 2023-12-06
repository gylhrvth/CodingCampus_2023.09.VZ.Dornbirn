
using Selina.Week08.OOP.Aufgabe1;

namespace Selina.Week08.OOP.Aufgabe_02
{
    public class MainClass
    {
        public static void Start()
        {
            House familyHouse = new House(20, 30, "Musterstraße 44 Hohenems 6845");
            House smallHouse = new House(10, 15, "Musterstraße 15 Dornbirn 6850");
            House bigHouse = new House(60, 100, "Musterstraße 25 Frastanz 6820");

            Person selina = new Person("Selina", 18, Gender.Female);
            Person sandra = new Person("Sandra", 46, Gender.Female);
            Person michael = new Person("Michael", 49, Gender.Male);
            Person manuel = new Person("Manuel", 14, Gender.Female);

            Person magnus = new Person("Magnus", 1, Gender.Male);
            Person janine = new Person("Janine", 27, Gender.Female);
            Person markus = new Person("Markus", 30, Gender.Male);

            Person opa = new Person("Opa", 80, Gender.Male);
            Person oma = new Person("Oma", 74, Gender.Female);

            familyHouse.AddPerson(selina);
            familyHouse.AddPerson(sandra);
            familyHouse.AddPerson(michael);
            familyHouse.AddPerson(manuel);

            smallHouse.AddPerson(magnus);
            smallHouse.AddPerson(janine);
            smallHouse.AddPerson(markus);

            bigHouse.AddPerson(opa);
            bigHouse.AddPerson(oma);

            Console.WriteLine("\nFamily House: ");
            familyHouse.PrintPerson();
            Console.WriteLine("\nSmall House: ");
            smallHouse.PrintPerson();
            Console.WriteLine("\nBig House: ");
            bigHouse.PrintPerson();   
        }
    }
}
