using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace Mehmet.Week11
{
    internal class SQL_PreparedStatement
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Mehmet;Password=Mehmet";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select ci.Name, ci.Province, ci.Population \r\n\tFrom City ci\r\n\tJoin Country c on c.Code = ci.Country\r\n\twhere c.Name = 'Austria'", connection);

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "%on";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;
                try
                {
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    PrintResult(dataReader);
                    dataReader.Close();
                }
                catch(SqlException se) 
                {
                    Console.WriteLine(se.Message);
                }
            }
        }
        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            for(int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(header[i].ColumnName);
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0;i < dataReader.FieldCount;i++)
                {
                    if ( i > 0)
                    {
                        Console.Write(" | ");
                    }
                    Console.Write(dataReader[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
