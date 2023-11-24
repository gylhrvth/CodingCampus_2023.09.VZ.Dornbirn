 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Carsimulation
{
    internal class RepairStation
    {
        public RepairStation()
        {

        }

        public Engine ChangeMotor(Car car, Engine engine)
        {
            Engine retrievedEngine = car.RetrieveEngine();
            car.InsertEngine(engine);
            return retrievedEngine;
        }
    }
}
