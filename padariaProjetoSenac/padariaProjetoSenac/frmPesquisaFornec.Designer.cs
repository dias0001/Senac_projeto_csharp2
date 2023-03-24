namespace padariaProjetoSenac
{
    partial class frmPesquisaFornec
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
            this.cliecdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieUFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.fornecedoresTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.fornecedoresTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliecdDataGridViewTextBoxColumn,
            this.clieNMDataGridViewTextBoxColumn,
            this.cliecnpjDataGridViewTextBoxColumn,
            this.clieendDataGridViewTextBoxColumn,
            this.clienumeroDataGridViewTextBoxColumn,
            this.cliecidadeDataGridViewTextBoxColumn,
            this.clieUFDataGridViewTextBoxColumn,
            this.cliecepDataGridViewTextBoxColumn,
            this.clietelefoneDataGridViewTextBoxColumn,
            this.cliecelularDataGridViewTextBoxColumn,
            this.clieemailDataGridViewTextBoxColumn,
            this.clieCadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 266);
            this.dataGridView1.TabIndex = 0;
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
            // cliecnpjDataGridViewTextBoxColumn
            // 
            this.cliecnpjDataGridViewTextBoxColumn.DataPropertyName = "clie_cnpj";
            this.cliecnpjDataGridViewTextBoxColumn.HeaderText = "clie_cnpj";
            this.cliecnpjDataGridViewTextBoxColumn.Name = "cliecnpjDataGridViewTextBoxColumn";
            // 
            // clieendDataGridViewTextBoxColumn
            // 
            this.clieendDataGridViewTextBoxColumn.DataPropertyName = "clie_end";
            this.clieendDataGridViewTextBoxColumn.HeaderText = "clie_end";
            this.clieendDataGridViewTextBoxColumn.Name = "clieendDataGridViewTextBoxColumn";
            // 
            // clienumeroDataGridViewTextBoxColumn
            // 
            this.clienumeroDataGridViewTextBoxColumn.DataPropertyName = "clie_numero";
            this.clienumeroDataGridViewTextBoxColumn.HeaderText = "clie_numero";
            this.clienumeroDataGridViewTextBoxColumn.Name = "clienumeroDataGridViewTextBoxColumn";
            // 
            // cliecidadeDataGridViewTextBoxColumn
            // 
            this.cliecidadeDataGridViewTextBoxColumn.DataPropertyName = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.HeaderText = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.Name = "cliecidadeDataGridViewTextBoxColumn";
            // 
            // clieUFDataGridViewTextBoxColumn
            // 
            this.clieUFDataGridViewTextBoxColumn.DataPropertyName = "clie_UF";
            this.clieUFDataGridViewTextBoxColumn.HeaderText = "clie_UF";
            this.clieUFDataGridViewTextBoxColumn.Name = "clieUFDataGridViewTextBoxColumn";
            // 
            // cliecepDataGridViewTextBoxColumn
            // 
            this.cliecepDataGridViewTextBoxColumn.DataPropertyName = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.HeaderText = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.Name = "cliecepDataGridViewTextBoxColumn";
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
            // clieCadastroDataGridViewTextBoxColumn
            // 
            this.clieCadastroDataGridViewTextBoxColumn.DataPropertyName = "clie_Cadastro";
            this.clieCadastroDataGridViewTextBoxColumn.HeaderText = "clie_Cadastro";
            this.clieCadastroDataGridViewTextBoxColumn.Name = "clieCadastroDataGridViewTextBoxColumn";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.systemsDataSet;
            // 
            // systemsDataSet
            // 
            this.systemsDataSet.DataSetName = "systemsDataSet";
            this.systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar Código";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(225, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 29);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesq Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisa dos Fornecedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesquisar Nome";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(225, 408);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(418, 29);
            this.textBox2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Pesq-Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPesquisaFornec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesquisaFornec";
            this.Text = "Pesquisa De Fornecedores";
            this.Load += new System.EventHandler(this.frmPesquisaFornec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private systemsDataSet systemsDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private systemsDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieUFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}