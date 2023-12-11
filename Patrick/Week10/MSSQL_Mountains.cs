using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week10
{
    internal class MSSQL_Mountains
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("select gm.Mountain as Berg, m.Elevation as BergHöhe, c.Name as Land \r\nFROM geo_Mountain as gm\r\nJOIN Country as c on gm.Country = c.Code\r\nJOIN Mountain as m on gm.Mountain = m.Name;\r\n", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    PrintResult(reader);
                    connection.Close();
                }catch(SqlException se)
                {
                    Console.WriteLine(se.Message);
                }

            }
        }

        public static void PrintResult(SqlDataReader reader)
        {
            List<DbColumn> header = reader.GetColumnSchema().ToList();
            
            for (int i = 0; i < header.Count; i++)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                //Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + " " + header[i].ColumnSize + " ,");
                Console.Write("| ");
                if (header[i].DataTypeName == "nvarchar")
                {
                    Console.Write($"{header[i].ColumnName,-50} ");
                }
                else if (header[i].DataTypeName == "float")
                {
                    Console.Write($"{header[i].ColumnName,8} ");
                }               
            }
            Console.WriteLine("|");
            Console.ResetColor();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetDataTypeName(i).Equals("nvarchar"))
                    {
                        Console.Write($"| {reader[i], -50} ");
                    }
                    else if (reader.GetDataTypeName(i).Equals("float"))
                    {
                        Console.Write($"| {reader[i], 8} ");
                    }
                }
                Console.WriteLine("| ");
            }
        }

    }
}
