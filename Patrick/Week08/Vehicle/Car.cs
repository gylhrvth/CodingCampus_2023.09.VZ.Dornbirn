using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    internal class Car : Vehicle, IVehicle
    {
       
        public Car(int doorCount, float acceleration, float breakSpeed, float speed) : base (doorCount, acceleration, breakSpeed, speed)
        {

        }

        public void Move()
        {
            Console.WriteLine("Vier Räder haben Bodenkontakt");
        }
    }
}
