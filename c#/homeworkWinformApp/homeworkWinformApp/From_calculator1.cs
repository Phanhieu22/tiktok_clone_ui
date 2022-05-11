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
    public partial class From_calculator1 : Form
    {
        public From_calculator1()
        {
            InitializeComponent();
        }

        private void bnt_result_Click(object sender, EventArgs e)
        {
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            string pt = txt_phepTinh.Text;
            double result = 0;

            switch (pt)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a = b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;
                    }
                case "/":
                    {
                        if (b == 0)
                        {
                            label_result.Text = "phép tính không hợp lệ";
                            break;
                        }
                        result = a / b;
                        break;
                    }
            }
            label_result.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.ResetText();
            num2.ResetText();
            txt_phepTinh.ResetText();
            label_result.ResetText();
            num1.Focus();
        }
    }
}
