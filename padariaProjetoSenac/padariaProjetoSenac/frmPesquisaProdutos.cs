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
    public partial class frmPesquisaProdutos : Form
    {
        public frmPesquisaProdutos()
        {
            InitializeComponent();
        }

        private void frmPesquisaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.systemsDataSet.produtos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu2 frm = new frmMenu2();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produtosBindingSource.Filter = string.Format("prod_CD={0}", textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                produtosBindingSource.Filter = "";
            }
            else
            {
                produtosBindingSource.Filter = string.Format("prod_descricacao like'{0}%'", textBox2.Text);
            }
        }
    }
}
