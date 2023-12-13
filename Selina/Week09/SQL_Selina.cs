using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Selina.Week09
{
    public class SQL_Selina
    {
        public static ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Cyan,ConsoleColor.Magenta,ConsoleColor.DarkBlue,ConsoleColor.Blue, ConsoleColor.DarkMagenta, ConsoleColor.Blue,ConsoleColor.Cyan};
        public static void Start()
        { 
            string connenctionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localHost,1433;user=selina;password=selina"; //Die Zeichenfolge enthält Verbindungsinformationen für eine SQL Server-Datenbank namens
                                                                                                                                                    //"Mondial" mit dem Benutzer "selina" und dem Passwort "selina".

            using (SqlConnection conn = new SqlConnection(connenctionString))   //Erstellt eine SqlConnection und verwendet sie innerhalb des angegebenen Codeblocks.
            {
                SqlCommand cmd = new SqlCommand("select Name as CityName, Province as Hauptstadt , Population as Einwohner \nfrom city where \nName like @Name and Population > @Pop", conn);    //Die Zeile erstellt ein SqlCommand-Objekt für eine SQL-Abfrage, die Städte nach Name und Bevölkerung filtert.

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "%a";   //Setzt den Parameter "@Name" auf den Wert "W%".
                cmd.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;     //Setzt den Parameter "@Pop" auf den Wert 1000000 vom Typ Integer.

                try
                {
                    cmd.Connection.Open();  //Die Zeile öffnet eine Datenbankverbindung in C# mithilfe eines SqlCommand-Objekts.
                    SqlDataReader dataReader = cmd.ExecuteReader();     //Die Zeile liest die Ergebnisse einer SQL - Abfrage mit einem SqlDataReader - Objekt(dataReader).
                    PrintResult(dataReader);
                    dataReader.Close();     //Die Zeile schließt den SqlDataReader (dataReader).
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        public static void PrintResult(SqlDataReader dataReader) 
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

                // statisch:
                //if (i > 0)
                //{
                //    Console.Write("|");
                //}
                //Console.Write($"{header[i].ColumnName,27}");
            }
            Console.WriteLine();
            Console.ResetColor(); // löscht Farbe

            while (dataReader.Read()) // gibt den Text von allen Überschriften aus
            {
                // statisch: => Felder legt der Programmierer fest
                //for (int i = 0; i < dataReader.FieldCount; i++)
                //{
                //    if (i > 0)
                //    {
                //        Console.Write("|");
                //    }
                //    Console.Write($"{dataReader[i],27}");
                //}
                //Console.WriteLine();

                // dynamisch: => Felder werden ausgerechnet aus Datenbank
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.Write("|");
                    Console.ForegroundColor = colors[i % colors.Length]; // ändert Farbe

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
