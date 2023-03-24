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
    public partial class frmMenu2 : Form
    {
        public frmMenu2()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarVendaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadFunc newform3 = new frmCadFunc();
            newform3.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCliente newform3 = new frmCliente();
            newform3.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmFornecedores newform3 = new frmFornecedores();
            newform3.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProdutos newform3 = new frmProdutos();
            newform3.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmServicos newform3 = new frmServicos();
            newform3.ShowDialog();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa funcionário
            Form3 frm = new Form3();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa funcionário
            frmPesquisaFunc frm = new frmPesquisaFunc();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa produtos
            frmPesquisaProdutos frm = new frmPesquisaProdutos();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa serviços
            frmPesquisaServicos frm = new frmPesquisaServicos();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa Fornecedores
            frmPesquisaFornec frm = new frmPesquisaFornec();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa Estoque
            frmCadEstoq frm = new frmCadEstoq();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Indo para pesquisa 
            frmPesquisaClientes frm = new frmPesquisaClientes();
            frm.Show(); // Mostra pesquisa
            this.Visible = false;
        }
    }
}
