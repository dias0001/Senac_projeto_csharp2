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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.systemsDataSet.produtos);

            produtosBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(systemsDataSet.produtos);
            this.produtosTableAdapter.Fill(this.systemsDataSet.produtos);
            produtosBindingSource.MoveLast();

            //chamar um novo registro
            produtosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
    }
}
