using System;
using System.Collections.Generic;
using System.Data.Common;
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
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Jovo;Password=jovo13696";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select ci. *\r\n\tFrom City ci\r\n\tJoin Country c on c.Code = ci.Country\r\n\twhere c.Name = 'Austria'", connection);

                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();
                    
                        foreach(DbColumn column in header)
                        {
                            Console.Write($"{column.ColumnName, -18} | "); // 15 ist fixe breite
                        }
                        Console.WriteLine();


                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                               string value = reader[i].ToString();
                                if (header[i].DataTypeName == "float") 
                                {
                                    Console.Write($"{value,18} | "); // Rechtsbündig
                                }
                                else
                                {
                                    Console.Write($"{value, -18} | ");
                                }
                            }
                            Console.WriteLine();
                        }
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
