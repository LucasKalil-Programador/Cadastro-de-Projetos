namespace Cadastro_projetos.University
{
    partial class SubUserControlUniversity
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
            this.ViewAndEdit = new Cadastro_projetos.University.ViewAndEditUniversity();
            this.Register = new Cadastro_projetos.University.RegisterUniversity();
            this.SuspendLayout();
            // 
            // viewAndEdit
            // 
            this.ViewAndEdit.BackColor = System.Drawing.Color.Silver;
            this.ViewAndEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAndEdit.Location = new System.Drawing.Point(0, 0);
            this.ViewAndEdit.Name = "viewAndEdit";
            this.ViewAndEdit.Size = new System.Drawing.Size(575, 349);
            this.ViewAndEdit.TabIndex = 0;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Silver;
            this.Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register.Location = new System.Drawing.Point(0, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(575, 349);
            this.Register.TabIndex = 1;
            // 
            // SubUserControlUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.ViewAndEdit);
            this.Controls.Add(this.Register);
            this.Name = "SubUserControlUniversity";
            this.Size = new System.Drawing.Size(575, 349);
            this.ResumeLayout(false);

        }

        #endregion

        public University.RegisterUniversity Register;
        public University.ViewAndEditUniversity ViewAndEdit;
    }
}
