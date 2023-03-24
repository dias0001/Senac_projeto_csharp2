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
    public partial class frmCaixaMov : Form
    {
        public frmCaixaMov()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCaixaMov_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.caixaTableAdapter.Fill(this.systemsDataSet.caixa);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
