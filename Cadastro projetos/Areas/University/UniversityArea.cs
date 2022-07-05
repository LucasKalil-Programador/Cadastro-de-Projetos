namespace Cadastro_projetos.University
{
    public partial class UniversityArea : UserControl
    {
        public UniversityArea()
        {
            InitializeComponent();
            RegisterButton_Click(new object(), EventArgs.Empty);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            ViewAndEditButton.BackColor = SystemColors.ControlLight;

            subUserControlUniversity1.Register.Enabled = true;
            subUserControlUniversity1.Register.Visible = true;
            subUserControlUniversity1.ViewAndEdit.Enabled = false;
            subUserControlUniversity1.ViewAndEdit.Visible = false;
        }

        private void ViewAndEditButton_Click(object sender, EventArgs e)
        {
            ViewAndEditButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.BackColor = SystemColors.ControlLight;

            subUserControlUniversity1.ViewAndEdit.On_ChangeForThis();
            subUserControlUniversity1.ViewAndEdit.Enabled = true;
            subUserControlUniversity1.ViewAndEdit.Visible = true;
            subUserControlUniversity1.Register.Enabled = false;
            subUserControlUniversity1.Register.Visible = false;
        }

    }
}
