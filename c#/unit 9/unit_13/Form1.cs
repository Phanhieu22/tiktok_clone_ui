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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
             string name = txt_userName.Text;
            string password = txt_password.Text;
            if (name == "hieu" && password == "123")
            {
                form_calculator f = new form_calculator();
             
                f.Show();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
