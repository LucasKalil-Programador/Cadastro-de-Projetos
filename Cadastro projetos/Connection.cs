using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro_projetos.SQLConnection
{
    internal class Connection
    {
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            if(connection == null || !connection.Ping())
            {
                connection = new MySqlConnection("server=localhost;database=cadastro_projeto_db;uid=root;pwd=admin;");
                connection.Open();
            }
            return connection;
        }

        public static void ExecuteQuery(string query)
        {
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
