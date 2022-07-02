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
        public ViewAndEdit()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Aluno[] alunos = Connection.SelectAllFromAluno();

            TableAluno.Rows.Clear();
            for (int i = 0; i < alunos.Length; i++)
            {
                TableAluno.Rows.Add(alunos[i].id, alunos[i].Name, alunos[i].RegisterNumber, alunos[i].Semester);
            }
        }
    }
}
