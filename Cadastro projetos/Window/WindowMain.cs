namespace Cadastro_projetos.WindowSys
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            resetAndSetButtons(StudentButton, studentArea1);
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            resetAndSetButtons((Button)sender, studentArea1);
        }

        private void ProjectButton_Click(object sender, EventArgs e)
        {
            resetAndSetButtons((Button)sender, projectArea1);
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            resetAndSetButtons((Button)sender, teamArea1);
        }

        private void AdvisorButton_Click(object sender, EventArgs e)
        {
            resetAndSetButtons((Button)sender, advisorArea1);
        }

        private void UniversityButton_Click(object sender, EventArgs e)
        {
            resetAndSetButtons((Button)sender, universityArea1);
        }

        private void resetAndSetButtons(Button buttonIn, UserControl userControlIn)
        {
            Button[] buttons = { StudentButton, ProjectButton, TeamButton, AdvisorButton, UniversityButton };
            foreach (Button button in buttons)
                button.BackColor = SystemColors.ControlLight;
            buttonIn.BackColor = SystemColors.ActiveCaption;

            UserControl[] userControls = { studentArea1, projectArea1, teamArea1, advisorArea1, universityArea1 };
            foreach (UserControl userControl in userControls)
            {
                userControl.Visible = false;
                userControl.Enabled = false;
            }
            userControlIn.Enabled = true;
            userControlIn.Visible = true;
        }
    }
}