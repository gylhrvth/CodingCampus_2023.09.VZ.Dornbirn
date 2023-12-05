using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Kerem.SelbsttestOOP.Person;


namespace Kerem.SelbsttestOOP
{
    internal class PersonMain
    {
        public static void Start()
        {
            List<Person> persons = CreatePerson();
            foreach(Person person in persons)
            {
                Console.WriteLine(person);
            }
           
        }
        public static List<Person> CreatePerson()
        {
            string[] names = { "Robin", "Santiago", "Rosie", "Kingston", "Gabriela", "Peyton", "Kaitlyn", "Marlon", "Jacob", "Antonella" };
            int[] ages = { 22, 45, 21, 36, 75, 35, 77, 34, 85, 20 };
            Genders[] genders = {Genders.male, Genders.male, Genders.female, Genders.divers, Genders.female, Genders.divers, Genders.female, Genders.female, Genders.male, Genders.female };
            
            List<Person> persons = new List<Person>();

            for(int i = 0; i < names.Length; i++)
            {
                Person person = new Person(names[i], ages[i], genders[i]);
                persons.Add(person);
            }
            return persons;
        }
        


    }
}
