using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week10
{
    public class MySQL
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=Fabienne;password=fabienne;database=mondial";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Hello! Please name a city you want to add people to the Population: ");
                string city = Console.ReadLine(); //welche stadt

                Console.WriteLine("How much people do you want to add?: ");
                int population = Convert.ToInt32(Console.ReadLine()); //wieviel geadded werden muss

                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Population FROM City WHERE Name = @Name", connection);

                command.Parameters.AddWithValue("@Name", city);






                MySqlCommand command1 = new MySqlCommand("UPDATE City SET Population = Population + @Amount WHERE Name = @Name", connection);

                command1.Parameters.AddWithValue("@Amount", population);

                int effectedRows = command.ExecuteNonQuery();
                int effectedRows1 = command1.ExecuteNonQuery();
                Console.WriteLine($"{effectedRows} rows has been updated.");
                Console.WriteLine($"{effectedRows1} rows has been updated.");
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}