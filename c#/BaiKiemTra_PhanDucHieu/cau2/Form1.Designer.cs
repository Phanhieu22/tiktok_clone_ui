
namespace cau2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.txt_nhap_n = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính tổng T = 1 + 2 + 3 + ... + n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập N";
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong.Location = new System.Drawing.Point(91, 154);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(45, 20);
            this.lbl_tong.TabIndex = 2;
            this.lbl_tong.Text = "Tổng";
            // 
            // txt_nhap_n
            // 
            this.txt_nhap_n.Location = new System.Drawing.Point(177, 111);
            this.txt_nhap_n.Name = "txt_nhap_n";
            this.txt_nhap_n.Size = new System.Drawing.Size(220, 20);
            this.txt_nhap_n.TabIndex = 3;
            this.txt_nhap_n.TextChanged += new System.EventHandler(this.txt_nhap_n_TextChanged);
            this.txt_nhap_n.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nhap_n_KeyUp);
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(158, 202);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(75, 23);
            this.btn_tinh.TabIndex = 5;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(262, 202);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(177, 158);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.ReadOnly = true;
            this.txt_tong.Size = new System.Drawing.Size(220, 20);
            this.txt_tong.TabIndex = 4;
            this.txt_tong.TextChanged += new System.EventHandler(this.txt_tong_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 282);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.txt_nhap_n);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tong;
        private System.Windows.Forms.TextBox txt_nhap_n;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_tong;
    }
}

