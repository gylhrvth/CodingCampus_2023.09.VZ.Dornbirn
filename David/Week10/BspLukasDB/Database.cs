using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
using David.Week10.BspLukasDB;

namespace David.Week10.BspLukasDB
{
    public class Database
    {
        private string connectionString;
        private MySqlConnection connection;

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void connect()
        {
            close();
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void close()
        {
            connection?.Close();
        }

        public List<Country> SearchCountry(string searchTerm)
        {
            List<Country> countries = new List<Country>();

            string query = "SELECT Name, Code, Capital, Province, Area, Population FROM country WHERE country.Name = @SearchTerm";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country country = new Country();
                        country.name = reader.GetString(0);
                        country.code = reader.GetString(1);
                        country.capital = reader.GetString(2);
                        country.province = reader.GetString(3);
                        country.area = reader.GetInt32(4);
                        country.population = reader.GetInt32(5);
                        countries.Add(country);
                    }
                }
            }
            return countries;
        }


        public Country CreateCountry(Country country)
        {
            string query = "INSERT INTO country (Name, Code, Capital, Province, Area, Population) " +
                "VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", country.name);
                command.Parameters.AddWithValue("@Code", country.code);
                command.Parameters.AddWithValue("@Capital", country.capital);
                command.Parameters.AddWithValue("@Province", country.province);
                command.Parameters.AddWithValue("@Area", country.area);
                command.Parameters.AddWithValue("@Population", country.population);

                int result = command.ExecuteNonQuery();

                if (result == 0)
                {
                    throw new Exception("Country could not be created! ");
                }
                return country;
            }
        }

        public bool DeleteCountry(string code, string capital, string province)
        {
            string query = "DELETE FROM country WHERE code = @Code AND capital = @Capital AND province = @Province";
            using(MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Code", code);
                command.Parameters.AddWithValue("@capital", capital);
                command.Parameters.AddWithValue("@province", province);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public Country UpdateCountry(string code, string capital, string province, Country updatedCounty)
        {
            string query = "UPDATE country SET " +
                "name = @Name, " +
                "Code = @Code, " +
                "Capital = @Capital, " +
                "Province = @Province, " +
                "Area = @Area, " +
                "Population = @Population " +
                "WHERE code = @QueryCode AND capital = @QueryCapital AND province = @QueryProvince";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                //Update parameters (all)
                command.Parameters.AddWithValue("@Name", updatedCounty.name);
                command.Parameters.AddWithValue("@Code", updatedCounty.code);
                command.Parameters.AddWithValue("@Capital", updatedCounty.capital);
                command.Parameters.AddWithValue("@Province", updatedCounty.province);
                command.Parameters.AddWithValue("@Area", updatedCounty.area);
                command.Parameters.AddWithValue("@Population", updatedCounty.population);

                //Query Parameterns --> key Values
                command.Parameters.AddWithValue("@Code", code);
                command.Parameters.AddWithValue("@Capital", capital);
                command.Parameters.AddWithValue("@Province", province);

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Could not update country");
                }
                return updatedCounty;
            }
        }

    }
}

