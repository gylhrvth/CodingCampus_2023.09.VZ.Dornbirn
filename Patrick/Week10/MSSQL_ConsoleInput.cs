using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week10
{
    internal class MSSQL_ConsoleInput
    {
        public static void Start()
        {
            // userinput city name 
            string city = UserInputCity();

            // check if city name exists in table          
            CheckIfCityExists(city);

            // ask for number to add to population
            int populationToAdd = UserInputPopulation();

            // update population 
            AddInputPopulation(city, populationToAdd);



        }

        public static void PrintResult(SqlDataReader reader)
        {
            List<DbColumn> header = reader.GetColumnSchema().ToList();


            for (int i = 0; i < header.Count; i++)
            {
                //Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + " " + header[i].ColumnSize + " ,");
                Console.Write("|");
                if (header[i].DataTypeName == "nvarchar")
                {
                    Console.Write($"{header[i].ColumnName,-50}");
                }
                else if (header[i].DataTypeName == "float")
                {
                    Console.Write($"{header[i].ColumnName,12}");
                }
            }
            Console.WriteLine("|");
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetDataTypeName(i).Equals("nvarchar"))
                    {
                        Console.Write($"|{reader[i],-50}");
                    }
                    else if (reader.GetDataTypeName(i).Equals("float"))
                    {
                        Console.Write($"|{reader[i],12}");
                    }

                }
                Console.WriteLine("|");
            }

        }

        public static bool ExistCity(SqlDataReader reader)
        {
            while (reader.Read())
            {
                return true;
            }
            return false;
        }

        public static string UserInputCity()
        {
            Console.WriteLine("Geben Sie die gewünschte Stadt ein: ");
            Console.Write(">>>>>");
            string city = Console.ReadLine();
            return city;
        }

        public static void CheckIfCityExists(string city)
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comand = new SqlCommand("SELECT Name, Population\r\nFROM city\r\nWHERE city.Name = @city", connection);
                comand.Parameters.AddWithValue("@city", city);               

                try
                {
                    connection.Open();
                    SqlDataReader reader = comand.ExecuteReader();
                    
                    if (ExistCity(reader) == true)
                    {
                        Console.WriteLine("Diese Stadt wurde gefunden!");
                    }
                    else if(ExistCity(reader) == false)
                    {
                        Console.WriteLine("Diese Stadt wurde NICHT gefunden");
                    }
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void AddInputPopulation(string city, int population)
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comand = new SqlCommand("SELECT Name, Population, Population + @Addpop as 'Sum of pop' \r\nFROM city\r\nWHERE city.Name = @city", connection);
                comand.Parameters.AddWithValue("@city", city);
                comand.Parameters.AddWithValue("@Addpop", population);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comand.ExecuteReader();
                    PrintResult(reader);
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static int UserInputPopulation()
        {
            Console.WriteLine("Geben Sie die Anzahl der Personen die Sie dazu addieren wollen an!");
            Console.Write(">>>>>");
            string popString = Console.ReadLine();
            int pop = Int32.Parse(popString);
            return pop;
        }

    }
}
