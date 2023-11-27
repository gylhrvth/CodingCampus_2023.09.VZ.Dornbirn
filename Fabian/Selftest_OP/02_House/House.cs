using Fabian.Selftest_OP._01_Person;
namespace Fabian.Selftest_OP._02_House
{
    internal class House
    {
        protected int Doors {  get; set; }
        protected int Windows {  get; set; }
        protected string Adress {  get; set; }
        protected List<Person> Persons {  get; set; }

        public House(int doors, int windows, string adress)
        {
            Doors = doors;
            Windows = windows;
            Adress = adress;
            Persons = new List<Person>();
        }

        public virtual void AddPerson(Person person)
        {
            Persons.Add(person);
        }

        public override string ToString()
        {
            string personList = string.Join(", ", Persons.Select(p => p.Name));
            return $"The house has {Doors} doors, {Windows} windows and the adress is \"{Adress}\". In the House live {personList}";
        }
    }
}
