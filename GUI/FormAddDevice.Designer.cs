namespace Gym
{
    partial class FormAddDevice
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._deviceName = new System.Windows.Forms.TextBox();
            this._deviceID = new System.Windows.Forms.TextBox();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addPictureBox1 = new System.Windows.Forms.Button();
            this.devicePicture = new System.Windows.Forms.PictureBox();
            this._employeeID = new System.Windows.Forms.TextBox();
            this._importDate = new System.Windows.Forms.DateTimePicker();
            this._status = new System.Windows.Forms.ComboBox();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_status = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQL = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(345, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ngày nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(344, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "NV quản lý :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(344, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tình trạng :";
            // 
            // _amount
            // 
            this._amount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(122, 246);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(203, 43);
            this._amount.TabIndex = 40;
            this._amount.Validating += new System.ComponentModel.CancelEventHandler(this._amount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên TB :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã TB :";
            // 
            // _deviceName
            // 
            this._deviceName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceName.Location = new System.Drawing.Point(122, 173);
            this._deviceName.Name = "_deviceName";
            this._deviceName.Size = new System.Drawing.Size(203, 43);
            this._deviceName.TabIndex = 36;
            this._deviceName.Validating += new System.ComponentModel.CancelEventHandler(this._deviceName_Validating);
            // 
            // _deviceID
            // 
            this._deviceID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceID.Location = new System.Drawing.Point(122, 102);
            this._deviceID.Name = "_deviceID";
            this._deviceID.Size = new System.Drawing.Size(203, 43);
            this._deviceID.TabIndex = 35;
            this._deviceID.Validating += new System.ComponentModel.CancelEventHandler(this._deviceID_Validating);
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-6, -1);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(739, 73);
            this.formNameLable.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, -1);
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
            this.formName.Location = new System.Drawing.Point(268, 20);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(195, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thêm thiết bị";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(436, 446);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 49;
            this.addButton.Text = "Thêm thiết bị";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addPictureBox1
            // 
            this.addPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addPictureBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPictureBox1.ForeColor = System.Drawing.Color.White;
            this.addPictureBox1.Location = new System.Drawing.Point(161, 620);
            this.addPictureBox1.Name = "addPictureBox1";
            this.addPictureBox1.Size = new System.Drawing.Size(94, 29);
            this.addPictureBox1.TabIndex = 58;
            this.addPictureBox1.Text = "Thêm ảnh";
            this.addPictureBox1.UseVisualStyleBackColor = false;
            this.addPictureBox1.Click += new System.EventHandler(this.addPictureBox1_Click);
            // 
            // devicePicture
            // 
            this.devicePicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.devicePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.devicePicture.Location = new System.Drawing.Point(97, 309);
            this.devicePicture.Name = "devicePicture";
            this.devicePicture.Size = new System.Drawing.Size(228, 291);
            this.devicePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.devicePicture.TabIndex = 57;
            this.devicePicture.TabStop = false;
            // 
            // _employeeID
            // 
            this._employeeID.BackColor = System.Drawing.Color.White;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(493, 173);
            this._employeeID.Name = "_employeeID";
            this._employeeID.ReadOnly = true;
            this._employeeID.Size = new System.Drawing.Size(203, 43);
            this._employeeID.TabIndex = 82;
            this._employeeID.Validating += new System.ComponentModel.CancelEventHandler(this._employeeID_Validating);
            // 
            // _importDate
            // 
            this._importDate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._importDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._importDate.Location = new System.Drawing.Point(493, 246);
            this._importDate.Name = "_importDate";
            this._importDate.Size = new System.Drawing.Size(203, 43);
            this._importDate.TabIndex = 81;
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
            this._status.Location = new System.Drawing.Point(493, 102);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(203, 45);
            this._status.TabIndex = 80;
            this._status.Validating += new System.ComponentModel.CancelEventHandler(this._status_Validating);
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
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
            // FormAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 671);
            this.ControlBox = false;
            this.Controls.Add(this._employeeID);
            this.Controls.Add(this._importDate);
            this.Controls.Add(this._status);
            this.Controls.Add(this.addPictureBox1);
            this.Controls.Add(this.devicePicture);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.formNameLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._deviceName);
            this.Controls.Add(this._deviceID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddDevice";
            this.Text = "addDevice";
            this.Load += new System.EventHandler(this.addDevice_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _deviceName;
        private System.Windows.Forms.TextBox _deviceID;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addPictureBox1;
        public System.Windows.Forms.PictureBox devicePicture;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
        public System.Windows.Forms.TextBox _employeeID;
        public System.Windows.Forms.DateTimePicker _importDate;
        public System.Windows.Forms.ComboBox _status;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSL;
        private System.Windows.Forms.ErrorProvider error_status;
        private System.Windows.Forms.ErrorProvider errorQL;
        private System.Windows.Forms.Button button1;
    }
}