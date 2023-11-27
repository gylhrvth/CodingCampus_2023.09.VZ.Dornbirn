using static Fabian.Selftest_OP._01_Person.Person;
namespace Fabian.Selftest_OP._01_Person
{
    internal class PersonMain
    {
        public static void Start()
        {
            List<Person> persons = CreatePersons();

            foreach(Person person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static List<Person> CreatePersons()
        {
            string[] firstNames = { "Charlie", "Alice", "Jack",  "Emma", "Bob", "Frank", "David", "Grace", "Henry", "Ivy" };
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
