
namespace homeworkWinformApp
{
    partial class sumOfNumbers
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
            this.btn_result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_result1 = new System.Windows.Forms.Button();
            this.txt_enterN = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_userName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.AutoSize = true;
            this.btn_result.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_result.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_result.Location = new System.Drawing.Point(199, 244);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(83, 26);
            this.btn_result.TabIndex = 16;
            this.btn_result.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(334, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tính tổng";
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(536, 301);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(98, 32);
            this.btn_signUp.TabIndex = 14;
            this.btn_signUp.Text = "Thoát";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(374, 301);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(143, 32);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Tính tổng S= 2+4+6+...+n";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_result1
            // 
            this.btn_result1.Location = new System.Drawing.Point(187, 304);
            this.btn_result1.Name = "btn_result1";
            this.btn_result1.Size = new System.Drawing.Size(158, 29);
            this.btn_result1.TabIndex = 12;
            this.btn_result1.Text = "Tính tổng S= 1+2+3...+n";
            this.btn_result1.UseVisualStyleBackColor = true;
            this.btn_result1.Click += new System.EventHandler(this.btn_result1_Click);
            // 
            // txt_enterN
            // 
            this.txt_enterN.Location = new System.Drawing.Point(339, 192);
            this.txt_enterN.Name = "txt_enterN";
            this.txt_enterN.Size = new System.Drawing.Size(276, 20);
            this.txt_enterN.TabIndex = 11;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(339, 250);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(276, 20);
            this.txt_result.TabIndex = 10;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_userName
            // 
            this.btn_userName.AutoSize = true;
            this.btn_userName.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_userName.Location = new System.Drawing.Point(199, 192);
            this.btn_userName.Name = "btn_userName";
            this.btn_userName.Size = new System.Drawing.Size(89, 26);
            this.btn_userName.TabIndex = 9;
            this.btn_userName.Text = "Nhập  N";
            // 
            // sumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_result1);
            this.Controls.Add(this.txt_enterN);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_userName);
            this.Name = "sumOfNumbers";
            this.Text = "sumOfNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_result1;
        private System.Windows.Forms.TextBox txt_enterN;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label btn_userName;
    }
}