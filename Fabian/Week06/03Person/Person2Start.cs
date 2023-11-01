using System.ComponentModel.DataAnnotations;

namespace Fabian.Week06._03Person
{
    public class Person2Start
    {
        public enum Data
        {
            AGE, HEIGHT, WEIGHT, NAME
        }
        public static void Start()
        {

            List<Person2> persons = new List<Person2>
            {
                new Person2("Fabian", 17, 187, 75),
                new Person2("Hassan", 19, 177, 60),
                new Person2("Lukas", 22, 190, 50),
                new Person2("Gyula", 40, 200, 100),
                new Person2("Sandro", 25, 163, 53)
            };

            Statistic statistics = GetStatistics.CalcStatistics(persons);
            Console.WriteLine("statistics: ");
            Console.WriteLine(statistics);
            Console.WriteLine("\n");

            persons = SortPersons(persons, Data.AGE);
            Console.WriteLine("Sorted persons:");
            foreach (Person2 person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");
            }
        }

        public static List<Person2> SortPersons(List<Person2> persons, Data data)
        {
            // p1 and p2 are variables and can be changed
            switch (data)
            {
                case Data.AGE:
                    persons.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
                    return persons;                   
                case Data.HEIGHT:
                    persons.Sort((p1, p2) => p1.Height.CompareTo(p2.Height));
                    return persons;
                case Data.WEIGHT:
                    persons.Sort((p1, p2) => p1.Weight.CompareTo(p2.Weight));
                    return persons;
                case Data.NAME:
                    persons.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal)); // CompareTo cant be used on strings
                    return persons;
                default:
                    return persons;
            }

        }
    }
}
