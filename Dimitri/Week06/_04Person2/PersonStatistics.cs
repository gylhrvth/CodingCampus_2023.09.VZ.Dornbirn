using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dimitri.Week06._01Person;
using Dimitri.Week06._03List;

namespace Dimitri.Week06._04Person2
{
    public class PersonStatistics
    {
        public static Person MinWeight(List<Person> personList)
        {
            Person personMinWeight = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMinWeight == null || personMinWeight.Weight > personList[i].Weight)
                {
                    personMinWeight = personList[i];
                }

            }

            return personMinWeight;
        }

        public static Person MaxWeight(List<Person> personList)
        {
            Person personMaxWeight = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMaxWeight == null || personMaxWeight.Weight < personList[i].Weight)
                {
                    personMaxWeight = personList[i];
                }

            }

            return personMaxWeight;
        }

        public static float AvgWeight(List<Person> personList)
        {


            float tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Weight;
            }

            return tmp / personList.Count;


        }

        public static Person MinHeight(List<Person> personList)
        {
            Person personMinHeight = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMinHeight == null || personMinHeight.Height > personList[i].Height)
                {
                    personMinHeight = personList[i];
                }

            }

            return personMinHeight;
        }

        public static Person MaxHeight(List<Person> personList)
        {
            Person personMaxHeight = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMaxHeight == null || personMaxHeight.Height < personList[i].Height)
                {
                    personMaxHeight = personList[i];
                }

            }

            return personMaxHeight;
        }

        public static float AvgHeight(List<Person> personList)
        {


            float tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Height;
            }

            return tmp / personList.Count;


        }

        public static Person MinAge(List<Person> personList)
        {
            Person personMinAge = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMinAge == null || personMinAge.Age > personList[i].Age)
                {
                    personMinAge = personList[i];
                }

            }

            return personMinAge;
        }

        public static Person MaxAge(List<Person> personList)
        {
            Person personMaxAge = null;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personMaxAge == null || personMaxAge.Age < personList[i].Age)
                {
                    personMaxAge = personList[i];
                }

            }

            return personMaxAge;
        }

        public static float AvgAge(List<Person> personList)
        {


            float tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Age;
            }

            return tmp / personList.Count;


        }
        public enum SortingValues
        {
            Age,
            Height,
            Weight,
            Name
        }

        public static List<Person> Sort(List<Person> personList, SortingValues sort)
        {
            if (sort == 0)
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    for (int j = i + 1; j < personList.Count; j++)
                    {
                        if (personList[i].Age > personList[j].Age)
                        {
                            Person tempPerson = personList[i];
                            personList[i] = personList[j];
                            personList[j] = tempPerson;
                        }
                    }
                }
                return personList;

            }
            else
            if (sort == SortingValues.Height)
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    for (int j = i + 1; j < personList.Count; j++)
                    {
                        if (personList[i].Height > personList[j].Height)
                        {
                            Person tempPerson = personList[i];
                            personList[i] = personList[j];
                            personList[j] = tempPerson;
                        }
                    }
                }
                return personList;

            } else if (sort == SortingValues.Weight)
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    for (int j = i + 1; j < personList.Count; j++)
                    {
                        if (personList[i].Weight > personList[j].Weight)
                        {
                            Person tempPerson = personList[i];
                            personList[i] = personList[j];
                            personList[j] = tempPerson;
                        }
                    }
                }
                return personList;
            } else if (sort == SortingValues.Name) 
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    for (int j = i + 1; j < personList.Count; j++)
                    {
                        if (personList[i].Name.CompareTo(personList[j].Name) > 0)
                        {
                            Person tempPerson = personList[i];
                            personList[i] = personList[j];
                            personList[j] = tempPerson;
                        }
                    }
                }
                return personList;

            }


            return personList;
        }

        public static void ListToString(List<Person> personList, string firstLine)
        {
            Console.WriteLine(firstLine);
            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine();
            }
        }



    }
}
