using System.Xml.Linq;
using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._07Car
{
    public class SelfRepairingCar : Car
    {
        private string _Producer;
        private string _Model;
        private Engine _Engine;
        private double _Weight;
        private Tank _Tank;
        private double _Consumption;
        private CarDriveType _DriveType;

        public SelfRepairingCar(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType) : base(producer, model, engine, weight, tank, carDriveType)
        {
            
        }

    }
}
