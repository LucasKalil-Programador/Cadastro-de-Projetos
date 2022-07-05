using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;
using System.Text.RegularExpressions;

namespace Cadastro_projetos
{
    public partial class TeamArea : UserControl
    {
        private string ActualIdAlunoTeam = String.Empty;
        private string ActualIdProject = String.Empty;
        private string ActualIdAluno = String.Empty;

        public TeamArea()
        {
            InitializeComponent();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (ActualIdProject != String.Empty) UpdateTeamDataGrid(ActualIdProject);
            UpdateStudantDataGrid();
            UpdateProjectDataGrid();
        }

        private void UpdateTeamDataGrid(string idProjeto)
        {
            Aluno[] alunos = Connection.SelectFromTeam(idProjeto);
            TeamTable.Rows.Clear();
            for (int i = 0; i < alunos.Length; i++)
                TeamTable.Rows.Add(alunos[i].Id, alunos[i].Name, alunos[i].RegisterNumber, alunos[i].Semester);
        }

        private void UpdateStudantDataGrid()
        {
            Aluno[] alunos = Connection.SelectAllFromAluno();
            TableAluno.Rows.Clear();
            for (int i = 0; i < alunos.Length; i++)
            {
                bool teamContain = false;
                for (int j = 0; j < TeamTable.Rows.Count; j++)
                {
                    if (alunos[i].Id.Equals(TeamTable.Rows[j].Cells[0].Value))
                    {
                        teamContain = true;
                        break;
                    }
                }

                if (!teamContain) TableAluno.Rows.Add(alunos[i].Id, alunos[i].Name, alunos[i].RegisterNumber, alunos[i].Semester);
            }
        }

        private void UpdateProjectDataGrid()
        {
            Projeto[] projetos = Connection.SelectAllFromProjeto();

            DataGrid.Rows.Clear();
            for (int i = 0; i < projetos.Length; i++)
                DataGrid.Rows.Add(projetos[i].Id, projetos[i].Name, projetos[i].Description, projetos[i].References, projetos[i].Type, projetos[i].Orientador.Name, projetos[i].Orientador.Subjects, projetos[i].Universidade.Name);
        }

        private void On_SelectProject(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idProject = (string)DataGrid.Rows[e.RowIndex].Cells[0].Value;
            if (idProject != null && Regex.IsMatch(idProject, "[0-9]+"))
            {
                ActualIdProject = idProject;
                ActualIdAlunoTeam = string.Empty;
                ReloadButton_Click(new object(), EventArgs.Empty);
            }
        }

        private void AddStudantOnTeamButton_Click(object sender, EventArgs e)
        {
            if (ActualIdAluno != string.Empty && ActualIdProject != string.Empty)
            {
                Team team = new(string.Empty,
                    new Aluno(ActualIdAluno, string.Empty, string.Empty, string.Empty),
                    new Projeto(ActualIdProject, string.Empty, string.Empty, string.Empty, string.Empty, new Orientador(string.Empty, string.Empty, string.Empty), new Universidade(string.Empty, string.Empty)));
                Connection.InsertTeam(team);
                ReloadButton_Click(new object(), EventArgs.Empty);
            }
        }

        private void On_SelectStudant(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idAluno = (string)TableAluno.Rows[e.RowIndex].Cells[0].Value;
            if (idAluno != null && Regex.IsMatch(idAluno, "[0-9]+"))
            {
                ActualIdAluno = idAluno;
            }
        }

        private void On_SelectTeam(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idAluno = (string)TeamTable.Rows[e.RowIndex].Cells[0].Value;
            if (idAluno != null && Regex.IsMatch(idAluno, "[0-9]+"))
            {
                ActualIdAlunoTeam = idAluno;
            }
        }

        private void DeleteTeam_Click(object sender, EventArgs e)
        {
            if (ActualIdAlunoTeam != string.Empty && ActualIdProject != string.Empty)
            {
                Connection.DeleteTeam(ActualIdAlunoTeam, ActualIdProject);
                ReloadButton_Click(new object(), EventArgs.Empty);
            }
        }
    }
}
