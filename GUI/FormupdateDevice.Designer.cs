namespace Gym
{
    partial class FormUpdateDevice
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
            this.devicePicture = new System.Windows.Forms.PictureBox();
            this._status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._deviceName = new System.Windows.Forms.TextBox();
            this._deviceID = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this._importDate = new System.Windows.Forms.DateTimePicker();
            this.DeleteImgBtn = new System.Windows.Forms.Button();
            this.AddImgBtn = new System.Windows.Forms.Button();
            this._employeeID = new System.Windows.Forms.TextBox();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_status = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQL = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQL)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-1, -2);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(732, 79);
            this.formNameLable.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, 0);
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
            this.formName.Location = new System.Drawing.Point(180, 23);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(366, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thay đổi thông tin thiết bị";
            // 
            // devicePicture
            // 
            this.devicePicture.BackColor = System.Drawing.Color.White;
            this.devicePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.devicePicture.Location = new System.Drawing.Point(111, 317);
            this.devicePicture.Name = "devicePicture";
            this.devicePicture.Size = new System.Drawing.Size(228, 291);
            this.devicePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.devicePicture.TabIndex = 72;
            this.devicePicture.TabStop = false;
            // 
            // _status
            // 
            this._status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._status.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._status.FormattingEnabled = true;
            this._status.Items.AddRange(new object[] {
            "Tốt",
            "Bình thường",
            "Hỏng"});
            this._status.Location = new System.Drawing.Point(501, 110);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(203, 45);
            this._status.TabIndex = 70;
            this._status.Validating += new System.ComponentModel.CancelEventHandler(this._status_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(362, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ngày nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(358, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 67;
            this.label7.Text = "NV quản lý :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(358, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Tình trạng :";
            // 
            // _amount
            // 
            this._amount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(136, 254);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(203, 43);
            this._amount.TabIndex = 64;
            this._amount.Validating += new System.ComponentModel.CancelEventHandler(this._amount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tên TB :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mã TB:";
            // 
            // _deviceName
            // 
            this._deviceName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceName.Location = new System.Drawing.Point(136, 181);
            this._deviceName.Name = "_deviceName";
            this._deviceName.Size = new System.Drawing.Size(203, 43);
            this._deviceName.TabIndex = 60;
            this._deviceName.Validating += new System.ComponentModel.CancelEventHandler(this._deviceName_Validating);
            // 
            // _deviceID
            // 
            this._deviceID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceID.Location = new System.Drawing.Point(136, 110);
            this._deviceID.Name = "_deviceID";
            this._deviceID.Size = new System.Drawing.Size(203, 43);
            this._deviceID.TabIndex = 59;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(435, 460);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(231, 49);
            this.editButton.TabIndex = 75;
            this.editButton.Text = "Lưu thay đổi";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // _importDate
            // 
            this._importDate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._importDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._importDate.Location = new System.Drawing.Point(501, 254);
            this._importDate.Name = "_importDate";
            this._importDate.Size = new System.Drawing.Size(203, 43);
            this._importDate.TabIndex = 76;
            // 
            // DeleteImgBtn
            // 
            this.DeleteImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DeleteImgBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteImgBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteImgBtn.Location = new System.Drawing.Point(115, 614);
            this.DeleteImgBtn.Name = "DeleteImgBtn";
            this.DeleteImgBtn.Size = new System.Drawing.Size(92, 38);
            this.DeleteImgBtn.TabIndex = 78;
            this.DeleteImgBtn.Text = "Xóa ảnh";
            this.DeleteImgBtn.UseVisualStyleBackColor = false;
            this.DeleteImgBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddImgBtn
            // 
            this.AddImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AddImgBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddImgBtn.ForeColor = System.Drawing.Color.White;
            this.AddImgBtn.Location = new System.Drawing.Point(231, 614);
            this.AddImgBtn.Name = "AddImgBtn";
            this.AddImgBtn.Size = new System.Drawing.Size(97, 38);
            this.AddImgBtn.TabIndex = 78;
            this.AddImgBtn.Text = "Thêm ảnh";
            this.AddImgBtn.UseVisualStyleBackColor = false;
            this.AddImgBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // _employeeID
            // 
            this._employeeID.BackColor = System.Drawing.Color.White;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(501, 181);
            this._employeeID.Name = "_employeeID";
            this._employeeID.ReadOnly = true;
            this._employeeID.Size = new System.Drawing.Size(203, 43);
            this._employeeID.TabIndex = 79;
            this._employeeID.Validating += new System.ComponentModel.CancelEventHandler(this._employeeID_Validating);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorSL
            // 
            this.errorSL.ContainerControl = this;
            // 
            // error_status
            // 
            this.error_status.ContainerControl = this;
            // 
            // errorQL
            // 
            this.errorQL.ContainerControl = this;
            // 
            // FormUpdateDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 681);
            this.ControlBox = false;
            this.Controls.Add(this._employeeID);
            this.Controls.Add(this.AddImgBtn);
            this.Controls.Add(this.DeleteImgBtn);
            this.Controls.Add(this._importDate);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.devicePicture);
            this.Controls.Add(this._status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._deviceName);
            this.Controls.Add(this._deviceID);
            this.Controls.Add(this.formNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fixDevice ";
            this.Load += new System.EventHandler(this.updateDevice_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        public System.Windows.Forms.ComboBox _status;
        public System.Windows.Forms.TextBox _amount;
        public System.Windows.Forms.TextBox _deviceName;
        public System.Windows.Forms.TextBox _deviceID;
        public System.Windows.Forms.DateTimePicker _importDate;
        public System.Windows.Forms.PictureBox devicePicture;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
        private System.Windows.Forms.Button DeleteImgBtn;
        private System.Windows.Forms.Button AddImgBtn;
        public System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSL;
        private System.Windows.Forms.ErrorProvider error_status;
        private System.Windows.Forms.ErrorProvider errorQL;
        private System.Windows.Forms.Button button1;
    }
}