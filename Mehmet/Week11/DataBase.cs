using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mehmet.Week11.Model;

namespace Mehmet.Week11
{
    public class DataBase
    {
        private string _ConnectionString;
        private SqlConnection _Connection;

        public DataBase(string connectionString) 
        {
            _ConnectionString = connectionString;
        }

        public void Connect()
        {
            Close();
            _Connection = new SqlConnection(_ConnectionString);
            _Connection.Open();
        }

        public void Close() 
        {
            _Connection?.Close();
        }

        public List<City> SearchCities(string searchTerm)
        {
            List<City> cities = new List<City>();

            string query = "SELECT name, country, province, population, latitude, longitude, elevation FROM city WHERE name like @SearchTerm";

            using (SqlCommand command = new SqlCommand(query, _Connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        City city =new City();
                        city._Name = reader.GetString(0);
                        city._Country = reader.GetString(1);
                        city._Province = reader.GetString(2);
                        city._Population= reader.GetDouble(3);
                        city._Latitude = reader.GetDouble(4);
                        city._Longitude = reader.GetDouble(5);
                        city._Elevation = reader.GetDouble(6);
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
            using (SqlCommand command = new SqlCommand(query, _Connection))
            {
                command.Parameters.AddWithValue("@Name", city._Name);
                command.Parameters.AddWithValue("@Country", city._Country);
                command.Parameters.AddWithValue("@Province", city._Province);
                command.Parameters.AddWithValue("@Population", city._Population);
                command.Parameters.AddWithValue("@Latitude", city._Latitude);
                command.Parameters.AddWithValue("@Longitude", city._Longitude);
                command.Parameters.AddWithValue("@Elevation", city._Elevation);

                int result = command.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("City could not be created");
                }
                return city;
            }
        }

        public bool DeleteCity(string name, string country, string province)
        {
            string query = "DELETE FROM city WHERE name = @Name AND country = @Country AND province = @Province";
            using (SqlCommand command = new SqlCommand(query, _Connection))
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
            using (SqlCommand command = new SqlCommand(query, _Connection))
            {
                //Update parameters
                command.Parameters.AddWithValue("@Name", updatedCity._Name);
                command.Parameters.AddWithValue("@Country", updatedCity._Country);
                command.Parameters.AddWithValue("@Province", updatedCity._Province);
                command.Parameters.AddWithValue("@Population", updatedCity._Population);
                command.Parameters.AddWithValue("@Latitude", updatedCity._Latitude);
                command.Parameters.AddWithValue("@Longitude", updatedCity._Longitude);
                command.Parameters.AddWithValue("@Elevation", updatedCity._Elevation);

                //Query parameters
                command.Parameters.AddWithValue("@QueryName", name);
                command.Parameters.AddWithValue("@QueryCountry", country);
                command.Parameters.AddWithValue("@QueryProvince", province);

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Could not update city");
                }
                return updatedCity;
            }
        }

    }
}
