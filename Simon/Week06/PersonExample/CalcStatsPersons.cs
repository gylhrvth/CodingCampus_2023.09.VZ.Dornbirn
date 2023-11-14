using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.PersonExample
{
    public class CalcStatsPersons
    {
        public static Calc CalcStatsofPersons(List<Person> persons)
        {
            if(persons == null || persons.Count == 0)
            {
                throw new ArgumentException("Can't take empty list");
            }
            double minheight = int.MaxValue;
            double maxheight = int.MinValue;
            double sumheight = 0;

            double minweight = int.MaxValue;
            double maxweight = int.MinValue;
            double sumweight = 0;

            int minage = int.MaxValue;
            int maxage = int.MinValue;
            double sumage = 0;

            foreach(Person person in persons)
            {
                if(person.Height < minheight)
                {
                    minheight = person.Height;                    
                }
                if(person.Height > maxheight)
                {
                    maxheight = person.Height;
                }
                sumheight += person.Height;

                if (person.Weight < minweight)
                {
                    minweight = person.Weight;
                }
                if (person.Weight > maxweight)
                {
                    maxweight = person.Weight;
                }
                sumweight += person.Weight;

                if (person.Age < minage)
                {
                    minage = person.Age;                    
                }
                if (person.Age > maxage)
                {
                    maxage = person.Age;
                }
                sumage += person.Age;
            }

            double avgheight = sumheight / persons.Count;
            double avgweight = sumweight / persons.Count;
            double avgage = sumage / persons.Count;

            return new Calc(minheight, maxheight, avgheight, minage, maxage, avgage, minweight, maxweight, avgweight);
        }

    }
}
