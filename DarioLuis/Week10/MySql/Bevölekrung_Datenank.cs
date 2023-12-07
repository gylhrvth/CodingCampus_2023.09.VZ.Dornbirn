using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week10.MySql
{
    public class Bevölekrung_Datenank
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=DarAndrad;password=Abruf!3300;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

            Question();
        }

        public static void Question()
        {
            try
            {
                //Abfrage Stadt
                Console.WriteLine("Hallo, bei welcher Stadt wollen sie die Bevölkerungsanzahl verändern?");
                string city = Console.ReadLine().ToLower();
                
                //Abfrage Anzahl
                Console.WriteLine("Wie viele Personen sollen hinzugefügt werden?");
                int population = Convert.ToInt32(Console.ReadLine());

                if (population > 10000) 
                {
                    Console.WriteLine("Soviele können sie nicht hinzugügen.");
                }
            }
            catch (MySqlException se)
            {
                Console.WriteLine("Diese Stadt ist nicht im System");
            }
            
            
        }
    }
}
