using Selina.Week08.OOP.Aufgabe1;

namespace Selina.Week08.OOP.Aufgabe_02
{
    public class SortedHouse : House
    {
        private List<Person> Persons;
        public SortedHouse(int doors, int windows, string address) : base(doors, windows, address)
        {
            Persons = new List<Person>();
        }

        public override void AddPerson(Person person)
        {
            if (!Persons.Contains(person))
            {
                Persons.Add(person);
            }

            Persons.Sort();
        }

    }
}
