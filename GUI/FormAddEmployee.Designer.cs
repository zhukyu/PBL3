namespace Gym
{
    partial class FormAddEmployee
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
            this.addButton = new System.Windows.Forms.Button();
            this.employeePicture = new System.Windows.Forms.PictureBox();
            this.addPictureBox1 = new System.Windows.Forms.Button();
            this._gender = new System.Windows.Forms.ComboBox();
            this._role = new System.Windows.Forms.ComboBox();
            this._birthday = new System.Windows.Forms.DateTimePicker();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorChucvu = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroradress = new System.Windows.Forms.ErrorProvider(this.components);
            this._password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).BeginInit();
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
            this.formNameLable.Location = new System.Drawing.Point(-1, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(791, 67);
            this.formNameLable.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(726, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(216, 20);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(362, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thêm thông tin nhân viên";
            // 
            // _address
            // 
            this._address.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(166, 514);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(258, 43);
            this._address.TabIndex = 52;
            this._address.Validating += new System.ComponentModel.CancelEventHandler(this._address_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Chức vụ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Số CMND :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "SĐT :";
            // 
            // _idNumber
            // 
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(166, 402);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(258, 43);
            this._idNumber.TabIndex = 46;
            this._idNumber.Validating += new System.ComponentModel.CancelEventHandler(this._idNumber_Validating);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(166, 349);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(258, 43);
            this._phoneNumber.TabIndex = 45;
            this._phoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this._phoneNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Họ tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã NV :";
            // 
            // _fullName
            // 
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(166, 183);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(258, 43);
            this._fullName.TabIndex = 38;
            this._fullName.Validating += new System.ComponentModel.CancelEventHandler(this._fullName_Validating);
            // 
            // _employeeID
            // 
            this._employeeID.BackColor = System.Drawing.Color.White;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(166, 130);
            this._employeeID.Name = "_employeeID";
            this._employeeID.ReadOnly = true;
            this._employeeID.Size = new System.Drawing.Size(258, 43);
            this._employeeID.TabIndex = 37;
            this._employeeID.Validating += new System.ComponentModel.CancelEventHandler(this._employeeID_Validating);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(470, 511);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "Thêm nhân viên";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeePicture
            // 
            this.employeePicture.BackColor = System.Drawing.Color.White;
            this.employeePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeePicture.Location = new System.Drawing.Point(470, 112);
            this.employeePicture.Name = "employeePicture";
            this.employeePicture.Size = new System.Drawing.Size(228, 291);
            this.employeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicture.TabIndex = 54;
            this.employeePicture.TabStop = false;
            // 
            // addPictureBox1
            // 
            this.addPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addPictureBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPictureBox1.ForeColor = System.Drawing.Color.White;
            this.addPictureBox1.Location = new System.Drawing.Point(531, 416);
            this.addPictureBox1.Name = "addPictureBox1";
            this.addPictureBox1.Size = new System.Drawing.Size(94, 29);
            this.addPictureBox1.TabIndex = 56;
            this.addPictureBox1.Text = "Thêm ảnh";
            this.addPictureBox1.UseVisualStyleBackColor = false;
            this.addPictureBox1.Click += new System.EventHandler(this.addPictureBox1_Click);
            // 
            // _gender
            // 
            this._gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._gender.FormattingEnabled = true;
            this._gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this._gender.Location = new System.Drawing.Point(166, 245);
            this._gender.Name = "_gender";
            this._gender.Size = new System.Drawing.Size(258, 36);
            this._gender.TabIndex = 57;
            // 
            // _role
            // 
            this._role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._role.FormattingEnabled = true;
            this._role.Items.AddRange(new object[] {
            "Lễ Tân",
            "Huấn luyện viên"});
            this._role.Location = new System.Drawing.Point(166, 463);
            this._role.Name = "_role";
            this._role.Size = new System.Drawing.Size(258, 36);
            this._role.TabIndex = 58;
            this._role.Validating += new System.ComponentModel.CancelEventHandler(this._role_Validating);
            // 
            // _birthday
            // 
            this._birthday.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._birthday.Location = new System.Drawing.Point(166, 293);
            this._birthday.Name = "_birthday";
            this._birthday.Size = new System.Drawing.Size(258, 38);
            this._birthday.TabIndex = 59;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // errorChucvu
            // 
            this.errorChucvu.ContainerControl = this;
            // 
            // erroradress
            // 
            this.erroradress.ContainerControl = this;
            // 
            // _password
            // 
            this._password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._password.Location = new System.Drawing.Point(164, 578);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(258, 43);
            this._password.TabIndex = 61;
            this._password.Validating += new System.ComponentModel.CancelEventHandler(this._password_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(39, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 60;
            this.label9.Text = "Mật khẩu :";
            // 
            // errorMK
            // 
            this.errorMK.ContainerControl = this;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 686);
            this.ControlBox = false;
            this.Controls.Add(this._password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._birthday);
            this.Controls.Add(this._role);
            this.Controls.Add(this._gender);
            this.Controls.Add(this.addPictureBox1);
            this.Controls.Add(this.employeePicture);
            this.Controls.Add(this.addButton);
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
            this.Name = "FormAddEmployee";
            this.Text = "addEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox employeePicture;
        private System.Windows.Forms.Button addPictureBox1;
        private System.Windows.Forms.ComboBox _gender;
        private System.Windows.Forms.ComboBox _role;
        private System.Windows.Forms.DateTimePicker _birthday;
        private System.Drawing.Bitmap bmp = null;
        public string filePath = null;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.ErrorProvider errorChucvu;
        private System.Windows.Forms.ErrorProvider erroradress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorMK;
    }
}