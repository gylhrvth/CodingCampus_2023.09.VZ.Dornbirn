using System;
namespace Mohammed.Week08.Hospital
{
	public class Ambulance : Department
	{
		public Ambulance(string name, int oeffnungszeiten, int warteraumplatze)
		{
			_Name = name;
			_Oeffnungszeiten = oeffnungszeiten;
			_Warterraumplatze = warteraumplatze;

            
        }
	}
}

