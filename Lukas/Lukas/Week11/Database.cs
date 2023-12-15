using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Lukas.Week11.Models;

namespace Lukas.Week11
{
    public class Database
    {
        private string connectionString;
        private SqlConnection connection;

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void connect()
        {
            close();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void close()
        {
            connection?.Close();
        }

        public List<City> SearchCities(string searchTerm)
        {
            List<City> cities = new List<City>();

            string query = "SELECT name, country, province, population, latitude, longitude, elevation FROM city WHERE name like @SearchTerm";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        City city = new City();
                        city.name = reader.GetString(0);
                        city.country = reader.GetString(1);
                        city.province = reader.GetString(2);
                        city.population = reader.GetDouble(3);
                        city.latitude = reader.GetDouble(4);
                        city.longitude = reader.GetDouble(5);
                        city.elevation = reader.GetDouble(6);
                        cities.Add(city);
                    }
                }
            }
            return cities;
        }

        public City CreateCity(City city)
        {
            string query = "INSERT INTO city (name, country, province, population, latitude, longitude, elevation)" +
                "VALUES (@Name, @Country, @Province, @Population, @Latitude, @Longitude, @Elevation)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Name", city.name);
                command.Parameters.AddWithValue("@Country", city.country);
                command.Parameters.AddWithValue("@Province", city.province);
                command.Parameters.AddWithValue("@Population", city.population);
                command.Parameters.AddWithValue("@Latitude", city.latitude);
                command.Parameters.AddWithValue("@Longitude", city.longitude);
                command.Parameters.AddWithValue("@Elevation", city.elevation);

                int result = command.ExecuteNonQuery();
                if(result == 0)
                {
                    throw new Exception("City could not be created");
                }
                return city;
            }

        }

        public bool DeleteCity(string name, string country, string province)
        {
            string query = "DELETE FROM city WHERE name = @Name AND country = @Country AND province = @Province";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@Province", province);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public City UpdateCity(string name, string country, string province, City updatedCity)
        {
            string query = "UPDATE city SET " +
                "name = @Name, country = @Country, province = @Province, population = @Population, latitude = @Latitude, longitude = @Longitude, elevation = @Elevation " +
                "WHERE name = @QueryName AND country = @QueryCountry AND province = @QueryProvince";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                //Update parameters
                command.Parameters.AddWithValue("@Name", updatedCity.name);
                command.Parameters.AddWithValue("@Country", updatedCity.country);
                command.Parameters.AddWithValue("@Province", updatedCity.province);
                command.Parameters.AddWithValue("@Population", updatedCity.population);
                command.Parameters.AddWithValue("@Latitude", updatedCity.latitude);
                command.Parameters.AddWithValue("@Longitude", updatedCity.longitude);
                command.Parameters.AddWithValue("@Elevation", updatedCity.elevation);

                //Query parameters
                command.Parameters.AddWithValue("@QueryName", name);
                command.Parameters.AddWithValue("@QueryCountry", country);
                command.Parameters.AddWithValue("@QueryProvince", province);

                if(command.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Could not update city");
                }
                return updatedCity;
            }
        }
    }
}

