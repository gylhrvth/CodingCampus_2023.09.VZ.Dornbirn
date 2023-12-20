using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Michael.Week10_maybe.Country_CRUD
{
    internal class DataBase
    {
        private string _connectionString;
        private SqlConnection _connection;

        public DataBase(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void Connect()
        {
            Disconnect();
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }


        public void Disconnect()
        {
            _connection?.Close();
        }


        public List<Country> Find(string searchTerm)
        {
            List<Country> countries = new List<Country>();
            string command = "SELECT name, code, capital, area, population FROM country WHERE name = @SearchTerm";
            SqlCommand cmd = new SqlCommand(command, _connection);
            cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Country country = new Country();
                    country._name = reader.GetString(0);
                    country._code = reader.GetString(1);
                    country._capital = reader.GetString(2);
                    country._area = reader.GetDouble(3);
                    country._population = reader.GetDouble(4);
                    countries.Add(country);
                }
            }

            return countries;
        }

        public List<T> Find2<T>(SqlCommand command) where T : FillFromDatabase, new()
        {
            command.Connection = _connection;
            List<T> elements = new List<T>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    T element = new T();
                    element.fill(reader);
                    elements.Add(element);
                }
            }
            return elements;
        }

        public int Delete(string country)
        {
            List<Country> countries = Find(country);

            if (countries.Count == 0)
            {
                return 0;
            }
            else if (countries.Count > 1)
            {
                throw new Exception("multiple countries fit that name");
            }

            return Delete(countries[0]);
        }


        public int Delete(Country country)
        {
            return DeleteByCode(country._code);
        }


        public int DeleteByCode(string code)
        {
            string commandString = "DELETE FROM country WHERE code = @Code";

            using (SqlCommand cmd = new SqlCommand(commandString, _connection))
            {
                cmd.Parameters.AddWithValue("@Code", code);

                return cmd.ExecuteNonQuery();
            }
        }


        public int Create(Country country)
        {
            string commandString = "INSERT INTO country (name, code, capital, area, population) " +
                "VALUES (@Name, @Code, @Capital, @Area, @Population)";

            using (SqlCommand cmd = new SqlCommand(commandString, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", country._name);
                cmd.Parameters.AddWithValue("@Code", country._code);
                cmd.Parameters.AddWithValue("@Capital", country._capital);
                cmd.Parameters.AddWithValue("@Area", country._area);
                cmd.Parameters.AddWithValue("@Population", country._population);

                return cmd.ExecuteNonQuery();
            }
        }


        public int Update(string oldCountry, Country newCountry)
        {
            List<Country> countries = Find(oldCountry);

            if (countries.Count > 1)
            {
                throw new Exception("multiple countries fit that name");
            }

            return Update(countries[0], newCountry);
        }


        public int Update(Country oldCountry, Country newCountry)
        {
            return UpdateByCode(oldCountry._code, newCountry);
        }


        public int UpdateByCode(string queryCode, Country newCountry)
        {
            string commandString = "UPDATE country " +
                "SET name = @Name, code = @Code, capital = @Capital, area = @Area, population = @Population " +
                "WHERE code = @queryCode";

            using (SqlCommand cmd = new SqlCommand(commandString, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", newCountry._name);
                cmd.Parameters.AddWithValue("@Code", newCountry._code);
                cmd.Parameters.AddWithValue("@Capital", newCountry._capital);
                cmd.Parameters.AddWithValue("@Area", newCountry._area);
                cmd.Parameters.AddWithValue("@Population", newCountry._population);

                cmd.Parameters.AddWithValue("@queryCode", queryCode);

                return cmd.ExecuteNonQuery();
            }
        }


        public bool Exists(string searchTerm)
        {
            return Find(searchTerm).Count > 0;
        }

    }
}
