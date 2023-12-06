using System.Data;
using System.Data.Common;
using System.Data.SqlClient;




namespace Gheorghe.Week10
{
    public class MSSQL
    {
        public static void Start()
        {
            string conectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=gheorghe;Password=Eldad100";
            using (SqlConnection conection = new SqlConnection(conectionString))
            {
                SqlCommand command = new SqlCommand("select * from city where Name Like @Name and Population > @Pop", conection);
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "%on";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;
                try
                {
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
            for (int i = 0; i < header.Count; i++)
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
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
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


   

