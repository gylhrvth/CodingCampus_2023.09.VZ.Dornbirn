using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Selina.Week10
{
    public class ConnectExample
    {
        public static void Start()
        {
            string connenctionString = "Persist Security Info=False;Initial Catalog=Mondial; server=tcp:localHost,1433, User = wpfsebr";

            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                SqlCommand cmd = new SqlCommand("select 'Hello World!' as Text", conn);
                try
                {
                    cmd.Connection.Open();
                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();
                        for(int i = 0; i < header.Count; i++)
                        {
                            Console.WriteLine(header[i].ColumnName + " " + header[i].DataTypeName+ "[" + header[i].ColumnSize + "] ");
                        }
                        Console.WriteLine();

                        while (reader.Read())
                        {
                            for(int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader[0]);
                            }
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
