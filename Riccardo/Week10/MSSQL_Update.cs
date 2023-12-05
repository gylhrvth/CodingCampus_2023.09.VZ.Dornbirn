using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week10
{
    internal class MSSQL_Update
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:192.168.188.78,1433;User=gyula;Password=gyula";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("update city set Population = Population + @Amount where Name = @Name", connection);

                command.Parameters.Add("@Amount", SqlDbType.Int).Value = -1;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "Dornbirn";
                try
                {
                    command.Connection.Open();
                    int effectedRows = command.ExecuteNonQuery();

                    Console.WriteLine($"{effectedRows} rows has been updated.");
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }
    }
}
