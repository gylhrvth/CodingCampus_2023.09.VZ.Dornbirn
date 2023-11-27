using System;
using System.Xml.Linq;

namespace Mohammed.Week08.Hospital
{
	public class Station : Department
	{
		private int _Zimmer;
        private int _Betten;

		public Station(string name, int oeffnungszeiten, int warteraumplatze, int zimmer, int betten) 
		{
			_Name = name;
			_Oeffnungszeiten = oeffnungszeiten;
			_Warterraumplatze = warteraumplatze;
			_Zimmer = zimmer;
			_Betten = betten;
		}
	}
}

