using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace homeworkWinformApp
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {

        }


        private void lbt_hienthi_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool testN;
            int n;
            
            testN = int.TryParse(txt_nhapn.Text, out n);
            if (testN)
            {
                lbt_hienthi.Items.Add(n);
                txt_nhapn.Text = "";
            }
            else
            {
                lb_ketqua.Text = "số nhập vào không hợp lệ";
            }
            txt_nhapn.Focus();

        }

        private void btn_tongpt_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int i in lbt_hienthi.Items)
            {
                sum += i;
            }
            lb_ketqua.Text = sum.ToString();
            txt_nhapn.Text = "";
        }

        private void btn_delpt1_Click(object sender, EventArgs e)
        {
            lbt_hienthi.Items.RemoveAt(0);
        }

        private void btn_delpt2_Click(object sender, EventArgs e)
        {
            lbt_hienthi.Items.RemoveAt(lbt_hienthi.Items.Count -1);
        }

        private void btn_delall_Click(object sender, EventArgs e)
        {
            lbt_hienthi.Items.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delnow_Click(object sender, EventArgs e)
        {
           int select =  lbt_hienthi.SelectedIndex;
            if(select== -1)
            {
                lb_ketqua.Text = "phần tử không tồn tại";
            }
            else
            {
                lbt_hienthi.Items.RemoveAt(select);
            }
        }
    }
}
