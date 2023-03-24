using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetinho_splash
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cAdPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadPessoa newform3 = new frmCadPessoa();
            newform3.ShowDialog();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
