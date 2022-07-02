namespace Cadastro_projetos.WindowSys
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
            On_Button_Click(StudentButton, AreasCrontrol.StudentArea);
        }

        private void On_Button_Click(Button button, UserControl area)
        {

            // Prepare ButtonsList
            List<Button> ButtonsList = new() { StudentButton, ProjectButton, TeamButton, AdvisorButton, UniversityButton };
            ButtonsList.Remove(button);

            // Change Buttons Colors
            ButtonsList.ForEach(item => { item.BackColor = SystemColors.ControlLight; });
            button.BackColor = SystemColors.ActiveCaption;

            // Prepare UserControlsList
            List<UserControl> userControlsList = new() { AreasCrontrol.StudentArea, AreasCrontrol.ProjectArea, AreasCrontrol.TeamArea, AreasCrontrol.AdvisorArea, AreasCrontrol.UniversityArea };
            userControlsList.Remove(area);

            // Change visibility and enabled
            userControlsList.ForEach(item => { item.Visible = false; item.Enabled = false; });
            area.Visible = true;
            area.Enabled = true;
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            On_Button_Click(((Button)sender), AreasCrontrol.StudentArea);
        }

        private void ProjectButton_Click(object sender, EventArgs e)
        {
            On_Button_Click(((Button)sender), AreasCrontrol.ProjectArea);
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            On_Button_Click(((Button)sender), AreasCrontrol.TeamArea);
        }

        private void AdvisorButton_Click(object sender, EventArgs e)
        {
            On_Button_Click(((Button)sender), AreasCrontrol.AdvisorArea);
        }

        private void UniversityButton_Click(object sender, EventArgs e)
        {
            On_Button_Click(((Button)sender), AreasCrontrol.UniversityArea);
        }
    }
}