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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.caixaTableAdapter.Fill(this.systemsDataSet.caixa);

            caixaBindingSource.AddNew();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            caixaBindingSource.EndEdit();
            caixaTableAdapter.Update(systemsDataSet.caixa);
            this.caixaTableAdapter.Fill(this.systemsDataSet.caixa);
            caixaBindingSource.MoveLast();

            //chamar um novo registro
            caixaBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
