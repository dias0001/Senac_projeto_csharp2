using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_surf_shop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cadFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cadCliente = new Form3();
            this.Hide();
            cadCliente.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 cadFuncionarios = new Form6();
            this.Hide();
            cadFuncionarios.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 cadFuncionarios = new Form4();
            this.Hide();
            cadFuncionarios.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 cadProdutos = new Form7();
            this.Hide();
            cadProdutos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 cadFuncionarios = new Form8();
            this.Hide();
            cadFuncionarios.ShowDialog();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
