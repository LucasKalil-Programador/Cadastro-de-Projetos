namespace Cadastro_projetos.Student
{
    partial class SubUserControlStudent
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register = new Cadastro_projetos.Student.RegisterStudant();
            this.viewAndEdit1 = new Cadastro_projetos.Student.ViewAndEditStudant();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register.Location = new System.Drawing.Point(0, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(589, 346);
            this.Register.TabIndex = 0;
            // 
            // viewAndEdit1
            // 
            this.viewAndEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAndEdit1.Location = new System.Drawing.Point(0, 0);
            this.viewAndEdit1.Name = "viewAndEdit1";
            this.viewAndEdit1.Size = new System.Drawing.Size(589, 346);
            this.viewAndEdit1.TabIndex = 1;
            // 
            // SubUserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewAndEdit1);
            this.Controls.Add(this.Register);
            this.Name = "SubUserControlStudent";
            this.Size = new System.Drawing.Size(589, 346);
            this.ResumeLayout(false);

        }

        #endregion

        public RegisterStudant Register;
        public ViewAndEditStudant viewAndEdit1;
    }
}
