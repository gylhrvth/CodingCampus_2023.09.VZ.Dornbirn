using System;
namespace David.Week10.BspLukasDB
{
	public class Country
	{
		public string name;
		public string code;
		public string capital;
		public string province;
		public int area;
		public int population;

		public Country()
		{
		}

		public Country(string name, string code, string capital, string province, int area, int population)
		{
			this.name = name;
			this.code = code;
			this.capital = capital;
			this.province = province;
			this.area = area;
			this.population = population;
		}
	}
}

