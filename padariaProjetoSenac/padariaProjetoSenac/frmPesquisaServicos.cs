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
    public partial class frmPesquisaServicos : Form
    {
        public frmPesquisaServicos()
        {
            InitializeComponent();
        }

        private void frmPesquisaServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.systemsDataSet.servicos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu2 frm = new frmMenu2();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicosBindingSource.Filter = string.Format("serv_CD={0}", textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                servicosBindingSource.Filter = "";
            }
            else
            {
                servicosBindingSource.Filter = string.Format("serv_NM like'{0}%'", textBox2.Text);
            }
        }
    }
}
