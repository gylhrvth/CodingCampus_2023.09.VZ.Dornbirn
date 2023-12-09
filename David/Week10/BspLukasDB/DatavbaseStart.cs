using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
using David.Week10.BspLukasDB;

namespace David.Week10.BspLukasDB
{
	public class DatavbaseStart
	{
		public DatavbaseStart()
		{
		}
		public static void Start()
		{
			string connectionString = "server=localhost;port=3306;user=david;pwd=david;database=mondial";
            Database database = new Database(connectionString);

            try
            {
				database.connect();
                database.DeleteCity("KD", "KönigCity", "Central Königreich");
                database.DeleteCity("KD", "KingCity", "Central Kingdom");

                // Exist the requested Cities?
                Console.WriteLine("Does Denmark exist in Mondial: " + (database.SearchCountry("Denmark").Count > 0));
				Console.WriteLine("Does the Kingdom of David exist in Mondial: " + (database.SearchCountry("Kingdom of David").Count > 0));

				// Create the missing City.
				Console.WriteLine("Creating now the Kingdom of David");

				Country kingdomOfDavid = new Country("Kingdom of David", "KD", "KingCity", "Central Kingdom", 18000000, 150000000);
				database.CreateCountry(kingdomOfDavid);
                Console.WriteLine("Does the Kingdom of David exist in Mondial: " + (database.SearchCountry("Kingdom of David").Count > 0));

				// Update the Population
				//Country receiveName = database.SearchCountry("KingCity")[2];
				//Console.WriteLine("Updating the Name: " + receiveName.capital);

				//kingdomOfDavid.capital = "KingCity";
				//database.UpdateCountry("KD", "KönigsStadt", "Central Kingdom", kingdomOfDavid);
				//Console.WriteLine("Neuer Name der Stadt = KönigsStadt: " + (database.SearchCountry("KönigsStadt").Count > 0));

                //Zurück
                //kingdomOfDavid.capital = "KönigsStadt";
               //database.UpdateCountry("KD", "KingCity", "Central Kingdom", kingdomOfDavid);


                // Delete the new City again.
                Console.WriteLine("Delting Kingdom of David agian.");
				database.DeleteCity("KD", "KingCity", "Central Kingdom");

                //Check if deleted.
                Console.WriteLine("Does the Kingdom of David exist in Mondial: " + (database.SearchCountry("Kingdom of David").Count > 0));

                // Delete a City that doesn't exist to prove the Exeption
               database.DeleteCity("KD", "KingCity", "Central Kingdom");


            }

            catch (MySqlException ex)
			{
				Console.WriteLine("Unfortunately this failed for the following reason: " + ex);
			}

			finally
			{
				database.close();
			}



        }
	}
}

