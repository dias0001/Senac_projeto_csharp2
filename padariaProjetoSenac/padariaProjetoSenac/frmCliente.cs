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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.systemsDataSet.clientes);

            clientesBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(systemsDataSet.clientes);
            this.clientesTableAdapter.Fill(this.systemsDataSet.clientes);
            clientesBindingSource.MoveLast();

            //chamar um novo registro
            clientesBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Cliente cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
