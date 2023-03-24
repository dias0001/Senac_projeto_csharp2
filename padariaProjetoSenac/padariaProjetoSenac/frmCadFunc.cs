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
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.systemsDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.systemsDataSet.funcionarios);

           funcionariosBindingSource.AddNew();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(systemsDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.systemsDataSet.funcionarios);
            funcionariosBindingSource.MoveLast();

            //chamar um novo registro
            funcionariosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPesquisaFunc outroform = new frmPesquisaFunc();
            this.Hide();
            outroform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu2 outroform = new frmMenu2();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
