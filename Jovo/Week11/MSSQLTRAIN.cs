using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jovo.Week11
{
    internal class MSSQLTRAIN
    {
        public static void Start()
        {
            //verbinden vom server 
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Jovo;Password=jovo13696";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {


                //Eingeben was ich aufrufen will
                SqlCommand command = new SqlCommand("");




                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader()) 
                    { 
                        while(reader.Read())
                        {
                            for(int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader[i] + " ");
                            }
                            Console.WriteLine(reader[0]);
                        }
                    }


                }
                catch (SqlException sqlE)
                {
                    Console.WriteLine(sqlE.Message);
                }
            }
        }
    }
}
