using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
namespace David.Week11.uebung
{
	public class Country
	{
		public object Name;
		public object Code;
		public object Captital;
		public object Province;
		public object Area;
		public object Population;

		public Country(string name, string code, string capital, string provine, int area, int population)
		{
			this.Name = name;
			this.Code = code;
            this.Captital = capital;
            this.Province = provine;
            this.Area = area;
            this.Population = population;
        }
	}
}


