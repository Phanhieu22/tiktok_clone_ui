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
    public partial class form_calculator : Form
    {
        public form_calculator()
        {
            InitializeComponent();
        }

        private void form_calculator_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                        if(b ==0){
                            label_result.Text = "phép tính không hợp lệ";
                            break;
                        }
                        result = a / b;
                        break;
                    }

            }
            label_result.Text = result.ToString();




        }
    }
}
