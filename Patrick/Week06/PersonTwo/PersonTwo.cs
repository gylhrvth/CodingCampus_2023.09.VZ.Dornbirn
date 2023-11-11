using Patrick.Week06.PersonOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.PersonTwo
{
    internal class PersonTwo
    {

        public static Person MinHeight(List<Person> persons)
        {
            Person personMinHeight = null;

            for (int i = 0; i < persons.Count; i++)
            {
                if (personMinHeight == null || persons[i].Height < personMinHeight.Height)
                {
                    personMinHeight = persons[i];
                }
            }
            return personMinHeight;
        }

        public static Person MaxHeight(List<Person> persons)
        {
            Person personMaxHeight = null;

            for (int i = 0; i < persons.Count; i++)
            {
                if (personMaxHeight == null || persons[i].Height > personMaxHeight.Height)
                {
                    personMaxHeight = persons[i];
                }
            }
            return personMaxHeight;
        }

        public static Person MinAge(List<Person> persons)
        {
            Person personMinAge = null;

            for (int i = 0; i < persons.Count; i++)
            {
                if (personMinAge == null || personMinAge.Age > persons[i].Age)
                {
                    personMinAge = persons[i];
                }
            }
            return personMinAge;
        }

        public static Person MaxAge (List<Person> persons)
        {
            Person personMaxAge = null;
            for(int i = 0; i < persons.Count; i++)
            {
                if(personMaxAge == null || personMaxAge.Age < persons[i].Age)
                {
                    personMaxAge = persons[i];
                }
            }
            return personMaxAge;
        }

        public static Person MaxWeight (List<Person> persons)
        {
            Person personMaxWeight = null;
            for(int i = 0; i< persons.Count; i++)
            {
                if(personMaxWeight == null || personMaxWeight.Weight < persons[i].Weight)
                {
                    personMaxWeight = persons[i];
                }
            }
            return personMaxWeight;
        }

        public static Person MinWeight (List<Person> persons)
        {
            Person personMinWeight = null;
            for (int i = 0; i < persons.Count;i++)
            {
                if (personMinWeight == null || personMinWeight.Weight < persons[i].Weight)
                {
                    personMinWeight = persons[i];
                }
            }
            return personMinWeight;
        }

        public static float AvgAge(List<Person> persons)
        {
            float personAvg = 0;
            for(int i =0; i < persons.Count; i++)
            {
                personAvg += persons[i].Age;
            }
            personAvg = personAvg / persons.Count;

            return personAvg;
        }

        public static float AvgHeight(List<Person> persons)
        {
            float personAvg = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                personAvg += persons[i].Height;
            }
            personAvg = personAvg / persons.Count;

            return personAvg;
        }

        public static float AvgWeight(List<Person> persons)
        {
            float personAvg = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                personAvg += persons[i].Weight;
            }
            personAvg = personAvg / persons.Count;

            return personAvg;
        }

        public void PrintList(List<float> person)
        {
            foreach (float personItem in person)
            {
                Console.Write(personItem);
            }
        }
    }
}
