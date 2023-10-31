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

            List<Person2> persons = new List<Person2>();
            persons.Add(new Person2("Fabian", 17, 187, 75));
            persons.Add(new Person2("Hassan", 19, 177, 60));
            persons.Add(new Person2("Lukas", 22, 190, 50));
            persons.Add(new Person2("Gyula", 40, 200, 100));
            persons.Add(new Person2("Sandro", 25, 163, 53));

            Statistic statistics = GetStatistics.CalcStatistics(persons);

            Console.WriteLine(statistics);
        }

        public static void SortPersons(List<Person2> persons, Data data)
        {
            switch (data)
            {
                case Data.AGE:
                    
                    break;
            }
        }
        
    }
}
