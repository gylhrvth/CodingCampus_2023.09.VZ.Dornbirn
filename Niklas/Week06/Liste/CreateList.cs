using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Liste
{
    internal class CreateList
    {
        public static Random random = new Random();
        public static void Start()
        {
            List<int> list = new List<int>();
            GetList(list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            List<int> list2 = new List<int>();
            GetList2(list2);
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
        public static List<int> GetList(List<int> list)
        {

            for (int i = 0; i <= 20; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list;
        }
        public static List<int> GetList2(List<int> list)
        {

            for (int i = 0; i <= 20; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list;
        }
    }
}
