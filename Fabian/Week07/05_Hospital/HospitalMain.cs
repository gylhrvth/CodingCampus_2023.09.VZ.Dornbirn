namespace Fabian.Week07._05_Hospital
{
    public class HospitalMain
    {
        public static void Start()
        {
            Room room = new(101, 4);
            Room room2 = new(102, 4);

            Department department = new();

            Hospital hospital = new ("Schwarzwald Klinik");

            Ambulance ambulance  = new("General medicine", "08:00 - 18:00", 20);

            Station station = new("Internal Medicine", new List<Room> { room, room2});

            Patient max = new("Max Mustermann", 20,  "Fever");
            Patient maria = new("Maria Musterfrau", 25,  "Broken left arm");
            Patient stefan = new("Stefan Hallinger", 30, "Broken right leg");
            Patient sophia = new("Sophia Mayer", 38, "Myocardial Infarction");
            Patient jacob = new("Jacob Huber", 55, "Stroke");
            Patient emily = new("Emily Schulz", 42, "Severe Respiratory Distress");
            Patient jonas = new("Jonas Kroos", 60, "Lost left arm");
            Patient emma = new("Emma Wagner", 45, "Pneumonia");
            Patient ben = new("Benjamin Keller", 32, "Appendicitis");
            Patient laura = new("Laura Becker", 50, "Hypertension");
            Patient david = new("David Fischer", 28, "Fractured wrist");


            hospital.Departments.Add(department);

            department.Ambulances.Add(ambulance);
            department.Stations.Add(station);

            ambulance.AddPatient(max);
            ambulance.AddPatient(maria);          
            ambulance.AddPatient(emma);
            ambulance.AddPatient(stefan);
            ambulance.AddPatient(ben);
            ambulance.AddPatient(laura);
            station.AddPatient(david);
            station.AddPatient(sophia);
            station.AddPatient(jacob);
            station.AddPatient(emily);
            station.AddPatient(jonas);

            Console.WriteLine();
            hospital.PrintStructure();

        }
    }
}
