using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace Gheorghe.Week11.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public Country() { }

        public Country(string name, string code, string capital, int population)
        {
            Name = name;
            Code = code;
            Capital = capital;
            Population = population;
        }
    }
}
