using System;
namespace Mohammed.Week08.Hospital
{
	public class HospitalMain 
	{
	
		public static void Start()
		{
			Hospital hospital = new Hospital();

			Patient patient1 = new Patient("Martin Ali", "Grippe");
			Patient patient2 = new Patient("Laura lai", "Gebrochenens Arm");
			Patient patient3 = new Patient("lifuf", "Krebs in Schilddrüse breich");


			//hospital.Departments[0].Patient.Add(patient1);
			//hospital.Departments[1].Patient.Add(patient2);
			//hospital.Departments[2].Patient.Add(patient3);

			
		}
	}
}

