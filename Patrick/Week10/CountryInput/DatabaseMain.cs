using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week10.CountryInput
{
    public class DatabaseMain
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";
            Database database = new Database(connectionString);

            try
            {              
                database.Connect();
                Console.WriteLine("Die Verbindung wurde aufgebaut!");

                Console.WriteLine("Ist Lustenau in der Datenbank vorhanden? " + (database.SearchCountry("Lustenau").Count > 0));

                //Create New Country
                Country country = new Country("Austria", "A", "Wien", "Wien", 83850, 8401940);
                database.CreateCountry(country);

                //Console.WriteLine("Ist Austria in der Datenbank vorhanden? " + (database.SearchCountry("Austria").Count > 0));
                Console.WriteLine("Ist Lustenau JETZT NACH DEM ERSTELLEN in der Datenbank vorhanden? " + (database.SearchCountry("Lustenau").Count > 0));


                //Search Country
                List<Country> selectedCountries = database.SearchCountry("%A");
                foreach (Country country2 in selectedCountries)
                {
                    Console.WriteLine(country2.Name + " " + country2.Capital + " " + country2.Population);
                }

                //Delete Country
                database.DeleteCountry(country);
                Console.WriteLine("Ist Lustenau NACH DEM LÖSCHEN vorhanden? " + (database.SearchCountry("Lustenau").Count > 0));


                //Úpdate a Country
                database.UpdateCountry("A", country);
               
          
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                database.Disconnect();
            }



        }

    }
}
