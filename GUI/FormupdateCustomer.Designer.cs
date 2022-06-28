namespace Gym
{
    partial class FormUpdateCustomer
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
            this.fixButton = new System.Windows.Forms.Button();
            this.gioitinh = new System.Windows.Forms.ComboBox();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._customerID = new System.Windows.Forms.TextBox();
            this.formName = new System.Windows.Forms.Label();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this._birtday = new System.Windows.Forms.DateTimePicker();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroradress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            this.SuspendLayout();
            // 
            // fixButton
            // 
            this.fixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.fixButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fixButton.ForeColor = System.Drawing.Color.White;
            this.fixButton.Location = new System.Drawing.Point(200, 549);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(241, 49);
            this.fixButton.TabIndex = 75;
            this.fixButton.Text = "Lưu thay đổi";
            this.fixButton.UseVisualStyleBackColor = false;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // gioitinh
            // 
            this.gioitinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gioitinh.FormattingEnabled = true;
            this.gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioitinh.Location = new System.Drawing.Point(243, 231);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(289, 39);
            this.gioitinh.TabIndex = 74;
            // 
            // _address
            // 
            this._address.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(243, 401);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(289, 43);
            this._address.TabIndex = 73;
            this._address.Validating += new System.ComponentModel.CancelEventHandler(this._address_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(108, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 72;
            this.label5.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(108, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Số CMND :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(108, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "SĐT :";
            // 
            // _idNumber
            // 
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(243, 466);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(289, 43);
            this._idNumber.TabIndex = 69;
            this._idNumber.Validating += new System.ComponentModel.CancelEventHandler(this._idNumber_Validating);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(243, 344);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(289, 43);
            this._phoneNumber.TabIndex = 68;
            this._phoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this._phoneNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Họ tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã KH :";
            // 
            // _fullName
            // 
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(243, 173);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(289, 43);
            this._fullName.TabIndex = 62;
            this._fullName.Validating += new System.ComponentModel.CancelEventHandler(this._fullName_Validating);
            // 
            // _customerID
            // 
            this._customerID.Enabled = false;
            this._customerID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._customerID.Location = new System.Drawing.Point(243, 117);
            this._customerID.Name = "_customerID";
            this._customerID.Size = new System.Drawing.Size(289, 43);
            this._customerID.TabIndex = 61;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(107, 19);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(425, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thay đổi thông tin khách hàng";
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
            this.formNameLable.Size = new System.Drawing.Size(659, 74);
            this.formNameLable.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(591, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _birtday
            // 
            this._birtday.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._birtday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._birtday.Location = new System.Drawing.Point(243, 290);
            this._birtday.Name = "_birtday";
            this._birtday.Size = new System.Drawing.Size(289, 43);
            this._birtday.TabIndex = 76;
            this._birtday.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
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
            // erroradress
            // 
            this.erroradress.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 684);
            this.ControlBox = false;
            this.Controls.Add(this._birtday);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this._address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._idNumber);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fullName);
            this.Controls.Add(this._customerID);
            this.Controls.Add(this.formNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "y";
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroradress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Panel formNameLable;
        public System.Windows.Forms.TextBox _customerID;
        public System.Windows.Forms.ComboBox gioitinh;
        public System.Windows.Forms.TextBox _address;
        public System.Windows.Forms.TextBox _idNumber;
        public System.Windows.Forms.TextBox _phoneNumber;
        public System.Windows.Forms.TextBox _fullName;
        public System.Windows.Forms.DateTimePicker _birtday;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider erroradress;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.Button button1;
    }
}