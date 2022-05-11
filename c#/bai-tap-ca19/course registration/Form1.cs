using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listCourse_MultilineChanged(object sender, EventArgs e)
        {

        }

        private void listCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_single_Click(object sender, EventArgs e)
        {
            var index = listCourse.SelectedItem;
            if (index != null)
            {
                list_selected.Items.Add(index);
                listCourse.Items.RemoveAt(listCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("bạn chưa chọn phần tử");

            }
           
           


        }

        private void btn_add_all_Click(object sender, EventArgs e)
        {
            foreach (var item in listCourse.Items)
            {
                list_selected.Items.Add(item);


            }
            listCourse.Items.Clear();

        }

        private void listCourse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_unchecked_all.Enabled = false;
            btn_uncheck_single.Enabled = false;
            btn_add_all.Enabled = true;
            btn_add_single.Enabled = true;
        }

        private void btn_unchecked_all_Click(object sender, EventArgs e)
        {
            foreach (var item in list_selected.Items)
            {
                listCourse.Items.Add(item);
            }
            list_selected.Items.Clear();
        }

        private void btn_uncheck_single_Click(object sender, EventArgs e)
        {

            var index = list_selected.SelectedItem;
            if (index != null)
            {
                listCourse.Items.Add(list_selected.SelectedItem);
                list_selected.Items.RemoveAt(list_selected.SelectedIndex);
            }
            else
            {
                MessageBox.Show("bạn chưa chọn phần tử");

            }
         
        }

        private void list_selected_MouseDown(object sender, MouseEventArgs e)
        {
            btn_unchecked_all.Enabled = true;
            btn_uncheck_single.Enabled = true;
            btn_add_all.Enabled = false;
            btn_add_single.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;

            txt_day.Text = x.ToShortDateString();
            txt_hour.Text = x.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string totalCourse = "";
            foreach (var item in list_selected.Items)
            {
                totalCourse = totalCourse + item + " , ";

            }
            txt_result.Text ="họ và tên sinh viên : "+ cb_name.Text + "đăng ký vào ngày : " +txt_day.Text+" giờ đăng ký : "+ txt_hour.Text +"với các môn là " + totalCourse; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
