using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeworkWinformApp
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            bool test;
            int n;
            test = int.TryParse(txt_numberN.Text, out n);
            if (test == false || n == 0)
            {
                txt_result.Text = "wrong format";
                txt_numberN.ResetText();
                txt_numberN.Focus();
            }
            else
            {
                int result = factorial(n);
                txt_result.Text = result.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_result.Text = "delete successful";
            txt_numberN.ResetText();
            txt_numberN.Focus();
        }
        private static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * factorial(n - 1);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
