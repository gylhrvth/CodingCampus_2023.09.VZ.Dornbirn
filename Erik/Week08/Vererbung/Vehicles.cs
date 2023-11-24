
namespace Erik.Week08.Vererbung
{
    public class Vehicles
    {
        protected string _VehicleName;
        protected int _WheelCount;
        protected int _GasTank;
        protected bool _isMoving;
        protected int _Ps;

        public Vehicles(string name, int wheelCount, int gasTank, bool isMoving, int ps)
        {
            _VehicleName = name;
            _WheelCount = wheelCount;
            _GasTank = gasTank;
            _isMoving = isMoving;
            _Ps = ps;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"{_VehicleName}:\nPs: {_Ps}\nWheels: {_WheelCount}\nGastank: {_GasTank}\nVehicle is moving: {_isMoving}");
        }


    }
}
