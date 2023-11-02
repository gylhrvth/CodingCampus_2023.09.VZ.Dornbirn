using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week06
{
    public class DynamicDatastructureByGyula
    {
        private static Random rand = new Random();
        private List<int> _values;

        public DynamicDatastructureByGyula(int size, int min, int max) {
            int minIntern = Math.Min(min, max);
            int maxIntern = Math.Max(min, max);
            _values = new List<int>();
            for (int i = 0;  i < size;  i++)
            {
                _values.Add(rand.Next(minIntern, maxIntern));
            }
        }

        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", _values));
        }

        public int GetMaximum()
        {
            int result = Int32.MinValue;
            for (int i = 0; i < _values.Count; i++)
            {
                if (_values[i] > result)
                {
                    result = _values[i];
                }
            }
            return result;
        }
    }
}
