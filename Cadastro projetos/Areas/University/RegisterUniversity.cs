﻿using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;
using System.Text.RegularExpressions;

namespace Cadastro_projetos.University
{
    public partial class RegisterUniversity : UserControl
    {
        public RegisterUniversity()
        {
            InitializeComponent();
            pictureBox.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;

            pictureBox.Visible = true;

            if (Validate(name))
            {
                InsertOnDB(name);
            }
        }

        private bool Validate(string name)
        {
            bool nameIsValid = Regex.IsMatch(name, "([A-Za-z]| ){1,120}");

            if (!nameIsValid)
            {
                Console.WriteLine("a");
                ErrorOrSucessesLabel.Text = "O nome é invalido";
                pictureBox.BackgroundImage = Properties.Resources.error;
            }

            NameTextBox.BackColor = nameIsValid ? Color.White : Color.Red;

            return nameIsValid;
        }

        private void InsertOnDB(string name)
        {
            Universidade universidade = new(String.Empty, name);
            bool result = Connection.InsertUniversidade(universidade);
            if (result)
            {
                this.pictureBox.BackgroundImage = Properties.Resources.sucesses;
                ErrorOrSucessesLabel.Text = "Cadastro realizado com sucesso!";

                NameTextBox.Clear();
            }
            else
            {
                this.pictureBox.BackgroundImage = Properties.Resources.error;
                ErrorOrSucessesLabel.Text = "Error desconhecido";
            }
        }
    }
}
