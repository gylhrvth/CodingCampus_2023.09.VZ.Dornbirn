using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mehmet.Week11.Model
{
    public class City
    {
        public string _Name;
        public string _Country;
        public string _Province;
        public double _Population;
        public double _Latitude;
        public double _Longitude;
        public double _Elevation;

        public City()
        {

        }

        public City(string name, string country, string province, double population, double latitude, double longitude, double elevation)
        {
            _Name = name;
            _Country = country;
            _Province = province;
            _Population = population;
            _Latitude = latitude;
            _Longitude = longitude;
            _Elevation = elevation;
        }
    }
}
