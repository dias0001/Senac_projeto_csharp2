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
    public partial class Form9 : Form
    {
        private void ClearAllBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {

                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        public Form9()
        {
            InitializeComponent();
        }



        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAllBoxes(); Form2 outroform = new Form2();
            this.Hide();
            outroform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
