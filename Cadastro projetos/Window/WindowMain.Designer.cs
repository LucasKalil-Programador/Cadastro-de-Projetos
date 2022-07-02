namespace Cadastro_projetos.WindowSys
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UniversityButton = new System.Windows.Forms.Button();
            this.AdvisorButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.ProjectButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AreasCrontrol = new Cadastro_projetos.Window.AreasCrontrol();
            this.ButtonsLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 1;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.Controls.Add(this.UniversityButton, 0, 4);
            this.ButtonsLayout.Controls.Add(this.AdvisorButton, 0, 3);
            this.ButtonsLayout.Controls.Add(this.TeamButton, 0, 2);
            this.ButtonsLayout.Controls.Add(this.ProjectButton, 0, 1);
            this.ButtonsLayout.Controls.Add(this.StudentButton, 0, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(0, 0);
            this.ButtonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 5;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.Size = new System.Drawing.Size(194, 421);
            this.ButtonsLayout.TabIndex = 5;
            // 
            // UniversityButton
            // 
            this.UniversityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversityButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UniversityButton.Image = global::Cadastro_projetos.Properties.Resources.university;
            this.UniversityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UniversityButton.Location = new System.Drawing.Point(3, 339);
            this.UniversityButton.Name = "UniversityButton";
            this.UniversityButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UniversityButton.Size = new System.Drawing.Size(188, 79);
            this.UniversityButton.TabIndex = 4;
            this.UniversityButton.Text = "Universidade";
            this.UniversityButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UniversityButton.UseVisualStyleBackColor = true;
            // 
            // AdvisorButton
            // 
            this.AdvisorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvisorButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvisorButton.Image = global::Cadastro_projetos.Properties.Resources.online_counseling;
            this.AdvisorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdvisorButton.Location = new System.Drawing.Point(3, 255);
            this.AdvisorButton.Name = "AdvisorButton";
            this.AdvisorButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AdvisorButton.Size = new System.Drawing.Size(188, 78);
            this.AdvisorButton.TabIndex = 3;
            this.AdvisorButton.Text = "Orientador";
            this.AdvisorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdvisorButton.UseVisualStyleBackColor = true;
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamButton.Image = global::Cadastro_projetos.Properties.Resources.team_leader;
            this.TeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamButton.Location = new System.Drawing.Point(3, 171);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TeamButton.Size = new System.Drawing.Size(188, 78);
            this.TeamButton.TabIndex = 2;
            this.TeamButton.Text = "Equipe";
            this.TeamButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TeamButton.UseVisualStyleBackColor = false;
            // 
            // ProjectButton
            // 
            this.ProjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectButton.Image = global::Cadastro_projetos.Properties.Resources.management;
            this.ProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProjectButton.Location = new System.Drawing.Point(3, 87);
            this.ProjectButton.Name = "ProjectButton";
            this.ProjectButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ProjectButton.Size = new System.Drawing.Size(188, 78);
            this.ProjectButton.TabIndex = 1;
            this.ProjectButton.Text = "Projeto";
            this.ProjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProjectButton.UseVisualStyleBackColor = true;
            // 
            // StudentButton
            // 
            this.StudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentButton.Image = global::Cadastro_projetos.Properties.Resources.student;
            this.StudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentButton.Location = new System.Drawing.Point(3, 3);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StudentButton.Size = new System.Drawing.Size(188, 78);
            this.StudentButton.TabIndex = 0;
            this.StudentButton.Text = "Aluno";
            this.StudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40273F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonsLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AreasCrontrol, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 421);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // AreasCrontrol
            // 
            this.AreasCrontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreasCrontrol.Location = new System.Drawing.Point(197, 3);
            this.AreasCrontrol.Name = "AreasCrontrol";
            this.AreasCrontrol.Size = new System.Drawing.Size(561, 415);
            this.AreasCrontrol.TabIndex = 6;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(670, 385);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ButtonsLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel ButtonsLayout;
        private Button UniversityButton;
        private Button AdvisorButton;
        private Button TeamButton;
        private Button ProjectButton;
        private Button StudentButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Cadastro_projetos.Window.AreasCrontrol AreasCrontrol;
    }
}