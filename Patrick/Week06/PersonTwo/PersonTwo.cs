using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.PersonTwo
{
    internal class PersonTwo
    {

        public float Min (List<float> person)
        {
            float min = float.MaxValue;
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i] < min)
                {
                    min = person[i];
                }
            }
            return min;
        }

        public float Max (List<float> person)
        {
            float max = float.MinValue;
            for(int i = 0;i < person.Count;i++)
            {
                if (person[i] > max)
                {
                    max = person[i];
                }
            }
            return max;
        }

        public float Avg (List<float> person)
        {
            return 1;
        }

        public void PrintList(List<float> person)
        {
            foreach(float personItem in person)
            {
                Console.WriteLine(personItem);
            }
        }
    }
}
