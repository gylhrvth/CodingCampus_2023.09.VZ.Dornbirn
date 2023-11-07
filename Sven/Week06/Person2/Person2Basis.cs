using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.Person2
{

    public class Person2
    {
        private string _name;
        private int _height;
        private int _age;
        private int _weight;

        public int height
        {
            get => _height;
        }
        public int age
        {
            get => _age;
        }
        public int weight
        {
            get => _weight;
        }
        public Person2(string name, int age, int height, int weight)
        {
            _name = name;
            _height = height;
            _age = age;
            _weight = weight;
        }
        public static void PrintMinMaxAvg(List<Person2> personlist)
        {
            int minweight = int.MaxValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].weight < minweight)
                {
                    minweight = personlist[i].weight;
                }
            }


            Console.WriteLine("Minimum weight: {0}", minweight);

            int maxweight = int.MinValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].weight > maxweight)
                {
                    maxweight = personlist[i].weight;
                }
            }

            Console.WriteLine("Maximum weight: {0}", maxweight);

            int minage = int.MaxValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].age < minage)
                {
                    minage = personlist[i].age;
                }
            }

            Console.WriteLine("Minimum age: {0}", minage);

            int maxage = int.MinValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].age > maxage)
                {
                    maxage = personlist[i].age;
                }
            }

            Console.WriteLine("Maximum age: {0}", maxage);

            int minheight = int.MaxValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].height < minheight)
                {
                    minheight = personlist[i].height;
                }
            }

            Console.WriteLine("Minimum height: {0}", minheight);

            int maxheight = int.MinValue;

            for (int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].height > maxheight)
                {
                    maxheight = personlist[i].height;
                }
            }

            Console.WriteLine("Maximum height: {0}", maxheight);
        }
        public static void PrintAvgheight(List<Person2> personlist)
        {
            int avgheight = 0;

            for (int i = 0; i < personlist.Count; i++)
            {
                avgheight += personlist[i].height;
            }
            avgheight = avgheight / personlist.Count;

            Console.WriteLine("Average height: {0}", avgheight);
        }
        public static void PrintAvgage(List<Person2> personlist)
        {
            int avgage = 0;

            for (int i = 0; i < personlist.Count; i++)
            {
                avgage += personlist[i].age;
            }
            avgage = avgage / personlist.Count;

            Console.WriteLine("Average age: {0}", avgage);
        }
        public static void PrintAvgweight(List<Person2> personlist)
        {
            int avgweight = 0;

            for (int i = 0; i < personlist.Count; i++)
            {
                avgweight += personlist[i].weight;
            }
            avgweight = avgweight / personlist.Count;

            Console.WriteLine("Average weight: {0}", avgweight);
        }

        public static void SortAge(List<Person2> personList)
        {
            for (int i = 0; i < personList.Count; i++)
            {
                for (int j = 0; j < personList.Count - i - 1; j++)
                {
                    if (personList[j].age < personList[j + 1].age)
                    {
                        Person2 tempPerson = personList[j];
                        personList[j] = personList[j + 1];
                        personList[j + 1] = tempPerson;
                    }
                }
            }
        }
        public static void SortWeight(List<Person2> personList)
        {
            for (int i = 0; i < personList.Count; i++)
            {
                for (int j = 0; j < personList.Count - i - 1; j++)
                {
                    if (personList[j].weight < personList[j + 1].weight)
                    {
                        Person2 tempPerson = personList[j];
                        personList[j] = personList[j + 1];
                        personList[j + 1] = tempPerson;
                    }
                }
            }
        }
        public static void SortHeight(List<Person2> personList)
        {
            for (int i = 0; i < personList.Count; i++)
            {
                for (int j = 0; j < personList.Count - i - 1; j++)
                {
                    if (personList[j].height < personList[j + 1].height)
                    {
                        Person2 tempPerson = personList[j];
                        personList[j] = personList[j + 1];
                        personList[j + 1] = tempPerson;
                    }
                }
            }
        }
        public static void SortName(List<Person2> personList)
        {
            for (int i = 0; i < personList.Count; i++)
            {
                for (int j = 0; j < personList.Count - i - 1; j++)
                {
                    if (personList[j]._name.CompareTo(personList[j + 1]._name) < 0)
                    {
                        Person2 tempPerson = personList[j];
                        personList[j] = personList[j + 1];
                        personList[j + 1] = tempPerson;
                    }
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0}", _name);
        }

    }
}
