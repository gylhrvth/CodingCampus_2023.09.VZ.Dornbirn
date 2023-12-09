using Mehmet.Week11.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week11
{
    internal class DataBaseStart
    {
        public static void Start()
        {
            string connectionString = @"Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=Mehmet;Password=Mehmet";

            DataBase database = new DataBase(connectionString);

            try
            {
                database.Connect();
             
                List<City> cities = database.SearchCities("%erli%");
                foreach (City city in cities)
                {
                    Console.WriteLine($"{city._Name} {city._Country} {city._Population}");
                }

                Console.WriteLine("Does Vienna exist in Mondial: " + (database.SearchCities("Wien").Count > 0));
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine("Does Lustenau exist in Mondial: " + (database.SearchCities("Lustenau").Count > 0));
                City lustenau = new City("Lustenau", "A", "Vorarlberg", 23843.0, 47.26, 9.40, 404);
                database.CreateCity(lustenau);
                Console.WriteLine("Does Lustenau exist now in Mondial: " + (database.SearchCities("Lustenau").Count > 0));
                Console.WriteLine("------------------------------------------------------------------------------------");


                database.DeleteCity("Lustenau", "A", "Vorarlberg");
                database.DeleteCity("Lūstenæu", "A", "Vorarlberg");
                Console.WriteLine("Does Lustenau exist in Mondial: " + (database.SearchCities("Lustenau").Count > 0));
                Console.WriteLine("------------------------------------------------------------------------------------");


                City fakeLustenau = new City("Lūstenæu", "A", "Vorarlberg", 23843.0, 47.26, 9.40, 404);
                database.CreateCity(fakeLustenau);
                Console.WriteLine("Does Lūstenæu exist: " + (database.SearchCities("Lūstenæu").Count > 0));
                Console.WriteLine("Does Lustenau exist: " + (database.SearchCities("Lustenau").Count > 0));

                City retrievedFakeLustenau = database.SearchCities("Lūstenæu")[0];
                Console.WriteLine("Fake Lustenau's name: " + retrievedFakeLustenau._Name);

                fakeLustenau._Name = "Lustenau";
                database.UpdateCity("Lūstenæu", "A", "Vorarlberg", fakeLustenau);

                Console.WriteLine("Does Lūstenæu exist: " + (database.SearchCities("Lūstenæu").Count > 0));
                Console.WriteLine("Does Lustenau exist: " + (database.SearchCities("Lustenau").Count > 0));






            }
            catch (SqlException exq)
            {
                Console.WriteLine("MISSION FAILED!!!"+exq);
            } finally
            {
                database.Close();
            }

            



        }

      
    }
}
