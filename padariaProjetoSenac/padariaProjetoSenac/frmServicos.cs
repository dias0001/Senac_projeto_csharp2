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
    public partial class frmServicos : Form
    {

        public frmServicos()
        {
            InitializeComponent();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.systemsDataSet.servicos);

            servicosBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            servicosBindingSource.EndEdit();
            servicosTableAdapter.Update(systemsDataSet.servicos);
            this.servicosTableAdapter.Fill(this.systemsDataSet.servicos);
            servicosBindingSource.MoveLast();

            //chamar um novo registro
            servicosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Produtos cadastrados com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
