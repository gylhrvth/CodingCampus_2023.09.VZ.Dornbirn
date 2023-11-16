using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._06Car
{
    public class Tank
    {
        private string _Name;
        private double _MaxCapacity;
        private double _Capacity;

        public Tank(string name, double maxCapacity)
        {
            _Name = name;
            _MaxCapacity = maxCapacity;
            _Capacity = maxCapacity;
        }
        public string Name
        { get => _Name; }
        public double MaxCapacity
        { get => _MaxCapacity; }
        public double Capacity
        { 
            get => _Capacity;
            set => _Capacity = value;
        }


    }
}
