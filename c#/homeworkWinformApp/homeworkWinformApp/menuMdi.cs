using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeworkWinformApp
{
    public partial class menuMdi : Form
    {
        public menuMdi()
        {
            InitializeComponent();
        }

        private void tìmƯớcTrungLớnNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new BSCNN_USCLN();
            f.Show();
        }

        private void menuMdi_Load(object sender, EventArgs e)
        {

        }

        private void tínhGiaiThừaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Factorial();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void điềuKhiểnComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new From_calculator1();
            f.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new sumOfNumbers();
            f.Show();
        }

        private void ứngDụngFormChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ListBox();
            f.Show();
        }
    }
}
