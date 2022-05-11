
namespace ca2_fixed
{
    partial class form_khoa
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
            this.dvg_khoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma_khoa = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_khoa
            // 
            this.dvg_khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_khoa.Location = new System.Drawing.Point(27, 234);
            this.dvg_khoa.Name = "dvg_khoa";
            this.dvg_khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_khoa.Size = new System.Drawing.Size(761, 204);
            this.dvg_khoa.TabIndex = 0;
            this.dvg_khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_khoa_CellClick);
            this.dvg_khoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_khoa_CellContentClick);
            this.dvg_khoa.SelectionChanged += new System.EventHandler(this.dvg_khoa_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khoa";
            // 
            // txt_ma_khoa
            // 
            this.txt_ma_khoa.Location = new System.Drawing.Point(314, 42);
            this.txt_ma_khoa.Name = "txt_ma_khoa";
            this.txt_ma_khoa.Size = new System.Drawing.Size(297, 20);
            this.txt_ma_khoa.TabIndex = 3;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Location = new System.Drawing.Point(314, 127);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(297, 20);
            this.txt_khoa.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(125, 175);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 31);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(286, 175);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 31);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xóa
            // 
            this.btn_xóa.Location = new System.Drawing.Point(447, 175);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(75, 31);
            this.btn_xóa.TabIndex = 7;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // form_khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_ma_khoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_khoa);
            this.Name = "form_khoa";
            this.Load += new System.EventHandler(this.form_khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ma_khoa;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button button4;
    }
}

