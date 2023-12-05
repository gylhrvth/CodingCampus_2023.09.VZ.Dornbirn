
using Selina.Week08.OOP.Aufgabe1;

namespace Selina.Week08.OOP.Aufgabe_02
{
    public class House
    {
        private int Doors;
        private int Windows;
        private string Address;
        private List<Person> Persons;

        public int doors
        {
            get => Doors; set => Doors = value;
        }
        public int windows
        {
            get => Windows; set => Windows = value;
        }
        public string address
        {
            get => Address; set => Address = value;
        }

        public House(int doors, int windows, string address)
        {
            this.Doors = doors;
            this.Windows = windows;
            this.Address = address;
            Persons = new List<Person>();
        }

        public virtual void AddPerson(Person person)
        {
            if (!Persons.Contains(person))
            {
                Persons.Add(person);
            }
        }
        public void PrintPerson()
        {
            foreach (Person person in Persons)
            {
                Console.WriteLine(" - " + person.name);
            }
        }
        public override string ToString()
        {
            return $"Doors = {doors}, Windows = {windows}, Address = {address}";
        }
    }
}
