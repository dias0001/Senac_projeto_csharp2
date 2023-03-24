namespace projetinho_splash
{
    partial class frmCadPessoa
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
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colabDataSet = new projetinho_splash.colabDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pessoaTableAdapter = new projetinho_splash.colabDataSetTableAdapters.pessoaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.colabDataSet;
            // 
            // colabDataSet
            // 
            this.colabDataSet.DataSetName = "colabDataSet";
            this.colabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_nm", true));
            this.textBox2.Location = new System.Drawing.Point(12, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_nm_fantasia", true));
            this.textBox3.Location = new System.Drawing.Point(12, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_endereco", true));
            this.textBox4.Location = new System.Drawing.Point(12, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_numero", true));
            this.textBox5.Location = new System.Drawing.Point(12, 203);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_compl", true));
            this.textBox6.Location = new System.Drawing.Point(358, 59);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(184, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_bairro", true));
            this.textBox7.Location = new System.Drawing.Point(358, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_cep", true));
            this.textBox8.Location = new System.Drawing.Point(358, 130);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_cidade", true));
            this.textBox9.Location = new System.Drawing.Point(358, 166);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(184, 20);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "pess_uf", true));
            this.textBox10.Location = new System.Drawing.Point(358, 203);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(184, 20);
            this.textBox10.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 61);
            this.button2.TabIndex = 11;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 61);
            this.button3.TabIndex = 12;
            this.button3.Text = "MENU";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 344);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "frmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadPessoa";
            this.Load += new System.EventHandler(this.frmCadPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colabDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private colabDataSet colabDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private colabDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}