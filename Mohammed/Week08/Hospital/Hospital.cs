using System;
namespace Mohammed.Week08.Hospital
{
    public class Hospital : Department
    {
        public List<Department> Departments;

        public Hospital()
        {
            Departments = new List<Department>();

            Departments.Add(new Ambulance("Notaufnahme", 8, 10));
            Departments.Add(new Ambulance("Innere Medizin", 10, 15));
            Departments.Add(new Ambulance("KinderKlinik", 6, 12));
            Departments.Add(new Ambulance("Chirurgie", 10, 20));
            Departments.Add(new Ambulance("Onkologie", 12, 24));
            Departments.Add(new Ambulance("Neurologie", 8, 16));


        }

        public void PatientsTreatment()
        {
            foreach (Department department in Departments)
            {
                department.Treatment();
            }

           
        }





    }
}

