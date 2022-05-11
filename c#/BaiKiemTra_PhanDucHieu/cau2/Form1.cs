using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("xác nhận thoát khỏi ứng dụng", "Thông báo...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                Dispose();
            }
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_nhap_n.Text);
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }
            txt_tong.Text = tong.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nhap_n.Focus();
            btn_tinh.Enabled = false;

        }

        private void txt_nhap_n_KeyUp(object sender, KeyEventArgs e)
        {
            int n;
            bool testN;
            testN = int.TryParse(txt_nhap_n.Text, out n);
            if (testN == true)
            {
                btn_tinh.Enabled = true;
            }
            else
            {
                MessageBox.Show("N nhập vào phải là số nguyên và là trường bắt buộc xin mời nhập lại .", "Cảnh báo");
                txt_nhap_n.Focus();
                txt_nhap_n.Clear();
            }
        }

        private void txt_nhap_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
