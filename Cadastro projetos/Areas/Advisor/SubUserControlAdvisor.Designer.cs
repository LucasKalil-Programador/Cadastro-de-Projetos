namespace Cadastro_projetos.Advisor
{
    partial class SubUserControlAdvisor
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
            this.registerAdvisor1 = new Cadastro_projetos.Advisor.RegisterAdvisor();
            this.viewAndEditAdvisor1 = new Cadastro_projetos.Advisor.ViewAndEditAdvisor();
            this.SuspendLayout();
            // 
            // registerAdvisor1
            // 
            this.registerAdvisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerAdvisor1.Location = new System.Drawing.Point(0, 0);
            this.registerAdvisor1.Name = "registerAdvisor1";
            this.registerAdvisor1.Size = new System.Drawing.Size(594, 346);
            this.registerAdvisor1.TabIndex = 0;
            // 
            // viewAndEditAdvisor1
            // 
            this.viewAndEditAdvisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAndEditAdvisor1.Location = new System.Drawing.Point(0, 0);
            this.viewAndEditAdvisor1.Name = "viewAndEditAdvisor1";
            this.viewAndEditAdvisor1.Size = new System.Drawing.Size(594, 346);
            this.viewAndEditAdvisor1.TabIndex = 1;
            // 
            // SubUserControlAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.viewAndEditAdvisor1);
            this.Controls.Add(this.registerAdvisor1);
            this.Name = "SubUserControlAdvisor";
            this.Size = new System.Drawing.Size(594, 346);
            this.ResumeLayout(false);

        }

        #endregion

        public RegisterAdvisor registerAdvisor1;
        public ViewAndEditAdvisor viewAndEditAdvisor1;
    }
}
