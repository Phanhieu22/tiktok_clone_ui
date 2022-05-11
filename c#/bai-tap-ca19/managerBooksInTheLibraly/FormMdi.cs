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
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form quanLiSach = new Form1();
            quanLiSach.Show();
        }
    }
}
