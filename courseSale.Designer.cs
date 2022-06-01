namespace Gym
{
    partial class CourseSale
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
            this.courseCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._customerID = new System.Windows.Forms.TextBox();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._duration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.teacherCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.formNameLable.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseCb
            // 
            this.courseCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseCb.FormattingEnabled = true;
            this.courseCb.Location = new System.Drawing.Point(135, 394);
            this.courseCb.Name = "courseCb";
            this.courseCb.Size = new System.Drawing.Size(491, 36);
            this.courseCb.TabIndex = 60;
            this.courseCb.SelectedIndexChanged += new System.EventHandler(this.courseCb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mã KH :";
            // 
            // _customerID
            // 
            this._customerID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._customerID.Location = new System.Drawing.Point(134, 148);
            this._customerID.Name = "_customerID";
            this._customerID.Size = new System.Drawing.Size(214, 38);
            this._customerID.TabIndex = 61;
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-1, -2);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(683, 80);
            this.formNameLable.TabIndex = 65;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(212, 25);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(256, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Đăng ký khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên KH :";
            // 
            // _fullName
            // 
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(134, 207);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(492, 38);
            this._fullName.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(354, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "SĐT :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(423, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 38);
            this.textBox1.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "CMND :";
            // 
            // _idNumber
            // 
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(134, 273);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(214, 38);
            this._idNumber.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(274, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 72;
            this.label7.Text = "Khóa học";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.registerButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(465, 606);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(161, 49);
            this.registerButton.TabIndex = 73;
            this.registerButton.Text = "Đăng ký";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Thời gian :";
            // 
            // _duration
            // 
            this._duration.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._duration.Location = new System.Drawing.Point(134, 527);
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(214, 38);
            this._duration.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(354, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 77;
            this.label10.Text = "Giá :";
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(423, 527);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(203, 38);
            this._price.TabIndex = 76;
            // 
            // teacherCb
            // 
            this.teacherCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacherCb.FormattingEnabled = true;
            this.teacherCb.Location = new System.Drawing.Point(135, 460);
            this.teacherCb.Name = "teacherCb";
            this.teacherCb.Size = new System.Drawing.Size(491, 36);
            this.teacherCb.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 80;
            this.label11.Text = "Giáo viên :";
            // 
            // courseSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 680);
            this.Controls.Add(this.teacherCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._duration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._price);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._idNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._fullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formNameLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._customerID);
            this.Controls.Add(this.courseCb);
            this.Controls.Add(this.label6);
            this.Name = "courseSale";
            this.Text = "courseSale";
            this.Load += new System.EventHandler(this.courseSale_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox courseCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _duration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.ComboBox teacherCb;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox _customerID;
        public System.Windows.Forms.TextBox _fullName;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox _idNumber;
    }
}