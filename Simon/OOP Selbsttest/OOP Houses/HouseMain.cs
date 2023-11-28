using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.OOP_Selbsttest.OOP_Houses
{
    public class HouseMain
    {
        public static void Start()
        {
            Person person1 = new Person("Bert", 67, Person.EnumGender.male);
            Person person2 = new Person("Berta", 65, Person.EnumGender.female);
            Person person3 = new Person("Kurt", 74, Person.EnumGender.male);
            Person person4 = new Person("Ida", 49, Person.EnumGender.male);
            Person person5 = new Person("Adele", 45, Person.EnumGender.diverse);
            Person person6 = new Person("Paul", 27, Person.EnumGender.male);
            Person person7 = new Person("Paula", 21, Person.EnumGender.female);
            Person person8 = new Person("Sandro", 19, Person.EnumGender.male);
            Person person9 = new Person("Sandra", 4, Person.EnumGender.female);
            Person person10 = new Person("Richard", 53, Person.EnumGender.male);

            House house1 = new House("Hof 46", 10, 41);
            House house2 = new House("Bühel 7", 4, 10);
            House house3 = new House("Schachen 24", 20, 86);

            SortedHouse sortedHouse1 = new SortedHouse("Schachen 24", 20, 86);

            sortedHouse1.AddPerson(person8);
            sortedHouse1.AddPerson(person9);
            sortedHouse1.AddPerson(person6);
            sortedHouse1.AddPerson(person7);            
            sortedHouse1.SortPerson();

            house1.AddPerson(person1);
            house1.AddPerson(person2);

            house2.AddPerson(person3);
            house2.AddPerson(person4);
            house2.AddPerson(person5);

            house3.AddPerson(person8);
            house3.AddPerson(person9);
            house3.AddPerson(person6);
            house3.AddPerson(person7);
            

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person5.ToString());
            Console.WriteLine(person6.ToString());
            Console.WriteLine(person7.ToString());
            Console.WriteLine(person8.ToString());
            Console.WriteLine(person9.ToString());
            Console.WriteLine(person10.ToString());


            Console.WriteLine(house1.ToString() + "\n" + house2.ToString() + "\n" + house3.ToString());
            Console.WriteLine("Haus mit sortierten Bewohnern:");
            Console.WriteLine(sortedHouse1.ToString());

        }
    }
}
