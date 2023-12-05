using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week10
{
    public class MSSQLtest
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tpc: localHost,1433;User=simber;Password=";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commmand = new("select c.* from city join country co on c.Country = co.Code where co.Name = 'Austria'", connection);
                try
                {
                    commmand.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using SqlDataReader reader = commmand.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader[i] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }


    }
}
