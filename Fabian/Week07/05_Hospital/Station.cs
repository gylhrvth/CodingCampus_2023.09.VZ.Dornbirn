namespace Fabian.Week07._05_Hospital
{
    public class Station : Department
    {
        private List<Patient> _Patients;
        private List<Room> _Rooms;

        public Station(string name, List<Room> rooms)
        {
            _Name = name;
            _Rooms = rooms;
            _Patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            bool patientAdded = false;
            foreach (var room in _Rooms)
            {
                if (room.Beds > room.BedsTaken)
                {
                    _Patients.Add(patient);
                    patient.Room = room;
                    room.BedsTaken++;
                    Console.WriteLine($"{patient.Name} got added to room {room.RoomNumber}");
                    patientAdded = true;
                    break;
                }               
            }
            if (!patientAdded) Console.WriteLine($"No available space in any room for {patient.Name}");
        }

        public void PrintStations()
        {
            Console.WriteLine($"│\t├── Station: {Name}");
            foreach (var room in _Rooms)
            {
                Console.WriteLine($"│\t\t├── Room {room.RoomNumber}:");
                foreach (var patient in _Patients)
                {
                    if (patient.Room == room)
                    {
                        patient.PrintPatients();
                    }
                }
            }
        }
    }
}
