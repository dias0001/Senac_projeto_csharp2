namespace padariaProjetoSenac
{
    partial class frmPesquisaServicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servprecoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.servicosTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.servicosTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisa de Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pesquisar código";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 16;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 29);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesq Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servCDDataGridViewTextBoxColumn,
            this.servNMDataGridViewTextBoxColumn,
            this.servprecoUnitarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 247);
            this.dataGridView1.TabIndex = 13;
            // 
            // servCDDataGridViewTextBoxColumn
            // 
            this.servCDDataGridViewTextBoxColumn.DataPropertyName = "serv_CD";
            this.servCDDataGridViewTextBoxColumn.HeaderText = "serv_CD";
            this.servCDDataGridViewTextBoxColumn.Name = "servCDDataGridViewTextBoxColumn";
            this.servCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servNMDataGridViewTextBoxColumn
            // 
            this.servNMDataGridViewTextBoxColumn.DataPropertyName = "serv_NM";
            this.servNMDataGridViewTextBoxColumn.HeaderText = "serv_NM";
            this.servNMDataGridViewTextBoxColumn.Name = "servNMDataGridViewTextBoxColumn";
            // 
            // servprecoUnitarioDataGridViewTextBoxColumn
            // 
            this.servprecoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "serv_precoUnitario";
            this.servprecoUnitarioDataGridViewTextBoxColumn.HeaderText = "serv_precoUnitario";
            this.servprecoUnitarioDataGridViewTextBoxColumn.Name = "servprecoUnitarioDataGridViewTextBoxColumn";
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "servicos";
            this.servicosBindingSource.DataSource = this.systemsDataSet;
            // 
            // systemsDataSet
            // 
            this.systemsDataSet.DataSetName = "systemsDataSet";
            this.systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Pesq Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(208, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 29);
            this.textBox2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Pesquisar nome";
            // 
            // frmPesquisaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesquisaServicos";
            this.Text = "frmPesquisaServicos";
            this.Load += new System.EventHandler(this.frmPesquisaServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private systemsDataSet systemsDataSet;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private systemsDataSetTableAdapters.servicosTableAdapter servicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servprecoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}