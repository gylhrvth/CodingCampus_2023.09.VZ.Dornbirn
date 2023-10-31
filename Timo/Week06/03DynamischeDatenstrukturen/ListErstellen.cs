using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Timo.Week06._03DynamischeDatenstrukturen
{
    public class ListErstellen
    {
        private static Random random = new Random();

        public List<int> CreateList(int max) 
        {
            List<int> list = new List<int>();
            for (int i = 0; i < max;i++)
            {
                list.Add(random.Next(0,100));
            }
            return list;
        }

        public void PrintList(List<int> list)
        {
            for (int i = 0;i < list.Count;i++)
            {
                Console.WriteLine(list[i].ToString());
            } 
        }

       
    }
}
