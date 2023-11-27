using Fabian.Selftest_OP._01_Person;
using static Fabian.Selftest_OP._01_Person.Person;

namespace Fabian.Selftest_OP._02_House
{
    internal class HouseMain
    {
        public static void Start()
        {
            List<Person> persons = CreatePersons();

            House h1 = new(2, 4, "Bahnhofstraße 10");
            h1.AddPerson(persons[0]);
            h1.AddPerson(persons[1]);
            h1.AddPerson(persons[2]);

            House h2 = new(1, 3, "Sebastiangasse 4");
            h2.AddPerson(persons[3]);
            h2.AddPerson(persons[4]);
            h2.AddPerson(persons[5]);

            SortedHouse h3 = new(4, 10, "Kreuzäckerweg 20");
            h3.AddPerson(persons[6]);
            h3.AddPerson(persons[7]);
            h3.AddPerson(persons[8]);
            h3.AddPerson(persons[9]);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);


        }

        public static List<Person> CreatePersons()
        {
            string[] firstNames = { "Charlie", "Alice", "Jack", "Frank", "David", "Henry", "Grace", "Bob", "Emma", "Ivy" };
            int[] ages = { 10, 46, 79, 34, 32, 15, 18, 20, 97, 48 };
            Genders[] genders = { Genders.female, Genders.male, Genders.divers, Genders.male, Genders.female, Genders.male, Genders.divers, Genders.divers, Genders.female, Genders.divers };

            List<Person> persons = new List<Person>();

            for (int i = 0; i < firstNames.Length; i++)
            {
                Person person = new Person(firstNames[i], ages[i], genders[i]);
                persons.Add(person);
            }

            return persons;
        } 
    }
}
