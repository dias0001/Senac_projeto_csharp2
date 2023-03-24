namespace padariaProjetoSenac
{
    partial class frmPesquisaClientes
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cliecdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.clientesTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.clientesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisa dos Clientes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 29);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesq Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliecdDataGridViewTextBoxColumn,
            this.clieNMDataGridViewTextBoxColumn,
            this.clieendDataGridViewTextBoxColumn,
            this.cliecidadeDataGridViewTextBoxColumn,
            this.clieestadoDataGridViewTextBoxColumn,
            this.cliecepDataGridViewTextBoxColumn,
            this.clieCPFDataGridViewTextBoxColumn,
            this.clieRGDataGridViewTextBoxColumn,
            this.clietelefoneDataGridViewTextBoxColumn,
            this.cliecelularDataGridViewTextBoxColumn,
            this.clieemailDataGridViewTextBoxColumn,
            this.cliedataCadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 247);
            this.dataGridView1.TabIndex = 7;
            // 
            // cliecdDataGridViewTextBoxColumn
            // 
            this.cliecdDataGridViewTextBoxColumn.DataPropertyName = "clie_cd";
            this.cliecdDataGridViewTextBoxColumn.HeaderText = "clie_cd";
            this.cliecdDataGridViewTextBoxColumn.Name = "cliecdDataGridViewTextBoxColumn";
            this.cliecdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clieNMDataGridViewTextBoxColumn
            // 
            this.clieNMDataGridViewTextBoxColumn.DataPropertyName = "clie_NM";
            this.clieNMDataGridViewTextBoxColumn.HeaderText = "clie_NM";
            this.clieNMDataGridViewTextBoxColumn.Name = "clieNMDataGridViewTextBoxColumn";
            // 
            // clieendDataGridViewTextBoxColumn
            // 
            this.clieendDataGridViewTextBoxColumn.DataPropertyName = "clie_end";
            this.clieendDataGridViewTextBoxColumn.HeaderText = "clie_end";
            this.clieendDataGridViewTextBoxColumn.Name = "clieendDataGridViewTextBoxColumn";
            // 
            // cliecidadeDataGridViewTextBoxColumn
            // 
            this.cliecidadeDataGridViewTextBoxColumn.DataPropertyName = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.HeaderText = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.Name = "cliecidadeDataGridViewTextBoxColumn";
            // 
            // clieestadoDataGridViewTextBoxColumn
            // 
            this.clieestadoDataGridViewTextBoxColumn.DataPropertyName = "clie_estado";
            this.clieestadoDataGridViewTextBoxColumn.HeaderText = "clie_estado";
            this.clieestadoDataGridViewTextBoxColumn.Name = "clieestadoDataGridViewTextBoxColumn";
            // 
            // cliecepDataGridViewTextBoxColumn
            // 
            this.cliecepDataGridViewTextBoxColumn.DataPropertyName = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.HeaderText = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.Name = "cliecepDataGridViewTextBoxColumn";
            // 
            // clieCPFDataGridViewTextBoxColumn
            // 
            this.clieCPFDataGridViewTextBoxColumn.DataPropertyName = "clie_CPF";
            this.clieCPFDataGridViewTextBoxColumn.HeaderText = "clie_CPF";
            this.clieCPFDataGridViewTextBoxColumn.Name = "clieCPFDataGridViewTextBoxColumn";
            // 
            // clieRGDataGridViewTextBoxColumn
            // 
            this.clieRGDataGridViewTextBoxColumn.DataPropertyName = "clie_RG";
            this.clieRGDataGridViewTextBoxColumn.HeaderText = "clie_RG";
            this.clieRGDataGridViewTextBoxColumn.Name = "clieRGDataGridViewTextBoxColumn";
            // 
            // clietelefoneDataGridViewTextBoxColumn
            // 
            this.clietelefoneDataGridViewTextBoxColumn.DataPropertyName = "clie_telefone";
            this.clietelefoneDataGridViewTextBoxColumn.HeaderText = "clie_telefone";
            this.clietelefoneDataGridViewTextBoxColumn.Name = "clietelefoneDataGridViewTextBoxColumn";
            // 
            // cliecelularDataGridViewTextBoxColumn
            // 
            this.cliecelularDataGridViewTextBoxColumn.DataPropertyName = "clie_celular";
            this.cliecelularDataGridViewTextBoxColumn.HeaderText = "clie_celular";
            this.cliecelularDataGridViewTextBoxColumn.Name = "cliecelularDataGridViewTextBoxColumn";
            // 
            // clieemailDataGridViewTextBoxColumn
            // 
            this.clieemailDataGridViewTextBoxColumn.DataPropertyName = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.HeaderText = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.Name = "clieemailDataGridViewTextBoxColumn";
            // 
            // cliedataCadastroDataGridViewTextBoxColumn
            // 
            this.cliedataCadastroDataGridViewTextBoxColumn.DataPropertyName = "clie_dataCadastro";
            this.cliedataCadastroDataGridViewTextBoxColumn.HeaderText = "clie_dataCadastro";
            this.cliedataCadastroDataGridViewTextBoxColumn.Name = "cliedataCadastroDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.systemsDataSet;
            // 
            // systemsDataSet
            // 
            this.systemsDataSet.DataSetName = "systemsDataSet";
            this.systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Pesq-Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(208, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 29);
            this.textBox2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pesquisar Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pesquisar Código";
            // 
            // frmPesquisaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesquisaClientes";
            this.Text = "Formulário de Clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private systemsDataSet systemsDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private systemsDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}