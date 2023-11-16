using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class Food
    {
        private string _Name;
        private string _Unit;
        private double _UnitAmount;
        private double _Unitrpice;

        public string Name { get => _Name; }
        public string Unit { get => _Unit; }
        public double Unitprice { get => _Unitrpice; }
        public Food(string name, string unit, double unitamount, double unitrpice)
        {
            _Name = name;
            _Unit = unit;
            _UnitAmount = unitamount;
            _Unitrpice = unitrpice;
        }
        public override string ToString()
        {
            return _Name;
        }
    }
}
