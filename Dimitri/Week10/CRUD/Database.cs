using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.CRUD
{
    internal class Database
    {
        private string _ConnectionString;
        private SqlConnection? _Connection;

        public Database(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public void Connect()
        {
            Disconnect();
            _Connection = new SqlConnection(_ConnectionString);
            _Connection.Open();

        }

        public void Disconnect()
        {
            _Connection?.Close();
        }

        public void CreateCountry(Country country)
        {
            string query = "INSERT INTO country (name, code, capital, province, area, population)" +
                "VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";

            using  (SqlCommand cmd = new SqlCommand(query, _Connection)) 
            {
                cmd.Parameters.AddWithValue("@Name", country._Name);
                cmd.Parameters.AddWithValue("@Code", country._Code);
                cmd.Parameters.AddWithValue("@Capital", country._Capital);
                cmd.Parameters.AddWithValue("@Province", country._Province);
                cmd.Parameters.AddWithValue("@Area", country._Area);
                cmd.Parameters.AddWithValue("@Population", country._Population);

                cmd.ExecuteNonQuery();
            }
        }

        public bool SearchCountry(string country)
        {
            string query = "Select * FROM country where name = @CountryName";

            using (SqlCommand cmd = new SqlCommand(query, _Connection))
            {
                cmd.Parameters.AddWithValue("@CountryName", country);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }

        public void DeleteCountry(string code) 
        {
            string query = "DELETE FROM country WHERE code = @Code";

            using(SqlCommand cmd = new SqlCommand(query, _Connection))
            {
                cmd.Parameters.AddWithValue("Code", code);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCityName(string cityName, Country country) 
        {
            
        }
    }
}
