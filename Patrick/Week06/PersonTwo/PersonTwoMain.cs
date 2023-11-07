using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.PersonOne;
using Patrick.Week06.PersonTwo;


namespace Patrick.Week06.PersonTwo
{
    internal static class PersonTwoMain
    {
        public static void Start()
        {
            List<Person> persons = new List<Person>()
            {
                new Person("Patrick", 29, 200f, 110),
                new Person("Dimitri", 32, 165f, 80),
                new Person("Mohammed", 28, 185f, 90),
                new Person("Richard", 45, 172f, 73),
                new Person("David", 35, 176f, 60)
            };

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person._Name, 8} {person._Age, 4} {person._Height, 5} {person._Weight, 5}");
            }
              
            Person lowestHeight = PersonTwo.MinHeight(persons);
            Console.WriteLine($"Der kleinste Teilnehmer ist: {lowestHeight._Name} er ist {lowestHeight._Height}cm groß");
         
            Console.WriteLine($"Der größte Teilnehmer ist : {PersonTwo.MaxHeight(persons)._Name} er ist {PersonTwo.MaxHeight(persons)._Height}cm groß");

            Console.WriteLine("Der älteste Teilnehmer ist : {0} und er ist {1} Jahre alt", PersonTwo.MaxAge(persons)._Name, PersonTwo.MaxAge(persons)._Age);

            Console.WriteLine("Der jüngste Teilnehmer ist : {0} und er ist {1} Jahre alt", PersonTwo.MinAge(persons)._Name, PersonTwo.MinAge(persons)._Age);

            Console.WriteLine("Der schwerste Teilnehmer ist : {0} und er ist {1} Kg schwer", PersonTwo.MaxWeight(persons)._Name, PersonTwo.MaxWeight(persons)._Weight);

            Console.WriteLine("Der leichteste Teilnehmer ist: {0} und er ist {1} Kg schwer", PersonTwo.MinHeight(persons)._Name, PersonTwo.MinHeight(persons)._Weight);

            Console.WriteLine("Der Altersdurchschnitt von den Personen in der Liste beträgt: {0} Jahre", PersonTwo.AvgAge(persons));

            Console.WriteLine("Der Größendurchschnitt von den Personen in der Liste beträgt: {0} cm", PersonTwo.AvgHeight(persons));

            Console.WriteLine("Der Gewichtsdurchschnitt von den Personen in der Liste beträgt: {0} Kg", PersonTwo.AvgWeight(persons));
        }

    }
}
