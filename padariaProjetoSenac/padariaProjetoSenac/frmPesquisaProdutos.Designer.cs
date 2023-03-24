namespace padariaProjetoSenac
{
    partial class frmPesquisaProdutos
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
            this.prodCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescricacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprecoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.produtosTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.produtosTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisa dos  Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pesquisar Código";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 443);
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
            this.textBox1.Location = new System.Drawing.Point(207, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 29);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesq-Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCDDataGridViewTextBoxColumn,
            this.proddescricacaoDataGridViewTextBoxColumn,
            this.prodprecoUnitarioDataGridViewTextBoxColumn,
            this.prodestoqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 247);
            this.dataGridView1.TabIndex = 13;
            // 
            // prodCDDataGridViewTextBoxColumn
            // 
            this.prodCDDataGridViewTextBoxColumn.DataPropertyName = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn.HeaderText = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn.Name = "prodCDDataGridViewTextBoxColumn";
            this.prodCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proddescricacaoDataGridViewTextBoxColumn
            // 
            this.proddescricacaoDataGridViewTextBoxColumn.DataPropertyName = "prod_descricacao";
            this.proddescricacaoDataGridViewTextBoxColumn.HeaderText = "prod_descricacao";
            this.proddescricacaoDataGridViewTextBoxColumn.Name = "proddescricacaoDataGridViewTextBoxColumn";
            // 
            // prodprecoUnitarioDataGridViewTextBoxColumn
            // 
            this.prodprecoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "prod_precoUnitario";
            this.prodprecoUnitarioDataGridViewTextBoxColumn.HeaderText = "prod_precoUnitario";
            this.prodprecoUnitarioDataGridViewTextBoxColumn.Name = "prodprecoUnitarioDataGridViewTextBoxColumn";
            // 
            // prodestoqueDataGridViewTextBoxColumn
            // 
            this.prodestoqueDataGridViewTextBoxColumn.DataPropertyName = "prod_estoque";
            this.prodestoqueDataGridViewTextBoxColumn.HeaderText = "prod_estoque";
            this.prodestoqueDataGridViewTextBoxColumn.Name = "prodestoqueDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.systemsDataSet;
            // 
            // systemsDataSet
            // 
            this.systemsDataSet.DataSetName = "systemsDataSet";
            this.systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "Pesq-Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(207, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 29);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesquisar Nome";
            // 
            // frmPesquisaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
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
            this.Name = "frmPesquisaProdutos";
            this.Text = "frmPesquisaProdutos";
            this.Load += new System.EventHandler(this.frmPesquisaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private systemsDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddescricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprecoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}