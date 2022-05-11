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
    public partial class formMdi : Form
    {
        public formMdi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ql = new form_quan_li_sinh_vien();
             ql.MdiParent = this;
            // option cho full size tab
            // ql.WindowState = FormWindowState.Maximized;
            ql.Show();
        }
    }
}
