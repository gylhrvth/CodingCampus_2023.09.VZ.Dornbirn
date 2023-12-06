using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Patrick.Week10
{
    internal class MSSQL_ConnectionExample
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT *\r\nFROM City", connection);

                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader[i] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                } catch (SqlException sqlE)
                {
                    Console.WriteLine(sqlE.Message);
                }
            }
        }
    }
}
