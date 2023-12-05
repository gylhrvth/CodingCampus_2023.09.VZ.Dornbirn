using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Dimitri.Week10.MSSql
{
    internal class MSSql
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select top 10 * from lake where name like @name and depth > @depth", connection);

                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 50).Value = "%A";
                cmd.Parameters.Add("@depth", System.Data.SqlDbType.Float).Value = 0f;
                try
                {
                    cmd.Connection.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        PrintResult(dataReader);
                        dataReader.Close();

                    }
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
            //for (int i = 0; i < header.Count; i++)
            //{
            //    if (i > 0)
            //    {
            //        Console.Write(" | ");
            //    }
            //    Console.Write(header[i].DataTypeName + "[" + header[i].ColumnSize + "]");
            //}
            //Console.WriteLine();
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                if (header[i].DataTypeName.CompareTo("nvarchar") == 0)
                {
                    Console.Write($"{header[i].ColumnName,-25}");
                }
                else if (header[i].DataTypeName.CompareTo("float") == 0)
                {
                    Console.Write($"{header[i].ColumnName,-10}");
                }

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
                    if (dataReader.GetDataTypeName(i).CompareTo("nvarchar") == 0)
                    {
                        Console.Write("{0,-25}", dataReader[i]);
                    }
                    else if (dataReader.GetDataTypeName(i).CompareTo("float") == 0)
                    {
                        Console.Write("{0,10}", dataReader[i]);
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

