


namespace Kerem.Week06.ExercisePerson2
{
    internal class Person2Example
    {
        public static void Start()
        {
            List<Person2> personList = new List<Person2>() {
                new Person2("Kerem", 23, 180, 86),
                new Person2("Ali", 50, 160, 71),
                new Person2("Hüseyin", 12, 170, 30),
                new Person2("Hüsrettin", 27, 165, 120)
            };

            Person2.PrintMinMaxAvg(personList);

        }
    }
}
