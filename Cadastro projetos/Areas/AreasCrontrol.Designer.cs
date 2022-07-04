using Cadastro_projetos.Student;
using Cadastro_projetos.University;
using Cadastro_projetos.Advisor;
using Cadastro_projetos.Project;

namespace Cadastro_projetos.Window
{
    partial class AreasCrontrol
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
            this.AdvisorArea = new Cadastro_projetos.Advisor.AdvisorArea();
            this.ProjectArea = new Cadastro_projetos.Project.ProjectArea();
            this.StudentArea = new Cadastro_projetos.Student.StudentArea();
            this.TeamArea = new Cadastro_projetos.TeamArea();
            this.UniversityArea = new Cadastro_projetos.University.UniversityArea();
            this.SuspendLayout();
            // 
            // AdvisorArea
            // 
            this.AdvisorArea.BackColor = System.Drawing.Color.Silver;
            this.AdvisorArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvisorArea.Location = new System.Drawing.Point(0, 0);
            this.AdvisorArea.Name = "AdvisorArea";
            this.AdvisorArea.Size = new System.Drawing.Size(561, 415);
            this.AdvisorArea.TabIndex = 0;
            // 
            // ProjectArea
            // 
            this.ProjectArea.BackColor = System.Drawing.Color.Silver;
            this.ProjectArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectArea.Location = new System.Drawing.Point(0, 0);
            this.ProjectArea.Name = "ProjectArea";
            this.ProjectArea.Size = new System.Drawing.Size(561, 415);
            this.ProjectArea.TabIndex = 1;
            // 
            // StudentArea
            // 
            this.StudentArea.BackColor = System.Drawing.Color.Silver;
            this.StudentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentArea.Location = new System.Drawing.Point(0, 0);
            this.StudentArea.Name = "StudentArea";
            this.StudentArea.Size = new System.Drawing.Size(561, 415);
            this.StudentArea.TabIndex = 2;
            // 
            // TeamArea
            // 
            this.TeamArea.BackColor = System.Drawing.Color.Silver;
            this.TeamArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamArea.Location = new System.Drawing.Point(0, 0);
            this.TeamArea.Name = "TeamArea";
            this.TeamArea.Size = new System.Drawing.Size(561, 415);
            this.TeamArea.TabIndex = 3;
            // 
            // UniversityArea
            // 
            this.UniversityArea.BackColor = System.Drawing.Color.Silver;
            this.UniversityArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversityArea.Location = new System.Drawing.Point(0, 0);
            this.UniversityArea.Name = "UniversityArea";
            this.UniversityArea.Size = new System.Drawing.Size(561, 415);
            this.UniversityArea.TabIndex = 4;
            // 
            // AreasCrontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentArea);
            this.Controls.Add(this.TeamArea);
            this.Controls.Add(this.AdvisorArea);
            this.Controls.Add(this.ProjectArea);
            this.Controls.Add(this.UniversityArea);
            this.Name = "AreasCrontrol";
            this.Size = new System.Drawing.Size(561, 415);
            this.ResumeLayout(false);

        }

        #endregion

        public AdvisorArea AdvisorArea;
        public ProjectArea ProjectArea;
        public StudentArea StudentArea;
        public TeamArea TeamArea;
        public UniversityArea UniversityArea;
    }
}
