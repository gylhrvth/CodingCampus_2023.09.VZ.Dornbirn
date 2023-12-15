using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Selina.Week10.Aufgabe_03
{

    public class Database
    {
        private string connectionString;
        private SqlConnection connection;
        public static ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.DarkBlue, ConsoleColor.Blue, ConsoleColor.DarkMagenta, ConsoleColor.Blue, ConsoleColor.Cyan };

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            Disconnect();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void Disconnect()
        {
            connection?.Close();
        }
        public bool CityIsInTheQuery(string cityName)
        {
            using (SqlCommand conn = new SqlCommand(connectionString))
            {
                bool cityExists = false;
                try
                {
                    conn.Parameters.Add("@Name", SqlDbType.NVarChar).Value = cityName;
                    SqlDataReader dataReader = conn.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        cityExists = true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return cityExists;
            }
        }
        public Country CreateCountry(Country country)
        {
            string updateQuery = "INSERT INTO Country (name, code, capital, province, area, population) VALUES (@Name, @Code, @Capital, @Province, @Area, @Population)";

            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@Name", country.Name);
                cmd.Parameters.AddWithValue("@Code", country.Code);
                cmd.Parameters.AddWithValue("@Capital", country.Capital);
                cmd.Parameters.AddWithValue("@Province", country.Province);
                cmd.Parameters.AddWithValue("@Area", country.Area);
                cmd.Parameters.AddWithValue("@Population", country.Population);

                int rows = cmd.ExecuteNonQuery();

                if(rows == 0)
                {
                    throw new Exception("Etwas ist schief gelaufen, das Land wurde nicht erstellt!!");
                }
                return country;
            }
        }
        public bool DeleteCountry(string name, string code, string capital)
        {
            string deleteQuery = "DELETE FROM Country Where Name = @Name And Code = @Code And Capital = @Capital";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Country", code);
                command.Parameters.AddWithValue("@Province", capital);

                return command.ExecuteNonQuery() > 0;
            }
        }
        public Country UpdateCountry(string name, string code, string capital, Country updatedCountry)
        {
            string updateQuery = "UPDATE Country SET name = @Name, code = @Code, capital = @Capital, province = @Province, area = @Area, population = @Population" +
                                 "Where name = @QueryName AND code = @QueryCode AND capital = @QueryCapital";

            using (SqlCommand command = new SqlCommand (updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", updatedCountry.Name);
                command.Parameters.AddWithValue("@Code", updatedCountry.Code);
                command.Parameters.AddWithValue("@Capital", updatedCountry.Capital);
                command.Parameters.AddWithValue("@Province", updatedCountry.Province);
                command.Parameters.AddWithValue("@Area", updatedCountry.Area);
                command.Parameters.AddWithValue("@Population", updatedCountry.Population);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Country", code);
                command.Parameters.AddWithValue("@Province", capital);

                if(command.ExecuteNonQuery() == 0) 
                {
                    throw new Exception("Etwas hat nicht funktioniert!");
                }

                return updatedCountry;
            }
        }
        public void Print(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();  //Erzeugt eine Liste namens "header" aus den Spaltenschemata einer Datenbankabfrage (dataReader).

            // dynamisch: 
            for (int i = 0; i < header.Count; i++) // gibt alle Überschrieften aus
            {
                Console.ForegroundColor = colors[i % colors.Length]; // ändert Farbe

                if (header[i].DataTypeName == "nvarchar")
                {
                    string format = string.Format(" {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));      //Die Zeile erstellt ein Formatierungsmuster für eine Spaltenausgabe basierend auf der
                                                                                                                                                   //Breite der Spalte und deren Namen.
                    Console.Write(format, header[i].ColumnName);
                }
                else if (header[i].DataTypeName == "float")
                {
                    Console.Write("  {0,20:N2} ", header[i].ColumnName);
                }
                else
                {
                    Console.Write("  {0,20:N2} ", header[i].ColumnName);
                }
            }
            Console.WriteLine();
            Console.ResetColor(); // löscht Farbe

            while (dataReader.Read()) // gibt den Text von allen Überschriften aus
            {
                // dynamisch: => Felder werden ausgerechnet aus Datenbank
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.ForegroundColor = colors[i % colors.Length];
                    Console.Write("|");

                    if (header[i].DataTypeName == "nvarchar") // wenn datentyp nvarchar
                    {
                        string format = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        // string.Format wird verwendet, wenn zwei Werte dynamisch sind!
                        // Math.Max bekommt den größten Wert von einer Spale

                        Console.Write(format, dataReader[i]); // schreibt in die Console
                    }
                    else if (header[i].DataTypeName == "float") // wenn datentyp float
                    {
                        Console.Write("{0,20:N2} ", dataReader[i]);
                    }
                    else // alles andere
                    {
                        Console.Write("{0,20:N2} ", dataReader[i]);
                    }
                    Console.ResetColor(); // löscht Farbe
                }
                Console.WriteLine("|");
            }
        }
    }
}
