using System;
using Erik.Week06;

namespace Erik.Week06
{
    public class SortPerson
    {

        private static List<Person_2> CreatPerson()
        {
            return new List<Person_2>() {
                new Person_2(180, 50, "Peter", 98, "Innsbruck"),
                new Person_2(165, 18, "Lena", 66, "München"),
                new Person_2(177, 26, "Martin", 56, "Bregenz"),
                new Person_2(192, 33, "Tim", 84, "London"),
                new Person_2(188, 23, "Brunoooo", 76, "Egg")
            };
        }

        private static void SortPersonHeight(List<Person_2> personListUnsorted)
        {
            int tmp = 0;
            int i = 0;
            List<Person_2> personSortedHeight = new List<Person_2>();
            
            while (i != personListUnsorted.Count)
            {
                if (personListUnsorted[i].Height < personListUnsorted[i + 1].Height)
                {
                    personSortedHeight.Add(personListUnsorted[i]);
                    i++;
                }
                else
                {
                    
                }
            }
        }
    }
}
