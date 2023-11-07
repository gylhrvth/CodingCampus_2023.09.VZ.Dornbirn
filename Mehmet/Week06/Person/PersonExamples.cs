using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Mehmet.Week06.Person;

namespace Mehmet
{
    internal class PersonExamples
    {

        private static List<string> nameList = new List<string>();
        private static List<int> heightList = new List<int>();
        private static List<int> weightList = new List<int>();
        private static List<int> ageList = new List<int>();

        public static void Start()
        {
            Person p1 = new Person (180,22,"Memo",81);
            Person p2 = new Person(185, 26, "Günther", 149);
            Person p3 = new Person(210, 81, "Albert", 115);
            Person p4 = new Person(167, 27, "Lisa", 60);

            p1.Height = 151;
            p2.Age = 30;
            p1.Name = "MeMo";

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

            heightList.Add(p1.Height);
            heightList.Add(p2.Height);
            heightList.Add(p3.Height);
            heightList.Add(p4.Height);

         


            ageList.Add(p1.Age);
            ageList.Add(p2.Age);
            ageList.Add(p3.Age);
            ageList.Add(p4.Age);


            Console.WriteLine("Min height: " + PersonList.MinInAIntList(heightList));
            Console.WriteLine("Avg height: "+PersonList.AvgInAIntList(heightList));
            Console.WriteLine("Max height: " + PersonList.MaxInAIntList(heightList));

            Console.WriteLine("Min age: " + PersonList.MinInAIntList(ageList));
            Console.WriteLine("Avg age: " + PersonList.AvgInAIntList(ageList));
            Console.WriteLine("Max age: " + PersonList.MaxInAIntList(ageList));



            Console.WriteLine("Sort/List/Height/Des=Names");
            PersonList.SortListDes(heightList);
            Console.WriteLine(string.Join("\n", heightList));
        }


    }
}
