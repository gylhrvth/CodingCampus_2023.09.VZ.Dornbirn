using System.Security.Cryptography;

namespace Fabian.Week08._05_Museum
{
    public class Museum
    {
        private string _Name;
        public List<ExhibitiomRoom> _Rooms;
        public List<Hallway> _Hallways;
        public DateTime _OpeningTime;
        public DateTime _ClosingTime;

        public List<ExhibitiomRoom> ExhibitionRooms { get => _Rooms; set => _Rooms = value; }
        public List<Hallway> Hallways { get => _Hallways; set => _Hallways = value; }
        public Museum(string name, DateTime openingTime, DateTime closingTime)
        {
            _Name = name;
            _Rooms = new List<ExhibitiomRoom>();
            _Hallways = new List<Hallway>();
            _OpeningTime = openingTime;
            _ClosingTime = closingTime;
        }

        public override string ToString()
        {
            return $"Name: {_Name}, opening time: {_OpeningTime.ToString("t")} - {_ClosingTime.ToString("t")}";
        }
    }
}
