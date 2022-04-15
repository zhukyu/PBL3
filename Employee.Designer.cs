namespace Gym
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._role = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._gender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._employeeID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTable
            // 
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.fullname,
            this.gender,
            this.birthday,
            this.phoneNumber,
            this.idNumber,
            this.role,
            this.address});
            this.employeeTable.Location = new System.Drawing.Point(12, 417);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 51;
            this.employeeTable.RowTemplate.Height = 29;
            this.employeeTable.Size = new System.Drawing.Size(1311, 229);
            this.employeeTable.TabIndex = 1;
            this.employeeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeTable_CellContentClick);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(1064, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 36);
            this.textBox2.TabIndex = 21;
            // 
            // detail
            // 
            this.detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detail.Controls.Add(this.pictureBox1);
            this.detail.Controls.Add(this._address);
            this.detail.Controls.Add(this.label5);
            this.detail.Controls.Add(this._role);
            this.detail.Controls.Add(this.label6);
            this.detail.Controls.Add(this.label7);
            this.detail.Controls.Add(this.label8);
            this.detail.Controls.Add(this._idNumber);
            this.detail.Controls.Add(this._phoneNumber);
            this.detail.Controls.Add(this.textBox1);
            this.detail.Controls.Add(this.label4);
            this.detail.Controls.Add(this._gender);
            this.detail.Controls.Add(this.label3);
            this.detail.Controls.Add(this.label2);
            this.detail.Controls.Add(this.label1);
            this.detail.Controls.Add(this._fullName);
            this.detail.Controls.Add(this._employeeID);
            this.detail.Location = new System.Drawing.Point(12, 12);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(1018, 340);
            this.detail.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 291);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // _address
            // 
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._address.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(741, 274);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(255, 36);
            this._address.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(634, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Địa chỉ";
            // 
            // _role
            // 
            this._role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._role.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._role.Location = new System.Drawing.Point(741, 192);
            this._role.Name = "_role";
            this._role.Size = new System.Drawing.Size(255, 36);
            this._role.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(634, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(634, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(634, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "SĐT";
            // 
            // _idNumber
            // 
            this._idNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._idNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(741, 105);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(255, 36);
            this._idNumber.TabIndex = 30;
            // 
            // _phoneNumber
            // 
            this._phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._phoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(741, 19);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(255, 36);
            this._phoneNumber.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(362, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 36);
            this.textBox1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(248, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày sinh";
            // 
            // _gender
            // 
            this._gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gender.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._gender.Location = new System.Drawing.Point(362, 192);
            this._gender.Name = "_gender";
            this._gender.Size = new System.Drawing.Size(255, 36);
            this._gender.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(248, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã NV";
            // 
            // _fullName
            // 
            this._fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(362, 105);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(255, 36);
            this._fullName.TabIndex = 22;
            // 
            // _employeeID
            // 
            this._employeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(362, 19);
            this._employeeID.Name = "_employeeID";
            this._employeeID.Size = new System.Drawing.Size(255, 36);
            this._employeeID.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1288, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(1073, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Thêm nhân viên";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.add_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(1073, 184);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(231, 49);
            this.editButton.TabIndex = 25;
            this.editButton.Text = "Sửa thông tin";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.edit_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1073, 255);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(231, 49);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Xóa nhân viên";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 355);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 59);
            this.panel1.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(523, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh sách nhân viên";
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Mã NV";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeID.Width = 125;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Họ tên";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fullname.Width = 250;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 125;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.birthday.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Số điện thoại";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneNumber.Width = 125;
            // 
            // idNumber
            // 
            this.idNumber.HeaderText = "Số CMND";
            this.idNumber.MinimumWidth = 6;
            this.idNumber.Name = "idNumber";
            this.idNumber.ReadOnly = true;
            this.idNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idNumber.Width = 125;
            // 
            // role
            // 
            this.role.HeaderText = "Chức vụ";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.role.Width = 125;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.employeeTable);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.detail.ResumeLayout(false);
            this.detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel detail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}