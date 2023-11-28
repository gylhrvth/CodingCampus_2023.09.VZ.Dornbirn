using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Carsimulation
{
    public enum FuelType { Benzin, Diese, Gas, Strom }

    internal class Car
    {
        private string _Manufacteurer;
        private string _Model;
        private int _Power;
        private int _FuelCapacity;
        private int _FuelCurrent;
        private int _Weight;
        private FuelType _FuelType;
        private Tank _Tank;
        private Engine _Engine;


        public Car(string manufacteurer, string model, int power, int fuelCapacity, int weight, FuelType fueltype, int fuelCurrent)
        {
            _Manufacteurer = manufacteurer;
            _Model = model;
            _Power = power;
            _FuelCapacity = fuelCapacity;
            _Weight = weight;
            _FuelType = fueltype;
            _FuelCurrent = fuelCurrent;
        }


        public int Drive(int kilometer)
        {
            int maxKilometers = _FuelCapacity / (_Weight * _Power);
            int goal = Math.Min(maxKilometers, kilometer);

            for (int driven = 0; driven < goal; driven++)
            {
                if (_Engine.BreakingDuringDrive())
                {
                    _FuelCurrent -= driven * _Weight * _Power;
                    return driven;
                }
            }

            _FuelCurrent -= goal * _Weight * _Power;
            return goal;
        }


        public int Refuel()
        {
            int neededFuel = _FuelCapacity - _FuelCurrent;
            _FuelCurrent += neededFuel;
            return neededFuel;
        }


        public Engine RetrieveEngine()
        {
            Engine retrievedEngine = _Engine;
            _Engine = null;
            return retrievedEngine;
        }


        public void InsertEngine(Engine engine)
        {
            if (_Engine != null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _Engine = engine;
            }
        }


        public int CheckFuel()
        {
            return _FuelCurrent;
        }


        public bool CheckEngineIfBroken()
        {
            return _Engine.Broken;
        }
    }
}
