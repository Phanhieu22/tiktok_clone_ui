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
    public partial class form_quan_li_sinh_vien : Form
    {
        public form_quan_li_sinh_vien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void clearDataInput()
        {
            txt_ma_sinh_vien.Clear();
            txt_ten_sinh_vien.Clear();
            txt_que_quan.Clear();
            txt_diem_tb.Clear();
            txt_nam_sinh.Clear();
            txt_ma_sinh_vien.Focus();

        }
        private bool testingData()
        {
            float x;

            if (txt_ma_sinh_vien.Text == "")
            {
                MessageBox.Show("mã sinh viên là trường bắt buộc", "thông báo");
                txt_ma_sinh_vien.Focus();
                return false;
            }

            if (txt_ten_sinh_vien.Text == "")
            {
                txt_ten_sinh_vien.Focus();
                MessageBox.Show("tên sinh viên là trường bắt buộc", "thông báo");

                return false;
            }
            if (txt_que_quan.Text == "")
            {
                txt_que_quan.Focus();
                MessageBox.Show("quê quán sinh viên là trường bắt buộc", "thông báo");

                return false;

            }
            if (txt_diem_tb.Text == "")
            {
                MessageBox.Show("điểm tb sinh viên là trường bắt buộc", "thông báo");
                txt_diem_tb.Focus();
                return false;
            }
            if (!float.TryParse(txt_diem_tb.Text, out x))
            {
                MessageBox.Show("điểm tb sinh viên phải là một số ", "thông báo");
                txt_diem_tb.Focus();
                return false;
            }
            if (!float.TryParse(txt_nam_sinh.Text, out x))
            {
                MessageBox.Show("năm sinh của sinh viên phải là 1 số", "thông báo");
                txt_nam_sinh.Focus();
                return false;
            }
            if (txt_nam_sinh.Text == "")
            {
                MessageBox.Show("năm sinh sinh viên là trường bắt buộc", "thông báo");

                txt_nam_sinh.Focus();
                return false;


            }
            return true;

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (testingData())
            {
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                string[] arr = new string[5];
                ListViewItem item;
                //Add first item
                arr[0] = txt_ma_sinh_vien.Text;
                arr[1] = txt_ten_sinh_vien.Text;
                arr[2] = txt_que_quan.Text;
                arr[3] = txt_diem_tb.Text;
                arr[4] = txt_nam_sinh.Text;

                item = new ListViewItem(arr);
                listView1.Items.Add(item);
                clearDataInput();
                ;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    txt_ma_sinh_vien.Text = listView1.Items[i].SubItems[0].Text;
                    txt_ten_sinh_vien.Text = listView1.Items[i].SubItems[1].Text;
                    txt_que_quan.Text = listView1.Items[i].SubItems[2].Text;
                    txt_diem_tb.Text = listView1.Items[i].SubItems[3].Text;
                    txt_nam_sinh.Text = listView1.Items[i].SubItems[4].Text;
                }

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    listView1.Items[i].Remove();
                }

            }
            clearDataInput();
        }
        private bool testCode(string ma_sv)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == ma_sv) return true;
            }

            MessageBox.Show("bạn không được phép thay đổi mã sinh viên", "Cảnh báo nghiêm trọng",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            clearDataInput();
            return false;

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (testingData() && testCode(txt_ma_sinh_vien.Text))
                {
                    string[] arrEdit = new string[5];
                    ListViewItem item;
                    // get data affter edit
                    arrEdit[0] = txt_ma_sinh_vien.Text;
                    arrEdit[1] = txt_ten_sinh_vien.Text;
                    arrEdit[2] = txt_que_quan.Text;
                    arrEdit[3] = txt_diem_tb.Text;
                    arrEdit[4] = txt_nam_sinh.Text;

                    item = new ListViewItem(arrEdit);
                    listView1.Items[i] = item;
                    clearDataInput();
                    ;
                }

            }
        }
    }
}
