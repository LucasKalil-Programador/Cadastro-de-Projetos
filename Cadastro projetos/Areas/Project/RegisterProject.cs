using Cadastro_projetos.Entities;
using Cadastro_projetos.SQLConnection;
using System.Text.RegularExpressions;

namespace Cadastro_projetos.Areas.Project
{
    public partial class RegisterProject : UserControl
    {
        public RegisterProject()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void UpdateDataGrids()
        {
            Universidade[] universidades = Connection.SelectAllFromUniversidade();
            TableUniversity.Rows.Clear();
            for (int i = 0; i < universidades.Length; i++)
                TableUniversity.Rows.Add(universidades[i].Id, universidades[i].Name);

            Orientador[] orientadores = Connection.SelectAllFromOrientador();
            TableAdvisor.Rows.Clear();
            for (int i = 0; i < orientadores.Length; i++)
                TableAdvisor.Rows.Add(orientadores[i].Id, orientadores[i].Name, orientadores[i].Subjects);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string references = ReferencesTextBox.Text;
            string description = DescriptionTextBox.Text;
            string name = NameTextBox.Text;
            string type = TypeTextBox.Text;
            string iDAdvisor = "";
            string iDUniversiry = "";
            try
            {
                iDAdvisor = (string)TableAdvisor.SelectedRows[0].Cells[0].Value;
            }
            catch { }
            try
            {
                iDUniversiry = (string)TableUniversity.SelectedRows[0].Cells[0].Value;
            }
            catch { }


            if (Validate(references, description, name, type, iDAdvisor, iDUniversiry))
            {
                InsertOnDB(references, description, name, type, iDAdvisor, iDUniversiry);
            }
        }

        private void InsertOnDB(string references, string description, string name,
            string type, string iDAdvisor, string iDUniversiry)
        {
            pictureBox1.Visible = true;
            Projeto projeto = new(String.Empty, name, type, references, description,
                new Orientador(iDAdvisor, string.Empty, string.Empty),
                new Universidade(iDUniversiry, string.Empty));
            bool result = Connection.InsertProjeto(projeto);
            if (result)
            {
                this.pictureBox1.BackgroundImage = Properties.Resources.sucesses;
                ErrorOrSucessesLabel.Text = "Cadastro realizado com sucesso!";

                ReferencesTextBox.Text = "Escreva as referencias usadas aqui";
                DescriptionTextBox.Text = "Escreva a descrição aqui";
                NameTextBox.Clear();
                TypeTextBox.Clear();

            }
            else
            {
                this.pictureBox1.BackgroundImage = Properties.Resources.error;
                ErrorOrSucessesLabel.Text = "Error desconhecido";
            }
        }

        private bool Validate(string references, string description, string name,
            string type, string iDAdvisor, string iDUniversiry)
        {
            bool referencesIsValid = Regex.IsMatch(references, "[A-z].+");
            bool descriptionIsValid = Regex.IsMatch(description, "[A-z].+");
            bool nameIsValid = Regex.IsMatch(name, "[A-z].+");
            bool typeIsValid = Regex.IsMatch(type, "[A-z].+");
            bool iDAdvisorIsValid = iDAdvisor != null && Regex.IsMatch(iDAdvisor, "[0-9]+");
            bool iDUniversiryIsValid = iDUniversiry != null && Regex.IsMatch(iDUniversiry, "[0-9]+");

            if (referencesIsValid && descriptionIsValid && nameIsValid && typeIsValid && iDAdvisorIsValid && iDUniversiryIsValid)
            {
                return true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = Properties.Resources.error;
                ErrorOrSucessesLabel.Text = "Alguns erros foram detectados verifique capos em branco";
                if (!nameIsValid) NameTextBox.BackColor = Color.Red;
                if (!typeIsValid) TypeTextBox.BackColor = Color.Red;


                return false;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateDataGrids();
        }
    }
}
