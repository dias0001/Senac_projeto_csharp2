namespace padariaProjetoSenac
{
    partial class frmServicos
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataSet = new padariaProjetoSenac.systemsDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicosTableAdapter = new padariaProjetoSenac.systemsDataSetTableAdapters.servicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 83);
            this.button4.TabIndex = 5;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 83);
            this.button3.TabIndex = 4;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_precoUnitario", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(543, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 29);
            this.textBox3.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_NM", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(144, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 29);
            this.textBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Preço Unitário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nome";
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private systemsDataSet systemsDataSet;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private systemsDataSetTableAdapters.servicosTableAdapter servicosTableAdapter;
    }
}