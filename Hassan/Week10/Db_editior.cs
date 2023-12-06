using MySql.Data.MySqlClient;

namespace Hassan.Week10
{
    public class Db_editior
    {
        public static void Start()
        {
            string connentionString = "server=localhost;port=3306;user=root;password=Hassan.1407;database=Mondial";
            MySqlConnection conn = new MySqlConnection(connentionString);

            try
            {
                conn.Open();

                string city = GetUserInput("Gib den Namen der Stadt ein (oder 'exit' zum Beenden): ");
                while (city.ToLower() != "exit")
                {
                    int populationIncrease = GetPopulationIncrease();

                    if (CityExists(conn, city))
                    {
                        UpdatePopulation(conn, city, populationIncrease);
                    }
                    else
                    {
                        Console.WriteLine("Stadt existiert nicht.");
                    }

                    city = GetUserInput("Gib den Namen der Stadt ein (oder 'exit' zum Beenden): ");
                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                conn.Close();
            }

        }

      

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetPopulationIncrease()
        {
            int populationIncrease;
            while (true)
            {
                Console.Write("Gib die Bevölkerungserhöhung ein: ");
                if (int.TryParse(Console.ReadLine(), out populationIncrease))
                {
                    return populationIncrease;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
                }
            }
        }

        public static bool CityExists(MySqlConnection conn, string cityName)
        {
            MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM city WHERE Name = @Name", conn);
            checkCommand.Parameters.AddWithValue("@Name", cityName);
            MySqlDataReader checkDataReader = checkCommand.ExecuteReader();
            bool exists = checkDataReader.HasRows;
            checkDataReader.Close();
            return exists;
        }


        public static void UpdatePopulation(MySqlConnection conn, string cityName, int populationIncrease)
        {
            MySqlCommand updateCommand = new MySqlCommand("UPDATE city SET Population = Population + @PopulationIncrease WHERE Name = @Name", conn);
            updateCommand.Parameters.AddWithValue("@PopulationIncrease", populationIncrease);
            updateCommand.Parameters.AddWithValue("@Name", cityName);
            int rowsAffected = updateCommand.ExecuteNonQuery();

            if (rowsAffected == 1)
            {
                Console.WriteLine($"Bevölkerung für {cityName} wurde um {populationIncrease} erhöht.");

                // Ausgabe der aktualisierten Informationen
                MySqlCommand queryCommand = new MySqlCommand("SELECT Name, Population FROM city WHERE Name = @Name", conn);
                queryCommand.Parameters.AddWithValue("@Name", cityName);
                MySqlDataReader dataReader = queryCommand.ExecuteReader();
                PrintResult(dataReader);
                dataReader.Close();
            }
            else
            {
                Console.WriteLine($"Es gab ein Problem beim Aktualisieren der Bevölkerung für {cityName}.");
            }
        }


        public static void PrintResult(MySqlDataReader dataReader)
        {
            while (dataReader.Read())
            {
                string cityName = dataReader.GetString("Name");
                int population = dataReader.GetInt32("Population");

                Console.WriteLine($"Stadt: {cityName}, Population: {population}");
            }
        }

    }
}
