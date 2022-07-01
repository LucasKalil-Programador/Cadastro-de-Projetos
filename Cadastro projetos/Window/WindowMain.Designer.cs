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
            this.StudentButton = new System.Windows.Forms.Button();
            this.ProjectButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.AdvisorButton = new System.Windows.Forms.Button();
            this.UniversityButton = new System.Windows.Forms.Button();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.studentArea1 = new Cadastro_projetos.StudentArea();
            this.teamArea1 = new Cadastro_projetos.TeamArea();
            this.advisorArea1 = new Cadastro_projetos.AdvisorArea();
            this.universityArea1 = new Cadastro_projetos.UniversityArea();
            this.projectArea1 = new Cadastro_projetos.ProjectArea();
            this.ButtonsLayout.SuspendLayout();
            this.SuspendLayout();
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
            this.StudentButton.Size = new System.Drawing.Size(181, 76);
            this.StudentButton.TabIndex = 0;
            this.StudentButton.Text = "Aluno";
            this.StudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // ProjectButton
            // 
            this.ProjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectButton.Image = global::Cadastro_projetos.Properties.Resources.management;
            this.ProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProjectButton.Location = new System.Drawing.Point(3, 85);
            this.ProjectButton.Name = "ProjectButton";
            this.ProjectButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ProjectButton.Size = new System.Drawing.Size(181, 76);
            this.ProjectButton.TabIndex = 1;
            this.ProjectButton.Text = "Projeto";
            this.ProjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProjectButton.UseVisualStyleBackColor = true;
            this.ProjectButton.Click += new System.EventHandler(this.ProjectButton_Click);
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamButton.Image = global::Cadastro_projetos.Properties.Resources.team_leader;
            this.TeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamButton.Location = new System.Drawing.Point(3, 167);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TeamButton.Size = new System.Drawing.Size(181, 76);
            this.TeamButton.TabIndex = 2;
            this.TeamButton.Text = "Equipe";
            this.TeamButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TeamButton.UseVisualStyleBackColor = false;
            this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
            // 
            // AdvisorButton
            // 
            this.AdvisorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvisorButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvisorButton.Image = global::Cadastro_projetos.Properties.Resources.online_counseling;
            this.AdvisorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdvisorButton.Location = new System.Drawing.Point(3, 249);
            this.AdvisorButton.Name = "AdvisorButton";
            this.AdvisorButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AdvisorButton.Size = new System.Drawing.Size(181, 76);
            this.AdvisorButton.TabIndex = 3;
            this.AdvisorButton.Text = "Orientador";
            this.AdvisorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdvisorButton.UseVisualStyleBackColor = true;
            this.AdvisorButton.Click += new System.EventHandler(this.AdvisorButton_Click);
            // 
            // UniversityButton
            // 
            this.UniversityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversityButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UniversityButton.Image = global::Cadastro_projetos.Properties.Resources.university;
            this.UniversityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UniversityButton.Location = new System.Drawing.Point(3, 331);
            this.UniversityButton.Name = "UniversityButton";
            this.UniversityButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UniversityButton.Size = new System.Drawing.Size(181, 78);
            this.UniversityButton.TabIndex = 4;
            this.UniversityButton.Text = "Universidade";
            this.UniversityButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UniversityButton.UseVisualStyleBackColor = true;
            this.UniversityButton.Click += new System.EventHandler(this.UniversityButton_Click);
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 1;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.UniversityButton, 0, 4);
            this.ButtonsLayout.Controls.Add(this.AdvisorButton, 0, 3);
            this.ButtonsLayout.Controls.Add(this.TeamButton, 0, 2);
            this.ButtonsLayout.Controls.Add(this.ProjectButton, 0, 1);
            this.ButtonsLayout.Controls.Add(this.StudentButton, 0, 0);
            this.ButtonsLayout.Location = new System.Drawing.Point(-1, -1);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 5;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.Size = new System.Drawing.Size(187, 412);
            this.ButtonsLayout.TabIndex = 5;
            // 
            // studentArea1
            // 
            this.studentArea1.BackColor = System.Drawing.Color.Silver;
            this.studentArea1.Location = new System.Drawing.Point(189, -1);
            this.studentArea1.Name = "studentArea1";
            this.studentArea1.Size = new System.Drawing.Size(595, 415);
            this.studentArea1.TabIndex = 6;
            // 
            // teamArea1
            // 
            this.teamArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.teamArea1.Location = new System.Drawing.Point(189, -1);
            this.teamArea1.Name = "teamArea1";
            this.teamArea1.Size = new System.Drawing.Size(595, 412);
            this.teamArea1.TabIndex = 7;
            // 
            // advisorArea1
            // 
            this.advisorArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.advisorArea1.Location = new System.Drawing.Point(189, -1);
            this.advisorArea1.Name = "advisorArea1";
            this.advisorArea1.Size = new System.Drawing.Size(595, 412);
            this.advisorArea1.TabIndex = 8;
            // 
            // universityArea1
            // 
            this.universityArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.universityArea1.Location = new System.Drawing.Point(189, -1);
            this.universityArea1.Name = "universityArea1";
            this.universityArea1.Size = new System.Drawing.Size(595, 412);
            this.universityArea1.TabIndex = 9;
            // 
            // projectArea1
            // 
            this.projectArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.projectArea1.Location = new System.Drawing.Point(189, -1);
            this.projectArea1.Name = "projectArea1";
            this.projectArea1.Size = new System.Drawing.Size(595, 415);
            this.projectArea1.TabIndex = 10;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.teamArea1);
            this.Controls.Add(this.ButtonsLayout);
            this.Controls.Add(this.studentArea1);
            this.Controls.Add(this.advisorArea1);
            this.Controls.Add(this.projectArea1);
            this.Controls.Add(this.universityArea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Text = "Form1";
            this.ButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button StudentButton;
        private Button ProjectButton;
        private Button TeamButton;
        private Button AdvisorButton;
        private Button UniversityButton;
        private TableLayoutPanel ButtonsLayout;
        private StudentArea studentArea1;
        private TeamArea teamArea1;
        private AdvisorArea advisorArea1;
        private UniversityArea universityArea1;
        private ProjectArea projectArea1;
    }
}