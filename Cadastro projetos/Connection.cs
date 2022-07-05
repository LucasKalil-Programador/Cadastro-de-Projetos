using Cadastro_projetos.Entities;
using MySql.Data.MySqlClient;

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

        #region Aluno

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

        public static Aluno[] SelectAllFromAluno()
        {
            List<Aluno> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Aluno;", connection);
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
                DeleteTeam(aluno.Id);
                MySqlCommand cmd = new($"DELETE FROM Aluno WHERE idAluno = {aluno.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        #endregion Aluno

        #region Universidade

        public static bool InsertUniversidade(Universidade universidade)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"INSERT INTO Universidade(nome) values ('{universidade.Name}');", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Universidade[] SelectAllFromUniversidade()
        {
            List<Universidade> universidadeList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Universidade;", connection);
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

        #endregion Universidade

        #region Orientador

        public static bool InsertOrientador(Orientador orientador)
        {
            lock (connection)
            {
                MySqlCommand cmd = new("INSERT INTO Orientador(nome,materias) values " +
                    $"('{orientador.Name}', '{orientador.Subjects}');", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Orientador[] SelectFromOrientador(int index, int limit)
        {
            List<Orientador> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Orientador LIMIT {index}, {limit};", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Orientador orientador = new(
                        dataReader.GetString(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2));
                    alunoList.Add(orientador);
                }

                dataReader.Close();
            }
            return alunoList.ToArray();
        }

        public static Orientador[] SelectAllFromOrientador()
        {
            List<Orientador> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT * FROM Orientador;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Orientador orientador = new(
                        dataReader.GetString(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2));
                    alunoList.Add(orientador);
                }

                dataReader.Close();
            }
            return alunoList.ToArray();
        }

        public static int CountFromOrientador()
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT COUNT(*) FROM Orientador;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                if (dataReader.Read()) count = dataReader.GetInt32(0);
                dataReader.Close();
                return count;
            }
        }

        public static bool UpdateOrientador(Orientador orientador)
        {
            lock (connection)
            {
                MySqlCommand cmd = new("UPDATE Orientador SET " +
                    $"Nome = '{orientador.Name}', Materias = '{orientador.Subjects}' where idOrientador = {orientador.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static bool DeleteOrientador(Orientador orientador)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Orientador WHERE idOrientador = {orientador.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        #endregion Orientador

        #region Projeto

        public static bool InsertProjeto(Projeto projeto)
        {
            lock (connection)
            {
                MySqlCommand cmd = new("INSERT INTO Projeto(nome,tipo,descricao,referencias_usadas,Orientador_idOrientador,Universidade_idUniversidade) values " +
                    $"('{projeto.Name}','{projeto.Type}','{projeto.Description}','{projeto.References}',{projeto.Orientador.Id},{projeto.Universidade.Id});", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Projeto[] SelectFromProjeto(int index, int limit)
        {
            List<Projeto> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new("select p.idProjeto, p.nome, p.descricao, p.tipo, p.referencias_usadas, o.nome," + "o.Materias, u.nome from projeto p " +
                  "inner join orientador o " +
                  "inner join universidade u " +
                  "where p.Orientador_idOrientador = o.idOrientador " +
                  $"and p.Universidade_idUniversidade = u.idUniversidade LIMIT {index}, {limit};", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Orientador orientador = new(String.Empty, dataReader.GetString(5), dataReader.GetString(6));
                    Universidade universidade = new(string.Empty, dataReader.GetString(7));
                    Projeto projeto = new(
                        id: dataReader.GetString(0),
                        name: dataReader.GetString(1),
                        description: dataReader.GetString(2),
                        type: dataReader.GetString(3),
                        references: dataReader.GetString(4),
                        orientador: orientador,
                        universidade: universidade);
                    alunoList.Add(projeto);
                }

                dataReader.Close();
            }
            return alunoList.ToArray();
        }

        public static Projeto[] SelectAllFromProjeto()
        {
            SelectAllFromAluno();
            List<Projeto> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new("select p.idProjeto, p.nome, p.descricao, p.tipo, p.referencias_usadas, o.nome," + "o.Materias, u.nome from projeto p " +
                  "inner join orientador o " +
                  "inner join universidade u " +
                  "where p.Orientador_idOrientador = o.idOrientador " +
                  $"and p.Universidade_idUniversidade = u.idUniversidade;", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Orientador orientador = new(String.Empty, dataReader.GetString(5), dataReader.GetString(6));
                    Universidade universidade = new(string.Empty, dataReader.GetString(7));
                    Projeto projeto = new(
                        id: dataReader.GetString(0),
                        name: dataReader.GetString(1),
                        description: dataReader.GetString(2),
                        type: dataReader.GetString(3),
                        references: dataReader.GetString(4),
                        orientador: orientador,
                        universidade: universidade);
                    alunoList.Add(projeto);
                }

                dataReader.Close();
            }
            return alunoList.ToArray();
        }

        public static bool DeleteProjeto(Projeto projeto)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Projeto WHERE idProjeto = {projeto.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static bool UpdateProjeto(Projeto projeto)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"UPDATE Projeto Set nome = '{projeto.Name}', tipo = '{projeto.Type}', descricao = '{projeto.Description}', referencias_usadas = '{projeto.References}' WHERE idProjeto = {projeto.Id};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static int CountFromProjeto()
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT COUNT(*) FROM Projeto;", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                if (dataReader.Read()) count = dataReader.GetInt32(0);
                dataReader.Close();
                return count;
            }
        }

        #endregion Projeto

        #region Team

        public static bool InsertTeam(Team team)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"INSERT INTO Projeto_Has_Aluno(Aluno_IdAluno, Projeto_idProjeto) values ({team.Aluno.Id}, {team.Projeto.Id});", connection);
                Console.WriteLine(cmd.CommandText);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static Aluno[] SelectFromTeam(string idProjeto)
        {
            List<Aluno> alunoList = new();
            lock (connection)
            {
                MySqlCommand cmd = new($"SELECT a.idAluno, a.nome, a.matricula, a.semestre FROM Projeto_has_Aluno pa " +
                    $"inner join Aluno a where pa.Projeto_idProjeto = {idProjeto} and a.idAluno = pa.Aluno_idAluno;", connection);
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

        public static bool DeleteTeam(string idAluno, string idProjeto)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Projeto_has_Aluno WHERE Aluno_idAluno = {idAluno} and Projeto_idProjeto = {idProjeto};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        public static bool DeleteTeam(string idAluno)
        {
            lock (connection)
            {
                MySqlCommand cmd = new($"DELETE FROM Projeto_has_Aluno WHERE Aluno_idAluno = {idAluno};", connection);
                return cmd.ExecuteNonQuery() != -1;
            }
        }

        #endregion Team
    }
}
