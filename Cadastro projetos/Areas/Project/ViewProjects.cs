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
    public partial class ViewProjects : UserControl
    {
        public ViewProjects()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Projeto[] projetos = Connection.SelectFromProjeto();
            DataGrid.Rows.Clear();
            foreach (Projeto projeto in projetos)
            {
                DataGrid.Rows.Add(projeto.Id, projeto.Name, projeto.Description, projeto.References, projeto.Orientador.Name, projeto.Orientador.Subjects, projeto.Universidade.Name);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DataGrid.SelectedRows.Count; i++)
            {
                var projeto = DataGrid.SelectedRows[i].Cells[0].Value;
                if (projeto is string && Regex.IsMatch((string)projeto, "[0-9]+"))
                {
                    Connection.DeleteProjeto(new Projeto((string)projeto, string.Empty, string.Empty, string.Empty, string.Empty, new Orientador(string.Empty, string.Empty, string.Empty), new Universidade(string.Empty, string.Empty)));
                }
            }

            RefreshButton_Click(new object(), EventArgs.Empty);
        }
    }
}
