using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_red.Checked == true)
            {
                btn_preview.ForeColor = Color.Red;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdo_blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_blue.Checked == true)
            {
                btn_preview.ForeColor = Color.Blue;

            }
        }

        private void rdo_green_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_green.Checked == true)
            {
                btn_preview.ForeColor = Color.Green;

            }
        }

        private void rdo_orange_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_orange.Checked == true)
            {
                btn_preview.ForeColor = Color.Orange;

            }
        }

        private void rdo_yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_yellow.Checked == true)
            {
                btn_preview.BackColor = Color.Yellow;

            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {

        }

        private void rdo_pink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_pink.Checked == true)
            {
                btn_preview.BackColor = Color.Pink;

            }
        }

        private void rdo_cyan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_cyan.Checked == true)
            {
                btn_preview.BackColor = Color.Cyan;

            }
        }

        private void rdo_violet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_violet.Checked == true)
            {
                btn_preview.BackColor = Color.Violet;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(106, 174, 152);
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
           if(cdl_color.ShowDialog() == DialogResult.OK) {
                btn_preview.BackColor = cdl_color.Color;
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
