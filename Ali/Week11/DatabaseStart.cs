using Ali.Week11.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week11
{
    public class DatabaseStart
    {
        public DatabaseStart()  
        {
        
        } 
        public static void Start()
        {
            string connectionString= "server=localhost;port=3306;user=Ali;password=Denizli20@;database=Mondial";
            Database database = new Database(connectionString);
            try
            {
                database.connect();

                Console.WriteLine("Ein bestimmtes Land aus der Datenbank löschen");
                Console.WriteLine();
                Console.WriteLine("Has WanoKuni been deleted?: " + database.DeleteCountry("WanoKuni", "WK", "FlowerCapital"));
                Console.WriteLine();

                Console.WriteLine("Ein neues Land erstellen und in die Datenbank hinzufügen");
                Console.WriteLine();

                Countries WanoKuni = new Countries("WanoKuni", "WK", "FlowerCapital", "Oden", 567.3, 2300000.4);
                database.CreateCountry(WanoKuni);
                Console.WriteLine("Existiert WanoKuni in der Datenbank nun?: " + (database.SearchCountries("WanoKuni").Count > 0));
                Console.WriteLine("");

                //Console.WriteLine("Ein vorhandenes Land in der Datenbank bearbeiten" + (database.UpdateCountries("WanoKuni", "WK", "FlowerCapital", WanoKuni)));

                Countries fakeWanoKuni = new Countries("WanoKsuni", "WsK", "FlowerCapital", "Oden", 567.3, 2300000);
                database.CreateCountry(fakeWanoKuni);
                Console.WriteLine("Does WanoKKuni exist: " + (database.SearchCountries("WanoKKsuni").Count > 0));
                Console.WriteLine("Does WanoKuni exist: " + (database.SearchCountries("WanoKuni").Count > 0));

                //Countries retrievedFakeWanoKuni = database.SearchCountries("WanoKKuni")[0];
                //Console.WriteLine("Fake WanoKunis name: " + retrievedFakeWanoKuni.name);

                //fakeWanoKuni.name = "WanoKuni";
                //database.UpdateCountries("WanoKKuni", "WKS", "FlowerCapitalS", fakeWanoKuni);








            }
            
            
            
            
            
            
            catch (MySqlException exc)
            {
                Console.WriteLine("Fehlgeschlagen" + exc);
            }
            finally
            {
                database.close();
            }




        }
    }
}
