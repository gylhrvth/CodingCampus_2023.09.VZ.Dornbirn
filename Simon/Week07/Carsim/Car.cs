using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.Carsim
{
    internal class Car
    {
        public static Random random = new Random();
        public enum Fuel
        {
            Benzin,
            Diesel,
            Gas,
            Strom,
        }
        private string _Producer;
        private string _Model;
        private int _kW;
        private int _Tankcapacity;
        private Fuel _Fuel;
        private int _Weight;
        private int _Tank;
        private double _Fuelperkm;
        private double _Range;

        public Car(string producer, string model, int kW, int tankcapacity, Fuel fuel, int weight)
        {
            _Producer = producer;
            _Model = model;
            _kW = kW;
            _Tankcapacity = tankcapacity;
            _Fuel = fuel;
            _Weight = weight;
            _Tank = _Tankcapacity;
            _Fuelperkm = _kW / (double)_Weight;
            _Range = _Tank / _Fuelperkm;

        }

        public int Drive(int kilometer)
        {
            if (_Range > kilometer)
            {
                return kilometer;
            }
            else
            {
                return (int)_Range;
            }
        }

        public void Refill(int fuelammount)
        {
            _Tank = fuelammount;
            if (_Tank > _Tankcapacity)
            {
                _Tank = _Tankcapacity;
            }
        }
        public void Printcarsim(int distancetobedriven)
        {
            int drivensofar = Drive(distancetobedriven);
            int countrefill = 0;
            Console.WriteLine($"Simulation for {_Model}:");

            while (drivensofar < distancetobedriven)
            {
                if (drivensofar == distancetobedriven)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{_Model} completed the entire distance of {distancetobedriven} km without refueling.");
                    Console.ResetColor();
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{_Model} stopped at {drivensofar} km and needs to be refueled. ");
                Console.ResetColor();
                int refillammount = random.Next(20, _Tankcapacity);
                Refill(refillammount);
                _Range = _Tank / _Fuelperkm;
                drivensofar += (int)_Range;
                Console.WriteLine($"{_Model} was filled with {_Tank} l.");

                countrefill++;
            }

            //_Tank =  distancetobedriven - drivensofar == restkm rest km * fuelperkm == fuelammount --> _Tank - fuelammount
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The {_Model} needed to be refilled {countrefill} times and had {_Tank} l of fuel left in the tank");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
