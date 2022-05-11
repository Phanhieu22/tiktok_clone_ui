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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.ResetText();
            txt_userName.ResetText();
            txt_userName.Focus();
            txt_message.Text = "successful delete";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string authUserName = "admin";
            string authPass = "1234";

            if (userName.Length == 0 || password.Length == 0)
            {
                txt_password.ResetText();
                txt_userName.ResetText();
                txt_message.Text = "user name and password is require";
                txt_userName.Focus();

            }
            else
            {
                if (userName == authUserName && password == authPass)
                {
                    Form f = new menuMdi();
                    f.Show();
                    
                }

            }
            }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
