using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Lukas.Week11.Models;

namespace Lukas.Week11
{
    public class DatabaseStart
    {
        public DatabaseStart()
        {
        }

        public static void Start()
        {
            string connectionString = @"Data Source=localhost; Initial Catalog=master;User=sa;Password=Test123#";

            Database database = new Database(connectionString);
            try
            {
                database.connect();


                Console.WriteLine("Has Lustenau been deleted?: "+database.DeleteCity("Lustenau", "A", "Vorarlberg"));

                List<City> cities = database.SearchCities("%erli%");
                foreach (var city in cities)
                {
                    Console.WriteLine(city.name + " " + city.country + " " + city.population);
                }


                Console.WriteLine("Does Vienna exist in Mondial: " + (database.SearchCities("Wien").Count > 0));
                Console.WriteLine("Does Lustenau exist in Mondial: " + (database.SearchCities("Lustenau").Count > 0));


                Console.WriteLine("Wer hilft mir Lustenau einzutragen?!1");

                City lustenau = new City("Lustenau", "A", "Vorarlberg", 23843.0, 47.26, 9.40, 404);
                database.CreateCity(lustenau);
                Console.WriteLine("Does Lustenau exist now in Mondial: " + (database.SearchCities("Lustenau").Count > 0));

                //Clean up created cities
                database.DeleteCity("Lustenau", "A", "Vorarlberg");
                database.DeleteCity("Lūstenæu", "A", "Vorarlberg");

                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();

                City fakeLustenau = new City("Lūstenæu", "A", "Vorarlberg", 23843.0, 47.26, 9.40, 404);
                database.CreateCity(fakeLustenau);
                Console.WriteLine("Does Lūstenæu exist: " + (database.SearchCities("Lūstenæu").Count > 0));
                Console.WriteLine("Does Lustenau exist: " + (database.SearchCities("Lustenau").Count > 0));

                City retrievedFakeLustenau = database.SearchCities("Lūstenæu")[0];
                Console.WriteLine("Fake Lustenau's name: " + retrievedFakeLustenau.name);

                fakeLustenau.name = "Lustenau";
                database.UpdateCity("Lūstenæu", "A", "Vorarlberg", fakeLustenau);

                Console.WriteLine("Does Lūstenæu exist: " + (database.SearchCities("Lūstenæu").Count > 0));
                Console.WriteLine("Does Lustenau exist: " + (database.SearchCities("Lustenau").Count > 0));
            }
            catch (SqlException exc)
            {
                Console.WriteLine("THAT FAILED!!!!!!!!!" + exc);
            }
            finally
            {
                database.close();
            }

        }
    }
}

