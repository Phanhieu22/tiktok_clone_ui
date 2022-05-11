
namespace homeworkWinformApp
{
    partial class ListBox
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
            this.lbt_hienthi = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_nhapn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_delall = new System.Windows.Forms.Button();
            this.btn_delnow = new System.Windows.Forms.Button();
            this.btn_delpt2 = new System.Windows.Forms.Button();
            this.btn_delpt1 = new System.Windows.Forms.Button();
            this.btn_tongpt = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listbõ = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbt_hienthi
            // 
            this.lbt_hienthi.FormattingEnabled = true;
            this.lbt_hienthi.Location = new System.Drawing.Point(169, 226);
            this.lbt_hienthi.Margin = new System.Windows.Forms.Padding(2);
            this.lbt_hienthi.Name = "lbt_hienthi";
            this.lbt_hienthi.Size = new System.Drawing.Size(182, 121);
            this.lbt_hienthi.TabIndex = 19;
            this.lbt_hienthi.SelectedIndexChanged += new System.EventHandler(this.lbt_hienthi_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(169, 161);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 27);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_nhapn
            // 
            this.txt_nhapn.Location = new System.Drawing.Point(169, 118);
            this.txt_nhapn.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nhapn.Multiline = true;
            this.txt_nhapn.Name = "txt_nhapn";
            this.txt_nhapn.Size = new System.Drawing.Size(182, 25);
            this.txt_nhapn.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập số nguyên";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(496, 331);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(154, 32);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_delall
            // 
            this.btn_delall.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delall.Location = new System.Drawing.Point(496, 284);
            this.btn_delall.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delall.Name = "btn_delall";
            this.btn_delall.Size = new System.Drawing.Size(154, 32);
            this.btn_delall.TabIndex = 11;
            this.btn_delall.Text = "Xóa tất cả";
            this.btn_delall.UseVisualStyleBackColor = true;
            this.btn_delall.Click += new System.EventHandler(this.btn_delall_Click);
            // 
            // btn_delnow
            // 
            this.btn_delnow.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delnow.Location = new System.Drawing.Point(496, 235);
            this.btn_delnow.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delnow.Name = "btn_delnow";
            this.btn_delnow.Size = new System.Drawing.Size(154, 32);
            this.btn_delnow.TabIndex = 12;
            this.btn_delnow.Text = "Xóa phần tử hiện tại";
            this.btn_delnow.UseVisualStyleBackColor = true;
            this.btn_delnow.Click += new System.EventHandler(this.btn_delnow_Click);
            // 
            // btn_delpt2
            // 
            this.btn_delpt2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delpt2.Location = new System.Drawing.Point(496, 187);
            this.btn_delpt2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delpt2.Name = "btn_delpt2";
            this.btn_delpt2.Size = new System.Drawing.Size(154, 32);
            this.btn_delpt2.TabIndex = 13;
            this.btn_delpt2.Text = "Xóa các phần tử cuối";
            this.btn_delpt2.UseVisualStyleBackColor = true;
            this.btn_delpt2.Click += new System.EventHandler(this.btn_delpt2_Click);
            // 
            // btn_delpt1
            // 
            this.btn_delpt1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delpt1.Location = new System.Drawing.Point(496, 139);
            this.btn_delpt1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delpt1.Name = "btn_delpt1";
            this.btn_delpt1.Size = new System.Drawing.Size(154, 32);
            this.btn_delpt1.TabIndex = 14;
            this.btn_delpt1.Text = "Xóa các phần tử đầu";
            this.btn_delpt1.UseVisualStyleBackColor = true;
            this.btn_delpt1.Click += new System.EventHandler(this.btn_delpt1_Click);
            // 
            // btn_tongpt
            // 
            this.btn_tongpt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tongpt.Location = new System.Drawing.Point(496, 91);
            this.btn_tongpt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tongpt.Name = "btn_tongpt";
            this.btn_tongpt.Size = new System.Drawing.Size(154, 32);
            this.btn_tongpt.TabIndex = 15;
            this.btn_tongpt.Text = "Tổng các phần tử";
            this.btn_tongpt.UseVisualStyleBackColor = true;
            this.btn_tongpt.Click += new System.EventHandler(this.btn_tongpt_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(460, 63);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 324);
            this.listBox2.TabIndex = 8;
            // 
            // listbõ
            // 
            this.listbõ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listbõ.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbõ.FormattingEnabled = true;
            this.listbõ.ItemHeight = 16;
            this.listbõ.Location = new System.Drawing.Point(150, 63);
            this.listbõ.Margin = new System.Windows.Forms.Padding(2);
            this.listbõ.Name = "listbõ";
            this.listbõ.Size = new System.Drawing.Size(222, 324);
            this.listbõ.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kết quả";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(269, 402);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(0, 13);
            this.lb_ketqua.TabIndex = 21;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbt_hienthi);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_nhapn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_delall);
            this.Controls.Add(this.btn_delnow);
            this.Controls.Add(this.btn_delpt2);
            this.Controls.Add(this.btn_delpt1);
            this.Controls.Add(this.btn_tongpt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listbõ);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbt_hienthi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_nhapn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_delall;
        private System.Windows.Forms.Button btn_delnow;
        private System.Windows.Forms.Button btn_delpt2;
        private System.Windows.Forms.Button btn_delpt1;
        private System.Windows.Forms.Button btn_tongpt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listbõ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ketqua;
    }
}