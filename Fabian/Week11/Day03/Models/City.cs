
namespace Fabian.Week11.Day03
{
	public class City
	{
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

