
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Fabian.Week10.MySQL
{
    internal class SQLUpdateCity
    {
        private static string connectionString = "server=localhost;port=3306;user=root;password=?Krfa2006?;database=Mondial";
        public static void Start()
        {
           
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string city;
                do
                {
                    Console.Write("Enter the city u want to select: ");
                    city = Console.ReadLine();
                } while (!IsValidCity(connection, city));

                int amount = 0;

                while(amount == 0)
                {
                    Console.Write("How many people do u want to add to the population? ");
                    try
                    {
                        amount = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is too high!");
                    }
                }
                          
                MySqlCommand command = new MySqlCommand("update city set Population = Population + @Amount where Name = @Name", connection);

                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@Name", city);

                int effectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{effectedRows} rows were affected.");
            }
            catch (MySqlException se)
            {
                switch (se.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine(se.Message + " error code: " + se.Number);
                        break;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsValidCity(MySqlConnection conn, string city)
        {
            MySqlCommand command = new MySqlCommand("select * from city where name = @City", conn);
            command.Parameters.AddWithValue("@City", city);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            Console.WriteLine("Not a valid city!");
            return false;
        }



    }
}
