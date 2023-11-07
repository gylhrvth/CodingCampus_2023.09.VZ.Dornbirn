using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._01Person
{
    public class Statistic
    {
        private int _MaxHeight;
        private int _MinHeight;
        private double _AvgHeight;
        private int _MaxAge;
        private int _MinAge;
        private double _AvgAge;
        private double _MaxWeight;
        private double _MinWeight;
        private double _AvgWeight;

        public Statistic(int maxHeight, int minHeight, double avgHeight, int maxAge, int minAge, double avgAge, double maxWeight, double minWeight, double avgWeight)
        {
            _MaxHeight = maxHeight;
            _MinHeight = minHeight;
            _AvgHeight = avgHeight;
            _MaxAge = maxAge;
            _MinAge = minAge;
            _AvgAge = avgAge;
            _MaxWeight = maxWeight;
            _MinWeight = minWeight;
            _AvgWeight = avgWeight;
        }
        public int MaxHeight
        {
            get => _MaxHeight;
        }
        public int MinHeight
        {
            get => _MinHeight;
        }
        public double AvgHeight
        {
            get => _AvgHeight;
        }
        public int MaxAge
        {
            get => _MaxAge;
        }
        public int MinAge
        {
            get => _MinAge;
        }
        public double AvgAge
        {
            get => _AvgAge;
        }
        public double MaxWeight
        {
            get => _MaxWeight;
        }
        public double MinWeight
        {
            get => _MinWeight;
        }
        public double AvgWeight
        {
            get => _AvgWeight;
        }

        public override string ToString()
        {
            return string.Format("min height: {0} cm \tmax height: {1} cm \taverage height: {2} cm\n" +
                                 "min age: {3} years \tmax age: {4} years \taverage age: {5} years\n" +
                                 "min weight: {6} kg \tmax weight: {7} kg \taverage weight: {8} kg", _MinHeight, _MaxHeight, _AvgHeight, _MinAge, _MaxAge, _AvgAge, _MinWeight, _MaxWeight, _AvgWeight);
        }
    }
}
