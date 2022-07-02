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

namespace Cadastro_projetos.Student
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string semester = SemesterNumeric.Text;
            string registerNumber = RegisterNumberTextBox.Text;

            Aluno aluno = new Aluno(String.Empty, name, registerNumber, semester);
            Connection.InsertAluno(aluno);
        }
    }
}
