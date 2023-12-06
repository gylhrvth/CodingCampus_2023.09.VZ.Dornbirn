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
            Console.WriteLine("The lakes of what land you wanna know?");
            string land = Console.ReadLine();
            Console.WriteLine();
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select la.* from geo_lake as l join country as co on l.Country = co.Code join lake as la on la.Name = l.lake where co.Name = @LandSelect", connection);

                cmd.Parameters.Add("@LandSelect", System.Data.SqlDbType.NVarChar, 50).Value = land;
                try
                {
                    cmd.Connection.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        PrintResult(dataReader);
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
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(header[i].DataTypeName + "[" + header[i].ColumnSize + "]");
            }
            Console.WriteLine();
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

