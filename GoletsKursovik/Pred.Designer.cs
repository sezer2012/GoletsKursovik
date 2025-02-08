namespace GoletsKursovik
{
    partial class Pred
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОДиректораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предприятияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new GoletsKursovik.DatabaseDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.предприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предприятияTableAdapter = new GoletsKursovik.DatabaseDataSetTableAdapters.ПредприятияTableAdapter();
            this.прайс_листыTableAdapter = new GoletsKursovik.DatabaseDataSetTableAdapters.Прайс_листыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.названиеПредприятияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.фИОДиректораDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.предприятияBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 217);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // названиеПредприятияDataGridViewTextBoxColumn
            // 
            this.названиеПредприятияDataGridViewTextBoxColumn.DataPropertyName = "Название предприятия";
            this.названиеПредприятияDataGridViewTextBoxColumn.HeaderText = "Название предприятия";
            this.названиеПредприятияDataGridViewTextBoxColumn.Name = "названиеПредприятияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // фИОДиректораDataGridViewTextBoxColumn
            // 
            this.фИОДиректораDataGridViewTextBoxColumn.DataPropertyName = "ФИО директора";
            this.фИОДиректораDataGridViewTextBoxColumn.HeaderText = "ФИО директора";
            this.фИОДиректораDataGridViewTextBoxColumn.Name = "фИОДиректораDataGridViewTextBoxColumn";
            // 
            // предприятияBindingSource1
            // 
            this.предприятияBindingSource1.DataMember = "Предприятия";
            this.предприятияBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(646, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Вернуться на главную страницу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // предприятияBindingSource
            // 
            this.предприятияBindingSource.DataMember = "Предприятия";
            this.предприятияBindingSource.DataSource = this.databaseDataSet;
            // 
            // предприятияTableAdapter
            // 
            this.предприятияTableAdapter.ClearBeforeFill = true;
            // 
            // прайс_листыTableAdapter
            // 
            this.прайс_листыTableAdapter.ClearBeforeFill = true;
            // 
            // Pred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Name = "Pred";
            this.Text = "Предприятия";
            this.Load += new System.EventHandler(this.Pred_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предприятияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource предприятияBindingSource;
        private DatabaseDataSetTableAdapters.ПредприятияTableAdapter предприятияTableAdapter;
        private System.Windows.Forms.BindingSource предприятияBindingSource1;
        private DatabaseDataSetTableAdapters.Прайс_листыTableAdapter прайс_листыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОДиректораDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}