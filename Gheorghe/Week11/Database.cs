using Gheorghe.Week11.Models;
using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;



namespace Gheorghe.Week11
{
    public class Database
    {
        private string connectionString;
        private SqlConnection connection;


        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            Close();
            this.connection = new SqlConnection(connectionString);
            this.connection.Open();
        }

        public void Close()
        {
            this.connection?.Close();
        }

        public bool CreateCountry(Country country)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO country (name, code, capital, population) VALUES (@name, @code, @capital, @population)", connection);
                command.Parameters.AddWithValue("@name", country.Name);
                command.Parameters.AddWithValue("@code", country.Code);
                command.Parameters.AddWithValue("@capital", country.Capital);
                command.Parameters.AddWithValue("@population", country.Population);

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }

                return false;
            }
        }

        public Country ReadCountry(string name)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT name, code, capital, population FROM country WHERE name = @name", connection);
                command.Parameters.AddWithValue("@name", name);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Country country = new Country
                    {
                        Name = reader.GetString(0),
                        Code = reader.GetString(1),
                        Capital = reader.GetString(2),
                        Population = (int)reader.GetDouble(3)
                    };

                    return country;
                }

                return null;
            }
        }

        public bool UpdateCountry(string countryCode, Country country)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("UPDATE country SET name = @name, code = @code, capital = @capital, population = @population WHERE code = @queryCode", connection);
                command.Parameters.AddWithValue("@name", country.Name);
                command.Parameters.AddWithValue("@code", country.Code);
                command.Parameters.AddWithValue("@capital", country.Capital);
                command.Parameters.AddWithValue("@population", country.Population);
                command.Parameters.AddWithValue("@queryCode", countryCode);

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }

                return false;
            }
        }

        public bool DeleteCountry(string code)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM country WHERE code = @code", connection);
                command.Parameters.AddWithValue("@code", code);

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
