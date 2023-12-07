using System;
namespace Lukas.Week11.Models
{
	public class City
	{
		//We don't have time for getters and setters
		public string name;
		public string country;
		public string province;
		public double population;
		public double latitude;
		public double longitude;
		public double elevation;

		public City()
		{
		}

        public City(string name, string country, string province, double population, double latitude, double longitude, double elevation)
        {
            this.name = name;
            this.country = country;
            this.province = province;
            this.population = population;
            this.latitude = latitude;
            this.longitude = longitude;
            this.elevation = elevation;
        }
    }
}

