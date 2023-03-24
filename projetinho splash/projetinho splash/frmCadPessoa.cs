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
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();

        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            pessoaBindingSource.AddNew();

///////////////////////////////////////////////////////////

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }

        ////////////////////////////////////////////////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            pessoaBindingSource.EndEdit();
            pessoaTableAdapter.Update(colabDataSet.pessoa);
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            pessoaBindingSource.MoveLast();

            //chamar um novo registro
            pessoaBindingSource.AddNew();

            textBox2.Focus();


            //aparece a mensagem quando der certo
            MessageBox.Show("pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu newform3 = new frmMenu();
            newform3.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
