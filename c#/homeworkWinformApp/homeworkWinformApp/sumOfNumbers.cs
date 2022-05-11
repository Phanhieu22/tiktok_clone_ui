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
    public partial class sumOfNumbers : Form
    {
        public sumOfNumbers()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_result1_Click(object sender, EventArgs e)
        {
            bool testN;
            int N;
            int result = 0;
            testN = int.TryParse(txt_enterN.Text, out N);

            if(txt_enterN.Text.Length == 0 || testN ==false )
            {
                txt_result.Text = "số N phải là một số nguyên hoặc bạn chưa nhập N ";
                txt_enterN.ResetText();
                txt_enterN.Focus();

            }
            else
            {
               for(int i = 0; i<=N; i+=1)
                {
                    result += i;
                }
                txt_result.Text = result.ToString();
                txt_enterN.Focus();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            bool testN;
            int N;
            int result = 0;
            testN = int.TryParse(txt_enterN.Text, out N);

            if (txt_enterN.Text.Length == 0 || testN == false)
            {
                txt_result.Text = "số N phải là một số nguyên hoặc bạn chưa nhập N ";
                txt_enterN.ResetText();
                txt_enterN.Focus();

            }
            else
            {
                for (int i = 0; i <= N; i +=2)
                {
                    result += i;
                }
                txt_result.Text = result.ToString();
                txt_enterN.Focus();
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
