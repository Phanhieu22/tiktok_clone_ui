
namespace cau1
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
            System.Windows.Forms.TextBox txt_ten_dang_nhap;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            txt_ten_dang_nhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ten_dang_nhap
            // 
            resources.ApplyResources(txt_ten_dang_nhap, "txt_ten_dang_nhap");
            txt_ten_dang_nhap.Name = "txt_ten_dang_nhap";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_mat_khau
            // 
            resources.ApplyResources(this.txt_mat_khau, "txt_mat_khau");
            this.txt_mat_khau.Name = "txt_mat_khau";
            // 
            // btn_dang_nhap
            // 
            resources.ApplyResources(this.btn_dang_nhap, "btn_dang_nhap");
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.UseVisualStyleBackColor = true;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // btn_xoa
            // 
            resources.ApplyResources(this.btn_xoa, "btn_xoa");
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            resources.ApplyResources(this.btn_thoat, "btn_thoat");
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_dang_nhap);
            this.Controls.Add(this.txt_mat_khau);
            this.Controls.Add(txt_ten_dang_nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
    }
}

