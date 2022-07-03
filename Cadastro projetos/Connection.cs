using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Cadastro_projetos.Entities;

namespace Cadastro_projetos.SQLConnection
{
    internal class Connection
    {

        private static string ConnectionString = "server=localhost;database=cadastro_projeto_db;uid=root;pwd=admin;";
        private static MySqlConnection connection = GetConnectionInternal();

        private static MySqlConnection GetConnectionInternal()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
             connection.Open();
            return connection;
        }
        
        public static bool InsertAluno(Aluno aluno)
        {
            lock (connection)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Aluno(nome,semestre,matricula) values " +
                    $"('{aluno.Name}',{aluno.Semester},'{aluno.RegisterNumber}');", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Aluno[] SelectFromAluno(int index, int limit)
        {
            List<Aluno> alunoList = new List<Aluno>();
            lock (connection)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Aluno LIMIT {index}, {limit};", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Aluno aluno = new Aluno(
                        dataReader.GetString(0), 
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3));
                    alunoList.Add(aluno);
                }
              
                dataReader.Close();
            }
            return alunoList.ToArray();
        }

        public static int CountFromAluno()
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM Aluno;", connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            int count = 0;
            if (dataReader.Read()) 
                count = dataReader.GetInt32(0);
            dataReader.Close();
            return count;
        }
    }
}
