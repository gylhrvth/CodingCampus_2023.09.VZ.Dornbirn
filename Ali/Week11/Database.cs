using Ali.Week11.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week11
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
        public List<Countries> SearchCountries(string searchTerm)
        {
            List<Countries> countries = new List<Countries>();

            string query = "SELECT name, code, capital, province, area, population FROM country WHERE name like @SearchTerm";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Countries country = new Countries();
                        country.name = reader.GetString(0);
                        country.code = reader.GetString(1);
                        country.capital = reader.GetString(2);
                        country.province = reader.GetString(3);
                        country.area = reader.GetDouble(4);
                        country.population = reader.GetDouble(5);
                        countries.Add(country);


                    }
                }


            }
            return countries;
        }
        public Countries CreateCountry(Countries country)
        {
            string query = "INSERT INTO country (name, code, capital, province, area, population)" +
                "VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";
            using (MySqlCommand command = new MySqlCommand(query,connection))
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
                    throw new Exception("country could not be created");
                }
                return country;

            }
        }
        public bool DeleteCountry(string name, string code, string capital)
        {
            string query = "DELETE FROM country WHERE name = @Name AND code = @Code AND capital = @Capital";
            using (MySqlCommand command = new MySqlCommand (query,connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Code", code);
                command.Parameters.AddWithValue("@Capital", capital);

                return command.ExecuteNonQuery() > 0;
            }

        }
        //public Countries UpdateCountries(string name, string code, string capital, Countries updatedCountries)
        //{
        //    string query = "UPDATE country SET " +
        //       "name = @Name, code = @Code, capital = @Capital, province = @Province, area = @Area, population = @Population" +
        //       "WHERE name = @QueryName AND code = @QueryCode AND capital = @QueryCapital";
        //    using (MySqlCommand command = new MySqlCommand (query,connection))
        //    {
            
        //        //command.Parameters.AddWithValue("@Name", updatedCountries.name);
        //        //command.Parameters.AddWithValue("@Code", updatedCountries.code);
        //        //command.Parameters.AddWithValue("@Capital", updatedCountries.capital);
        //        //command.Parameters.AddWithValue("@Province", updatedCountries.province);
        //        //command.Parameters.AddWithValue("@Area", updatedCountries.area);
        //        //command.Parameters.AddWithValue("@Population", updatedCountries.population);

        //        //command.Parameters.AddWithValue("@QueryName", name);
        //        //command.Parameters.AddWithValue("@QueryCode", code);
        //        //command.Parameters.AddWithValue("@QueryCapital", capital);

        //        //if (command.ExecuteNonQuery() == 0)
        //        //{
        //        //    throw new Exception("Could not update country");
        //        //}
        //        //return updatedCountries;

        //    }


        }

    }
}
