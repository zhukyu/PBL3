namespace Gym
{
    partial class FormUpdateEmployee
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
            this.components = new System.ComponentModel.Container();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this._role = new System.Windows.Forms.ComboBox();
            this._gender = new System.Windows.Forms.ComboBox();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._employeeID = new System.Windows.Forms.TextBox();
            this.employeePicture = new System.Windows.Forms.PictureBox();
            this.fixButton = new System.Windows.Forms.Button();
            this._birthday = new System.Windows.Forms.DateTimePicker();
            this.deleteImgBtn = new System.Windows.Forms.Button();
            this.replaceImgBtn = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorChucvu = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroradress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this._password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMK)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(0, -1);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(797, 74);
            this.formNameLable.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(728, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // 
            // _role
            // 
            this._role.BackColor = System.Drawing.Color.White;
            this._role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._role.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._role.FormattingEnabled = true;
            this._role.Items.AddRange(new object[] {
            "Lễ Tân",
            "Huấn luyện viên"});
            this._role.Location = new System.Drawing.Point(180, 455);
            this._role.Name = "_role";
            this._role.Size = new System.Drawing.Size(258, 39);
            this._role.TabIndex = 74;
            this._role.Validating += new System.ComponentModel.CancelEventHandler(this._role_Validating);
            // 
            // _gender
            // 
            this._gender.BackColor = System.Drawing.Color.White;
            this._gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._gender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._gender.FormattingEnabled = true;
            this._gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this._gender.Location = new System.Drawing.Point(180, 231);
            this._gender.Name = "_gender";
            this._gender.Size = new System.Drawing.Size(258, 39);
            this._gender.TabIndex = 73;
            // 
            // _address
            // 
            this._address.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(180, 506);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(258, 43);
            this._address.TabIndex = 72;
            this._address.Validating += new System.ComponentModel.CancelEventHandler(this._address_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 71;
            this.label5.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 70;
            this.label6.Text = "Chức vụ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 69;
            this.label7.Text = "Số CMND :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 27);
            this.label8.TabIndex = 68;
            this.label8.Text = "SĐT :";
            // 
            // _idNumber
            // 
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(180, 394);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(258, 43);
            this._idNumber.TabIndex = 67;
            this._idNumber.Validating += new System.ComponentModel.CancelEventHandler(this._idNumber_Validating);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(180, 341);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(258, 43);
            this._phoneNumber.TabIndex = 66;
            this._phoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this._phoneNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "Họ tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mã NV :";
            // 
            // _fullName
            // 
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(180, 175);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(258, 43);
            this._fullName.TabIndex = 60;
            this._fullName.Validating += new System.ComponentModel.CancelEventHandler(this._fullName_Validating);
            // 
            // _employeeID
            // 
            this._employeeID.BackColor = System.Drawing.Color.White;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(180, 119);
            this._employeeID.Name = "_employeeID";
            this._employeeID.ReadOnly = true;
            this._employeeID.Size = new System.Drawing.Size(258, 43);
            this._employeeID.TabIndex = 59;
            // 
            // employeePicture
            // 
            this.employeePicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeePicture.Location = new System.Drawing.Point(483, 121);
            this.employeePicture.Name = "employeePicture";
            this.employeePicture.Size = new System.Drawing.Size(228, 291);
            this.employeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicture.TabIndex = 75;
            this.employeePicture.TabStop = false;
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
            // _birthday
            // 
            this._birthday.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._birthday.Location = new System.Drawing.Point(180, 284);
            this._birthday.Name = "_birthday";
            this._birthday.Size = new System.Drawing.Size(258, 38);
            this._birthday.TabIndex = 79;
            this._birthday.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            // 
            // deleteImgBtn
            // 
            this.deleteImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteImgBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteImgBtn.ForeColor = System.Drawing.Color.White;
            this.deleteImgBtn.Location = new System.Drawing.Point(482, 425);
            this.deleteImgBtn.Name = "deleteImgBtn";
            this.deleteImgBtn.Size = new System.Drawing.Size(99, 40);
            this.deleteImgBtn.TabIndex = 80;
            this.deleteImgBtn.Text = "Xóa ảnh";
            this.deleteImgBtn.UseVisualStyleBackColor = false;
            this.deleteImgBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // replaceImgBtn
            // 
            this.replaceImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.replaceImgBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.replaceImgBtn.ForeColor = System.Drawing.Color.White;
            this.replaceImgBtn.Location = new System.Drawing.Point(608, 425);
            this.replaceImgBtn.Name = "replaceImgBtn";
            this.replaceImgBtn.Size = new System.Drawing.Size(100, 40);
            this.replaceImgBtn.TabIndex = 80;
            this.replaceImgBtn.Text = "Đổi ảnh";
            this.replaceImgBtn.UseVisualStyleBackColor = false;
            this.replaceImgBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorChucvu
            // 
            this.errorChucvu.ContainerControl = this;
            // 
            // erroradress
            // 
            this.erroradress.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // _password
            // 
            this._password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._password.Location = new System.Drawing.Point(180, 567);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(258, 43);
            this._password.TabIndex = 82;
            this._password.Validating += new System.ComponentModel.CancelEventHandler(this._password_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(45, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 81;
            this.label9.Text = "Mật khẩu :";
            // 
            // errorMK
            // 
            this.errorMK.ContainerControl = this;
            // 
            // FormUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 647);
            this.ControlBox = false;
            this.Controls.Add(this._password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.replaceImgBtn);
            this.Controls.Add(this.deleteImgBtn);
            this.Controls.Add(this._birthday);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.employeePicture);
            this.Controls.Add(this._role);
            this.Controls.Add(this._gender);
            this.Controls.Add(this._address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._idNumber);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fullName);
            this.Controls.Add(this._employeeID);
            this.Controls.Add(this.formNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fixEmployee";
            this.Load += new System.EventHandler(this.updateEmployee_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.ComboBox _role;
        private System.Windows.Forms.ComboBox _gender;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.DateTimePicker _birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.PictureBox employeePicture;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
        private System.Windows.Forms.Button deleteImgBtn;
        private System.Windows.Forms.Button replaceImgBtn;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorChucvu;
        private System.Windows.Forms.ErrorProvider erroradress;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorMK;
    }
}