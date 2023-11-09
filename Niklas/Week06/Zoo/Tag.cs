using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week06.Zoo
{
    internal class Tag
    {
        private string _day;

        public Tag(string day)
        {
            _day = day;
        }
        public void Day()
        {
            DateTime day = DateTime.Now;

            Console.WriteLine(day.ToString("dddd"));
        }
    }
}
