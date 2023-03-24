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
    public partial class frmCadEstoq : Form
    {
        public frmCadEstoq()
        {
            InitializeComponent();
        }

        private void frmCadEstoq_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.systemsDataSet.estoque);

            estoqueBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            estoqueBindingSource.EndEdit();
            estoqueTableAdapter.Update(systemsDataSet.estoque);
            this.estoqueTableAdapter.Fill(this.systemsDataSet.estoque);
            estoqueBindingSource.MoveLast();

            //chamar um novo registro
            estoqueBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
