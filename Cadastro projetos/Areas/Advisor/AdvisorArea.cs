namespace Cadastro_projetos.Advisor
{
    public partial class AdvisorArea : UserControl
    {
        public AdvisorArea()
        {
            InitializeComponent();
            RegisterButton_Click(new object(), EventArgs.Empty);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            ViewAndEditButton.BackColor = SystemColors.ControlLight;

            subUserControlAdvisor1.registerAdvisor1.Enabled = true;
            subUserControlAdvisor1.registerAdvisor1.Visible = true;
            subUserControlAdvisor1.viewAndEditAdvisor1.Enabled = false;
            subUserControlAdvisor1.viewAndEditAdvisor1.Visible = false;
        }

        private void ViewAndEditButton_Click(object sender, EventArgs e)
        {
            ViewAndEditButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.BackColor = SystemColors.ControlLight;

            subUserControlAdvisor1.viewAndEditAdvisor1.On_ChangeForThis();
            subUserControlAdvisor1.viewAndEditAdvisor1.Enabled = true;
            subUserControlAdvisor1.viewAndEditAdvisor1.Visible = true;
            subUserControlAdvisor1.registerAdvisor1.Enabled = false;
            subUserControlAdvisor1.registerAdvisor1.Visible = false;
        }
    }
}
