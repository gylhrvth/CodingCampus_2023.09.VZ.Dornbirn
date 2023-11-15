using System;
using Mohammed.Week06.KursUndTrainer;

namespace Mohammed.Week06.CreateAList
{
	public class Person20
	{

        public static void Start()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Mohammed", 28, 180, 82),
                new Person("David", 30, 179, 70),
                new Person("Sandro", 33, 177, 75)
            };


            Person maxHeightP = GetMaxSize(people);
            Console.WriteLine("Der größte Person ist: {0} mit {1}cm.",
                maxHeightP == null ? "n.n." : maxHeightP.Name,
                maxHeightP == null ? "- " : maxHeightP.Height);
            
            PrintListPerson(people);
        }


        public static void PrintListPerson(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(people[i]);
            }
            Console.WriteLine();
        }




        public static Person GetMaxSize(List<Person>people)
        {
            Person max = null;

            foreach(Person person in people)
            {
                if (max == null || max.Height < person.Height)
                {
                    max = person;
                }
            }
            return max;
        }

        public static Person GetOldest(List<Person>people)
        {
            Person max = null;

            foreach(Person person in people)
            {
                if(max == null || max.Age < person.Age)
                {
                    max = person;
                }
            }
            return max;
        }

        public static Person GetWeight(List<Person> people)
        {
            Person max = null;

            foreach(Person person in people)
            {
                if(max == null || max.Weight < person.Weight)
                {
                    max = person;
                }
            }
            return max;
        }



        

    }
}

