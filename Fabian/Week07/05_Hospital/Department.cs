
namespace Fabian.Week07._05_Hospital
{
    public class Department
    {
        protected string _Name;
        private List<Ambulance> _Ambulances = new();
        private List<Station> _Stations = new();
        public string Name
        {
            get => _Name;
        }
        public List<Station> Stations
        {
            get => _Stations;
            set => _Stations = value;
        }
        public List<Ambulance> Ambulances
        {
            get => _Ambulances;
            set => _Ambulances = value;
        }
      
    }
}
