namespace padariaProjetoSenac
{
    partial class frmPesquisaFunc
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
            this.funccdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcUFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcdataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcsenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.funcionariosTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.funcionariosTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funccdDataGridViewTextBoxColumn,
            this.funcNMDataGridViewTextBoxColumn,
            this.funcendDataGridViewTextBoxColumn,
            this.funcCPFDataGridViewTextBoxColumn,
            this.funcRGDataGridViewTextBoxColumn,
            this.funccidadeDataGridViewTextBoxColumn,
            this.funcUFDataGridViewTextBoxColumn,
            this.funcCEPDataGridViewTextBoxColumn,
            this.functelefoneDataGridViewTextBoxColumn,
            this.funccelularDataGridViewTextBoxColumn,
            this.funcemailDataGridViewTextBoxColumn,
            this.funcCargoDataGridViewTextBoxColumn,
            this.funcdataCadastroDataGridViewTextBoxColumn,
            this.funcLoginDataGridViewTextBoxColumn,
            this.funcsenhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // funccdDataGridViewTextBoxColumn
            // 
            this.funccdDataGridViewTextBoxColumn.DataPropertyName = "func_cd";
            this.funccdDataGridViewTextBoxColumn.HeaderText = "func_cd";
            this.funccdDataGridViewTextBoxColumn.Name = "funccdDataGridViewTextBoxColumn";
            this.funccdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcNMDataGridViewTextBoxColumn
            // 
            this.funcNMDataGridViewTextBoxColumn.DataPropertyName = "func_NM";
            this.funcNMDataGridViewTextBoxColumn.HeaderText = "func_NM";
            this.funcNMDataGridViewTextBoxColumn.Name = "funcNMDataGridViewTextBoxColumn";
            // 
            // funcendDataGridViewTextBoxColumn
            // 
            this.funcendDataGridViewTextBoxColumn.DataPropertyName = "func_end";
            this.funcendDataGridViewTextBoxColumn.HeaderText = "func_end";
            this.funcendDataGridViewTextBoxColumn.Name = "funcendDataGridViewTextBoxColumn";
            // 
            // funcCPFDataGridViewTextBoxColumn
            // 
            this.funcCPFDataGridViewTextBoxColumn.DataPropertyName = "func_CPF";
            this.funcCPFDataGridViewTextBoxColumn.HeaderText = "func_CPF";
            this.funcCPFDataGridViewTextBoxColumn.Name = "funcCPFDataGridViewTextBoxColumn";
            // 
            // funcRGDataGridViewTextBoxColumn
            // 
            this.funcRGDataGridViewTextBoxColumn.DataPropertyName = "func_RG";
            this.funcRGDataGridViewTextBoxColumn.HeaderText = "func_RG";
            this.funcRGDataGridViewTextBoxColumn.Name = "funcRGDataGridViewTextBoxColumn";
            // 
            // funccidadeDataGridViewTextBoxColumn
            // 
            this.funccidadeDataGridViewTextBoxColumn.DataPropertyName = "func_cidade";
            this.funccidadeDataGridViewTextBoxColumn.HeaderText = "func_cidade";
            this.funccidadeDataGridViewTextBoxColumn.Name = "funccidadeDataGridViewTextBoxColumn";
            // 
            // funcUFDataGridViewTextBoxColumn
            // 
            this.funcUFDataGridViewTextBoxColumn.DataPropertyName = "func_UF";
            this.funcUFDataGridViewTextBoxColumn.HeaderText = "func_UF";
            this.funcUFDataGridViewTextBoxColumn.Name = "funcUFDataGridViewTextBoxColumn";
            // 
            // funcCEPDataGridViewTextBoxColumn
            // 
            this.funcCEPDataGridViewTextBoxColumn.DataPropertyName = "func_CEP";
            this.funcCEPDataGridViewTextBoxColumn.HeaderText = "func_CEP";
            this.funcCEPDataGridViewTextBoxColumn.Name = "funcCEPDataGridViewTextBoxColumn";
            // 
            // functelefoneDataGridViewTextBoxColumn
            // 
            this.functelefoneDataGridViewTextBoxColumn.DataPropertyName = "func_telefone";
            this.functelefoneDataGridViewTextBoxColumn.HeaderText = "func_telefone";
            this.functelefoneDataGridViewTextBoxColumn.Name = "functelefoneDataGridViewTextBoxColumn";
            // 
            // funccelularDataGridViewTextBoxColumn
            // 
            this.funccelularDataGridViewTextBoxColumn.DataPropertyName = "func_celular";
            this.funccelularDataGridViewTextBoxColumn.HeaderText = "func_celular";
            this.funccelularDataGridViewTextBoxColumn.Name = "funccelularDataGridViewTextBoxColumn";
            // 
            // funcemailDataGridViewTextBoxColumn
            // 
            this.funcemailDataGridViewTextBoxColumn.DataPropertyName = "func_email";
            this.funcemailDataGridViewTextBoxColumn.HeaderText = "func_email";
            this.funcemailDataGridViewTextBoxColumn.Name = "funcemailDataGridViewTextBoxColumn";
            // 
            // funcCargoDataGridViewTextBoxColumn
            // 
            this.funcCargoDataGridViewTextBoxColumn.DataPropertyName = "func_Cargo";
            this.funcCargoDataGridViewTextBoxColumn.HeaderText = "func_Cargo";
            this.funcCargoDataGridViewTextBoxColumn.Name = "funcCargoDataGridViewTextBoxColumn";
            // 
            // funcdataCadastroDataGridViewTextBoxColumn
            // 
            this.funcdataCadastroDataGridViewTextBoxColumn.DataPropertyName = "func_dataCadastro";
            this.funcdataCadastroDataGridViewTextBoxColumn.HeaderText = "func_dataCadastro";
            this.funcdataCadastroDataGridViewTextBoxColumn.Name = "funcdataCadastroDataGridViewTextBoxColumn";
            // 
            // funcLoginDataGridViewTextBoxColumn
            // 
            this.funcLoginDataGridViewTextBoxColumn.DataPropertyName = "func_Login";
            this.funcLoginDataGridViewTextBoxColumn.HeaderText = "func_Login";
            this.funcLoginDataGridViewTextBoxColumn.Name = "funcLoginDataGridViewTextBoxColumn";
            // 
            // funcsenhaDataGridViewTextBoxColumn
            // 
            this.funcsenhaDataGridViewTextBoxColumn.DataPropertyName = "func_senha";
            this.funcsenhaDataGridViewTextBoxColumn.HeaderText = "func_senha";
            this.funcsenhaDataGridViewTextBoxColumn.Name = "funcsenhaDataGridViewTextBoxColumn";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.systemsDataSet;
            // 
            // systemsDataSet
            // 
            this.systemsDataSet.DataSetName = "systemsDataSet";
            this.systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesq-Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(228, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pesquisar Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa dos Funcionários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pesquisar Nome";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(228, 400);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pesq-Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPesquisaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 527);
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
            this.Name = "frmPesquisaFunc";
            this.Text = "Pesquisa de Funcionários";
            this.Load += new System.EventHandler(this.frmPesquisaFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private systemsDataSet systemsDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private systemsDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcUFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}