
namespace Fabian.Week08._05_Museum
{
    public class Museum
    {
        private string _Name;
        private List<ExhibitionRoom> _Rooms;
        private List<Hallway> _Hallways;
        private DateTime _OpeningTime;
        private DateTime _ClosingTime;
        private int _Ticks;

        public List<ExhibitionRoom> ExhibitionRooms { get => _Rooms; set => _Rooms = value; }
        public List<Hallway> Hallways { get => _Hallways; set => _Hallways = value; }
        public int Ticks { get => _Ticks; set => _Ticks = value; }
        public Museum(string name, DateTime openingTime, DateTime closingTime)
        {
            _Name = name;
            _Rooms = new List<ExhibitionRoom>();
            _Hallways = new List<Hallway>();
            _OpeningTime = openingTime;
            _ClosingTime = closingTime;
            _Ticks = 0;
        }
        


        public override string ToString()
        {
            return $"Name: {_Name}, opening time: {_OpeningTime:t} - {_ClosingTime:t}";
        }
    }
}
