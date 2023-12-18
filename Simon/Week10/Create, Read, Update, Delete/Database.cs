using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week10.Create__Read__Update__Delete
{
    public class Database
    {
        private string _connectionString;
        private SqlConnection _connection;

        public Database (string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public void Sqlconnectionopen()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Sqlconnectionclose() => _connection?.Close();

        public Country CreateCountry(Country country)
        {
            string query = "INSERT INTO country (name, code, capital, province, area, population) VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";
            using(SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", country.Name);
                cmd.Parameters.AddWithValue("@Code", country.Code);
                cmd.Parameters.AddWithValue("@Capital", country.Capital);
                cmd.Parameters.AddWithValue("@Province", country.Province);
                cmd.Parameters.AddWithValue("@Area", country.Area);
                cmd.Parameters.AddWithValue("@Population", country.Population);

                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("Country could not be created");
                }

                return country;
            }            
        }

        public List<Country> SearchCountries(string searchTerm)
        {
            List<Country> countries = new List<Country>();

            string query = "SELECT name, code, capital, province, area, population FROM country WHERE name like @SearchTerm";

            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country country = new Country();
                        country.Name = reader.GetString(0);
                        country.Code = reader.GetString(1);
                        country.Capital = reader.GetString(2);
                        country.Province = reader.GetString(3);
                        country.Area = reader.GetDouble(4);
                        country.Population = reader.GetDouble(5);
                        countries.Add(country);
                    }
                }
            }
            return countries;
        }
        public Country UpdateCountry(string code, Country updatedCountry)
        {
            string query = "UPDATE country SET name = @Name, code = @Code, capital = @Capital, province = @Province, area = @Area, population = @Population WHERE code = @QueryCode";
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                //Update parameters
                cmd.Parameters.AddWithValue("@Name", updatedCountry.Name);
                cmd.Parameters.AddWithValue("@Code", updatedCountry.Code);
                cmd.Parameters.AddWithValue("@Capital", updatedCountry.Capital);
                cmd.Parameters.AddWithValue("@Province", updatedCountry.Province);
                cmd.Parameters.AddWithValue("@Area", updatedCountry.Area);
                cmd.Parameters.AddWithValue("@Population", updatedCountry.Population);

                //Query parameters
                cmd.Parameters.AddWithValue("@QueryCode", code);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Could not update country");
                }
                return updatedCountry;
            }
        }

        public bool DeleteCountry(string code)
        {
            string query = "delete from country where code = @Code";
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Code", code);

                return cmd.ExecuteNonQuery() > 0;
            }            
        }



    }
}
