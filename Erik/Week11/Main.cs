using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Erik.Week11
{
    internal class Main
    {

        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=erikdittrich;Password=mmbbekjsix";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);
                Console.WriteLine("Connecting...");
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "%on";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;
                try
                {
                    Console.WriteLine("Successfully connected to database! \n");
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    PrintResult(dataReader);
                    dataReader.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }

        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(String.Format("{0,-13}", " | "));
                    }
                    Console.Write(dataReader[i]);
                }
                Console.WriteLine();
            }
        }
    }
}


