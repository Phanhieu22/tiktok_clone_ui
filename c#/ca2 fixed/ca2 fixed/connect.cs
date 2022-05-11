using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ca2_fixed
{
    class connect
    {
        private static string linkToDb;

        public connect(string linkToDbInput)
        {
            linkToDb = linkToDbInput;
        } public connect()
        {
            linkToDb = "";
        }

        public string LinkToDb { get => linkToDb; set => linkToDb = value; }


        // kết nối tới db
        public SqlConnection connectDb()
        {
        //    SqlConnection connectString = new SqlConnection("Data Source=DESKTOP-CFTMCK3\\SQLEXPRESS01;Initial Catalog=SinhVien;Integrated Security=True");
            SqlConnection connectString = new SqlConnection(linkToDb);
            connectString.Open();
            return connectString;
        }


        // kết nối tới db thực thi câu lệnh truyền vào và trả về dữ liệu kiểu data table
        public DataTable query(string sql)
        {
            // kết nối lại tới db
            SqlConnection stringConnect = connectDb();

            // khởi tạo các đối tượng cần dùng
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();

            // bổ xung các thuộc tính cho câu lệnh truy vấn
            cmd.CommandText = sql;
            cmd.Connection = stringConnect;

            // chọn câu lệnh truy vấn là
            data.SelectCommand = cmd;

            // đổ dữ liệu từ dạng sql data adapter sang data table
            data.Fill(dt);

            stringConnect.Close();

            return dt;
        }

        // kết nối tới db thay đổi trực tiếp các yêu cầu trong db và không trả về giá trị 
        public void execute(string sql)
        {
            // kết nối tới db
            SqlConnection connectString = connectDb();

            // khởi tạo câu lệnh truy vấn
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = connectString;

            // thực thi câu lệnh truy vấn 
            cmd.ExecuteNonQuery();

            // đóng cổng
            connectString.Close();
        }



    }
}
