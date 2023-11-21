using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._06Car
{
    public class AeroDynamicCar : Car
    {
        public AeroDynamicCar(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType) : base(producer, model, engine, weight, tank, carDriveType)
        {
        }
    }
}