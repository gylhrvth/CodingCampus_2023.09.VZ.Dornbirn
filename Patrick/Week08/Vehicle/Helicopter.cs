using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    internal class Helicopter : Plane
    {

        public Helicopter(int doorCount, float acceleration, float breakSpeed, float speed, bool hasJetDrive) : base (doorCount, acceleration, breakSpeed, speed, hasJetDrive)
        {

        }

        public override void Landing()              //Override überschreibt die Methode Landing von der Klasse Plane!
        {
            //base.Landing();                       // base --> steht für die basisKlasse, jetzt wird zuerst Landing vom Plane ausgeführt und danach die vom Heli
            Console.WriteLine("Der Helicopter sinkt langsam.");
        }
    }
}
