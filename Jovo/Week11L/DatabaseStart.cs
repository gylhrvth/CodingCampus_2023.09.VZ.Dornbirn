using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jovo.Week11L.Models;

namespace Jovo.Week11L.Models
{
    internal class DatabaseStart
    {
        public DatabaseStart() 
        {
        }


        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Jovo;Password=jovo13696";

            Database database = new Database(connectionString);

            try
            {
                database.connect();

                


                List<Country> countries = database.SearchCountries("%str%");
                foreach ( var country in countries ) 
                {
                    Console.WriteLine(country.Name + " " + country.Code + " " + country.Population);

                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }


        }
    }
}
