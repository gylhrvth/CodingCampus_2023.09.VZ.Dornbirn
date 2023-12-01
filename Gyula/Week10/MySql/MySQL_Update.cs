using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gyula.Week10.MySql
{
    public class MySQL_Update
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=gyula;password=gyula;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("update city set Population = Population + @Amount where Name = @Name", connection);

                command.Parameters.AddWithValue("@Amount", -1);
                command.Parameters.AddWithValue("@Name", "Graz");

                int effectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{effectedRows} rows has been updated.");
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

