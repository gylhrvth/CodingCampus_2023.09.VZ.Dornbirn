using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    internal class MotorCycle : Vehicle, IVehicle
    {
        public MotorCycle(int doorCount, float acceleration, float breakSpeed, float speed) : base (doorCount, acceleration, breakSpeed, speed)
        {

        }

        public void Move()
        {
            Console.WriteLine("Zwei Räder haben Bodenkontakt");
        }
    }
}
