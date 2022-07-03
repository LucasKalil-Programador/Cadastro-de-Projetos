using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_projetos.SQLConnection;
using Cadastro_projetos.Entities;

namespace Cadastro_projetos.Student
{
    public partial class ViewAndEdit : UserControl
    {
        private const int LIMIT = 10;

        private DataGridViewCellCollection ActualRow;

        public ViewAndEdit()
        {
            InitializeComponent();
            pictureBox.Visible = false;
        }

        private void On_VisibleChange(object sender, EventArgs e)
        {
            if (Visible)
            {
                UpdateDataGrid(0);
                PageCountLabel.Text = $"0 / {Connection.CountFromAluno() / 10}";
                ErrorAndSucessesLabel.Text = "Aluno ainda não selecionado";

                SemesterNumeric.Value = 1;
                RegisterTextBox.Clear();
                NameTextBox.Clear();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index < count) UpdateDataGrid(++index * 10);
            PageCountLabel.Text = $"{index} / {count / 10}";
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index > 0) UpdateDataGrid(--index * 10);
            PageCountLabel.Text = $"{index} / {count / 10}";
        }

        private void UpdateDataGrid(int index)
        {
            Aluno[] alunos = Connection.SelectFromAluno(index, LIMIT);
            TableAluno.Rows.Clear();
            for (int i = 0; i < alunos.Length; i++)
                TableAluno.Rows.Add(alunos[i].id, alunos[i].Name, alunos[i].RegisterNumber, alunos[i].Semester);
        }

        private void On_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ActualRow = TableAluno.Rows[e.RowIndex].Cells;
            SetTextAreas(ActualRow);
        }

        private void SetTextAreas(DataGridViewCellCollection Row)
        {
            NameTextBox.Text = (string)Row[1].Value;
            SemesterNumeric.Value = int.Parse((string)Row[2].Value);
            RegisterTextBox.Text = (string)Row[3].Value;
        }
    }
}
