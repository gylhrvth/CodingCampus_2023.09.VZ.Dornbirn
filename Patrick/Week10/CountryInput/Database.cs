using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week10.CountryInput
{
    internal class Database
    {
        private string _ConnectionString;
        private SqlConnection _Connection;

        public Database(string connectionString)
        {
            this._ConnectionString = connectionString;
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

        public List<Country> SearchCountry(string searchTerm)
        {
            List<Country> countries = new List<Country>();

            string query = "SELECT Name, Code, Capital, Province, Area, Population FROM Country Where Name Like @Name";

            using (SqlCommand command = new SqlCommand(query, _Connection))
            {
                command.Parameters.AddWithValue("@Name", searchTerm);

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

        public Country CreateCountry(Country country)
        {
            string query = "INSERT INTO Country (name, code, capital, province, area, population)" +
                "VALUES (@name, @code, @capital, @province, @area, @population)";

            using(SqlCommand command = new SqlCommand(query, _Connection))
            {
                command.Parameters.AddWithValue("@name", country.Name);
                command.Parameters.AddWithValue("@code", country.Code);
                command.Parameters.AddWithValue("@capital", country.Capital);
                command.Parameters.AddWithValue("@province", country.Province);
                command.Parameters.AddWithValue("@area", country.Area);
                command.Parameters.AddWithValue("@population", country.Population);

                int result = command.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("Es konnte kein neues Land erstellt werden! ");
                }
                return country;
            }
        }

        public bool DeleteCountry(Country country)
        {
            string query = "DELETE FROM country WHERE code = @code";

            using (SqlCommand command = new SqlCommand(query, _Connection))
            {             
                command.Parameters.AddWithValue("@code", country.Code);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public Country UpdateCountry(string code, Country updatedCountry)
        {
            string query = "UPDATE Country SET" +
                " name = @name, code = @code, capital = @capital, area = @area, population = @population" +
                " where code = @queryCode";

            using (SqlCommand command = new SqlCommand(query, _Connection))
            {
                command.Parameters.AddWithValue("@name", updatedCountry.Name);
                command.Parameters.AddWithValue("@code", updatedCountry.Code);
                command.Parameters.AddWithValue("@capital", updatedCountry.Capital);
                command.Parameters.AddWithValue("@area", updatedCountry.Area);
                command.Parameters.AddWithValue("@population", updatedCountry.Population);

                command.Parameters.AddWithValue("@queryCode", code);

                int result = command.ExecuteNonQuery();

                if(result == 0)
                {
                    Console.WriteLine("Das Land zu verändern ist fehlgeschlagen!");
                }
            }
            return updatedCountry;
        }

    }
}
