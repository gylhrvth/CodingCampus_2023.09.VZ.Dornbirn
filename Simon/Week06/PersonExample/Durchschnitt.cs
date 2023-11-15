using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.PersonExample
{
    public class Calc
    {
        private double _MinHeight;
        private double _MaxHeight;
        private double _AverageHeight;
        private int _MinAge;
        private int _MaxAge;
        private double _AverageAge;
        private double _MinWeight;
        private double _MaxWeight;
        private double _AverageWeight;

        public double MinHeight { get { return _MinHeight; } }
        public double MaxHeight { get { return _MaxHeight; } }
        public double AverageHeight { get { return _AverageHeight; } }
        public int MinAge { get { return _MinAge; } }
        public int MaxAge { get { return _MaxAge; } }
        public double AverageAge { get { return _AverageAge; } }
        public double MinWeight { get { return _MinWeight; } }
        public double MaximumWeight { get { return _MaxWeight; } }
        public double AverageWeight { get { return _AverageWeight; } }

        public Calc(double MinHeight, double MaxHeight, double AverageHeight, int MinAge,
            int MaxAge, double AverageAge, double MinWeight, double MaxWeight, double AverageWeight)
        {
            _MinHeight = MinHeight;
            _MaxHeight = MaxHeight;
            _AverageHeight = AverageHeight;
            _MinAge = MinAge;
            _MaxAge = MaxAge;
            _AverageAge = AverageAge;
            _MinWeight = MinWeight;
            _MaxWeight = MaxWeight;
            _AverageWeight = AverageWeight;
        }

        public override string ToString()
        {
            return string.Format("MinH: {0} MaxH: {1} AvgH: {2}\nMinA: {3} MaxA: {4} AvgA: {5}\nMinW: {6} MaxW: {7} AvgW: {8}",
                _MinHeight,  _MaxHeight, _AverageHeight, _MinAge, _MaxAge, _AverageAge, _MinWeight, _MaxWeight, _AverageWeight);
        }


    }
}
