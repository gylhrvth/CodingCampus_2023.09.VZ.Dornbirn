
using MySql.Data.MySqlClient;

namespace Fabian.Week11.MySQL
{
    internal class UpdateCityPopulation
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=?Krfa2006?;database=Mondial";
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

                while (amount == 0)
                {
                    Console.Write("How many people do u want to add to the population? ");
                    try
                    {
                        amount = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
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
                command.Parameters.AddWithValue("@City", city);

                MySqlCommand populationCommand = new MySqlCommand("SELECT Population FROM city WHERE Name = @City", connection);
                populationCommand.Parameters.AddWithValue("@City", city);

                MySqlDataReader reader = populationCommand.ExecuteReader();
                reader.Read();
                Console.WriteLine($"The population of {city} has been updated to {reader.GetValue(0)}.");
                reader.Close();

            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message + " error code: " + se.Number);
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
            Console.WriteLine($"'{city}' is not a valid city!");
            return false;
        }



    }
}
