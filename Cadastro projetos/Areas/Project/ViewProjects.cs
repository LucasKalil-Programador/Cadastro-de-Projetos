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
using System.Text.RegularExpressions;

namespace Cadastro_projetos.Areas.Project
{
    public partial class ViewAndEditProjects : UserControl
    {
        private const int LIMIT = 10;

        private DataGridViewCellCollection? ActualRow;

        public ViewAndEditProjects()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        // On visible change

        public void On_ChangeForThis()
        {
            if (!Visible)
            {
                UpdateDataGrid(0);
                PageCountLabel.Text = $"0 / {Connection.CountFromProjeto() / LIMIT}";
                ErrorAndSucessesLabel.Text = "Projeto ainda não selecionado";

                ReferencesTextBox.Text = "Escreva as referencias usadas aqui";
                DescriptionTextBox.Text = "Escreva a descrição aqui";
                TypeTextBox.Clear();
                NameTextBox.Clear();
            }
        }

        // Next Button

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromProjeto();

            if (index < count / LIMIT) UpdateDataGrid(++index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        // Prev Button

        private void PrevButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromProjeto();

            if (index > 0) UpdateDataGrid(--index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";
        }

        private void UpdateDataGrid(int index)
        {
            Projeto[] projetos = Connection.SelectFromProjeto(index, LIMIT);

            DataGrid.Rows.Clear();
            for (int i = 0; i < projetos.Length; i++)
                DataGrid.Rows.Add(projetos[i].Id, projetos[i].Name, projetos[i].Description, projetos[i].References, projetos[i].Type, projetos[i].Orientador.Name, projetos[i].Orientador.Subjects, projetos[i].Universidade.Name);
        }

        private void On_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGrid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                ActualRow = DataGrid.Rows[e.RowIndex].Cells;
                SetTextAreas(ActualRow);
            }
        }

        private void SetTextAreas(DataGridViewCellCollection Row)
        {
            NameTextBox.Text = (string)Row[1].Value;
            DescriptionTextBox.Text = (string)Row[2].Value;
            ReferencesTextBox.Text = (string)Row[3].Value;
            TypeTextBox.Text = (string)Row[4].Value;

            ErrorAndSucessesLabel.Text = "";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null) SetTextAreas(ActualRow);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                Connection.DeleteProjeto(new Projeto((string)ActualRow[0].Value, "", "", "", "",
                    new Orientador("", "", ""), new Universidade("", "")));
                ResetAll();
            }
        }

        private void ResetAll()
        {
            ReferencesTextBox.Text = "Escreva as referencias usadas aqui";
            DescriptionTextBox.Text = "Escreva a descrição aqui";
            TypeTextBox.Clear();
            NameTextBox.Clear();

            int index = int.Parse(PageCountLabel.Text.Split(" / ")[0]);
            int count = Connection.CountFromAluno();

            if (index < count) UpdateDataGrid(index * LIMIT);
            PageCountLabel.Text = $"{index} / {count / LIMIT}";

            ActualRow = null;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ActualRow != null)
            {
                pictureBox1.Visible = true;
                string id = (string)ActualRow[0].Value;
                string references = ReferencesTextBox.Text;
                string description = DescriptionTextBox.Text;
                string name = NameTextBox.Text;
                string type = TypeTextBox.Text;

                if (Validate(references, description, name, type))
                {
                    UpdateOnDB(id, references, description, name, type);
                }
            }
        }

        private void UpdateOnDB(string id, string references, string description, string name,
            string type)
        {
            pictureBox1.Visible = true;
            Projeto projeto = new(id, name, type, references, description,
                new Orientador(string.Empty, string.Empty, string.Empty),
                new Universidade(string.Empty, string.Empty));
            bool result = Connection.UpdateProjeto(projeto);
            if (result)
            {
                UpdateDataGrid(0);
                this.pictureBox1.BackgroundImage = Properties.Resources.sucesses;
                ErrorAndSucessesLabel.Text = "Edição realizado com sucesso!";
                
                ReferencesTextBox.Text = "Escreva as referencias usadas aqui";
                DescriptionTextBox.Text = "Escreva a descrição aqui";
                NameTextBox.Clear();
                TypeTextBox.Clear();

            }
            else
            {
                this.pictureBox1.BackgroundImage = Properties.Resources.error;
                ErrorAndSucessesLabel.Text = "Error desconhecido";
            }
        }

        private bool Validate(string references, string description, string name,
            string type)
        {
            bool referencesIsValid = Regex.IsMatch(references, "[A-z].+");
            bool descriptionIsValid = Regex.IsMatch(description, "[A-z].+");
            bool nameIsValid = Regex.IsMatch(name, "[A-z].+");
            bool typeIsValid = Regex.IsMatch(type, "[A-z].+");

            if (referencesIsValid && descriptionIsValid && nameIsValid && typeIsValid)
            {
                return true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = Properties.Resources.error;
                ErrorAndSucessesLabel.Text = "Alguns erros foram detectados verifique capos em branco";
                if (!nameIsValid) NameTextBox.BackColor = Color.Red;
                if (!typeIsValid) TypeTextBox.BackColor = Color.Red;


                return false;
            }
        }
    }
}
