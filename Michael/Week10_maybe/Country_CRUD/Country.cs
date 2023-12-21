using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week10_maybe.Country_CRUD
{
    interface FillFromDatabase
    {
        void fill(SqlDataReader reader);
    }

    internal class City : FillFromDatabase
    {
        public string? _name = null;

        public City()
        {

        }

        public void fill(SqlDataReader reader)
        {
            _name = reader.GetString(0);
        }

    }

    internal class Country : FillFromDatabase
    {
        public string? _name = null;
        public string? _code = null;
        public string? _capital = null;
        public double? _area = null;
        public double? _population = null;

        public Country()
        {

        }

        public void fill(SqlDataReader reader)
        {
            _name = reader.GetString(0);
            _code = reader.GetString(1);
            _capital = reader.GetString(2);
            _area = reader.GetDouble(3);
            _population = reader.GetDouble(4);
        }
        
    }
}
