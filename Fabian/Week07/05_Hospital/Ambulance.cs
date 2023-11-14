
namespace Fabian.Week07._05_Hospital
{
    public class Ambulance : Department
    {
        private string _OpeningTime;
        private int _WaitingRoomPlaces;
        private List<Patient> _Patients;

        public List<Patient> Patients
        {
            get => _Patients;
        }
        public Ambulance(string name, string openingTime, int waitingRoomPlaces)
        {
            _Name = name;
            _OpeningTime = openingTime;
            _WaitingRoomPlaces = waitingRoomPlaces;
            _Patients = new List<Patient>();

        }

        public void AddPatient(Patient patient)
        {
            if (_Patients.Count < _WaitingRoomPlaces)
            {
                _Patients.Add(patient);
                Console.WriteLine($"{patient.Name} got added to the {_Name} waiting room.");
            }
            else
            {
                Console.WriteLine($"the {_Name} waiting room is full.");
            }
        }

        public void PrintAmbulances()
        {
            Console.WriteLine($"│\t├── Ambulance: {_Name}, opening time: {_OpeningTime}");

            foreach (var patient in _Patients)
            {
                patient.PrintPatients();
            }

        }
        public override string ToString()
        {
            return $"Ambulance: {_Name}, opening time: {_OpeningTime}";
        }
    }

}
