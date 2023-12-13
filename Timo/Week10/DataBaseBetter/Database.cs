using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Week10.DataBaseBetter.Models;

namespace Timo.Week10.DataBaseBetter;
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
    public List<Country> SearchCountries(string searchTerm)
    {
        List<Country> cities = new List<Country>();

        string query = "SELECT name, code, capital, area, population FROM Country WHERE name = @SearchTerm";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@SearchTerm", searchTerm);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Country country = new Country();
                    country.name = reader.GetString(0);
                    country.code = reader.GetString(1);
                    country.capital = reader.GetString(2);
                    country.area = reader.GetDouble(3);
                    country.population = reader.GetDouble(4);
                    cities.Add(country);
                }
            }
        }
        return cities;
    }

    public void ShowCountrySimple(string Name)
    {
        List<Country> countries = this.SearchCountries(Name);
        foreach (var country in countries)
        {
            Console.WriteLine(country.name + " " + country.code + " " + country.capital + " " + country.area + " " + country.population);
        }
    }

    public void ShowCountry(string Name)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("Select * from country where Name = @LandSelect", connection);

            command.Parameters.Add("@LandSelect", System.Data.SqlDbType.NVarChar).Value = Name;
            try
            {
                command.Connection.Open();
                Console.ForegroundColor = ConsoleColor.Blue;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<DbColumn> header = reader.GetColumnSchema().ToList();
                    for (int i = 0; i < header.Count; i++)
                    {
                        //Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "["+ header[i].ColumnSize + "]   ");
                        if (header[i].DataTypeName == "nvarchar")
                        {
                            string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                            Console.Write(formatString, header[i].ColumnName);
                        }
                        else if (header[i].DataTypeName == "float")
                        {
                            Console.Write("| {0,20:N2} ", header[i].ColumnName);
                        }
                        else
                        {
                            Console.Write("| {0,20} ", header[i].ColumnName);
                        }
                    }
                    Console.WriteLine("|");
                    Console.ResetColor();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write("| ");
                            if (header[i].DataTypeName == "nvarchar")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                Console.Write(formatString, reader[i]);
                            }
                            else if (header[i].DataTypeName == "float")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("{0,20:N2} ", reader[i]);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("{0,20} ", reader[i]);
                            }
                            Console.ResetColor();
                        }
                        Console.WriteLine("|");
                    }
                }
            }
            catch (SqlException sqlE)
            {
                Console.WriteLine(sqlE.Message);
            }
        }
    }

    public Country CreateCountry(Country country)
    {
        string query = "INSERT INTO country (name, code, capital, province, area, population)" +
            "VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";
        using (SqlCommand command = new SqlCommand(query, connection))
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
                throw new Exception("Country could not be created");
            }
            return country;
        }
    }
    public void UpdateCountryName(string countryCode, string newCountryName)
    {
        string query = "UPDATE country SET name = @Name where code = @Code";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Name", newCountryName);
            command.Parameters.AddWithValue("@Code", countryCode);

            if (command.ExecuteNonQuery() == 0)
            {
                throw new Exception("Could not update country");
            }
        }
    }
    public void UpdateCountryPopulation(string countryCode, double newCountryPopulation)
    {
        string query = "UPDATE country SET population= @Population where code = @Code";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Population", newCountryPopulation);
            command.Parameters.AddWithValue("@Code", countryCode);

            if (command.ExecuteNonQuery() == 0)
            {
                throw new Exception("Could not update country");
            }
        }
    }

    public bool DeleteCountry(string countryCode)
    {
        string query = "DELETE from Country where code = @Code";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Code", countryCode);

            return command.ExecuteNonQuery() > 0;
        }
    }
}