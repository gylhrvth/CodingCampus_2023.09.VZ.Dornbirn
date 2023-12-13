using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarioLuis.Week10.Models;

namespace DarioLuis.Week10.MySql
{
    public class Datenbank
    {
        private string connectionString;
        private SqlConnection connection;

        public Datenbank(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void connect()
        {
            close();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void close()
        {
            connection?.Close();
        }

        
    }
}
