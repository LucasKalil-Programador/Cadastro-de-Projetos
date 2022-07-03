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
using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;

namespace Cadastro_projetos.Advisor
{
    public partial class RegisterAdvisor : UserControl
    {
        public RegisterAdvisor()
        {
            InitializeComponent();
            pictureBox.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string nome = NameTextBox.Text;

            bool valid = ValidSujects() & ValidName(nome);

            string subjects = GetSubjets();
            if (valid) InsertOnDB(nome, subjects);
        }

        private void InsertOnDB(string name, string subjects)
        {
            Orientador orientador = new(String.Empty, name, subjects);
            bool result = Connection.InsertOrientador(orientador);  
            if (result)
            {
                this.pictureBox.BackgroundImage = Properties.Resources.sucesses;
                ErrorOrSucessesLabel.Text = "Cadastro realizado com sucesso!";

                NameTextBox.Clear();
                SubjectsTable.Rows.Clear();
            }
            else
            {
                this.pictureBox.BackgroundImage = Properties.Resources.error;
                ErrorOrSucessesLabel.Text = "Error desconhecido";
            }
            pictureBox.Visible = true;
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

        private bool ValidName(string name)
        {
            if(Regex.IsMatch(name, "[a-zA-Z]([a-zA-Z]| )*"))
            {
                NameTextBox.BackColor = Color.White;
                return true;
            }
            else
            {
                NameTextBox.BackColor = Color.Red;
                ErrorOrSucessesLabel.Text = "O nome é invalido";
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
                ErrorOrSucessesLabel.Text = "Caracter invalido ',' ou vazio na tabela de materias";
                pictureBox.BackgroundImage = Properties.Resources.error;
                pictureBox.Visible = true;
            }

            return !error;
        }
    }
}
