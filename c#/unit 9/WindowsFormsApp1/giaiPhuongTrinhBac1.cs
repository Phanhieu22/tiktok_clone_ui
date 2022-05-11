using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class giaiPhuongTrinhBac1 : Form
    {
        public giaiPhuongTrinhBac1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            heSo1.ResetText();
            heSo2.ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void heSo1_TextChanged(object sender, EventArgs e)
        {

        }
        static void phuongTrinhBac1(double a, double b)
        {
            if (a != 0)
            {
                MessageBox.Show("phương trinh có nghiem la" + -b / a);
            }
            else
            {
                if (a == 0)
                {
                    MessageBox.Show("phuong trinh vo nghiem");
                }
                else
                {
                    MessageBox.Show("phuong trinh co vo so nghiem");
                }

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double heSo_1 = double.Parse(heSo1.Text);
            Double heSo_2 = double.Parse(heSo2.Text);
            phuongTrinhBac1(heSo_1, heSo_2);


        }
    }

}
