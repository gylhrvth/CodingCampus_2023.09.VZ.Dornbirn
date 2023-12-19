using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week10.Create__Read__Update__Delete
{
    public class Main
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=simber;Password=simon";
            Country schlaraffenland = new Country("Schlaraffenland", "SL", "Paradis", "", int.MaxValue, 543655); //wie kann man Province z.B. leer lassen aka dass NULL drin steht?
            Country schlaraffenland1 = new Country("Schlaraffenland1", "SL1", "Paradis", "", int.MaxValue, 543655);

            Database database = new Database(connectionString);
            try
            {
                database.Sqlconnectionopen();

                Console.WriteLine("Do we need to Delete Schlaraffenland1?");
                if (database.SearchCountries("Schlaraffenland1").Count > 0)
                {
                    Console.WriteLine("Yes it exists.");
                    database.DeleteCountry("SL1");
                    Console.WriteLine("It was deleted.");
                }
                else
                {
                    Console.WriteLine("It does not exist and does not need to be deleted.");
                }

                Console.WriteLine("Does Schlaraffenland1 exist in Mondial? " );
                if (database.SearchCountries("Schlaraffenland1").Count > 0)
                {
                    Console.WriteLine("Yes it exists.");
                }
                else
                {
                    Console.WriteLine("No, we add Schlaraffenland1 to the Database.");
                    database.CreateCountry(schlaraffenland1);
                }
                Console.WriteLine("Whats its area?");
                Country getdata = database.SearchCountries("Schlaraffenland1")[0];
                Console.WriteLine(schlaraffenland1.Area);
                Console.WriteLine("We decreace the area by 10");
                schlaraffenland1.Area = schlaraffenland1.Area - 10;
                database.UpdateCountry("SL1", schlaraffenland1);
                Console.WriteLine(schlaraffenland1.Area);





            }
            catch (SqlException ex)
            {
                Console.WriteLine("The following Error occurred" + ex);
            }
            finally
            {
                database.Sqlconnectionclose();
            }
        }




    }
}
