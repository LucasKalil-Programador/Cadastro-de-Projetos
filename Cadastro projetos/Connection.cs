using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Cadastro_projetos.Entities;

namespace Cadastro_projetos.SQLConnection
{
    public static class Connection
    {

        public const string ConnectionString = "server=localhost;database=cadastro_projeto_db;uid=root;pwd=admin;";
        private static readonly MySqlConnection connection = GetConnectionInternal();

        private static MySqlConnection GetConnectionInternal()
        {
            MySqlConnection connection = new(ConnectionString);
            connection.Open();
            return connection;
        }

        // sql querys Aluno

        public static bool InsertAluno(Aluno aluno)
        {
            lock (connection)
            {
                MySqlCommand cmd = new("INSERT INTO Aluno(nome,semestre,matricula) values " +
                    $"('{aluno.Name}',{aluno.Semester},'{aluno.RegisterNumber}');", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Aluno[] SelectFromAluno(int index, int limit)
        {
            List<Aluno> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Aluno LIMIT {index}, {limit};", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Aluno aluno = new(
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
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT COUNT(*) FROM Aluno;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                if (dataReader.Read()) count = dataReader.GetInt32(0);
                dataReader.Close();
                return count;
            }
        }

        public static bool UpdateAluno(Aluno aluno)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"UPDATE Aluno SET " +
                    $"nome = '{aluno.Name}', semestre = {aluno.Semester}, " +
                    $"matricula = '{aluno.RegisterNumber}' where idAluno = {aluno.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static bool DeleteAluno(Aluno aluno)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Aluno WHERE idAluno = {aluno.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        // sql querys Universidade

        public static bool InsertUniversidade(Universidade universidade)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"INSERT INTO Universidade(nome) values ('{universidade.Name}');", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Universidade[] SelectFromUniversidade(int index, int limit)
        {
            List<Universidade> universidadeList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Universidade LIMIT {index}, {limit};", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Universidade universidade = new(
                        dataReader.GetString(0),
                        dataReader.GetString(1));
                    universidadeList.Add(universidade);
                }

                dataReader.Close();
            }
            return universidadeList.ToArray();
        }

        public static int CountFromUniversidade()
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT COUNT(*) FROM Universidade;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                if (dataReader.Read()) count = dataReader.GetInt32(0);
                dataReader.Close();
                return count;
            }
        }

        public static bool UpdateUniversidade(Universidade universidade)
        {
            lock (connection)
            {
                MySqlCommand cmd = new("UPDATE Universidade SET Nome = " +
                    $"'{universidade.Name}' where idUniversidade = {universidade.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static bool DeleteUniversidade(Universidade universidade)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Universidade WHERE idUniversidade = {universidade.Id};", connection); 
                return cmd.ExecuteNonQuery() != -1;
            }
        }
    }
}
