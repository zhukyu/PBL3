﻿namespace Gym
{
    partial class updateEmployee
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
            this.formNameLable = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gioitinh = new System.Windows.Forms.ComboBox();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._employeeID = new System.Windows.Forms.TextBox();
            this.deletePictureBox1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fixPictureBox1 = new System.Windows.Forms.Button();
            this.fixButton = new System.Windows.Forms.Button();
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(0, 1);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(791, 72);
            this.formNameLable.TabIndex = 36;
            this.formNameLable.Paint += new System.Windows.Forms.PaintEventHandler(this.formNameLable_Paint);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(198, 19);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(402, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thay đổi thông tin nhân viên";
            this.formName.Click += new System.EventHandler(this.formName_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lễ Tân",
            "Huấn luyện viên"});
            this.comboBox1.Location = new System.Drawing.Point(168, 454);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 74;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gioitinh
            // 
            this.gioitinh.FormattingEnabled = true;
            this.gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioitinh.Location = new System.Drawing.Point(168, 236);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(215, 28);
            this.gioitinh.TabIndex = 73;
            this.gioitinh.SelectedIndexChanged += new System.EventHandler(this.gioitinh_SelectedIndexChanged);
            // 
            // _address
            // 
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._address.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(168, 505);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(215, 36);
            this._address.TabIndex = 72;
            this._address.TextChanged += new System.EventHandler(this._address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 27);
            this.label5.TabIndex = 71;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 70;
            this.label6.Text = "Chức vụ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 27);
            this.label7.TabIndex = 69;
            this.label7.Text = "Số CMND";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 68;
            this.label8.Text = "SĐT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // _idNumber
            // 
            this._idNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(168, 393);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(215, 36);
            this._idNumber.TabIndex = 67;
            this._idNumber.TextChanged += new System.EventHandler(this._idNumber_TextChanged);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._phoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(168, 340);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(215, 36);
            this._phoneNumber.TabIndex = 66;
            this._phoneNumber.TextChanged += new System.EventHandler(this._phoneNumber_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(168, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 36);
            this.textBox1.TabIndex = 65;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mã NV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _fullName
            // 
            this._fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(168, 174);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(215, 36);
            this._fullName.TabIndex = 60;
            this._fullName.TextChanged += new System.EventHandler(this._fullName_TextChanged);
            // 
            // _employeeID
            // 
            this._employeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(168, 121);
            this._employeeID.Name = "_employeeID";
            this._employeeID.Size = new System.Drawing.Size(215, 36);
            this._employeeID.TabIndex = 59;
            this._employeeID.TextChanged += new System.EventHandler(this._employeeID_TextChanged);
            // 
            // deletePictureBox1
            // 
            this.deletePictureBox1.Location = new System.Drawing.Point(617, 433);
            this.deletePictureBox1.Name = "deletePictureBox1";
            this.deletePictureBox1.Size = new System.Drawing.Size(94, 29);
            this.deletePictureBox1.TabIndex = 76;
            this.deletePictureBox1.Text = "Xoá ảnh";
            this.deletePictureBox1.UseVisualStyleBackColor = true;
            this.deletePictureBox1.Click += new System.EventHandler(this.deletePictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(483, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 291);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fixPictureBox1
            // 
            this.fixPictureBox1.Location = new System.Drawing.Point(483, 433);
            this.fixPictureBox1.Name = "fixPictureBox1";
            this.fixPictureBox1.Size = new System.Drawing.Size(128, 29);
            this.fixPictureBox1.TabIndex = 77;
            this.fixPictureBox1.Text = "Thêm ảnh mới";
            this.fixPictureBox1.UseVisualStyleBackColor = true;
            this.fixPictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fixButton
            // 
            this.fixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.fixButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fixButton.ForeColor = System.Drawing.Color.White;
            this.fixButton.Location = new System.Drawing.Point(480, 502);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(231, 49);
            this.fixButton.TabIndex = 78;
            this.fixButton.Text = "Lưu thay đổi";
            this.fixButton.UseVisualStyleBackColor = false;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // fixEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 622);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.fixPictureBox1);
            this.Controls.Add(this.deletePictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this._address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._idNumber);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fullName);
            this.Controls.Add(this._employeeID);
            this.Controls.Add(this.formNameLable);
            this.Name = "fixEmployee";
            this.Text = "fixEmployee";
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox gioitinh;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.Button deletePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fixPictureBox1;
        private System.Windows.Forms.Button fixButton;
    }
}