using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._01Person
{
    public class MinMaxAvg
    {
        public static Statistic CalcStatistics(List<Person> persons)
        {

            int minAge = Int32.MaxValue;
            int maxAge = Int32.MinValue;
            double sumAge = 0;

            int minHeight = Int32.MaxValue;
            int maxHeight = Int32.MinValue;
            double sumHeight = 0;

            double minWeight = Int32.MaxValue;
            double maxWeight = Int32.MinValue;
            double sumWeight = 0;


            foreach (Person p in persons)
            {
                if (p.Age < minAge)
                {
                    minAge = p.Age;
                }
                if (p.Age > maxAge)
                {
                    maxAge = p.Age;
                }
                sumAge += p.Age;



                if (p.Height < minHeight)
                {
                    minHeight = p.Height;
                }
                if (p.Height > maxHeight)
                {
                    maxHeight = p.Height;
                }
                sumHeight += p.Height;



                if (p.Weight < minWeight)
                {
                    minWeight = p.Weight;
                }
                if (p.Weight > maxWeight)
                {
                    maxWeight = p.Weight;
                }
                sumWeight += p.Weight;
            }

            double avgAge = sumAge / persons.Count;
            double avgHeight = sumHeight / persons.Count;
            double avgWeight = sumWeight / persons.Count;

            return new Statistic(maxHeight, minHeight, avgHeight, maxAge, minAge, avgAge, minWeight, maxWeight, avgWeight);
        }
    }
}


