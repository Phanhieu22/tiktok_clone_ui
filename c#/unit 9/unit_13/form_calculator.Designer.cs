
namespace unit_13
{
    partial class form_calculator
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
            this.txt_phepTinh = new System.Windows.Forms.ComboBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.bnt_result = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hạng 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phép tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số hạng 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // txt_phepTinh
            // 
            this.txt_phepTinh.DisplayMember = "+";
            this.txt_phepTinh.FormattingEnabled = true;
            this.txt_phepTinh.Items.AddRange(new object[] {
            "+",
            "_",
            "*",
            "/"});
            this.txt_phepTinh.Location = new System.Drawing.Point(321, 160);
            this.txt_phepTinh.Name = "txt_phepTinh";
            this.txt_phepTinh.Size = new System.Drawing.Size(76, 21);
            this.txt_phepTinh.TabIndex = 4;
            this.txt_phepTinh.ValueMember = "+";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(189, 161);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(76, 20);
            this.num1.TabIndex = 5;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(445, 160);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(62, 20);
            this.num2.TabIndex = 6;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(570, 164);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(44, 13);
            this.label_result.TabIndex = 7;
            this.label_result.Text = "Kết quả";
            // 
            // bnt_result
            // 
            this.bnt_result.Location = new System.Drawing.Point(258, 226);
            this.bnt_result.Name = "bnt_result";
            this.bnt_result.Size = new System.Drawing.Size(75, 23);
            this.bnt_result.TabIndex = 8;
            this.bnt_result.Text = "Result";
            this.bnt_result.UseVisualStyleBackColor = true;
            this.bnt_result.Click += new System.EventHandler(this.bnt_result_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // form_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.txt_phepTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_calculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.form_calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_phepTinh;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button bnt_result;
        private System.Windows.Forms.Button button2;
    }
}