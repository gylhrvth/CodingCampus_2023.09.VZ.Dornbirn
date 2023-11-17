using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.OOP.PersonOne;


namespace Patrick.Week06.OOP.PersonTwo
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
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            Console.WriteLine();
            Person lowestHeight = PersonTwo.MinHeight(persons);
            Console.WriteLine($"Der kleinste Teilnehmer ist: {lowestHeight.Name} er ist {lowestHeight.Height}cm groß");

            Console.WriteLine($"Der größte Teilnehmer ist : {PersonTwo.MaxHeight(persons).Name} er ist {PersonTwo.MaxHeight(persons).Height}cm groß");

            Console.WriteLine("Der älteste Teilnehmer ist : {0} und er ist {1} Jahre alt", PersonTwo.MaxAge(persons).Name, PersonTwo.MaxAge(persons).Age);

            Console.WriteLine("Der jüngste Teilnehmer ist : {0} und er ist {1} Jahre alt", PersonTwo.MinAge(persons).Name, PersonTwo.MinAge(persons).Age);

            Console.WriteLine("Der schwerste Teilnehmer ist : {0} und er ist {1} Kg schwer", PersonTwo.MaxWeight(persons).Name, PersonTwo.MaxWeight(persons).Weight);

            Console.WriteLine("Der leichteste Teilnehmer ist: {0} und er ist {1} Kg schwer", PersonTwo.MinHeight(persons).Name, PersonTwo.MinHeight(persons).Weight);

            Console.WriteLine("Der Altersdurchschnitt von den Personen in der Liste beträgt: {0} Jahre", PersonTwo.AvgAge(persons));

            Console.WriteLine("Der Größendurchschnitt von den Personen in der Liste beträgt: {0} cm", PersonTwo.AvgHeight(persons));

            Console.WriteLine("Der Gewichtsdurchschnitt von den Personen in der Liste beträgt: {0} Kg", PersonTwo.AvgWeight(persons));


            //Sortieren des Objektes Nach Alter aufsteigend
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted by Age up");
            Console.ResetColor();
            SortByAgeUp(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            //Sortieren des Objektes nach Alter absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted by Age down");
            Console.ResetColor();
            SortByAgeDown(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            //Sortieren des Objektes nach Größe aufsteigend
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted by Height up");
            Console.ResetColor();
            SortByHeightUp(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            //Sortieren des Objektes nach Größe absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted by Height down");
            Console.ResetColor();
            SortByHeightDown(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            //Sortieren des Objektes nach Gewicht aufsteigend
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortet by Weight up");
            Console.ResetColor();
            SortByWeightUp(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

            //Sortieren des Objektes nach Gewicht absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted by Weight down");
            Console.ResetColor();
            SortByWeightDown(persons);
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name,8} {person.Age,4} {person.Height,5} {person.Weight,5}");
            }

        }

        public static List<Person> SortByAgeUp(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Age > persons[j + 1].Age)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }

        public static List<Person> SortByAgeDown(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Age < persons[j + 1].Age)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }

        public static List<Person> SortByHeightUp(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Height > persons[j + 1].Height)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }

        public static List<Person> SortByHeightDown(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Height < persons[j + 1].Height)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }

        public static List<Person> SortByWeightUp(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Weight > persons[j + 1].Weight)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }

        public static List<Person> SortByWeightDown(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - i - 1; j++)
                {
                    if (persons[j].Weight < persons[j + 1].Weight)
                    {
                        Person temppers = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temppers;
                    }
                }
            }
            return persons;
        }
    }
}
