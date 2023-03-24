﻿using System;
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
    public partial class frmPesquisaFunc : Form
    {
        public frmPesquisaFunc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.Filter = string.Format("func_CD={0}", textBox1.Text);
        }

        private void frmPesquisaFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemsDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.systemsDataSet.funcionarios);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu2 frm = new frmMenu2();
            frm.Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                funcionariosBindingSource.Filter = "";
            }
            else
            {
                funcionariosBindingSource.Filter = string.Format("func_NM like'{0}%'", textBox2.Text);
            }
        }
    }
}
