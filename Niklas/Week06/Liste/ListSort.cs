using Niklas.Week06.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Niklas.Week06.Liste
{
    public class Person02
    {
        private int _Size;
        public int Size
        {
            get => _Size;

            set
            {
                Console.WriteLine("Size is: " + value);
                _Size = value;
            }
        }


        private int _Age;
        public int Age
        {
            get => _Age;

            set
            {
                Console.WriteLine("Age is: " + value);
                _Age = value;
            }
        }

        private string _Name;
        public string Name
        {
            get => _Name;

            set
            {
                Console.WriteLine("Name is: " + value);
                _Name = value;
            }
        }

        private int _Weight;
        public int Weight
        {
            get => _Weight;

            set
            {
                Console.WriteLine("Weight is: " + value);
                _Weight = value;
            }
        }
        public Person02(int size, int age, string name, int weight)
        {
            _Size = size;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }


        public override string ToString()
        {
            return string.Format("Person: {0}({1})", _Name, _Age);
        }
    }

    internal class ListSort
    {
        public enum SortedPerson
        {
            Niklas,
            Guyla,
            Lukas,
            Hassan,
        }
        public static void Start()
        {
            int min = 0;
            int max = 0;
            int count = 0;

            List<int> list = new List<int>();
            CreateList.GetList(list);
            PrintList(list);

            Console.WriteLine("Straight numbers are: ");
            count = StraightNumber(list);
            Console.WriteLine(count);

            Console.WriteLine("Min number is: ");
            min = MinNumber(list);
            Console.WriteLine(min);

            Console.WriteLine("Max number is: ");
            max = MaxNumber(list);
            Console.WriteLine(max);

            Console.WriteLine("Sorted descending: ");
            BubbleSortDesc(list);
            PrintList(list);

            Console.WriteLine("Straight numbers deleted: ");
            DeleteOddNumber(list);
            PrintList(list);

            Console.WriteLine();
            Person2(list);

            Console.WriteLine();
            PersonSorted(list);
        }
        public static void PrintList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static int StraightNumber(List<int> list)
        {
            int count = 0;
            count = list.Count(num => num % 2 == 0);
            return count;
        }
        public static int MinNumber(List<int> List)
        {
            int min = List[0];
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] < min)
                {
                    min = List[i];
                }
            }
            return min;
        }
        public static int MaxNumber(List<int> List)
        {
            int max = List[0];
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] > max)
                {
                    max = List[i];
                }
            }
            return max;
        }
        public static void BubbleSortDesc(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
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
        public static List<int> DeleteOddNumber(List<int> list)
        {
            list.RemoveAll(number => number % 2 != 0);
            return list;
        }
        public static void TwoLists(List<int> list)
        {

        }

        public static int Person2(List<int> list)
        {
            Person02 p2 = new Person02(0, 0, "Person", 0);
            SortedPerson s = SortedPerson.Niklas;

            p2.Name = "Niklas";
            p2.Age = 16;
            double a2 = p2.Age;
            p2.Weight = 75;
            double a3 = p2.Weight;
            p2.Size = 175;
            double a4 = p2.Size;
            Console.WriteLine();

            p2.Name = "Guyla";
            p2.Age = 44;
            int b2 = p2.Age;
            p2.Weight = 73;
            int b3 = p2.Weight;
            p2.Size = 180;
            int b4 = p2.Size;
            Console.WriteLine();

            p2.Name = "Lukas";
            p2.Age = 33;
            double c2 = p2.Age;
            p2.Weight = 78;
            double c3 = p2.Weight;
            p2.Size = 181;
            double c4 = p2.Size;
            Console.WriteLine();

            p2.Name = "Hassan";
            p2.Age = 18;
            double d2 = p2.Age;
            p2.Weight = 80;
            double d3 = p2.Weight;
            p2.Size = 185;
            double d4 = p2.Size;
            Console.WriteLine();

            double avgAge = (a2 + b2 + c2 + d2) / 4;
            double avgWeight = (a3 + b3 + c3 + d3) / 4;
            double avgHeight = (a4 + b4 + c4 + d4) / 4;
            Console.WriteLine($"Average stats! Age: {avgAge} , Height: {avgHeight} , Weight: {avgWeight}");

            for (int i = 0; i < list.Count; i++)
            {
                if (b2 < a2)
                {
                    a2 = b2;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d2 < c2)
                {
                    c2 = d2;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c2 < a2)
                {
                    a2 = c2;
                }
            }
            Console.WriteLine("Min age: " + a2);

            for (int i = 0; i < list.Count; i++)
            {
                if (b3 < a3)
                {
                    a3 = b3;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d3 < c3)
                {
                    c3 = d3;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c3 < a3)
                {
                    a3 = c3;
                }
            }
            Console.WriteLine("Min weight: " + a3);

            for (int i = 0; i < list.Count; i++)
            {
                if (b4 < a4)
                {
                    a4 = b4;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d4 < c4)
                {
                    c4 = d4;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c4 < a4)
                {
                    a4 = c4;
                }
            }
            Console.WriteLine("Min Height: " + a4);

            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                if (b2 > a2)
                {
                    a2 = b2;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d2 > c2)
                {
                    c2 = d2;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c2 > a2)
                {
                    a2 = c2;
                }
            }
            Console.WriteLine("Max age: " + a2);

            for (int i = 0; i < list.Count; i++)
            {
                if (b3 > a3)
                {
                    a3 = b3;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d3 > c3)
                {
                    c3 = d3;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c3 > a3)
                {
                    a3 = c3;
                }
            }
            Console.WriteLine("Max weight: " + a3);

            for (int i = 0; i < list.Count; i++)
            {
                if (b4 > a4)
                {
                    a4 = b4;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (d4 > c4)
                {
                    c4 = d4;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (c4 > a4)
                {
                    a4 = c4;
                }
            }
            Console.WriteLine("Max Height: " + a4);
            return Convert.ToInt32(p2);

        }
        public static int PersonSorted(List<int> list)
        {

            Person02 p2 = new Person02(0, 0, "Person", 0);

            object a = Person2;

            Console.WriteLine(a);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list.Count;
        }
    }
}
