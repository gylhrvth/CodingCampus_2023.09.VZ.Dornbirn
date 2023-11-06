using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week06.NmsPerson
{
    internal class PersonMain
    {
        public static void Start()
        {
            Person p1 = new Person("Cemal", 20, 1.73, 83.2);
            Person p2 = new Person("Gyula", 44, 1.72, 85.0);
            Person p3 = new Person("Lukas", 38, 1.74, 83.4);
            Person p4 = new Person("Kerem", 23, 1.80, 90.3);
            Person p5 = new Person("Lukas", 22, 1.78, 95.5);
            PersonMin(p1);
        }

        public static int PersonMin(List<int> list)
        {
            int mindestwert = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                mindestwert = Math.Min(mindestwert, list[i]);
            }

            return mindestwert;
        }
    }
}
