using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;
using System.Text.RegularExpressions;

namespace Cadastro_projetos.Student
{
    public partial class ViewAndEditStudant : UserControl
    {
        private const int LIMIT = 10;

        private DataGridViewCellCollection? ActualRow;

        public ViewAndEditStudant()
        {
            InitializeComponent();
            pictureBox.Visible = false;
        }

        // On visible change

        public void On_ChangeForThis()
        {
            if (!Visible)
            {
                UpdateDataGrid(0);
                PageCountLabel.Text = $"0 / {Connection.CountFromAluno() / LIMIT}";
                ErrorAndSucessesLabel.Text = "Aluno ainda não selecionado";

                SemesterNumeric.Value = 1;
                RegisterNumberTextBox.Clear();
                NameTextBox.Clear();
            }
        }

        // Next Button

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index < count / LIMIT) UpdateDataGrid(++index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        // Prev Button

        private void PrevButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index > 0) UpdateDataGrid(--index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        private void UpdateDataGrid(int index)
        {
            Aluno[] alunos = Connection.SelectFromAluno(index, LIMIT);
            TableAluno.Rows.Clear();
            for (int i = 0; i < alunos.Length; i++)
                TableAluno.Rows.Add(alunos[i].Id, alunos[i].Name, alunos[i].RegisterNumber, alunos[i].Semester);
        }

        private void On_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (TableAluno.Rows[e.RowIndex].Cells[0].Value != null)
            {
                ActualRow = TableAluno.Rows[e.RowIndex].Cells;
                SetTextAreas(ActualRow);
            }
        }

        private void SetTextAreas(DataGridViewCellCollection Row)
        {
            NameTextBox.Text = (string)Row[1].Value;
            SemesterNumeric.Value = int.Parse((string)Row[2].Value);
            RegisterNumberTextBox.Text = (string)Row[3].Value;
            ErrorAndSucessesLabel.Text = "";
        }

        // Edit Button Click

        private void EditStudantButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                string id = (string)ActualRow[0].Value;
                string name = NameTextBox.Text;
                string semester = SemesterNumeric.Text;
                string registerNumber = RegisterNumberTextBox.Text;

                pictureBox.Visible = true;

                if (ValidationData(name, registerNumber))
                    UpdateDB(id, name, semester, registerNumber);
                else
                    return;
            }
        }

        private bool ValidationData(string name, string registerNumber)
        {
            bool nameIsValid = Regex.IsMatch(name, "([A-Za-z]| ){1,120}");
            bool registerNumberIsValid = Regex.IsMatch(registerNumber, "[0-9]{10}");
            ErrorAndSucessesLabel.Text = "";

            if (!nameIsValid || !registerNumberIsValid)
                this.pictureBox.BackgroundImage = Properties.Resources.error;

            if (!nameIsValid && !registerNumberIsValid)
                ErrorAndSucessesLabel.Text = "O nome e matricula invalidos";
            else if (!nameIsValid)
                ErrorAndSucessesLabel.Text = "O nome esta invalido";
            else if (!registerNumberIsValid)
                ErrorAndSucessesLabel.Text = "A matricula esta invalida";

            NameTextBox.BackColor = nameIsValid ? Color.White : Color.Red;
            RegisterNumberTextBox.BackColor = registerNumberIsValid ? Color.White : Color.Red;

            return nameIsValid && registerNumberIsValid;
        }

        private void UpdateDB(string id, string name, string semester, string registerNumber)
        {
            Aluno aluno = new(id, name, registerNumber, semester);
            bool result = Connection.UpdateAluno(aluno);
            if (result)
            {
                this.pictureBox.BackgroundImage = Properties.Resources.sucesses;
                ErrorAndSucessesLabel.Text = "Atualização realizado com sucesso!";
                ResetAll();
            }
            else
            {
                this.pictureBox.BackgroundImage = Properties.Resources.error;
                ErrorAndSucessesLabel.Text = "Error desconhecido";
            }
        }

        // Refresh Button

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null) SetTextAreas(ActualRow);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                Connection.DeleteAluno(new Aluno((string)ActualRow[0].Value, "", "", ""));
                ResetAll();
            }
        }

        private void ResetAll()
        {
            NameTextBox.Clear();
            SemesterNumeric.Value = 1;
            RegisterNumberTextBox.Clear();

            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index < count) UpdateDataGrid(index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";

            ActualRow = null;
        }
    }
}
