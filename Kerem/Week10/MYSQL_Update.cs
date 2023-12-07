using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week10
{
    internal class MYSQL_Update
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=Fenerbahce1907.;database=Mondial";
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
