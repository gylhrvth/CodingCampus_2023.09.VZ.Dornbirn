using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Timo.Week07._06Car
{
    public class Car
    {
        public enum DriveType
        {
            Benzin,
            Diesel,
            Gas,
            Strom
        }
        private Tank _Tank;
        private Engine _Engine;
        private string _Producer;
        private string _Model;
        private DriveType _DriveType;
        private double _Weight;

        public Car(string producer, string model,  Tank tank, Engine engine, double weight, DriveType driveType)
        {
            _Tank = tank;
            _Engine = engine;
            _Producer = producer;
            _Model = model;
            _Weight = weight;
            _DriveType = driveType;
        }
        public string Model 
        {  get => _Model; }

        public int Drive(int kilometer)
        {
            int driven = 0;
            double consumtion = _Engine.Power / _Weight;
            while (driven < kilometer )
            {
                //if (driven % 150 == 0) { Console.WriteLine("BrummBrummBrumm"); }
                if (_Tank.Capacity-consumtion<0)
                {
                    Console.WriteLine("{1} ist nach {0} km leer und wird nachgetankt", driven, _Model);
                    FillTank(50);
                }
                _Tank.Capacity -= consumtion;
                driven++;
                _Engine.DistanceTravelled++;
            }
            return driven;
        }

        public void FillTank(double value)
        {
            _Tank.Capacity += value; 
        }
    }
}
