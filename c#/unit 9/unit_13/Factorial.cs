using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_13
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {
           
        }
        private static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * factorial(n - 1);

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            bool test;
            int n;
            test = int.TryParse(txt_numberN.Text, out n);
            if (test == false|| n ==0)
            {
                txt_result.Text = "wrong format";
                txt_numberN.ResetText();
                txt_numberN.Focus();
            }
            else
            {
                int result = factorial( n);
                txt_result.Text = result.ToString();

            }
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            txt_result.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_numberN.ResetText();
            txt_result.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
