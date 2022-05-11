using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGridView
{
    class CanBo
    {
        string maCb;
        string hoTen;
        string namSinh;

        public CanBo(string maCb, string hoTen, string namSinh)
        {
            this.MaCb = maCb;
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
        }
        public CanBo()
        {
            this.MaCb = "";
            this.HoTen = "";
            this.NamSinh = "";
        }

        public string MaCb { get => maCb; set => maCb = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
    }
}
