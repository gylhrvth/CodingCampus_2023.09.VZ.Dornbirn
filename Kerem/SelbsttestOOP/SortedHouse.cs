using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class SortedHouse : House
    {
        public SortedHouse(int doors, int windows, string adresse) : base(doors, windows, adresse)
        {



        }

        public override void AddPerson(Person person)
        {


            int index = people.FindIndex(p => string.Compare(p.Name, person.Name, StringComparison.Ordinal) > 0);
            if (index == -1)
            {
                people.Add(person);
            }
            else
            {
                people.Insert(index, person);
            }
        }
    }
}
