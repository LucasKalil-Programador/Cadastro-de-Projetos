using Cadastro_projetos.SQLConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_projetos.Entities;
using System.Text.RegularExpressions;

namespace Cadastro_projetos.University
{
    public partial class ViewAndEditUniversity : UserControl
    {
        private const int LIMIT = 10;

        private DataGridViewCellCollection? ActualRow;

        public ViewAndEditUniversity()
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
                PageCountLabel.Text = $"0 / {Connection.CountFromUniversidade() / LIMIT}";
                ErrorAndSucessesLabel.Text = "Universidade ainda não selecionado";

                NameTextBox.Clear();
            }
        }

        // Next Button

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromUniversidade();
            
            if (index < count / LIMIT) UpdateDataGrid(++index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        // Prev Button

        private void PrevButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromUniversidade();

            if (index > 0) UpdateDataGrid(--index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        private void UpdateDataGrid(int index)
        {
            Universidade[] universidades = Connection.SelectFromUniversidade(index, LIMIT);
            TableAluno.Rows.Clear();
            for (int i = 0; i < universidades.Length; i++)
                TableAluno.Rows.Add(universidades[i].Id, universidades[i].Name);
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
            ErrorAndSucessesLabel.Text = "";
        }

        // Edit Button Click

        private void EditUniversityButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                string id = (string)ActualRow[0].Value;
                string name = NameTextBox.Text;

                pictureBox.Visible = true;

                if (ValidationData(name))
                    UpdateDB(id, name);
                else
                    return;
            }
        }

        private bool ValidationData(string name)
        {
            bool nameIsValid = Regex.IsMatch(name, "([A-Za-z]| ){1,120}");

            if (!nameIsValid)
            {
                ErrorAndSucessesLabel.Text = "O nome é invalido";
                pictureBox.BackgroundImage = Properties.Resources.error;
            }

            NameTextBox.BackColor = nameIsValid ? Color.White : Color.Red;

            return nameIsValid;
        }

        private void UpdateDB(string id, string name)
        {
            Universidade universidade = new(id, name);
            bool result = Connection.UpdateUniversidade(universidade);
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
                Connection.DeleteUniversidade(new Universidade((string)ActualRow[0].Value, ""));
                ResetAll();
            }
        }

        private void ResetAll()
        {
            NameTextBox.Clear();

            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromUniversidade();

            if (index < count) UpdateDataGrid(index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";

            ActualRow = null;
        }

    }
}
