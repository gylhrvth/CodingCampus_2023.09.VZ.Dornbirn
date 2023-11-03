using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExercisePerson2
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

            for(int i = 0; i < personlist.Count; i++)
            {
               if( personlist[i].weight < minweight)
                {
                    minweight = personlist[i].weight;
                }
            }


            Console.WriteLine("minimum weight is {0}",  minweight);

            int maxweight = int.MinValue;

            for(int i =0; i < personlist.Count; i++)
            {
                if (personlist[i].weight > maxweight)
                {
                    maxweight = personlist[i].weight;
                }
            }

            Console.WriteLine("maximum weight is {0}",  maxweight);

            int minage = int.MaxValue;

            for(int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].age < minage)
                {
                    minage = personlist[i].age;
                }
            }

            Console.WriteLine("minimum age is {0}", minage);

            int maxage = int.MinValue;

            for(int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].age > maxage)
                {
                    maxage = personlist[i].age;
                }
            }

            Console.WriteLine("maximum age is {0}", maxage);

            int minheight = int.MaxValue;

            for(int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].height < minheight)
                {
                    minheight = personlist[i].height;
                }
            }

            Console.WriteLine("minimum height is {0}", minheight);

            int maxheight = int.MinValue;

            for( int i = 0; i < personlist.Count; i++)
            {
                if (personlist[i].height > maxheight)
                {
                    maxheight = personlist[i].height;
                }
            }

            Console.WriteLine("maximum height is {0}", maxheight);

            float avgage = 0;
            int tmp = 0;

            for(int i = 0; i < personlist.Count;i++)
            {

                tmp += personlist[i].age;

             
            }
            avgage = (float)tmp / personlist.Count;

            Console.WriteLine("Average age is {0}", avgage);

            float avgheight = 0;
            int tmp1 = 0;

            for(int i = 0; i < personlist.Count; i++)
            {
                tmp1 += personlist[i].height;
            }
            avgheight = (float)tmp /personlist.Count;

            Console.WriteLine("Average height is {0}", avgheight);

            float avgweight = 0;
            int tmp2 = 0;

            for(int i =0; i < personlist.Count; i++)
            {
                tmp2 += personlist[i].weight;
            }
            avgweight = (float)tmp /personlist.Count;

            Console.WriteLine("Average weight is {0}", avgweight);

        }

    }
 
}
