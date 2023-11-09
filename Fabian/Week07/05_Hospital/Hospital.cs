namespace Fabian.Week07._05_Hospital
{
    public class Hospital
    {
        private string _Name;
        private List<Department> _Departments;

        public List<Department> Departments
        {
            get => _Departments;
            set => _Departments = value;
        }
        public string Name
        {
            get => _Name; 
        }
        public Hospital(string Name)
        {
            _Name = Name;
            _Departments = new List<Department>();
        }

        public void PrintStructure()
        {
            Console.WriteLine($"├── Hospital: {_Name}");
            foreach (var department in _Departments)
            {
                foreach (var station in department.Stations)
                {
                    station.PrintStations();
                }
                foreach (var ambulance in department.Ambulances)
                {
                    ambulance.PrintAmbulances();
                }
            }
        }
    }
}
