namespace Fabian.Week07._07Car
{
    public class AeroDynamicCar : Car
    {
        private string _Producer;
        private string _Model;
        private Engine _Engine;
        private double _Weight;
        private Tank _Tank;
        private double _Consumption;
        private CarDriveType _DriveType;
        public AeroDynamicCar(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType) : base(producer, model, engine, weight, tank, carDriveType)
        {

        }
    }
}
