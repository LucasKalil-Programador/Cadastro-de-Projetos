namespace Cadastro_projetos.Advisor
{
    partial class AdvisorArea
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ViewAndEditButton = new System.Windows.Forms.Button();
            this.subUserControlAdvisor1 = new Cadastro_projetos.Advisor.SubUserControlAdvisor();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subUserControlAdvisor1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // 
            // ViewAndEditButton
            // 
            this.ViewAndEditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAndEditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAndEditButton.Location = new System.Drawing.Point(333, 3);
            this.ViewAndEditButton.Name = "ViewAndEditButton";
            this.ViewAndEditButton.Size = new System.Drawing.Size(204, 54);
            this.ViewAndEditButton.TabIndex = 2;
            this.ViewAndEditButton.Text = "Visualizar / Edição";
            this.ViewAndEditButton.UseVisualStyleBackColor = true;
            // 
            // subUserControlAdvisor1
            // 
            this.subUserControlAdvisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subUserControlAdvisor1.Location = new System.Drawing.Point(3, 3);
            this.subUserControlAdvisor1.Name = "subUserControlAdvisor1";
            this.subUserControlAdvisor1.Size = new System.Drawing.Size(594, 346);
            this.subUserControlAdvisor1.TabIndex = 2;
            // 
            // AdvisorArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdvisorArea";
            this.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RegisterButton;
        private Button ViewAndEditButton;
        private SubUserControlAdvisor subUserControlAdvisor1;
    }
}
