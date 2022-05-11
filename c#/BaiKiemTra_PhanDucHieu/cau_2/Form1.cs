using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private  bool kt_input ()
        {
            if (txt_ten_dang_nhap.Text == "")
            {
                return false;
                MessageBox.Show("tên đăng nhập là trường bắt buộc", "thông báo ...");
                txt_ten_dang_nhap.Focus();

            }
            if (txt_mat_khau.Text == "")
            {
                return false;
                MessageBox.Show("mật khẩu là trường bắt buộc", "thông báo ...");
                txt_mat_khau.Focus();

            }
            if (txt_ten_dang_nhap.Text =="admin" && txt_mat_khau.Text == "1234")
            {
                return true;
            }
            else
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng", "thông báo ...");
                txt_mat_khau.Clear();
                txt_ten_dang_nhap.Clear();
                txt_ten_dang_nhap.Focus();

            }
            return false;
        }
        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            if (kt_input())
            {
                Form dn = new formMdi();
                dn.Show();


            }
            
        }

        private void txt_ten_dang_nhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ten_dang_nhap.Focus();
        }
    }
}
