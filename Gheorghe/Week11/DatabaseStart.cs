
using Gheorghe.Week11;
using Gheorghe.Week11.Models;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace Gheorghe.Week11
{
    public class DatabaseStart
    {
        public static void Start()
        {
            // Establish a connection to the database
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=gheorghe;Password=Eldad100";
            Database database = new Database(connectionString);

            try
            {
                database.Connect();

                // Create a new country
                Country country = new Country
                {
                    Name = "Austria",
                    Code = "A",
                    Capital = "Vienna",
                    Population = 8885671
                };

                database.DeleteCountry("A");

                // Insert the new country into the database
                database.CreateCountry(country);

                // Read the first country from the database
                Console.WriteLine("Retrieved countries: ");
                Country germany = database.ReadCountry("Germany");
                Console.WriteLine("Germany: " + germany.Name);

                //foreach (Country retrievedCountry in Country.ReadAllCountries())
                //{
                //    Console.WriteLine($"{retrievedCountry.name} , {retrievedCountry.continent} , {retrievedCountry.population}");
                //}

                //// Update the first country in the 
                Country updatedCountry = database.ReadCountry("Austria");
                updatedCountry.Name = "Österreich"; // Update the country's name
                database.UpdateCountry("A", updatedCountry);
                


                //// Delete all countries from the database
                //Country.DeleteAllCountries();

                //// Set the country parameter to null
                //command.Parameters.AddWithValue("@country", null);

                //// Execute the command
                //command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                database.Close();
            }
        }
    }
}