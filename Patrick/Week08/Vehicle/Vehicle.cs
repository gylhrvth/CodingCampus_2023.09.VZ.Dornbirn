using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    abstract class Vehicle                          //abstract --> von vehicle kann nun kein Objekt erstellt werden
    {
        private int _DoorCount;
        private float _Acceleration;
        private float _BreakSpeed;
        private float _Speed;


        public Vehicle(int doorCount, float acceleration, float breakSpeed, float speed)
        {
            _DoorCount = doorCount;
            _Acceleration = acceleration;
            _BreakSpeed = breakSpeed;
            _Speed = speed;

        }

        public void LogInformation()
        {
            Console.WriteLine("Das Fahrzeug fährt mit " + _Speed + " km/h");
        }



    }
}
