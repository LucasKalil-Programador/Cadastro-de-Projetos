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

namespace Cadastro_projetos.Student
{
    public partial class StudentArea : UserControl
    {
        public StudentArea()
        {
            InitializeComponent();
            RegisterButton_Click(new object(), EventArgs.Empty);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            ViewAndEditButton.BackColor = SystemColors.ControlLight;

            UserControlStudent.Register.Enabled = true;
            UserControlStudent.Register.Visible = true;
            UserControlStudent.viewAndEdit1.Enabled = false;
            UserControlStudent.viewAndEdit1.Visible = false;
        }

        private void ViewAndEditButton_Click(object sender, EventArgs e)
        {
            ViewAndEditButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.BackColor = SystemColors.ControlLight;

            UserControlStudent.viewAndEdit1.Enabled = true;
            UserControlStudent.viewAndEdit1.Visible = true;
            UserControlStudent.Register.Enabled = false;
            UserControlStudent.Register.Visible = false;
        }
    }
}
