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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.colabDataSet.pessoa);
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Entre com os dados");
                }
                else
                {
                    pessoaBindingSource.Filter = "pess_login='" + textBox1.Text + "'";

                    if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper())
                    {
                        MessageBox.Show("USUARIO ERRADO");
                        return;
                    }
                    if (textBox2.Text.ToUpper() != textBox4.Text.ToUpper())
                    {
                        MessageBox.Show("SENHA ERRADA");
                        return;
                    }
                this.Visible = false;
                frmMenu newform3 = new frmMenu();
                newform3.ShowDialog();

            }
        }
    }
}
