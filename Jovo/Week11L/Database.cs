using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Jovo.Week11L.Models;


namespace Jovo.Week11L;

internal class Database
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
        connection.Close();
    }

    public List<Country> SearchCountries(string searchTerm)
    {
        List<Country> countries = new List<Country>();

        string query = "Select *\r\nFROM Country";
        using(SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@SearchTerm", searchTerm);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Country country = new Country();

                }
            }
        }

    }

 


    public Country CreatyCountry(Country country)
}
