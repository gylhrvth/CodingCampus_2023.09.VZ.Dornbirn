


namespace Kerem.Week06.ExercisePerson2
{
    internal class Person2Example
    {
        public static void Start()
        {
            List<Person2> personList = new List<Person2>() 
            {
                new Person2("Kerem", 23, 180, 86),
                new Person2("Ali", 50, 160, 71),
                new Person2("Hüseyin", 12, 170, 30),
                new Person2("Sven", 27, 165, 120)
            };

            Person2.PrintMinMaxAvg(personList);
            Person2.SortAge(personList);
            Console.WriteLine("Age [{0}]", string.Join(", ", personList));
            Person2.SortWeight(personList);
            Console.WriteLine("Weight [{0}]", string.Join(", ", personList));
            Person2.SortHeight(personList);
            Console.WriteLine("Height[{0}]", string.Join(", ", personList));
            Person2.SortName(personList);
            Console.WriteLine("Name [{0}]", string.Join(", ", personList));

            Person2.PrintAvgweight(personList);
            Person2.PrintAvgage(personList);
            Person2.PrintAvgheight(personList);



        }
    }
}
