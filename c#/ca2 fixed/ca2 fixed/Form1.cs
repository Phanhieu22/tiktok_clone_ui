using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ca2_fixed
{
    public partial class form_khoa : Form
    {
        public form_khoa()
        {
            InitializeComponent();
        }

        private void btn_thoat_Leave(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Load(object sender, EventArgs e)
        {

        }

        private void form_khoa_Load(object sender, EventArgs e)
        {
            string linkToDb = "Data Source=DESKTOP-CFTMCK3\\SQLEXPRESS01;Initial Catalog=SinhVien;Integrated Security=True";
            string sqlQueryGetAllData = "select * from KHOA";

            connect d =new connect(linkToDb);

            dvg_khoa.DataSource = d.query(sqlQueryGetAllData);
            dvg_khoa.ClearSelection();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // thực thi thêm dữ liệu
            string makhoa = txt_ma_khoa.Text;
            string tenkhoa = txt_khoa.Text;
            string sqlQueryGetAllData = "select * from KHOA";
            string sqlQueryInsert = "insert into KHOA(maKhoa, tenKhoa) values ('"+makhoa+ "', '" + tenkhoa + "')";
            string linkToDb = "Data Source=DESKTOP-CFTMCK3\\SQLEXPRESS01;Initial Catalog=SinhVien;Integrated Security=True";

            connect d = new connect(linkToDb);
            d.execute(sqlQueryInsert);

            dvg_khoa.DataSource = d.query(sqlQueryGetAllData);




        }

        private void btn_xóa_Click(object sender, EventArgs e)
        {

        }

        private void dvg_khoa_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void dvg_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dvg_khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dvg_khoa.SelectedRows)
            {
                string ma_khoa = row.Cells[0].Value.ToString();
                string ten_khoa = row.Cells[1].Value.ToString();
                //...
                txt_khoa.Text = ten_khoa;
                txt_ma_khoa.Text = ma_khoa;
            }
        }
    }
}
