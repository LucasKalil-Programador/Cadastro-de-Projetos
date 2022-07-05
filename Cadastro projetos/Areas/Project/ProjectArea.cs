namespace Cadastro_projetos.Project
{
    public partial class ProjectArea : UserControl
    {
        public ProjectArea()
        {
            InitializeComponent();
            RegisterButton_Click(new object(), EventArgs.Empty);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            ViewAndEditButton.BackColor = SystemColors.ControlLight;

            subUserControlProject1.registerProject1.Visible = true;
            subUserControlProject1.registerProject1.Enabled = true;
            subUserControlProject1.viewProjects1.Visible = false;
            subUserControlProject1.viewProjects1.Enabled = false;
        }

        private void ViewAndEditButton_Click(object sender, EventArgs e)
        {
            ViewAndEditButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.BackColor = SystemColors.ControlLight;

            subUserControlProject1.viewProjects1.On_ChangeForThis();
            subUserControlProject1.registerProject1.Visible = false;
            subUserControlProject1.registerProject1.Enabled = false;
            subUserControlProject1.viewProjects1.Visible = true;
            subUserControlProject1.viewProjects1.Enabled = true;
        }
    }
}
