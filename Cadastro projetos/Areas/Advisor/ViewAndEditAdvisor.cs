using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_projetos.Advisor
{
    public partial class ViewAndEditAdvisor : UserControl
    {
        private const int LIMIT = 10;

        private DataGridViewCellCollection? ActualRow;

        public ViewAndEditAdvisor()
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
                PageCountLabel.Text = $"0 / {Connection.CountFromOrientador() / LIMIT}";
                ErrorAndSucessesLabel.Text = "Orientador ainda não selecionado";

                SubjectsTable.Rows.Clear();
                NameTextBox.Clear();
            }
        }

        // Next Button

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromOrientador();

            if (index < count / LIMIT) UpdateDataGrid(++index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        // Prev Button

        private void PrevButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromOrientador();

            if (index > 0) UpdateDataGrid(--index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        private void UpdateDataGrid(int index)
        {
            Orientador[] orientadors = Connection.SelectFromOrientador(index, LIMIT);
            TableAluno.Rows.Clear();
            for (int i = 0; i < orientadors.Length; i++)
                TableAluno.Rows.Add(orientadors[i].Id, orientadors[i].Name, orientadors[i].Subjects);
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
            string[] subjecs = ((string)Row[2].Value).Split(',');

            SubjectsTable.Rows.Clear();
            foreach (string subjec in subjecs) SubjectsTable.Rows.Add(subjec);

            ErrorAndSucessesLabel.Text = "";
        }
        
        // Edit Button Click

        private void EditStudantButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                pictureBox.Visible = true;
                string id = (string)ActualRow[0].Value;
                string nome = NameTextBox.Text;

                bool valid = ValidSujects() & ValidName(nome);

                string subjects = GetSubjets();
                if (valid) UpdateDB(id, nome, subjects);
            }
        }

        private bool ValidName(string name)
        {
            if (Regex.IsMatch(name, "[a-zA-Z]([a-zA-Z]| )*"))
            {
                NameTextBox.BackColor = Color.White;
                return true;
            }
            else
            {
                NameTextBox.BackColor = Color.Red;
                ErrorAndSucessesLabel.Text = "O nome é invalido";
                pictureBox.Visible = true;
                pictureBox.BackgroundImage = Properties.Resources.error;
                return false;
            }
        }

        private bool ValidSujects()
        {
            bool error = SubjectsTable.RowCount < 2;
            for (int i = 0; i < SubjectsTable.RowCount - 1; i++)
            {
                if (SubjectsTable.Rows[i].Cells[0].Value != null && Regex.IsMatch((string)SubjectsTable.Rows[i].Cells[0].Value, "[a-zA-Z]([a-zA-Z]| )*"))
                {
                    if (((string)SubjectsTable.Rows[i].Cells[0].Value).Contains(','))
                    {
                        SubjectsTable.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        error = true;
                    }
                    else
                        SubjectsTable.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    SubjectsTable.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            if (error)
            {
                ErrorAndSucessesLabel.Text = "Caracter invalido ',' ou vazio na tabela de materias";
                pictureBox.BackgroundImage = Properties.Resources.error;
                pictureBox.Visible = true;
            }

            return !error;
        }

        private string GetSubjets()
        {
            string subjets = string.Empty;
            for (int i = 0; i < SubjectsTable.RowCount - 1; i++)
            {
                if (i > 0) subjets += ",";
                subjets += ((string)SubjectsTable.Rows[i].Cells[0].Value).Trim();
            }
            return subjets;
        }

        private void UpdateDB(string id, string name, string materias)
        {
            Orientador orientador = new(id, name, materias);
            bool result = Connection.UpdateOrientador(orientador);
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null) SetTextAreas(ActualRow);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                Connection.DeleteOrientador(new Orientador((string)ActualRow[0].Value, "", ""));
                ResetAll();
            }
        }

        private void ResetAll()
        {
            SubjectsTable.Rows.Clear();
            NameTextBox.Clear();

            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromOrientador();

            if (index < count) UpdateDataGrid(index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";

            ActualRow = null;
        }
    }
}
