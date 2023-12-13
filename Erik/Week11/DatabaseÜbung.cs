using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Erik.Week11
{
    internal class DatabaseÜbung
    {
        public static void Start()
        {
            while (true)
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString());
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Commands: 'exit'  'clear'  'addpop'  'deletepop' \n");
                Console.ResetColor();
                string userInput = ReadUserInputWithMessage("Enter a City: ");

                SqlCommand cmd = new SqlCommand("select Country.Name as Country ,City.Name , City.Population " +
                                                "from City " +
                                                "join Country on City.Country = Country.Code " +
                                                "where City.Name = @userInput", sqlConnection);
                
                cmd.Parameters.AddWithValue("@userInput", userInput);

                ProcessUserInput(userInput, sqlConnection);
                try
                {
                    cmd.Connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        PrintDB(reader);
                    }
                }
                catch (SqlException sqlex)
                {
                    Console.WriteLine(sqlex.Message);
                }
                string userInputNext = ReadUserInputWithMessage("Enter or command or a new city: ");
                ProcessUserInput(userInputNext, sqlConnection);

            }
        }

        public static string ConnectionString()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=erikdittrich;Password=mmbbekjsix";
        }

        public static string ReadUserInputWithMessage(string message)
        {
            string userInput = "placeholder";
            Console.Write(message);
            userInput = Console.ReadLine().ToLower();
            Console.WriteLine();
            return userInput;
        }


        public static int ReadUserNumberWithMessage(string message)
        {
            int userInput = 0;
            Console.Write(message);
            userInput = Int32.Parse(Console.ReadLine().ToLower());
            Console.WriteLine();
            return userInput;
        }


        public static string ProcessUserInput(string FirstuserInput, SqlConnection sqlConnection)
        {
            switch (FirstuserInput)
            {
                case "exit":
                    {
                        Environment.Exit(0);
                        break;
                    }

                case "clear":
                    {
                        Console.Clear();
                        Start();
                        break;
                    }
                case "addpop":
                    {
                        Console.Write("Enter a value to ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("increase ");
                        Console.ResetColor();
                        Console.Write($"the Population value: ");

                        int userAmountInput = Int32.Parse(Console.ReadLine());
                        SqlCommand cmd = new SqlCommand("update city set Population = Population + @userAmountInput " +
                                                        "where Name = '@cityUserInput'", sqlConnection);

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();



                        cmd.Parameters.AddWithValue("@cityUserInput", FirstuserInput);
                        cmd.Parameters.AddWithValue("@userAmountInput", userAmountInput);

                        Start();
                        break;
                    }
                case "deletepop":
                    {

                        break;
                    }
            }
            return "Error on ProcessUserInput";
        }

        public static void PrintDB(SqlDataReader reader)
        {
            List<DbColumn> header = reader.GetColumnSchema().ToList();

            if (!reader.HasRows)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("City not found! Try again! \n");
                Console.ResetColor();
            }

            foreach (DbColumn column in header)
            {
                Console.Write(column.ColumnName + "   |    ");
            }
            Console.WriteLine("\n");
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "      |      ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}
