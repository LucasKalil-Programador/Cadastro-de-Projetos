namespace Cadastro_projetos.Project
{
    partial class ProjectArea
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ViewAndEditButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subUserControlProject1 = new Cadastro_projetos.Areas.Project.SubUserControlProject();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.RegisterButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ViewAndEditButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 352);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(63, 3);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(204, 54);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Cadastro";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ViewAndEditButton
            // 
            this.ViewAndEditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAndEditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAndEditButton.Location = new System.Drawing.Point(333, 3);
            this.ViewAndEditButton.Name = "ViewAndEditButton";
            this.ViewAndEditButton.Size = new System.Drawing.Size(204, 54);
            this.ViewAndEditButton.TabIndex = 2;
            this.ViewAndEditButton.Text = "Visualizar/Edição";
            this.ViewAndEditButton.UseVisualStyleBackColor = true;
            this.ViewAndEditButton.Click += new System.EventHandler(this.ViewAndEditButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subUserControlProject1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // subUserControlProject1
            // 
            this.subUserControlProject1.BackColor = System.Drawing.Color.Silver;
            this.subUserControlProject1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subUserControlProject1.Location = new System.Drawing.Point(3, 3);
            this.subUserControlProject1.Name = "subUserControlProject1";
            this.subUserControlProject1.Size = new System.Drawing.Size(594, 346);
            this.subUserControlProject1.TabIndex = 2;
            // 
            // ProjectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectArea";
            this.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button RegisterButton;
        private Button ViewAndEditButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Areas.Project.SubUserControlProject subUserControlProject1;
    }
}
