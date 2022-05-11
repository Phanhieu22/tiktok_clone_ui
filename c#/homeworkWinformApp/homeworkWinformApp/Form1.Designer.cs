
namespace homeworkWinformApp
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
            this.btn_userName = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_password = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_userName
            // 
            this.btn_userName.AutoSize = true;
            this.btn_userName.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_userName.Location = new System.Drawing.Point(256, 177);
            this.btn_userName.Name = "btn_userName";
            this.btn_userName.Size = new System.Drawing.Size(113, 26);
            this.btn_userName.TabIndex = 0;
            this.btn_userName.Text = "User name";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(396, 235);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(243, 20);
            this.txt_password.TabIndex = 2;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(396, 177);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(243, 20);
            this.txt_userName.TabIndex = 3;
            this.txt_userName.TextChanged += new System.EventHandler(this.txt_userName_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(244, 289);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(114, 29);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(431, 286);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 32);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(572, 286);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(98, 32);
            this.btn_signUp.TabIndex = 6;
            this.btn_signUp.Text = "Close";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login now !";
            // 
            // btn_password
            // 
            this.btn_password.AutoSize = true;
            this.btn_password.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_password.Location = new System.Drawing.Point(256, 229);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(102, 26);
            this.btn_password.TabIndex = 8;
            this.btn_password.Text = "Password";
            // 
            // txt_message
            // 
            this.txt_message.AutoSize = true;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.Red;
            this.txt_message.Location = new System.Drawing.Point(369, 331);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(0, 24);
            this.txt_message.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homeworkWinformApp.Properties.Resources.backgound1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_userName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn_password;
        private System.Windows.Forms.Label txt_message;
    }
}

