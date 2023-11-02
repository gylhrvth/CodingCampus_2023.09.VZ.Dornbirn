using Dimitri.Week06._03List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._04Person2
{
    public class Person2
    {
        private int _Height;
        private int _Age;
        private string _Name;
        private int _Weight;

        public int Weight
        {
            get => _Weight;
        }

        public int Age
        {
            get => _Age;
        }

        public int Height
        {
            get => _Height;
        }

        public Person2(int height, int age, string name, int weight)
        {
            _Height = height;
            _Age = age;
            _Name = name;
            _Weight = weight;
        }

        public static void PrintMinMaxAvg(List<Person2> personList)
        {
            //Weight; Print min max values
            int minWeight = int.MaxValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Weight < minWeight)
                {
                    minWeight = personList[i].Weight;
                }
            }

            Console.WriteLine("Minimal weight is: {0}", minWeight);

            int maxWeight = int.MinValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Weight > maxWeight)
                {
                    maxWeight = personList[i].Weight;
                }
            }

            Console.WriteLine("Minimal weight is: {0}", maxWeight);

            //Age; Print min max values

            int minAge = int.MaxValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Age < minAge)
                {
                    minAge = personList[i].Age;
                }
            }

            Console.WriteLine("Minimal Age is: {0}", minAge);


            int maxAge = int.MinValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Age > maxAge)
                {
                    maxAge = personList[i].Age;
                }
            }

            Console.WriteLine("Maximal Age is: {0}", maxAge);

            //Height: Print min max values

            int minHeight = int.MaxValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Height < minHeight)
                {
                    minHeight = personList[i].Height;
                }
            }

            Console.WriteLine("Minimal Height is: {0}", minHeight);


            int maxHeight = int.MinValue;

            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Height > maxHeight)
                {
                    maxHeight = personList[i].Height;
                }
            }

            Console.WriteLine("Maximal Height is: {0}", maxHeight);


            //avg values of weight, age and height
            //Weight

            float avgWeight = 0;

            int tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Weight;
            }

            avgWeight = (float)tmp / personList.Count;


            Console.WriteLine("Average weight is: {0}", avgWeight);

            //Age

            float avgAge = 0;

            tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Age;
            }

            avgAge = (float)tmp / personList.Count;


            Console.WriteLine("Average age is: {0}", avgAge);

            //Heiight

            float avgHeight = 0;

            tmp = 0;

            for (int i = 0; i < personList.Count; i++)
            {
                tmp += personList[i].Height;
            }

            avgHeight = (float)tmp / personList.Count;

            Console.WriteLine("Average Height is: {0}", avgHeight);

        }

    }
}
