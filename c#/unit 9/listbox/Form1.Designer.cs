
namespace listbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_orange = new System.Windows.Forms.RadioButton();
            this.rdo_green = new System.Windows.Forms.RadioButton();
            this.rdo_blue = new System.Windows.Forms.RadioButton();
            this.rdo_red = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_violet = new System.Windows.Forms.RadioButton();
            this.rdo_cyan = new System.Windows.Forms.RadioButton();
            this.rdo_pink = new System.Windows.Forms.RadioButton();
            this.rdo_yellow = new System.Windows.Forms.RadioButton();
            this.btn_changeTextColor = new System.Windows.Forms.Button();
            this.select_backgroud = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cdl_color = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_preview.Location = new System.Drawing.Point(232, 54);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(325, 50);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_orange);
            this.groupBox1.Controls.Add(this.rdo_green);
            this.groupBox1.Controls.Add(this.rdo_blue);
            this.groupBox1.Controls.Add(this.rdo_red);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(130, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "for color";
            // 
            // rdo_orange
            // 
            this.rdo_orange.AutoSize = true;
            this.rdo_orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_orange.Location = new System.Drawing.Point(70, 152);
            this.rdo_orange.Name = "rdo_orange";
            this.rdo_orange.Size = new System.Drawing.Size(76, 20);
            this.rdo_orange.TabIndex = 6;
            this.rdo_orange.TabStop = true;
            this.rdo_orange.Text = "Orange";
            this.rdo_orange.UseVisualStyleBackColor = true;
            this.rdo_orange.CheckedChanged += new System.EventHandler(this.rdo_orange_CheckedChanged);
            // 
            // rdo_green
            // 
            this.rdo_green.AutoSize = true;
            this.rdo_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_green.Location = new System.Drawing.Point(70, 114);
            this.rdo_green.Name = "rdo_green";
            this.rdo_green.Size = new System.Drawing.Size(67, 20);
            this.rdo_green.TabIndex = 5;
            this.rdo_green.TabStop = true;
            this.rdo_green.Text = "Green";
            this.rdo_green.UseVisualStyleBackColor = true;
            this.rdo_green.CheckedChanged += new System.EventHandler(this.rdo_green_CheckedChanged);
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_blue.Location = new System.Drawing.Point(70, 80);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(56, 20);
            this.rdo_blue.TabIndex = 4;
            this.rdo_blue.TabStop = true;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            this.rdo_blue.CheckedChanged += new System.EventHandler(this.rdo_blue_CheckedChanged);
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_red.Location = new System.Drawing.Point(70, 39);
            this.rdo_red.Name = "rdo_red";
            this.rdo_red.Size = new System.Drawing.Size(48, 20);
            this.rdo_red.TabIndex = 3;
            this.rdo_red.TabStop = true;
            this.rdo_red.Text = "red";
            this.rdo_red.UseVisualStyleBackColor = true;
            this.rdo_red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_violet);
            this.groupBox2.Controls.Add(this.rdo_cyan);
            this.groupBox2.Controls.Add(this.rdo_pink);
            this.groupBox2.Controls.Add(this.rdo_yellow);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(460, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backgroud";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdo_violet
            // 
            this.rdo_violet.AutoSize = true;
            this.rdo_violet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_violet.Location = new System.Drawing.Point(64, 152);
            this.rdo_violet.Name = "rdo_violet";
            this.rdo_violet.Size = new System.Drawing.Size(65, 20);
            this.rdo_violet.TabIndex = 3;
            this.rdo_violet.TabStop = true;
            this.rdo_violet.Text = "Violet";
            this.rdo_violet.UseVisualStyleBackColor = true;
            this.rdo_violet.CheckedChanged += new System.EventHandler(this.rdo_violet_CheckedChanged);
            // 
            // rdo_cyan
            // 
            this.rdo_cyan.AutoSize = true;
            this.rdo_cyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_cyan.Location = new System.Drawing.Point(67, 114);
            this.rdo_cyan.Name = "rdo_cyan";
            this.rdo_cyan.Size = new System.Drawing.Size(60, 20);
            this.rdo_cyan.TabIndex = 2;
            this.rdo_cyan.TabStop = true;
            this.rdo_cyan.Text = "Cyan";
            this.rdo_cyan.UseVisualStyleBackColor = true;
            this.rdo_cyan.CheckedChanged += new System.EventHandler(this.rdo_cyan_CheckedChanged);
            // 
            // rdo_pink
            // 
            this.rdo_pink.AutoSize = true;
            this.rdo_pink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_pink.Location = new System.Drawing.Point(67, 80);
            this.rdo_pink.Name = "rdo_pink";
            this.rdo_pink.Size = new System.Drawing.Size(55, 20);
            this.rdo_pink.TabIndex = 1;
            this.rdo_pink.TabStop = true;
            this.rdo_pink.Text = "Pink";
            this.rdo_pink.UseVisualStyleBackColor = true;
            this.rdo_pink.CheckedChanged += new System.EventHandler(this.rdo_pink_CheckedChanged);
            // 
            // rdo_yellow
            // 
            this.rdo_yellow.AutoSize = true;
            this.rdo_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_yellow.Location = new System.Drawing.Point(67, 39);
            this.rdo_yellow.Name = "rdo_yellow";
            this.rdo_yellow.Size = new System.Drawing.Size(71, 20);
            this.rdo_yellow.TabIndex = 0;
            this.rdo_yellow.TabStop = true;
            this.rdo_yellow.Text = "Yellow";
            this.rdo_yellow.UseVisualStyleBackColor = true;
            this.rdo_yellow.CheckedChanged += new System.EventHandler(this.rdo_yellow_CheckedChanged);
            // 
            // btn_changeTextColor
            // 
            this.btn_changeTextColor.BackColor = System.Drawing.Color.Silver;
            this.btn_changeTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_changeTextColor.Location = new System.Drawing.Point(256, 394);
            this.btn_changeTextColor.Name = "btn_changeTextColor";
            this.btn_changeTextColor.Size = new System.Drawing.Size(166, 23);
            this.btn_changeTextColor.TabIndex = 3;
            this.btn_changeTextColor.Text = "select color text";
            this.btn_changeTextColor.UseVisualStyleBackColor = false;
            this.btn_changeTextColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_backgroud
            // 
            this.select_backgroud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.select_backgroud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.select_backgroud.Location = new System.Drawing.Point(460, 394);
            this.select_backgroud.Name = "select_backgroud";
            this.select_backgroud.Size = new System.Drawing.Size(164, 23);
            this.select_backgroud.TabIndex = 4;
            this.select_backgroud.Text = "select backgroud color  green";
            this.select_backgroud.UseVisualStyleBackColor = false;
            this.select_backgroud.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.select_backgroud);
            this.Controls.Add(this.btn_changeTextColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_preview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_orange;
        private System.Windows.Forms.RadioButton rdo_green;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.RadioButton rdo_violet;
        private System.Windows.Forms.RadioButton rdo_cyan;
        private System.Windows.Forms.RadioButton rdo_pink;
        private System.Windows.Forms.RadioButton rdo_yellow;
        private System.Windows.Forms.Button btn_changeTextColor;
        private System.Windows.Forms.Button select_backgroud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog cdl_color;
    }
}

