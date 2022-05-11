
namespace course_registration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hour = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add_all = new System.Windows.Forms.Button();
            this.btn_add_single = new System.Windows.Forms.Button();
            this.btn_unchecked_all = new System.Windows.Forms.Button();
            this.btn_uncheck_single = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listCourse = new System.Windows.Forms.ListBox();
            this.list_selected = new System.Windows.Forms.ListBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giờ";
            // 
            // txt_hour
            // 
            this.txt_hour.Location = new System.Drawing.Point(458, 136);
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(106, 20);
            this.txt_hour.TabIndex = 6;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(260, 136);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(88, 20);
            this.txt_day.TabIndex = 7;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(148, 335);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(362, 138);
            this.txt_result.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách các môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Danh sách đã chọn";
            // 
            // btn_add_all
            // 
            this.btn_add_all.Location = new System.Drawing.Point(381, 195);
            this.btn_add_all.Name = "btn_add_all";
            this.btn_add_all.Size = new System.Drawing.Size(75, 23);
            this.btn_add_all.TabIndex = 13;
            this.btn_add_all.Text = ">>";
            this.btn_add_all.UseVisualStyleBackColor = true;
            this.btn_add_all.Click += new System.EventHandler(this.btn_add_all_Click);
            // 
            // btn_add_single
            // 
            this.btn_add_single.Location = new System.Drawing.Point(381, 227);
            this.btn_add_single.Name = "btn_add_single";
            this.btn_add_single.Size = new System.Drawing.Size(75, 23);
            this.btn_add_single.TabIndex = 14;
            this.btn_add_single.Text = ">";
            this.btn_add_single.UseVisualStyleBackColor = true;
            this.btn_add_single.Click += new System.EventHandler(this.btn_add_single_Click);
            // 
            // btn_unchecked_all
            // 
            this.btn_unchecked_all.Location = new System.Drawing.Point(381, 259);
            this.btn_unchecked_all.Name = "btn_unchecked_all";
            this.btn_unchecked_all.Size = new System.Drawing.Size(75, 23);
            this.btn_unchecked_all.TabIndex = 15;
            this.btn_unchecked_all.Text = "<<";
            this.btn_unchecked_all.UseVisualStyleBackColor = true;
            this.btn_unchecked_all.Click += new System.EventHandler(this.btn_unchecked_all_Click);
            // 
            // btn_uncheck_single
            // 
            this.btn_uncheck_single.Location = new System.Drawing.Point(381, 291);
            this.btn_uncheck_single.Name = "btn_uncheck_single";
            this.btn_uncheck_single.Size = new System.Drawing.Size(75, 23);
            this.btn_uncheck_single.TabIndex = 16;
            this.btn_uncheck_single.Text = "<";
            this.btn_uncheck_single.UseVisualStyleBackColor = true;
            this.btn_uncheck_single.Click += new System.EventHandler(this.btn_uncheck_single_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(566, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 29);
            this.button5.TabIndex = 17;
            this.button5.Text = "Enter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(566, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 29);
            this.button6.TabIndex = 18;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(566, 437);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 29);
            this.button7.TabIndex = 19;
            this.button7.Text = "Close";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listCourse
            // 
            this.listCourse.FormattingEnabled = true;
            this.listCourse.Items.AddRange(new object[] {
            "lập trình web",
            "lập trình với c#",
            "lập trình hướng đối tượng",
            "quản trị với sql server",
            "hệ thống quản lý công nghệ thông tin"});
            this.listCourse.Location = new System.Drawing.Point(148, 195);
            this.listCourse.Name = "listCourse";
            this.listCourse.Size = new System.Drawing.Size(208, 121);
            this.listCourse.TabIndex = 20;
            this.listCourse.SelectedIndexChanged += new System.EventHandler(this.listCourse_SelectedIndexChanged);
            this.listCourse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listCourse_MouseDown);
            // 
            // list_selected
            // 
            this.list_selected.FormattingEnabled = true;
            this.list_selected.Location = new System.Drawing.Point(489, 195);
            this.list_selected.Name = "list_selected";
            this.list_selected.Size = new System.Drawing.Size(202, 121);
            this.list_selected.TabIndex = 21;
            this.list_selected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_selected_MouseDown);
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Items.AddRange(new object[] {
            "phan đưc hiếu ",
            "trịnh xuân mai",
            "phan văn mạnh",
            "trần quốc tuấn"});
            this.cb_name.Location = new System.Drawing.Point(404, 91);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(121, 21);
            this.cb_name.TabIndex = 22;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.list_selected);
            this.Controls.Add(this.listCourse);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_uncheck_single);
            this.Controls.Add(this.btn_unchecked_all);
            this.Controls.Add(this.btn_add_single);
            this.Controls.Add(this.btn_add_all);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.txt_hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hour;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_all;
        private System.Windows.Forms.Button btn_add_single;
        private System.Windows.Forms.Button btn_unchecked_all;
        private System.Windows.Forms.Button btn_uncheck_single;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listCourse;
        private System.Windows.Forms.ListBox list_selected;
        private System.Windows.Forms.ComboBox cb_name;
    }
}

