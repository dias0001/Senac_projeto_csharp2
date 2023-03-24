using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padariaProjetoSenac
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.systemsDataSet.fornecedores);

            fornecedoresBindingSource.AddNew();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            fornecedoresBindingSource.EndEdit();
            fornecedoresTableAdapter.Update(systemsDataSet.fornecedores);
            this.fornecedoresTableAdapter.Fill(this.systemsDataSet.fornecedores);
            fornecedoresBindingSource.MoveLast();

            //chamar um novo registro
            fornecedoresBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Fornecedor cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Voltar
            frmMenu2 frm = new frmMenu2();
            frm.Show(); // Mostra menu
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
