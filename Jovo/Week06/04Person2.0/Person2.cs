using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._04Person2
{
    public class Person2
    {

        private string _Name;
        private int _Age;
        private int _Height;
        private int _Weight;


        public string Name
        {
            get => _Name;
        }

        public int Age
        {
            get => _Age;
        }

        public int Height
        {
            get => _Height;
        }

        public int Weight
        {
            get => _Weight;
        }

        public Person2(string name, int age, int height, int weight)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
        }



        
        public static void PrintMinAge(List<Person2> personList)
        {
            int minAge = int.MaxValue;
            for( int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Age < minAge)
                {
                    minAge = personList[i].Age;
                }

            }
            Console.WriteLine("Min age:" + minAge );
        }
        public static void PrintMaxAge(List<Person2> personList)
        {
            int maxAge = int.MinValue;
            for (int i = 0; i < personList.Count;i++)
            {
                if (personList[i].Age > maxAge)
                {
                    maxAge = personList[i].Age;
                }
            }
            Console.WriteLine("Max age:" + maxAge);
        }

        public static void PrintAvgAge(List<Person2> personList)
        {
            int avgAge = 0;

            for(int i = 0;i < personList.Count; i++)
            {
                avgAge += personList[i].Age;
            }
            avgAge = avgAge/ personList.Count;

            Console.WriteLine("Avg age:" + avgAge);
        }


        public static void PrintMaxheight(List<Person2> personList)
        {
            int maxHeight = int.MinValue;
            for(int i = 0;i < personList.Count; i++)
            {
                if (personList[i].Height > maxHeight)
                {
                    maxHeight = personList[i].Height;
                }
            }
            Console.WriteLine("Max height:" + maxHeight);
        }

        public static void PrintMinheight(List<Person2> personList)
        {
            int minHeight = int.MaxValue;
            for(int i = 0; i <  personList.Count; i++)
            {
                if (personList[i].Height < minHeight)
                {
                    minHeight = personList[i].Height;
                }
            }
            Console.WriteLine("Min height:" + minHeight);
        }

        public static void PrintAvgheight(List<Person2> personList)
        {
            int avgHeight = 0;

            for(int i = 0; i < personList.Count; i++)
            {
                avgHeight += personList[i].Height;
            }
            avgHeight = avgHeight / personList.Count;
            Console.WriteLine("Avg height:" + avgHeight);
        }

        public static void PrintMaxweight(List<Person2> personList)
        {
            int maxWeight = int.MinValue;
            for(int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Weight > maxWeight)
                {
                    maxWeight = personList[i].Weight;
                }
            }
            Console.WriteLine("Max weight:" + maxWeight);
        }

        public static void PrintMinweight(List<Person2> personList)
        {
            int minWeight = int.MaxValue;
            for(int i = 0;i < personList.Count; i++)
            {
                if (personList[i].Weight < minWeight)
                {
                    minWeight = personList[i].Weight;
                }
            }
            Console.WriteLine("Min weight:" + minWeight);
        }


        public static void PrintAvgweight(List<Person2> personList)
        {
            int avgWeight = 0;
            for(int i =0;i<personList.Count;i++)
            {
                avgWeight += personList[i].Weight;
            }
            avgWeight = avgWeight / personList.Count;
            Console.WriteLine("Avg Weight:" + avgWeight);
        }


        //fragen!
        public static void SortPeopleName(List<Person2> personList)
        {
            for(int i = 0; i < personList.Count ; i++)
            {
                for ( int j = 0; j < personList.Count - i - 1 ; j++)
                {
                    if (personList[j].Name.CompareTo(personList[j+1].Name) > 0)
                    {
                        Person2 temp = personList[j];
                        personList[j] = personList[j+1];
                        personList[j + 1] = temp;
                    }
                }
                
            }
            
        }

        //WICHTIG sagen wie etwas ist
        public override string ToString()
        {
            return string.Format("{0} ({1}kg)", _Name, _Weight);

        }



        public static void SortPeopleWeight(List<Person2> personList)
        {
            for ( int i = 0; i < personList.Count ;i++)
            {
                for ( int j= 0; j < personList.Count - 1; j++)
                {
                    if (personList[j].Weight > personList[j+1].Weight)
                    {
                        Person2 temp = personList[j];
                        personList[j] = personList[j+1];
                        personList[j + 1] = temp;
                    }
                }
            }
           
        }

       
    }
}
