
using Fabian.Selftest_OP._01_Person;
using System.Globalization;

namespace Fabian.Selftest_OP._02_House
{
    internal class SortedHouse : House
    {
        public SortedHouse(int doors, int windows, string adress) : base(doors, windows, adress)
        {

        }

        public override void AddPerson(Person person)
        {
            Persons.Add(person);
            SortPersons();
        }

        public void SortPersons()
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                for (int j = 0; j < Persons.Count - i - 1; j++)
                {
                    if (string.Compare(Persons[j].Name, Persons[j + 1].Name, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) > 0)
                    {
                        (Persons[j], Persons[j + 1]) = (Persons[j + 1], Persons[j]);
                    }
                }
            }
        }

        public override string ToString()
        {
            string personList = string.Join(", ", Persons.Select(p => p.Name));
            return $"The house has {Doors} doors, {Windows} windows and the adress is \"{Adress}\". In the House live {personList}";
        }

    }
}
