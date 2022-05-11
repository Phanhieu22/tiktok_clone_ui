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
    public partial class BSCNN_USCLN : Form
    {
        public BSCNN_USCLN()
        {
            InitializeComponent();
        }

        static int UCLN(int num1 ,int num2)
        {
            int j = num1 > num2 ? num1 : num2;
            int result = 0;
            for(int i = j; i>0; i--)
            {
                if(num1 % i ==0 && num2 %i == 0)
                {
                    result = i;
                    break;
                
                }
            }
            return result;
        }
        private void btn_UCLN_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool testNum1, testNum2;
            testNum1 = int.TryParse(txt_num1.Text, out num1);
            testNum2 = int.TryParse(txt_num2.Text, out num2);
            bool checkNULL = (txt_num1.Text.Length == 0 || txt_num2.Text.Length ==0)  ? false : true;
            bool checkNum = (num1 < 0 || num2 < 0) ? false : true;
            int j = num1 > num2 ? num1 : num2;
            if (!checkNULL || !checkNum)
            {
                txt_message.Text = "số nhập vào không hợp lệ";
                txt_num1.Text = txt_num2.Text = "";
                txt_num1.Focus();

            }
            else
            {
                txt_result_UCLN.Text = UCLN(num1, num2).ToString();
            }

        }

        private void btn_BSCLN_Click(object sender, EventArgs e)
        {
            int num1, num2,result;
            bool testNum1, testNum2;
            testNum1 = int.TryParse(txt_num1.Text, out num1);
            testNum2 = int.TryParse(txt_num2.Text, out num2);
            bool checkNULL = (txt_num1.Text.Length == 0 || txt_num2.Text.Length == 0) ? false : true;
            bool checkNum = (num1 < 0 || num2 < 0) ? false : true;
            int j = num1 > num2 ? num1 : num2;
            if (!checkNULL || !checkNum)
            {
                txt_message.Text = "số nhập vào không hợp lệ";
                txt_num1.Text = txt_num2.Text = "";
                txt_num1.Focus();

            }
            else
            {
                result = Math.Abs(num1 * num2) / UCLN(num1, num2);
                txt_result_BCNN.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_result_BCNN.Text = txt_result_UCLN.Text = txt_num1.Text = txt_num2.Text = "";
            txt_num1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
