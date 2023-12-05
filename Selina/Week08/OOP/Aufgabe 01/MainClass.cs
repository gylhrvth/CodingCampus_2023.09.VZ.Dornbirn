using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.OOP.Aufgabe1
{
    public class MainClass
    {
        public static void Start()
        {
            List<Person> list = new List<Person>();

            Person selina = new Person("Selina", 18, Gender.Female);
            Person manuel = new Person("Manuel", 14 ,Gender.Male);
            Person michael = new Person("Michael", 49, Gender.Male);
            Person sandra = new Person("Sandra", 46, Gender.Female);
            Person magnus = new Person("Magnus",1,Gender.Male);
            Person walter = new Person("Walter", 81, Gender.Male);
            Person max = new Person("Max", 68, Gender.Male);
            Person elisabeth = new Person("Elisabeth", 17, Gender.Female);
            Person maria = new Person("Maria", 80, Gender.Female);
            Person samuel = new Person("Samuel", 17, Gender.Male);

            AddPerson(list, selina);
            AddPerson(list, manuel);
            AddPerson(list, michael);
            AddPerson(list, sandra);
            AddPerson(list, magnus);
            AddPerson(list, walter);
            AddPerson(list, max);
            AddPerson(list, elisabeth);
            AddPerson(list, maria);
            AddPerson(list, samuel);
        }
        public static void PrintPerson(List<Person>list,Person person)
        {
              Console.WriteLine($"Name = {person.name,-10} Alter =  {person.age,2}  Geschlecht = {person.gender}");
        }
        public static void AddPerson(List<Person>list,Person person)
        {
            if(!list.Contains(person))
            {
                list.Add(person);
            }
            PrintPerson(list, person);
        }
    }
}
