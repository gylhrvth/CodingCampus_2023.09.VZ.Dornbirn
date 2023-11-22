

namespace Erik.Week08.Vererbung
{
    internal class Motobike : Vehicles
    {
        private bool _CanWheelie;
        private int _SeatHeight;


        public Motobike(string name, int wheelCount, int gasTank, bool isMoving, bool canWheelie, int seatHeight, int ps) : base(name, wheelCount, gasTank, isMoving, ps)
        {
            _CanWheelie = canWheelie;
            _SeatHeight = seatHeight;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"{_VehicleName}:\nPs: {_Ps}\nWheels: {_WheelCount}\nGastank: {_GasTank}\nVehicle is moving: {_isMoving}\nCan Wheelie: {_CanWheelie}\nSeatheight: {_SeatHeight}");

        }

    }
}
