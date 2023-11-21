using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{

    internal class Guest : Human
    {
        private bool _isTired = false;
        private int _EnergyCount;

        public Guest(string name, int energyCount, Room currentRoom) : base(name, currentRoom)
        {
            _EnergyCount = energyCount;
        }
    }
}
