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
using MySql.Data.MySqlClient;

namespace Cadastro_projetos
{
    public partial class StudentArea : UserControl
    {
        public StudentArea()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = NomeTextBox.Text;
            string matricula = matriculatextBot.Text;
            string semestre = semestreTextBox.Text;

            Connection.ExecuteQuery($"INSERT INTO Aluno (nome, matricula, semestre) values ('{nome}','{matricula}','{semestre}');");

            matriculatextBot.Clear();
            semestreTextBox.Clear();
            NomeTextBox.Clear();
        }
    }
}
