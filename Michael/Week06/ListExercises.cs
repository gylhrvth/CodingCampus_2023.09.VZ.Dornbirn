using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week06
{
    internal class ListExercises
    {

        public static void Start()
        {
            Person person1 = new Person(160, 20, "test1", 85);
            Person person2 = new Person(177, 24, "test2", 70);
            List<Person> list = new List<Person>() { person1, person2 };

            Console.WriteLine(person1);

            Console.WriteLine();

            Console.WriteLine(person2);

            Console.WriteLine();

            Console.WriteLine(AverageAge(list));

        }


        public static List<string> CopyStringList(List<string> input)
        {
            List<string> returnList = new List<string>();

            foreach (string element in input)
            {
                returnList.Add(element);
            }

            return returnList;
        }


        public static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        public static List<int> CreateRandomList(int length, int min, int max)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(min, max));
            }

            return list;
        }


        public static int CountEven(List<int> list)
        {
            int count = 0;
            foreach (int num in list)
            {
                if (num % 2 == 0) count++;
            }

            return count;
        }


        public static int FindMin(List<int> list)
        {
            int min = list[0];
            foreach (int num in list)
            {
                if (num < min) min = num;
            }

            return min;
        }


        public static int FindMax(List<int> list)
        {
            int max = list[0];
            foreach (int num in list)
            {
                if (num > max) max = num;
            }

            return max;
        }


        public static void ListBubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }


        public static void RemoveOdds(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }


        public static List<int> SortedMerge(List<int> list1, List<int> list2)
        {
            int i = 0; //index for list1
            int j = 0; //index for list2
            List<int> result = new List<int>();


            while (i < list1.Count && j < list2.Count) 
            { 
                if (list1[i] > list2[j])
                {
                    result.Add(list1[i]);
                    i++;
                }
                else
                {
                    result.Add(list2[j]);
                    j++;
                }
            }

            while (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                result.Add(list2[j]);
                j++;
            }

            return result;
        }

        
        public static Person HeaviestPerson(List<Person> people)
        {
            Person max = people[0];

            foreach (Person person in people)
            {
                if (max.Weight < person.Weight)
                {
                    max = person;
                }
            }

            return max;
        }


        public static Person LightestPerson(List<Person> people)
        {
            Person min = people[0];

            foreach (Person person in people)
            {
                if (min.Weight > person.Weight)
                {
                    min = person;
                }
            }

            return min;
        }


        public static Person TallestPerson(List<Person> people)
        {
            Person max = people[0];

            foreach (Person person in people)
            {
                if (max.Size < person.Size)
                {
                    max = person;
                }
            }

            return max;
        }


        public static Person SmallestPerson(List<Person> people)
        {
            Person min = people[0];

            foreach (Person person in people)
            {
                if (min.Size < person.Size)
                {
                    min = person;
                }
            }

            return min;
        }


        public static Person OldestPerson(List<Person> people)
        {
            Person max = people[0];

            foreach (Person person in people)
            {
                if (max.Age < person.Age)
                {
                    max = person;
                }
            }

            return max;
        }


        public static Person YoungestPerson(List<Person> people)
        {
            Person min = people[0];

            foreach (Person person in people)
            {
                if (min.Age > person.Age)
                {
                    min = person;
                }
            }

            return min;
        }


        public static int AverageAge(List<Person> people)
        {
            int average = 0;

            foreach (Person person in people)
            {
                average += person.Age;
            }

            return average / people.Count;
        }


        public static double AverageWeight(List<Person> people)
        {
            double average = 0;

            foreach (Person person in people)
            {
                average += person.Weight;
            }

            return average / people.Count;
        }


        public static int AverageSize(List<Person> people)
        {
            int average = 0;

            foreach (Person person in people)
            {
                average += person.Size;
            }

            return average / people.Count;
        }


        public static void PeopleBubbleSortAge(List<Person> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].Age > list[j + 1].Age)
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }


        public static void PeopleBubbleSortSize(List<Person> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].Size > list[j + 1].Size)
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }


        public static void PeopleBubbleSortWeight(List<Person> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].Weight > list[j + 1].Weight)
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }


        public static void PeopleBubbleSortName(List<Person> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].Name.CompareTo(list[j + 1].Name) == 1)
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }


        public static List<List<string>> PermuteList(List<string> input)
        {
            //recursion end, all permutations of 1 element are just that 1 element
            if (input.Count == 1)
            {
                return new List<List<string>> { input };
            }


            //creates permutations of the smaller 'list without the first element'
            List<List<string>> rightPart = PermuteList(input.GetRange(1, input.Count - 1));
            List<List<string>> returnList = new List<List<string>>();


            //creates all permutations with the first element and each individual permutation from the smaller list
            for (int i = 0; i < rightPart.Count; i++)
            {
                for (int j = 0; j <= rightPart[i].Count; j++)
                {
                    List<string> addList = CopyStringList(rightPart[i]);

                    addList.Insert(j, input[0]);

                    returnList.Add(addList);
                }
            }

            return returnList;

        }
    }
}
