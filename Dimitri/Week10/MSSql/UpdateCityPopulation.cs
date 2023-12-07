using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.MSSql
{
    internal class UpdateCityPopulation
    {
        public static int Population = 0;
        public static void Start()
        {
            string promptCity = "Enter the name of the city you wanna update.";
            string city = UserInputCity(promptCity);

            while (!CheckIfCityExists(city))
            {
                city = UserInputCity(promptCity);
            }

            string promptPopulation = string.Format("Enter the number of people you wanna add to the {0}.", city);
            int numberPopulation = UserInputPopulation(promptPopulation);

            if(UpdatePopulation(city, numberPopulation))
            {
                Console.WriteLine("updated the population of {0} from {1} to {2}", city, Population, (Population + numberPopulation));
            } else
            {
                Console.WriteLine("couldn't update the population.");
            }
        }


        public static string UserInputCity(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public static bool CheckIfCityExists(string cityName)
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from city where name = @cityInput", connection);

                cmd.Parameters.Add("@cityInput", System.Data.SqlDbType.NVarChar, 50).Value = cityName;
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return CheckForStringInReader(cityName, reader);
                    }
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.Message);
                }

                return false;
            }
        }

        public static bool CheckForStringInReader(string cityName, SqlDataReader dataReader)
        {
            while (dataReader.Read())
            {
                if (dataReader.GetString(0).Equals(cityName, StringComparison.OrdinalIgnoreCase))
                {
                    Population = Int32.Parse(dataReader.GetValue(3).ToString());
                    return true;
                }
            }
            return false;

        }

        public static int UserInputPopulation(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    int input = Int32.Parse(Console.ReadLine());
                    return input;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Your number doesn't seem quite right. Please enter a correct number.");
                } catch (OverflowException oe)
                {
                    Console.WriteLine("Your number was to high. Please enter a smaller number.");
                }
            }
        }

        public static bool UpdatePopulation(string cityName, int inputNumberToAdd)
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Update city SET population = population + @numberToAdd where name = @cityInput", connection);

                cmd.Parameters.Add("@cityInput", System.Data.SqlDbType.NVarChar, 50).Value = cityName;
                cmd.Parameters.Add("@numberToAdd", System.Data.SqlDbType.Float, 8).Value = inputNumberToAdd;
                try
                {
                    connection.Open();
                    int outcome = cmd.ExecuteNonQuery();
                    Console.WriteLine(outcome);
                    connection.Close();
                    return true;
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.Message);
                }

                return false;
            }

        }
    }
}

