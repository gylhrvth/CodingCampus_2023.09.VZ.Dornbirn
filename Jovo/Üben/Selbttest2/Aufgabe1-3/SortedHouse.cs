using Jovo.Üben.Selbttest2.Aufgabe2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbttest2.Aufgabe1_3
{
    internal class SortedHouse : House
    {

        public SortedHouse(int doors, int windows, string adresse) : base (doors, windows, adresse)
        { 

        
        
        }

        public override void AddPerson (Person person)
        {
            

            int index = residents.FindIndex(p => string.Compare(p.name, person.name, StringComparison.Ordinal) > 0);
            if (index == -1)
            {
                residents.Add(person);
            }
            else
            {
                // Füge die Person and die richtige stelle ein (sorted)
                residents.Insert(index, person);
            }
        }
    }
}
