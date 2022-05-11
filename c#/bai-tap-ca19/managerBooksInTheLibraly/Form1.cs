using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managerBooksInTheLibraly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearDataInput()
        {
            txt_ma_sach.Clear();
            txt_ten_sach.Clear();
            txt_ten_tac_gia.Clear();
            txt_nha_xuat_ban.Clear();
            txt_nam_xuat_ban.Clear();
            txt_ma_sach.Focus();

        }
        private void xoa_du_lieu()
        {
            txt_ma.Clear();
            txt_tenmon.Clear();
            txt_sotinchi.Clear();
            txt_diem.Clear();
        }
        private bool testDuplicateCodeBook(string bookId)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == bookId) return true;
            }
            return false;


        }
        private bool testCodeBook(string bookId)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == bookId) return true;
            }
            lbl_message.Text = "Bạn không được phép thay đổi mã sách";

            MessageBox.Show("bạn không được phép thay đổi mã sách", "Cảnh báo nghiêm trọng",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            clearDataInput();
            return false;

        }

        private bool testingData()
        {
            lbl_message.ForeColor = Color.Red;


            // check for duplicate code

            if (testDuplicateCodeBook(txt_ma_sach.Text))
            {
                MessageBox.Show("Mã sách đã tồn tại hoặc không phù hợp cho hệ thống");
                return false;
            }

            // check dữ liệu năm xuất bản


            string txtValue = txt_nam_xuat_ban.Text;
            if (txtValue == "")
            {
                txtValue = "0";
            }
            // Lấy giá trị dạng số thập phân
            decimal publishingYear = Convert.ToDecimal(txtValue);
            if (txt_ma_sach.Text == "")
            {
                lbl_message.Text = "mã sách là trường bắt buộc xin mời nhập lại";
                txt_ma_sach.Clear();
                txt_ma_sach.Focus();
                return false;


            }
            if (txt_ten_sach.Text == "")
            {
                lbl_message.Text = "tên sách là trường bắt buộc xin mời nhập lại";
                txt_ten_sach.Clear();

                txt_ten_sach.Focus();

                return false;

            }
            if (txt_ten_tac_gia.Text == "")
            {
                lbl_message.Text = "tên tác giả là trường bắt buộc xin mời nhập lại";
                txt_ten_tac_gia.Clear();

                txt_ten_tac_gia.Focus();
                return false;


            }
            if (txt_nha_xuat_ban.Text == "")
            {
                lbl_message.Text = "nhà xuất bản là trường bắt buộc xin mời nhập lại";
                txt_nha_xuat_ban.Clear();
                txt_nha_xuat_ban.Focus();
                return false;


            }
            if (publishingYear <= 0)
            {
                lbl_message.Text = "bạn nhập sai định dạng xin mời nhập lại";
                txt_nam_xuat_ban.Clear();
                txt_nam_xuat_ban.Focus();
                return false;

            }
            return true;

        }

        private bool testingDataEdit()
        {
            lbl_message.ForeColor = Color.Red;


            // check for duplicate code



            // check dữ liệu năm xuất bản


            string txtValue = txt_nam_xuat_ban.Text;
            if (txtValue == "")
            {
                txtValue = "0";
            }
            // Lấy giá trị dạng số thập phân
            decimal publishingYear = Convert.ToDecimal(txtValue);
            if (txt_ma_sach.Text == "")
            {
                lbl_message.Text = "mã sách là trường bắt buộc xin mời nhập lại";
                txt_ma_sach.Clear();
                txt_ma_sach.Focus();
                return false;


            }
            if (txt_ten_sach.Text == "")
            {
                lbl_message.Text = "tên sách là trường bắt buộc xin mời nhập lại";
                txt_ten_sach.Clear();

                txt_ten_sach.Focus();

                return false;

            }
            if (txt_ten_tac_gia.Text == "")
            {
                lbl_message.Text = "tên tác giả là trường bắt buộc xin mời nhập lại";
                txt_ten_tac_gia.Clear();

                txt_ten_tac_gia.Focus();
                return false;


            }
            if (txt_nha_xuat_ban.Text == "")
            {
                lbl_message.Text = "nhà xuất bản là trường bắt buộc xin mời nhập lại";
                txt_nha_xuat_ban.Clear();
                txt_nha_xuat_ban.Focus();
                return false;


            }
            if (publishingYear <= 0)
            {
                lbl_message.Text = "bạn nhập sai định dạng xin mời nhập lại";
                txt_nam_xuat_ban.Clear();
                txt_nam_xuat_ban.Focus();
                return false;

            }
            return true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {





        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nam_xuat_ban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nam_xuat_ban_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (testingDataEdit() && testCodeBook(txt_ma_sach.Text))
                {
                    string[] arrEdit = new string[5];
                    ListViewItem item;
                    // get data affter edit
                    arrEdit[0] = txt_ma_sach.Text;
                    arrEdit[1] = txt_ten_sach.Text;
                    arrEdit[2] = txt_ten_tac_gia.Text;
                    arrEdit[3] = txt_nha_xuat_ban.Text;
                    arrEdit[4] = txt_nam_xuat_ban.Text;

                    item = new ListViewItem(arrEdit);
                    listView1.Items[i] = item;
                    lbl_message.ForeColor = Color.Blue;
                    lbl_message.Text = "Bạn vừa sửa thành công";
                    clearDataInput();
                    ;
                }

            }

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    txt_ma_sach.Text = listView1.Items[i].SubItems[0].Text;
                    txt_ten_sach.Text = listView1.Items[i].SubItems[1].Text;
                    txt_ten_tac_gia.Text = listView1.Items[i].SubItems[2].Text;
                    txt_nha_xuat_ban.Text = listView1.Items[i].SubItems[3].Text;
                    txt_nam_xuat_ban.Text = listView1.Items[i].SubItems[4].Text;

                }

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    lbl_message.Text = "bạn vừa xóa thành công sách có id là " + listView1.Items[i].SubItems[0].Text;
                    listView1.Items[i].Remove();


                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu nhập
            if (testingData())
            {
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                string[] arr = new string[5];
                ListViewItem item;
                //Add first item
                arr[0] = txt_ma_sach.Text;
                arr[1] = txt_ten_sach.Text;
                arr[2] = txt_ten_tac_gia.Text;
                arr[3] = txt_nha_xuat_ban.Text;
                arr[4] = txt_nam_xuat_ban.Text;

                item = new ListViewItem(arr);
                listView1.Items.Add(item);
                lbl_message.ForeColor = Color.Blue;
                lbl_message.Text = "Bạn vừa thêm thành công";
                clearDataInput();
                ;
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (testingDataEdit() && testCodeBook(txt_ma_sach.Text))
                {
                    string[] arrEdit = new string[5];
                    ListViewItem item;
                    // get data affter edit
                    arrEdit[0] = txt_ma_sach.Text;
                    arrEdit[1] = txt_ten_sach.Text;
                    arrEdit[2] = txt_ten_tac_gia.Text;
                    arrEdit[3] = txt_nha_xuat_ban.Text;
                    arrEdit[4] = txt_nam_xuat_ban.Text;

                    item = new ListViewItem(arrEdit);
                    listView1.Items[i] = item;
                    lbl_message.ForeColor = Color.Blue;
                    lbl_message.Text = "Bạn vừa sửa thành công";
                    clearDataInput();
                    ;
                }

            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDown_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    txt_ma_sach.Text = listView1.Items[i].SubItems[0].Text;
                    txt_ten_sach.Text = listView1.Items[i].SubItems[1].Text;
                    txt_ten_tac_gia.Text = listView1.Items[i].SubItems[2].Text;
                    txt_nha_xuat_ban.Text = listView1.Items[i].SubItems[3].Text;
                    txt_nam_xuat_ban.Text = listView1.Items[i].SubItems[4].Text;

                }

            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.FocusedItem.Index == i)
                {
                    lbl_message.Text = "bạn vừa xóa thành công sách có id là " + listView1.Items[i].SubItems[0].Text;
                    listView1.Items[i].Remove();


                }

            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// phần môn học 
        private bool kt_du_lieu_mon_hoc()
        {

            if (txt_ma.Text == "")
            {
                txt_ma.Focus();
                MessageBox.Show("trường mã môn học là bắt buộc", "Cảnh báo ",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_tenmon.Text == "")
            {
                txt_tenmon.Focus();
                MessageBox.Show("trường tên môn học là bắt buộc", "Cảnh báo ",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_sotinchi.Text == "")
            {
                txt_sotinchi.Focus();
                MessageBox.Show("trường số tín chỉ là bắt buộc", "Cảnh báo ",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_diem.Text == "")
            {
                MessageBox.Show("trường điểm là bắt buộc", "Cảnh báo ",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diem.Focus();
                return false;
            }
            return true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (kt_du_lieu_mon_hoc())
            {
                lv_mon.View = View.Details;
                lv_mon.GridLines = true;
                lv_mon.FullRowSelect = true;
                string[] arr = new string[4];
                ListViewItem item;
                //Add first item
                arr[0] = txt_ma.Text;
                arr[1] = txt_tenmon.Text;
                arr[2] = txt_sotinchi.Text;
                arr[3] = txt_diem.Text;

                item = new ListViewItem(arr);
                lv_mon.Items.Add(item);
                xoa_du_lieu();
            }

        }
        private bool kt_ma_sach(string bookId)
        {
            for (int i = 0; i < lv_mon.Items.Count; i++)
            {
                if (lv_mon.Items[i].Text == bookId) return true;
            }
           

            MessageBox.Show("bạn không được phép thay đổi mã môn học", "Cảnh báo nghiêm trọng",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            xoa_du_lieu();
            return false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_mon.Items.Count; i++)
            {
                if (kt_du_lieu_mon_hoc())
                {
                    string[] arrEdit = new string[4];
                    ListViewItem item;
                    // get data affter edit
                    arrEdit[0] = txt_ma.Text;
                    arrEdit[1] = txt_tenmon.Text;
                    arrEdit[2] = txt_sotinchi.Text;
                    arrEdit[3] = txt_diem.Text;

                    item = new ListViewItem(arrEdit);
                    lv_mon.Items[i] = item;
                    xoa_du_lieu();
                    ;
                }
                else
                {
                    MessageBox.Show("xin chọn môn học cần thay đổi", "Cảnh báo",
  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void lv_mon_MouseDown(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < lv_mon.Items.Count; i++)
            {
                if (lv_mon.FocusedItem.Index == i)
                {
                    txt_ma.Text = lv_mon.Items[i].SubItems[0].Text;
                    txt_tenmon.Text = lv_mon.Items[i].SubItems[1].Text;
                    txt_sotinchi.Text = lv_mon.Items[i].SubItems[2].Text;
                    txt_diem.Text = lv_mon.Items[i].SubItems[3].Text;

                }

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_mon.Items.Count; i++)
            {
                if (lv_mon.FocusedItem.Index == i)
                {
                    lbl_message.Text = "bạn vừa xóa thành công môn học có id là " + lv_mon.Items[i].SubItems[0].Text;
                    lv_mon.Items[i].Remove();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nam_xuat_ban_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
