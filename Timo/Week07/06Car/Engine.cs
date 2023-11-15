using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._06Car
{
    public class Engine
    {
        private string _Name;
        private int _Power;
        private bool _IsBroken;
        private int _DistanceTravelled;

        public Engine(string name, int power)
        {
            _Name = name;
            _Power = power;
            _IsBroken = false;
            _DistanceTravelled = 0;
        }

        public bool IsBroken 
        { 
            get => _IsBroken; 
            set => _IsBroken = value; 
        }

        public int Power
        {
            get => _Power;
        }
        public int DistanceTravelled
        {
            get => _DistanceTravelled;
            set => _DistanceTravelled = value;
        }
    }
}
