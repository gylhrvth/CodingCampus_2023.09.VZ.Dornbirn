using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    internal class Plane : Vehicle, IVehicle
    {
        private bool _HasJetDrive;

        public Plane(int doorCount, float acceleration, float breakSpeed, float speed, bool hasJetDrive) : base (doorCount, acceleration, breakSpeed, speed)
        {
            _HasJetDrive = hasJetDrive;
        }


        public void Move()
        {
            Console.WriteLine("Die Räder haben keinen Bodenkontakt");
        }

        public virtual void Landing()                       //Virtual --> diese Methode wird überschrieben
        {
            Console.WriteLine("Landeanflug beginnt mit Passagieren.");
        }



    }
}
