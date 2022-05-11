
namespace homeworkWinformApp
{
    partial class menuMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tínhGiaiThừaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điềuKhiểnComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ứngDụngFormChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhGiaiThừaToolStripMenuItem,
            this.tínhTổngToolStripMenuItem,
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem,
            this.điềuKhiểnComboBoxToolStripMenuItem,
            this.ứngDụngFormChứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tínhGiaiThừaToolStripMenuItem
            // 
            this.tínhGiaiThừaToolStripMenuItem.Name = "tínhGiaiThừaToolStripMenuItem";
            this.tínhGiaiThừaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.tínhGiaiThừaToolStripMenuItem.Text = "Tính giai thừa";
            this.tínhGiaiThừaToolStripMenuItem.Click += new System.EventHandler(this.tínhGiaiThừaToolStripMenuItem_Click);
            // 
            // tínhTổngToolStripMenuItem
            // 
            this.tínhTổngToolStripMenuItem.Name = "tínhTổngToolStripMenuItem";
            this.tínhTổngToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tínhTổngToolStripMenuItem.Text = "Tính tổng";
            this.tínhTổngToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngToolStripMenuItem_Click);
            // 
            // tìmƯớcTrungLớnNhấtToolStripMenuItem
            // 
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem.Name = "tìmƯớcTrungLớnNhấtToolStripMenuItem";
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem.Size = new System.Drawing.Size(182, 20);
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem.Text = "Tim BSCLN và USCNN của 2 số";
            this.tìmƯớcTrungLớnNhấtToolStripMenuItem.Click += new System.EventHandler(this.tìmƯớcTrungLớnNhấtToolStripMenuItem_Click);
            // 
            // điềuKhiểnComboBoxToolStripMenuItem
            // 
            this.điềuKhiểnComboBoxToolStripMenuItem.Name = "điềuKhiểnComboBoxToolStripMenuItem";
            this.điềuKhiểnComboBoxToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.điềuKhiểnComboBoxToolStripMenuItem.Text = "Điều khiển combo box";
            this.điềuKhiểnComboBoxToolStripMenuItem.Click += new System.EventHandler(this.điềuKhiểnComboBoxToolStripMenuItem_Click);
            // 
            // ứngDụngFormChứcNăngToolStripMenuItem
            // 
            this.ứngDụngFormChứcNăngToolStripMenuItem.Name = "ứngDụngFormChứcNăngToolStripMenuItem";
            this.ứngDụngFormChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.ứngDụngFormChứcNăngToolStripMenuItem.Text = "ứng dụng form chức năng";
            this.ứngDụngFormChứcNăngToolStripMenuItem.Click += new System.EventHandler(this.ứngDụngFormChứcNăngToolStripMenuItem_Click);
            // 
            // menuMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuMdi";
            this.Text = "menuMdi";
            this.Load += new System.EventHandler(this.menuMdi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tínhGiaiThừaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmƯớcTrungLớnNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điềuKhiểnComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ứngDụngFormChứcNăngToolStripMenuItem;
    }
}