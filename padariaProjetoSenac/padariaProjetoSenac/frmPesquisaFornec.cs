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
    public partial class frmPesquisaFornec : Form
    {
        public frmPesquisaFornec()
        {
            InitializeComponent();
        }

        private void frmPesquisaFornec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.systemsDataSet.fornecedores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu2 frm = new frmMenu2();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fornecedoresBindingSource.Filter = string.Format("clie_CD={0}", textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                fornecedoresBindingSource.Filter = "";
            }
            else
            {
                fornecedoresBindingSource.Filter = string.Format("clie_NM like'{0}%'", textBox2.Text);
            }
        }
    }
}
