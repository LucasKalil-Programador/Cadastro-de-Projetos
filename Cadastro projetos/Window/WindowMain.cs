namespace Cadastro_projetos.WindowSys
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void On_SizeChange(object sender, EventArgs e)
        {
            Console.WriteLine(Height + ";" + Width);
        }
    }
}