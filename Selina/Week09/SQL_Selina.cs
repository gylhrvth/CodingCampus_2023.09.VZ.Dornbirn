using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Selina.Week09
{
    public class SQL_Selina
    {
        public static void Start()
        {
            string connenctionString = "Persist Security Info=False;Initial Catalog=Mondial; server=tcp:localHost; user= wpfsebr";

            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                SqlCommand cmd = new SqlCommand("select * from city when Name like @Nameand Population > @Pop");

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "%on";
                cmd.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000;
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    PrintResult(dataReader);
                    dataReader.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
                    Console.WriteLine(" | ");
                }
                Console.WriteLine(header[i].ColumnName);
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if(i>0)
                    {
                        Console.WriteLine(" | ");
                    }
                    Console.WriteLine(dataReader[i]);
                }
                Console.WriteLine();
            }
        }

    }
}
