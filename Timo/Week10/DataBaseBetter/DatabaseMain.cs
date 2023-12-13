using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Timo.Week10.DataBaseBetter.Models;

namespace Timo.Week10.DataBaseBetter;
public class DatabaseMain
{
    public DatabaseMain()
    {
    }

    public static void Start()
    {
        string connectionString = @"Data Source=localhost; Initial Catalog=mondial; User=Timo; Password=Timo1234";
        Database database = new Database(connectionString);
        try
        {
            database.connect();

            database.ShowCountry("Austria");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            database.DeleteCountry("DT");
            Console.WriteLine("Does Diktatur Timostan exist in Mondial: " + (database.SearchCountries("Diktatur Timostan").Count > 0));
            Console.WriteLine("Create Diktatur Timostan: ");
            Country Timostan = new Country("Diktatur Timostan", "DT", "TimoTown", "Timotra", 76853, 300);
            database.CreateCountry(Timostan);
            Console.WriteLine("Does Diktatur Timostan exist in Mondial: " + (database.SearchCountries("Diktatur Timostan").Count > 0));
            database.ShowCountry("Diktatur Timostan");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            
            database.UpdateCountryName("DT", "Timostatan");
            Console.WriteLine("Updated Diktatur Timostan to Timostatan: ");
            Console.WriteLine("Does Diktatur Timostan exist in Mondial: " + (database.SearchCountries("Diktatur Timostan").Count > 0));
            Console.WriteLine("Does Timostatan exist in Mondial: " + (database.SearchCountries("Timostatan").Count > 0));
            database.ShowCountry("Timostatan");
            Console.WriteLine("People living in Timostatan are having to much time: ");
            database.UpdateCountryPopulation("DT", 553464);
            database.ShowCountry("Timostatan");

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Delete Timostatan");
            Console.WriteLine("Has Timoststan been deleted? " + database.DeleteCountry("DT")); 
            
            Console.WriteLine("Does Timostatan exist in Mondial: " + (database.SearchCountries("Timostatan").Count > 0));
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
