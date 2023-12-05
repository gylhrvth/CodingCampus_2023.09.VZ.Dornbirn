using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.OOP_Selbsttest.OOP_Houses
{
    public  class SortedHouse : House
    {

        public SortedHouse(string adress, int doors, int windows) : base(adress, doors, windows)
        {
        }

        public override void AddPerson(Person person)
        {
            base.AddPerson(person);
        }

        public void SortPerson()
        {
            for (int i = 0; i < PersonList.Count; i++)
            {
                for (int j = 0; j < PersonList.Count - i - 1; j++)
                {
                    if (PersonList[j].Name.CompareTo(PersonList[j + 1].Name) > 0)
                    {
                        Person temp = PersonList[j];
                        PersonList[j] = PersonList[j + 1];
                        PersonList[j + 1] = temp;
                    }
                }
            }
        }

    }
}
