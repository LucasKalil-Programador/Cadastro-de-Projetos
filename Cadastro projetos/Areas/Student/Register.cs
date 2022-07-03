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
using Cadastro_projetos.SQLConnection;
using System.Text.RegularExpressions;

namespace Cadastro_projetos.Student
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
            pictureBox.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string semester = SemesterNumeric.Text;
            string registerNumber = RegisterNumberTextBox.Text;

            pictureBox.Visible = true;

            if (ValidationData(name, registerNumber))
                InsertOnDB(name, semester, registerNumber);
            else
                return;
        }

        private bool ValidationData(string name, string registerNumber)
        {
            bool nameIsValid = Regex.IsMatch(name, "([A-Za-z]| )+");
            bool registerNumberIsValid =  Regex.IsMatch(registerNumber, "[0-9]{10}");
            ErrorOrSucessesLabel.Text = "";

            if (!nameIsValid || !registerNumberIsValid)
                this.pictureBox.BackgroundImage = Properties.Resources.error;

            if (!nameIsValid && !registerNumberIsValid)
                ErrorOrSucessesLabel.Text = "O nome e matricula invalidos";
            else if (!nameIsValid)
                ErrorOrSucessesLabel.Text = "O nome esta invalido";
            else if (!registerNumberIsValid)
                ErrorOrSucessesLabel.Text = "A matricula esta invalida";

            NameTextBox.BackColor = nameIsValid ? Color.White : Color.Red;
            RegisterNumberTextBox.BackColor = registerNumberIsValid ? Color.White : Color.Red;

            return nameIsValid && registerNumberIsValid;
        }

        private void InsertOnDB(string name, string semester, string registerNumber)
        {
            Aluno aluno = new (String.Empty, name, registerNumber, semester);
            bool result = Connection.InsertAluno(aluno);
            if (result)
            {
                this.pictureBox.BackgroundImage = Properties.Resources.sucesses;
                ErrorOrSucessesLabel.Text = "Cadastro realizado com sucesso!";

                NameTextBox.Clear();
                SemesterNumeric.Value = 1;
                RegisterNumberTextBox.Clear();
            }
            else
            {
                this.pictureBox.BackgroundImage = Properties.Resources.error;
                ErrorOrSucessesLabel.Text = "Error desconhecido";
            }
        }
    }
}
