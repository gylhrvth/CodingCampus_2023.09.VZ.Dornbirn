using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week08._05_Museum
{
    public class Visitor
    {
        private Random rnd = new();
        protected string _Name;

        public Room _CurrentLocation { get; set; }
        public string Name { get => _Name; set => _Name = value; }
        public Visitor(string name)
        {
            _Name = name;
            _CurrentLocation = null;
        }

        public void MoveTo(Room room)
        {
            if (room == _CurrentLocation)
            {
                return;
            }

            if (_CurrentLocation != null)
            {
                _CurrentLocation.ExitVisitor(this);
            }

            _CurrentLocation = room;
            _CurrentLocation.EnterVisitor(this);
        }
    }
}
