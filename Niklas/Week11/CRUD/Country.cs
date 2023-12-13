//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Niklas.Week11.CRUD
//{
//    internal class Country
//    {
//        private string connectionString;
//        private MySqlConnection connection;

//        public Country(string connectionString)
//        {
//            this.connectionString = connectionString;
//        }

//        public void connect()
//        {
//            close();
//            connection = new MySqlConnection(connectionString);
//            connection.Open();
//        }

//        public void close()
//        {
//            connection?.Close();
//        }

//        public List<Country> SearchCities(string searchTerm)
//        {
//            List<Country> countries = new List<Country>();

//            string query = "SELECT name, country, province, population, latitude, longitude, elevation FROM city WHERE name like @SearchTerm";

//            using (MySqlCommand command = new MySqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

//                using (MySqlDataReader reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Country country = new Country();
//                        country.name = reader.GetString(0);
//                        country.country = reader.GetString(1);
//                        country.province = reader.GetString(2);
//                        country.population = reader.GetDouble(3);
//                        country.latitude = reader.GetDouble(4);
//                        country.longitude = reader.GetDouble(5);
//                        country.elevation = reader.GetDouble(6);
//                        countries.Add(country);
//                    }
//                }
//            }
//            return countries;
//        }

//        public Country CreateCountry(Country country)
//        {
//            string query = "INSERT INTO country (name, code, capital, province, area, population)" + "VALUES (@Name, @Code, @Capital, @Province, @Area, @Population";

//            using (MySqlCommand command = new MySqlCommand(query, connection))
//            {

//                command.Parameters.AddWithValue("@Name", country.name);
//                command.Parameters.AddWithValue("@Country", country.code);
//                command.Parameters.AddWithValue("@Province", country.capital);
//                command.Parameters.AddWithValue("@Population", country.province);
//                command.Parameters.AddWithValue("@Latitude", country.area);
//                command.Parameters.AddWithValue("@Longitude", country.population);

//                int result = command.ExecuteNonQuery();
//                if (result == 0)
//                {
//                    throw new Exception("City could not be created");
//                }
//                return country;
//            }
//        }
//    }
//}
