namespace Cadastro_projetos.Areas.Project
{
    partial class SubUserControlProject
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
            this.viewProjects1 = new Cadastro_projetos.Areas.Project.ViewProjects();
            this.registerProject1 = new Cadastro_projetos.Areas.Project.RegisterProject();
            this.SuspendLayout();
            // 
            // viewProjects1
            // 
            this.viewProjects1.BackColor = System.Drawing.Color.Silver;
            this.viewProjects1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProjects1.Location = new System.Drawing.Point(0, 0);
            this.viewProjects1.Name = "viewProjects1";
            this.viewProjects1.Size = new System.Drawing.Size(594, 346);
            this.viewProjects1.TabIndex = 0;
            // 
            // registerProject1
            // 
            this.registerProject1.BackColor = System.Drawing.Color.Silver;
            this.registerProject1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerProject1.Location = new System.Drawing.Point(0, 0);
            this.registerProject1.Name = "registerProject1";
            this.registerProject1.Size = new System.Drawing.Size(594, 346);
            this.registerProject1.TabIndex = 1;
            // 
            // SubUserControlProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.viewProjects1);
            this.Controls.Add(this.registerProject1);
            this.Name = "SubUserControlProject";
            this.Size = new System.Drawing.Size(594, 346);
            this.ResumeLayout(false);

        }

        #endregion

        public ViewProjects viewProjects1;
        public RegisterProject registerProject1;
    }
}
