namespace Cadastro_projetos
{
    partial class TeamArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.iD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.References = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvisorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Universidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableAluno = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.DataGrid, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TableAluno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGrid
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD,
            this.NameP,
            this.Description,
            this.References,
            this.TypeP,
            this.AdvisorName,
            this.Subjects,
            this.Universidade});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(403, 85);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.Size = new System.Drawing.Size(194, 241);
            this.DataGrid.TabIndex = 2;
            // 
            // iD
            // 
            this.iD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iD.HeaderText = "ID";
            this.iD.Name = "iD";
            this.iD.Width = 43;
            // 
            // NameP
            // 
            this.NameP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameP.HeaderText = "Nome";
            this.NameP.Name = "NameP";
            this.NameP.Width = 65;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Descriçao";
            this.Description.Name = "Description";
            this.Description.Width = 83;
            // 
            // References
            // 
            this.References.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.References.HeaderText = "Referencias";
            this.References.Name = "References";
            this.References.Width = 92;
            // 
            // TypeP
            // 
            this.TypeP.HeaderText = "Tipo";
            this.TypeP.Name = "TypeP";
            // 
            // AdvisorName
            // 
            this.AdvisorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdvisorName.HeaderText = "Orientador";
            this.AdvisorName.Name = "AdvisorName";
            this.AdvisorName.Width = 89;
            // 
            // Subjects
            // 
            this.Subjects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subjects.HeaderText = "Materias do orientador";
            this.Subjects.Name = "Subjects";
            this.Subjects.Width = 139;
            // 
            // Universidade
            // 
            this.Universidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Universidade.HeaderText = "Universidade";
            this.Universidade.Name = "Universidade";
            // 
            // TableAluno
            // 
            this.TableAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NameA,
            this.Semester,
            this.RegisterNumber});
            this.TableAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableAluno.Location = new System.Drawing.Point(3, 85);
            this.TableAluno.Name = "TableAluno";
            this.TableAluno.RowTemplate.Height = 25;
            this.TableAluno.Size = new System.Drawing.Size(194, 241);
            this.TableAluno.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // NameA
            // 
            this.NameA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameA.HeaderText = "Nome";
            this.NameA.Name = "NameA";
            this.NameA.ReadOnly = true;
            this.NameA.Width = 78;
            // 
            // Semester
            // 
            this.Semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Semester.HeaderText = "Semestre";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // RegisterNumber
            // 
            this.RegisterNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RegisterNumber.HeaderText = "Matricula";
            this.RegisterNumber.Name = "RegisterNumber";
            this.RegisterNumber.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.Location = new System.Drawing.Point(203, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(194, 241);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Semestre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // TeamArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeamArea";
            this.Size = new System.Drawing.Size(600, 412);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn iD;
        private DataGridViewTextBoxColumn NameP;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn References;
        private DataGridViewTextBoxColumn TypeP;
        private DataGridViewTextBoxColumn AdvisorName;
        private DataGridViewTextBoxColumn Subjects;
        private DataGridViewTextBoxColumn Universidade;
        private DataGridView TableAluno;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NameA;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn RegisterNumber;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
